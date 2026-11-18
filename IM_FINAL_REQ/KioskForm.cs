using System;
using System.Drawing;
using System.Windows.Forms;

namespace IM_FINAL_REQ
{
    public partial class KioskForm : Form
    {
        private int _secondsLeft = 8;
        private int _lastRatedTicketId = 0;

        public KioskForm()
        {
            InitializeComponent();
            picLogo.Image = Properties.Resources.psu_logo;

            txtConcern.KeyDown += txtConcern_KeyDown;
            QueueManager.Changed += OnQueueChanged;
            this.FormClosed += (s, e) => QueueManager.Changed -= OnQueueChanged;
        }

        private void ShowPanel(Panel target)
        {
            pnlWelcome.Visible = false;
            pnlMainMenu.Visible = false;
            pnlId.Visible = false;
            pnlService.Visible = false;
            pnlTicket.Visible = false;
            pnlAppt.Visible = false;
            pnlRating.Visible = false;

            target.Visible = true;
            target.BringToFront();
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            ShowPanel(pnlMainMenu);
        }

        private void btnMenuQueue_Click(object? sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtStudentId.Enabled = true;
            chkGuest.Checked = false;
            ShowPanel(pnlId);
            txtStudentId.Focus();
        }

        private void btnMenuAppt_Click(object? sender, EventArgs e)
        {
            txtApptId.Clear();
            cbApptService.SelectedIndex = 0;
            dtpApptDate.Value = DateTime.Today;
            cbApptTime.SelectedIndex = 0;
            ShowPanel(pnlAppt);
        }

        private void btnBackMenu_Click(object? sender, EventArgs e)
        {
            ShowPanel(pnlWelcome);
        }

        private void btnBackId_Click(object? sender, EventArgs e)
        {
            ShowPanel(pnlMainMenu);
        }

        private void btnBackSvc_Click(object? sender, EventArgs e)
        {
            ShowPanel(pnlId);
        }

        private void chkGuest_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkGuest.Checked)
            {
                txtStudentId.Text = "GUEST";
                txtStudentId.Enabled = false;
            }
            else
            {
                txtStudentId.Clear();
                txtStudentId.Enabled = true;
                txtStudentId.Focus();
            }
        }

        private void txtStudentId_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnContinue_Click(sender, EventArgs.Empty);
            }
        }

        private void btnContinue_Click(object? sender, EventArgs e)
        {
            if (!chkGuest.Checked && string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please enter your Student ID or check 'I am a Guest / Alumni'.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblConcern.Visible = false;
            txtConcern.Visible = false;
            txtConcern.Clear();
            ShowPanel(pnlService);
        }

        private void ServiceButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn || btn.Tag is not ServiceType svc) return;

            if (svc == ServiceType.HelpDesk && !txtConcern.Visible)
            {
                lblConcern.Visible = true;
                txtConcern.Visible = true;
                txtConcern.Focus();
                return;
            }

            IssueAndShowTicket(svc, txtConcern.Text.Trim());
        }

        private void txtConcern_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                IssueAndShowTicket(ServiceType.HelpDesk, txtConcern.Text.Trim());
            }
        }

        private void IssueAndShowTicket(ServiceType svc, string concern)
        {
            string sid = chkGuest.Checked ? "GUEST" : txtStudentId.Text.Trim();
            Ticket t = QueueManager.GenerateTicket(sid, svc, concern);

            lblQueue.Text = t.Number;
            lblWindow.Text = $"PROCEED TO REGISTRAR WINDOW {t.Window} WHEN CALLED";
            lblAhead.Text = $"People ahead: {QueueManager.PeopleAhead(t)}";
            lblTime.Text = $"Est. Wait: {QueueManager.WaitMinutes(t)} mins";

            _secondsLeft = 8;
            lblCountdown.Text = $"Resetting in {_secondsLeft} seconds...";
            timerReset.Start();

            ShowPanel(pnlTicket);
        }

        private void timerReset_Tick(object? sender, EventArgs e)
        {
            _secondsLeft--;
            if (_secondsLeft <= 0)
            {
                timerReset.Stop();
                ShowPanel(pnlWelcome);
            }
            else
            {
                lblCountdown.Text = $"Resetting in {_secondsLeft} seconds...";
            }
        }

        private void btnSubmitAppt_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApptId.Text))
            {
                MessageBox.Show("Please enter your Student ID.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string svc = cbApptService.SelectedItem?.ToString() ?? "Adding/Dropping";
            string time = cbApptTime.SelectedItem?.ToString() ?? "08:00 AM";

            QueueManager.AddAppointment(txtApptId.Text.Trim(), svc, dtpApptDate.Value.Date, time);
            MessageBox.Show("Appointment booked successfully!", "PSU Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowPanel(pnlWelcome);
        }

        private void OnQueueChanged(object? sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => OnQueueChanged(sender, e)));
                return;
            }

            var completed = QueueManager.LastCompletedTicket;
            if (completed != null && completed.Id != _lastRatedTicketId)
            {
                _lastRatedTicketId = completed.Id;
                timerReset.Stop();

                lblRatingSub.Text = $"Ticket {completed.Number} — How was your experience?";
                ShowPanel(pnlRating);
            }
        }

        private void RateButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int score && QueueManager.LastCompletedTicket != null)
            {
                var t = QueueManager.LastCompletedTicket;
                QueueManager.SubmitRating(t.Id, t.Number, score);
                MessageBox.Show("Thank you for your feedback!", "PSU Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ShowPanel(pnlWelcome);
        }

        private void btnSkipRating_Click(object? sender, EventArgs e)
        {
            ShowPanel(pnlWelcome);
        }
    }
}