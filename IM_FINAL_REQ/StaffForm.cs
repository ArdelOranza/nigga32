using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace IM_FINAL_REQ
{
    public partial class StaffForm : Form
    {
        private int CurrentWindow = 1;
        private Ticket? _currentTicket;
        private Department _currentDept = Department.Registrar;

        public StaffForm()
        {
            InitializeComponent();

            string imgPath = Path.Combine(Application.StartupPath, "psu_logo.png");
            picLogoSmall.Image = Properties.Resources.psu_logo;

            this.KeyPreview = true;
            this.KeyDown += StaffForm_KeyDown;
        }

        private string GetWindowDisplayName(int winNum)
        {
            return winNum switch
            {
                1 => "Registrar Window 1",
                2 => "Registrar Window 2",
                3 => "Cashier Window 1",
                4 => "Cashier Window 2",
                _ => $"{QueueManager.Windows[winNum]} Window {winNum}"
            };
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            cbWindow.DrawMode = DrawMode.OwnerDrawFixed;
            cbWindow.DrawItem += cbWindow_DrawItem;

            foreach (var win in QueueManager.Windows.Keys)
            {
                cbWindow.Items.Add(win);
            }
            cbWindow.SelectedIndex = 0;
            RefreshUI();
        }

        private void cbWindow_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            int winNum = (int)cbWindow.Items[e.Index];
            string displayText = GetWindowDisplayName(winNum);

            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(displayText, e.Font ?? this.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void cbWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWindow.SelectedItem == null) return;

            CurrentWindow = (int)cbWindow.SelectedItem;
            _currentDept = QueueManager.Windows[CurrentWindow];

            lblLastCalled.Text = "READY TO CALL";
            lblLastCalled.BackColor = Theme.BgSlate;

            lblTitle.Text = GetWindowDisplayName(CurrentWindow);

            if (_currentDept == Department.Registrar)
            {
                btnAction1.Text = "COMPLETE TRANSACTION";
                btnAction2.Visible = true;
                btnAction2.Text = "SEND TO CASHIER";
            }
            else
            {
                btnAction1.Text = "PAYMENT VERIFIED";
                btnAction2.Visible = false;
            }

            RefreshUI();
        }

        private void StaffForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) btnNext_Click(this, EventArgs.Empty);
        }

        private void RefreshUI()
        {
            _currentTicket = QueueManager.GetCurrent(CurrentWindow);
            if (_currentTicket != null)
            {
                lblCurrentNumber.Text = _currentTicket.Number;
                lblCurrentStudent.Text = "Student: " + _currentTicket.StudentId;

                string statusText = "Service: " + QueueManager.ServiceName[_currentTicket.Service];

                if (_currentTicket.IsPaymentVerified)
                {
                    statusText += "\nStatus: Payment Verified";
                }

                if (!string.IsNullOrEmpty(_currentTicket.Concern))
                {
                    statusText += "\nConcern: " + _currentTicket.Concern;
                }

                lblCurrentStatus.Text = statusText;

                btnAction1.Enabled = true;
                btnAction2.Enabled = !_currentTicket.IsPaymentVerified;
                btnSkip.Enabled = true;
            }
            else
            {
                lblCurrentNumber.Text = "---";
                lblCurrentStudent.Text = "No Active Ticket";
                lblCurrentStatus.Text = "Click 'Call Next' to start.";

                btnAction1.Enabled = false;
                btnAction2.Enabled = false;
                btnSkip.Enabled = false;
            }

            var list = QueueManager.WaitingFor(CurrentWindow);
            dgvQueue.DataSource = null;
            dgvQueue.DataSource = list;

            if (dgvQueue.Columns.Count > 0)
            {
                dgvQueue.Columns["Id"].Visible = false;
                dgvQueue.Columns["Sequence"].Visible = false;
                dgvQueue.Columns["Service"].Visible = false;
                dgvQueue.Columns["Window"].Visible = false;
                dgvQueue.Columns["Status"].Visible = false;
                dgvQueue.Columns["CalledAt"].Visible = false;
                if (dgvQueue.Columns["IsPaymentVerified"] != null) dgvQueue.Columns["IsPaymentVerified"].Visible = false;
                if (dgvQueue.Columns["Concern"] != null) dgvQueue.Columns["Concern"].Visible = true;

                dgvQueue.Columns["Number"].HeaderText = "Ticket No.";
                dgvQueue.Columns["StudentId"].HeaderText = "Student ID";
                dgvQueue.Columns["IssuedAt"].HeaderText = "Time Issued";
                dgvQueue.Columns["IssuedAt"].DefaultCellStyle.Format = "hh:mm:ss tt";
            }
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            var t = QueueManager.CallNext(CurrentWindow);
            if (t != null)
            {
                lblLastCalled.Text = $"CALLING: {t.Number}";
                lblLastCalled.BackColor = Color.FromArgb(255, 235, 156);
                RefreshUI();
            }
            else
            {
                MessageBox.Show("The queue is currently empty.", "Queue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLastCalled.Text = "QUEUE EMPTY";
                lblLastCalled.BackColor = Color.FromArgb(248, 215, 218);
                RefreshUI();
            }
        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
            if (_currentTicket == null) return;

            if (_currentDept == Department.Registrar)
            {
                QueueManager.CompleteTicket(_currentTicket);
                lblLastCalled.Text = "TRANSACTION COMPLETED";
            }
            else
            {
                QueueManager.PaymentVerified(_currentTicket);
                lblLastCalled.Text = "SENT BACK TO REGISTRAR";
            }

            lblLastCalled.BackColor = Color.FromArgb(212, 237, 218);
            RefreshUI();
        }

        private void btnAction2_Click(object sender, EventArgs e)
        {
            if (_currentTicket == null) return;

            QueueManager.SendToCashier(_currentTicket);
            lblLastCalled.Text = "SENT TO CASHIER";
            lblLastCalled.BackColor = Color.FromArgb(255, 235, 156);
            RefreshUI();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (_currentTicket != null)
            {
                QueueManager.Skip(_currentTicket);
                lblLastCalled.Text = "SKIPPED";
                lblLastCalled.BackColor = Color.FromArgb(248, 215, 218);
                RefreshUI();
            }
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlHeader.ClientRectangle,
                                    Theme.BorderGray, 0, ButtonBorderStyle.None,
                                    Theme.BorderGray, 0, ButtonBorderStyle.None,
                                    Theme.BorderGray, 0, ButtonBorderStyle.None,
                                    Theme.BorderGray, 1, ButtonBorderStyle.Solid);
        }

        private void PnlLeft_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlLeft.ClientRectangle,
                                    Theme.BorderGray, 0, ButtonBorderStyle.None,
                                    Theme.BorderGray, 1, ButtonBorderStyle.Solid,
                                    Theme.BorderGray, 0, ButtonBorderStyle.None,
                                    Theme.BorderGray, 0, ButtonBorderStyle.None);
        }
    }
}