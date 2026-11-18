using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace IM_FINAL_REQ
{
    public enum ServiceType { AddingDropping, IdVerification, Document, HelpDesk, Priority }
    public enum TicketStatus { WaitingReg, ServingReg, WaitingCash, ServingCash, Done, Skipped }
    public enum Department { Registrar, Cashier }

    public class Ticket
    {
        public int Id { get; set; }
        public int Sequence { get; set; }
        public string Number { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public ServiceType Service { get; set; }
        public int Window { get; set; }
        public DateTime IssuedAt { get; set; }
        public DateTime? CalledAt { get; set; }
        public TicketStatus Status { get; set; }
        public string? Concern { get; set; }
        public bool IsPaymentVerified { get; set; } = false;
    }

    public static class QueueManager
    {
        private static readonly HashSet<int> _verifiedTicketIds = new HashSet<int>();

        public static Ticket? LastCompletedTicket { get; private set; }

        public static readonly Dictionary<ServiceType, string> Prefix = new Dictionary<ServiceType, string>
        {
            { ServiceType.AddingDropping, "AD" }, { ServiceType.IdVerification, "ID" },
            { ServiceType.Document, "DR" }, { ServiceType.HelpDesk, "HD" }, { ServiceType.Priority, "PL" }
        };

        public static readonly Dictionary<ServiceType, string> ServiceName = new Dictionary<ServiceType, string>
        {
            { ServiceType.AddingDropping, "Adding / Dropping" },
            { ServiceType.IdVerification, "ID Verification" },
            { ServiceType.Document, "Document Request" },
            { ServiceType.HelpDesk, "Help Desk" },
            { ServiceType.Priority, "Priority Lane" }
        };

        public static readonly Dictionary<int, Department> Windows = new Dictionary<int, Department>
        {
            { 1, Department.Registrar }, { 2, Department.Registrar },
            { 3, Department.Cashier }, { 4, Department.Cashier }
        };

        public static event EventHandler? Changed;

        public static int GetAvailableWindow(Department dept)
        {
            var deptWindows = Windows
                .Where(w => w.Value == dept)
                .Select(w => w.Key)
                .OrderBy(k => k)
                .ToList();

            int win1 = deptWindows[0];
            int win2 = deptWindows.Count > 1 ? deptWindows[1] : win1;

            if (GetCurrent(win1) == null)
            {
                return win1;
            }

            if (GetCurrent(win2) == null)
            {
                return win2;
            }

            int wait1 = WaitingFor(win1).Count;
            int wait2 = WaitingFor(win2).Count;
            return wait1 <= wait2 ? win1 : win2;
        }

        public static Ticket GenerateTicket(string studentId, ServiceType service, string? concern = null)
        {
            int targetWindow = GetAvailableWindow(Department.Registrar);

            using (var cn = Db.Open())
            using (var tx = cn.BeginTransaction())
            {
                int nextSeq;
                using (var cmd = new MySqlCommand("SELECT COALESCE(MAX(sequence),0)+1 FROM tickets WHERE service=@s FOR UPDATE", cn, tx))
                {
                    cmd.Parameters.AddWithValue("@s", service.ToString());
                    nextSeq = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string number = Prefix[service] + "-" + nextSeq.ToString("000");
                DateTime now = DateTime.Now;

                using (var cmd = new MySqlCommand(
                    "INSERT INTO tickets (ticket_no, sequence, service, student_id, window_no, status, issued_at, concern) VALUES (@no, @seq, @svc, @sid, @win, 'waiting_reg', @t, @concern)", cn, tx))
                {
                    cmd.Parameters.AddWithValue("@no", number);
                    cmd.Parameters.AddWithValue("@seq", nextSeq);
                    cmd.Parameters.AddWithValue("@svc", service.ToString());
                    cmd.Parameters.AddWithValue("@sid", string.IsNullOrWhiteSpace(studentId) ? "GUEST" : studentId);
                    cmd.Parameters.AddWithValue("@win", targetWindow);
                    cmd.Parameters.AddWithValue("@t", now);
                    cmd.Parameters.AddWithValue("@concern", string.IsNullOrWhiteSpace(concern) ? DBNull.Value : concern);
                    cmd.ExecuteNonQuery();
                }

                int newId;
                using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", cn, tx))
                {
                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                tx.Commit();

                var t = new Ticket
                {
                    Id = newId,
                    Sequence = nextSeq,
                    Number = number,
                    Service = service,
                    StudentId = string.IsNullOrWhiteSpace(studentId) ? "GUEST" : studentId,
                    Window = targetWindow,
                    IssuedAt = now,
                    Status = TicketStatus.WaitingReg,
                    Concern = concern,
                    IsPaymentVerified = false
                };

                Raise();
                return t;
            }
        }

        public static int PeopleAhead(Ticket t)
        {
            using (var cn = Db.Open())
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM tickets WHERE status='waiting_reg' AND id < @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", t.Id);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static int WaitMinutes(Ticket t) => PeopleAhead(t) * 3;

        public static void AddAppointment(string studentId, string service, DateTime date, string time)
        {
            Execute("INSERT INTO appointments (student_id, service, appt_date, appt_time, created_at) VALUES (@sid, @svc, @date, @time, @now)",
                ("@sid", studentId), ("@svc", service), ("@date", date.ToString("yyyy-MM-dd")), ("@time", time), ("@now", DateTime.Now));
        }

        public static Ticket? GetCurrent(int window)
        {
            var dept = Windows[window];
            string expectedStatus = dept == Department.Registrar ? "serving_reg" : "serving_cash";
            var list = Query("SELECT * FROM tickets WHERE window_no=@w AND status=@status ORDER BY called_at DESC LIMIT 1",
                ("@w", window), ("@status", expectedStatus));
            return list.Count > 0 ? list[0] : null;
        }

        public static Ticket? CallNext(int window)
        {
            var dept = Windows[window];
            string waitingStatus = dept == Department.Registrar ? "waiting_reg" : "waiting_cash";
            string servingStatus = dept == Department.Registrar ? "serving_reg" : "serving_cash";

            using (var cn = Db.Open())
            using (var tx = cn.BeginTransaction())
            {
                using (var cmd = new MySqlCommand("UPDATE tickets SET status='done' WHERE window_no=@w AND status=@status", cn, tx))
                {
                    cmd.Parameters.AddWithValue("@w", window);
                    cmd.Parameters.AddWithValue("@status", servingStatus);
                    cmd.ExecuteNonQuery();
                }

                int nextId = 0;
                using (var cmd = new MySqlCommand("SELECT id FROM tickets WHERE status=@status AND (window_no=@w OR window_no=0) ORDER BY id LIMIT 1", cn, tx))
                {
                    cmd.Parameters.AddWithValue("@status", waitingStatus);
                    cmd.Parameters.AddWithValue("@w", window);
                    var r = cmd.ExecuteScalar();
                    if (r != null && r != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(r);
                    }
                }

                if (nextId == 0)
                {
                    using (var cmd = new MySqlCommand("SELECT id FROM tickets WHERE status=@status ORDER BY id LIMIT 1", cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@status", waitingStatus);
                        var r = cmd.ExecuteScalar();
                        if (r == null || r == DBNull.Value) { tx.Commit(); Raise(); return null; }
                        nextId = Convert.ToInt32(r);
                    }
                }

                using (var cmd = new MySqlCommand("UPDATE tickets SET status=@newStatus, window_no=@w, called_at=@t WHERE id=@id", cn, tx))
                {
                    cmd.Parameters.AddWithValue("@newStatus", servingStatus);
                    cmd.Parameters.AddWithValue("@w", window);
                    cmd.Parameters.AddWithValue("@t", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", nextId);
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
            }
            Raise();
            return GetCurrent(window);
        }

        public static void SendToCashier(Ticket t)
        {
            int targetWindow = GetAvailableWindow(Department.Cashier);
            Execute("UPDATE tickets SET status='waiting_cash', window_no=@w WHERE id=@id", ("@w", targetWindow), ("@id", t.Id));
            Raise();
        }

        public static void PaymentVerified(Ticket t)
        {
            _verifiedTicketIds.Add(t.Id);
            t.IsPaymentVerified = true;

            int targetWindow = GetAvailableWindow(Department.Registrar);
            Execute("UPDATE tickets SET status='waiting_reg', window_no=@w WHERE id=@id", ("@w", targetWindow), ("@id", t.Id));
            Raise();
        }

        public static void CompleteTicket(Ticket t)
        {
            LastCompletedTicket = t;
            Execute("UPDATE tickets SET status='done' WHERE id=@id", ("@id", t.Id));
            Raise();
        }

        public static void SubmitRating(int ticketId, string ticketNo, int score)
        {
            Execute(@"CREATE TABLE IF NOT EXISTS ratings (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        ticket_id INT,
                        ticket_no VARCHAR(20),
                        score INT,
                        created_at DATETIME
                      )");

            Execute("INSERT INTO ratings (ticket_id, ticket_no, score, created_at) VALUES (@tid, @tno, @score, @now)",
                ("@tid", ticketId), ("@tno", ticketNo), ("@score", score), ("@now", DateTime.Now));
        }

        public static void Skip(Ticket t)
        {
            Execute("UPDATE tickets SET status='skipped' WHERE id=@id", ("@id", t.Id));
            Raise();
        }

        public static Ticket? GetServingTicket(Department dept)
        {
            string status = dept == Department.Registrar ? "serving_reg" : "serving_cash";
            var list = Query("SELECT * FROM tickets WHERE status=@s ORDER BY called_at DESC LIMIT 1", ("@s", status));
            return list.Count > 0 ? list[0] : null;
        }

        public static List<Ticket> GetWaitingList(Department dept)
        {
            string status = dept == Department.Registrar ? "waiting_reg" : "waiting_cash";
            return Query("SELECT * FROM tickets WHERE status=@s ORDER BY id LIMIT 8", ("@s", status));
        }

        public static List<Ticket> WaitingFor(int window)
        {
            var dept = Windows[window];
            string status = dept == Department.Registrar ? "waiting_reg" : "waiting_cash";
            return Query("SELECT * FROM tickets WHERE status=@s AND (window_no=@w OR window_no=0) ORDER BY id", ("@s", status), ("@w", window));
        }

        private static void Execute(string sql, params (string, object)[] p)
        {
            using (var cn = Db.Open()) using (var cmd = new MySqlCommand(sql, cn))
            {
                foreach (var (k, v) in p) cmd.Parameters.AddWithValue(k, v);
                cmd.ExecuteNonQuery();
            }
        }

        private static List<Ticket> Query(string sql, params (string, object)[] p)
        {
            var list = new List<Ticket>();
            using (var cn = Db.Open()) using (var cmd = new MySqlCommand(sql, cn))
            {
                foreach (var (k, v) in p) cmd.Parameters.AddWithValue(k, v);
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        int id = rd.GetInt32("id");
                        list.Add(new Ticket
                        {
                            Id = id,
                            Number = rd.GetString("ticket_no"),
                            Sequence = rd.GetInt32("sequence"),

                            Service = (ServiceType)Enum.Parse(typeof(ServiceType), rd.GetString("service").Replace("_", ""), true),
                            Status = (TicketStatus)Enum.Parse(typeof(TicketStatus), rd.GetString("status").Replace("_", ""), true),

                            StudentId = rd.GetString("student_id"),
                            Window = rd.GetInt32("window_no"),
                            IssuedAt = rd.GetDateTime("issued_at"),
                            CalledAt = rd.IsDBNull(rd.GetOrdinal("called_at")) ? (DateTime?)null : rd.GetDateTime("called_at"),
                            Concern = rd.IsDBNull(rd.GetOrdinal("concern")) ? null : rd.GetString("concern"),
                            IsPaymentVerified = _verifiedTicketIds.Contains(id)
                        });
                    }
                }
            }
            return list;
        }

        private static void Raise() => Changed?.Invoke(null, EventArgs.Empty);
    }
}