namespace IM_FINAL_REQ
{
    partial class KioskForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerReset = new System.Windows.Forms.Timer(this.components);

            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlId = new System.Windows.Forms.Panel();
            this.pnlService = new System.Windows.Forms.Panel();
            this.pnlTicket = new System.Windows.Forms.Panel();
            this.pnlAppt = new System.Windows.Forms.Panel();
            this.pnlRating = new System.Windows.Forms.Panel();

            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();

            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnMenuQueue = new System.Windows.Forms.Button();
            this.btnMenuAppt = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();

            this.lblIdTitle = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.chkGuest = new System.Windows.Forms.CheckBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBackId = new System.Windows.Forms.Button();

            this.lblSvcTitle = new System.Windows.Forms.Label();
            this.btnSvcAddDrop = new System.Windows.Forms.Button();
            this.btnSvcIdVer = new System.Windows.Forms.Button();
            this.btnSvcDoc = new System.Windows.Forms.Button();
            this.btnSvcHelp = new System.Windows.Forms.Button();
            this.btnSvcPrio = new System.Windows.Forms.Button();
            this.btnBackSvc = new System.Windows.Forms.Button();

            this.txtConcern = new System.Windows.Forms.TextBox();
            this.lblConcern = new System.Windows.Forms.Label();

            this.lblTktTitle = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblWindow = new System.Windows.Forms.Label();
            this.lblAhead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();

            this.lblApptTitle = new System.Windows.Forms.Label();
            this.txtApptId = new System.Windows.Forms.TextBox();
            this.lblApptId = new System.Windows.Forms.Label();
            this.cbApptService = new System.Windows.Forms.ComboBox();
            this.lblApptService = new System.Windows.Forms.Label();
            this.dtpApptDate = new System.Windows.Forms.DateTimePicker();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.cbApptTime = new System.Windows.Forms.ComboBox();
            this.lblApptTime = new System.Windows.Forms.Label();
            this.btnSubmitAppt = new System.Windows.Forms.Button();
            this.btnBackAppt = new System.Windows.Forms.Button();

            this.lblRatingTitle = new System.Windows.Forms.Label();
            this.lblRatingSub = new System.Windows.Forms.Label();
            this.btnRate1 = new System.Windows.Forms.Button();
            this.btnRate2 = new System.Windows.Forms.Button();
            this.btnRate3 = new System.Windows.Forms.Button();
            this.btnRate4 = new System.Windows.Forms.Button();
            this.btnRate5 = new System.Windows.Forms.Button();
            this.btnSkipRating = new System.Windows.Forms.Button();

            // WELCOME
            this.pnlWelcome.Controls.Add(this.picLogo);
            this.pnlWelcome.Controls.Add(this.lblWelcomeTitle);
            this.pnlWelcome.Controls.Add(this.lblWelcomeSub);
            this.pnlWelcome.Controls.Add(this.btnStart);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcome.BackColor = Theme.BgSlate;

            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.Location = new System.Drawing.Point(362, 120);
            this.picLogo.Size = new System.Drawing.Size(300, 300);

            this.lblWelcomeTitle.Font = Theme.TitleFont;
            this.lblWelcomeTitle.ForeColor = Theme.PSU_Blue;
            this.lblWelcomeTitle.Location = new System.Drawing.Point(0, 440);
            this.lblWelcomeTitle.Size = new System.Drawing.Size(1024, 50);
            this.lblWelcomeTitle.Text = "PANGASINAN STATE UNIVERSITY";
            this.lblWelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblWelcomeSub.Font = Theme.SubFont;
            this.lblWelcomeSub.ForeColor = Theme.TextGray;
            this.lblWelcomeSub.Location = new System.Drawing.Point(0, 490);
            this.lblWelcomeSub.Size = new System.Drawing.Size(1024, 30);
            this.lblWelcomeSub.Text = "Office of the University Registrar";
            this.lblWelcomeSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnStart.BackColor = Theme.PSU_Blue;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = Theme.BtnFont;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(312, 550);
            this.btnStart.Size = new System.Drawing.Size(400, 60);
            this.btnStart.Text = "TAP TO START";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // MAIN MENU
            this.pnlMainMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMainMenu.Controls.Add(this.btnMenuQueue);
            this.pnlMainMenu.Controls.Add(this.btnMenuAppt);
            this.pnlMainMenu.Controls.Add(this.btnBackMenu);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.BackColor = Theme.BgSlate;
            this.pnlMainMenu.Visible = false;

            this.lblMenuTitle.Font = Theme.HeaderFont;
            this.lblMenuTitle.ForeColor = Theme.TextDark;
            this.lblMenuTitle.Location = new System.Drawing.Point(0, 100);
            this.lblMenuTitle.Size = new System.Drawing.Size(1024, 50);
            this.lblMenuTitle.Text = "Select a Service";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnMenuQueue.BackColor = System.Drawing.Color.White;
            this.btnMenuQueue.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnMenuQueue.FlatAppearance.BorderSize = 1;
            this.btnMenuQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuQueue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnMenuQueue.ForeColor = Theme.PSU_Blue;
            this.btnMenuQueue.Location = new System.Drawing.Point(212, 200);
            this.btnMenuQueue.Size = new System.Drawing.Size(600, 100);
            this.btnMenuQueue.Text = "GET A QUEUE TICKET";
            this.btnMenuQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuQueue.Click += new System.EventHandler(this.btnMenuQueue_Click);

            this.btnMenuAppt.BackColor = System.Drawing.Color.White;
            this.btnMenuAppt.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnMenuAppt.FlatAppearance.BorderSize = 1;
            this.btnMenuAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAppt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnMenuAppt.ForeColor = Theme.PSU_Blue;
            this.btnMenuAppt.Location = new System.Drawing.Point(212, 330);
            this.btnMenuAppt.Size = new System.Drawing.Size(600, 100);
            this.btnMenuAppt.Text = "BOOK AN APPOINTMENT";
            this.btnMenuAppt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAppt.Click += new System.EventHandler(this.btnMenuAppt_Click);

            this.btnBackMenu.Text = "\u2190 Back";
            this.btnBackMenu.Font = Theme.SubFont;
            this.btnBackMenu.ForeColor = Theme.TextGray;
            this.btnBackMenu.Location = new System.Drawing.Point(20, 20);
            this.btnBackMenu.Size = new System.Drawing.Size(100, 40);
            this.btnBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMenu.FlatAppearance.BorderSize = 0;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);

            // ID ENTRY
            this.pnlId.Controls.Add(this.lblIdTitle);
            this.pnlId.Controls.Add(this.txtStudentId);
            this.pnlId.Controls.Add(this.chkGuest);
            this.pnlId.Controls.Add(this.btnContinue);
            this.pnlId.Controls.Add(this.btnBackId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlId.BackColor = Theme.BgSlate;
            this.pnlId.Visible = false;

            this.lblIdTitle.Font = Theme.HeaderFont;
            this.lblIdTitle.ForeColor = Theme.TextDark;
            this.lblIdTitle.Location = new System.Drawing.Point(0, 100);
            this.lblIdTitle.Size = new System.Drawing.Size(1024, 50);
            this.lblIdTitle.Text = "Enter Student ID";
            this.lblIdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.txtStudentId.Location = new System.Drawing.Point(262, 200);
            this.txtStudentId.Size = new System.Drawing.Size(500, 70);
            this.txtStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentId_KeyPress);

            this.chkGuest.Font = Theme.SubFont;
            this.chkGuest.ForeColor = Theme.TextDark;
            this.chkGuest.Location = new System.Drawing.Point(262, 300);
            this.chkGuest.Size = new System.Drawing.Size(500, 30);
            this.chkGuest.Text = "I am a Guest / Alumni";
            this.chkGuest.CheckedChanged += new System.EventHandler(this.chkGuest_CheckedChanged);

            this.btnContinue.BackColor = Theme.PSU_Blue;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = Theme.BtnFont;
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(312, 400);
            this.btnContinue.Size = new System.Drawing.Size(400, 60);
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);

            this.btnBackId.Text = "\u2190 Back";
            this.btnBackId.Font = Theme.SubFont;
            this.btnBackId.ForeColor = Theme.TextGray;
            this.btnBackId.Location = new System.Drawing.Point(20, 20);
            this.btnBackId.Size = new System.Drawing.Size(100, 40);
            this.btnBackId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackId.FlatAppearance.BorderSize = 0;
            this.btnBackId.Click += new System.EventHandler(this.btnBackId_Click);

            // SERVICE
            this.pnlService.Controls.Add(this.lblSvcTitle);
            this.pnlService.Controls.Add(this.btnSvcAddDrop);
            this.pnlService.Controls.Add(this.btnSvcIdVer);
            this.pnlService.Controls.Add(this.btnSvcDoc);
            this.pnlService.Controls.Add(this.btnSvcHelp);
            this.pnlService.Controls.Add(this.btnSvcPrio);
            this.pnlService.Controls.Add(this.lblConcern);
            this.pnlService.Controls.Add(this.txtConcern);
            this.pnlService.Controls.Add(this.btnBackSvc);
            this.pnlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlService.BackColor = Theme.BgSlate;
            this.pnlService.Visible = false;

            this.lblSvcTitle.Font = Theme.HeaderFont;
            this.lblSvcTitle.ForeColor = Theme.TextDark;
            this.lblSvcTitle.Location = new System.Drawing.Point(0, 30);
            this.lblSvcTitle.Size = new System.Drawing.Size(1024, 50);
            this.lblSvcTitle.Text = "Select Transaction";
            this.lblSvcTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnSvcAddDrop.BackColor = System.Drawing.Color.White;
            this.btnSvcAddDrop.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnSvcAddDrop.FlatAppearance.BorderSize = 1;
            this.btnSvcAddDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvcAddDrop.Font = Theme.BtnFont;
            this.btnSvcAddDrop.ForeColor = Theme.TextDark;
            this.btnSvcAddDrop.Location = new System.Drawing.Point(212, 100);
            this.btnSvcAddDrop.Size = new System.Drawing.Size(600, 70);
            this.btnSvcAddDrop.Text = "ADDING / DROPPING (Subjects)";
            this.btnSvcAddDrop.Tag = ServiceType.AddingDropping;
            this.btnSvcAddDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvcAddDrop.Click += new System.EventHandler(this.ServiceButton_Click);

            this.btnSvcIdVer.BackColor = System.Drawing.Color.White;
            this.btnSvcIdVer.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnSvcIdVer.FlatAppearance.BorderSize = 1;
            this.btnSvcIdVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvcIdVer.Font = Theme.BtnFont;
            this.btnSvcIdVer.ForeColor = Theme.TextDark;
            this.btnSvcIdVer.Location = new System.Drawing.Point(212, 185);
            this.btnSvcIdVer.Size = new System.Drawing.Size(600, 70);
            this.btnSvcIdVer.Text = "ID VERIFICATION";
            this.btnSvcIdVer.Tag = ServiceType.IdVerification;
            this.btnSvcIdVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvcIdVer.Click += new System.EventHandler(this.ServiceButton_Click);

            this.btnSvcDoc.BackColor = System.Drawing.Color.White;
            this.btnSvcDoc.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnSvcDoc.FlatAppearance.BorderSize = 1;
            this.btnSvcDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvcDoc.Font = Theme.BtnFont;
            this.btnSvcDoc.ForeColor = Theme.TextDark;
            this.btnSvcDoc.Location = new System.Drawing.Point(212, 270);
            this.btnSvcDoc.Size = new System.Drawing.Size(600, 70);
            this.btnSvcDoc.Text = "DOCUMENT REQUEST";
            this.btnSvcDoc.Tag = ServiceType.Document;
            this.btnSvcDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvcDoc.Click += new System.EventHandler(this.ServiceButton_Click);

            this.btnSvcHelp.BackColor = System.Drawing.Color.White;
            this.btnSvcHelp.FlatAppearance.BorderColor = Theme.PSU_Gold;
            this.btnSvcHelp.FlatAppearance.BorderSize = 2;
            this.btnSvcHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvcHelp.Font = Theme.BtnFont;
            this.btnSvcHelp.ForeColor = Theme.PSU_Blue;
            this.btnSvcHelp.Location = new System.Drawing.Point(212, 355);
            this.btnSvcHelp.Size = new System.Drawing.Size(600, 70);
            this.btnSvcHelp.Text = "HELP DESK / OTHERS";
            this.btnSvcHelp.Tag = ServiceType.HelpDesk;
            this.btnSvcHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvcHelp.Click += new System.EventHandler(this.ServiceButton_Click);

            this.btnSvcPrio.BackColor = System.Drawing.Color.White;
            this.btnSvcPrio.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnSvcPrio.FlatAppearance.BorderSize = 1;
            this.btnSvcPrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSvcPrio.Font = Theme.BtnFont;
            this.btnSvcPrio.ForeColor = Theme.TextDark;
            this.btnSvcPrio.Location = new System.Drawing.Point(212, 440);
            this.btnSvcPrio.Size = new System.Drawing.Size(600, 70);
            this.btnSvcPrio.Text = "PRIORITY LANE (PWD/Senior)";
            this.btnSvcPrio.Tag = ServiceType.Priority;
            this.btnSvcPrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvcPrio.Click += new System.EventHandler(this.ServiceButton_Click);

            this.lblConcern.Font = Theme.SubFont;
            this.lblConcern.ForeColor = Theme.RedAlert;
            this.lblConcern.Location = new System.Drawing.Point(212, 525);
            this.lblConcern.Size = new System.Drawing.Size(600, 25);
            this.lblConcern.Text = "If Help Desk: Please specify your concern below and press Enter";
            this.lblConcern.Visible = false;

            this.txtConcern.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtConcern.Location = new System.Drawing.Point(212, 550);
            this.txtConcern.Size = new System.Drawing.Size(600, 32);
            this.txtConcern.Visible = false;

            this.btnBackSvc.Text = "\u2190 Back";
            this.btnBackSvc.Font = Theme.SubFont;
            this.btnBackSvc.ForeColor = Theme.TextGray;
            this.btnBackSvc.Location = new System.Drawing.Point(20, 20);
            this.btnBackSvc.Size = new System.Drawing.Size(100, 40);
            this.btnBackSvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSvc.FlatAppearance.BorderSize = 0;
            this.btnBackSvc.Click += new System.EventHandler(this.btnBackSvc_Click);

            // TICKET
            this.pnlTicket.Controls.Add(this.lblTktTitle);
            this.pnlTicket.Controls.Add(this.lblQueue);
            this.pnlTicket.Controls.Add(this.lblWindow);
            this.pnlTicket.Controls.Add(this.lblAhead);
            this.pnlTicket.Controls.Add(this.lblTime);
            this.pnlTicket.Controls.Add(this.lblCountdown);
            this.pnlTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTicket.BackColor = Theme.BgWhite;
            this.pnlTicket.Visible = false;

            this.lblTktTitle.Font = Theme.SubFont;
            this.lblTktTitle.ForeColor = Theme.TextGray;
            this.lblTktTitle.Location = new System.Drawing.Point(0, 100);
            this.lblTktTitle.Size = new System.Drawing.Size(1024, 30);
            this.lblTktTitle.Text = "YOUR QUEUE NUMBER";
            this.lblTktTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblQueue.Font = Theme.MonoFont;
            this.lblQueue.ForeColor = Theme.PSU_Blue;
            this.lblQueue.Location = new System.Drawing.Point(0, 140);
            this.lblQueue.Size = new System.Drawing.Size(1024, 150);
            this.lblQueue.Text = "AD-000";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblWindow.Font = Theme.HeaderFont;
            this.lblWindow.ForeColor = Theme.TextDark;
            this.lblWindow.Location = new System.Drawing.Point(0, 310);
            this.lblWindow.Size = new System.Drawing.Size(1024, 50);
            this.lblWindow.Text = "PLEASE WAIT FOR YOUR NUMBER TO BE CALLED";
            this.lblWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblAhead.Font = Theme.SubFont;
            this.lblAhead.ForeColor = Theme.TextGray;
            this.lblAhead.Location = new System.Drawing.Point(0, 400);
            this.lblAhead.Size = new System.Drawing.Size(1024, 30);
            this.lblAhead.Text = "People ahead: 0";
            this.lblAhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTime.Font = Theme.SubFont;
            this.lblTime.ForeColor = Theme.TextGray;
            this.lblTime.Location = new System.Drawing.Point(0, 440);
            this.lblTime.Size = new System.Drawing.Size(1024, 30);
            this.lblTime.Text = "Est. Wait: 0 mins";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCountdown.ForeColor = Theme.TextGray;
            this.lblCountdown.Location = new System.Drawing.Point(0, 650);
            this.lblCountdown.Size = new System.Drawing.Size(1024, 30);
            this.lblCountdown.Text = "Resetting in 8 seconds...";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // APPOINTMENT
            this.pnlAppt.Controls.Add(this.lblApptTitle);
            this.pnlAppt.Controls.Add(this.lblApptId);
            this.pnlAppt.Controls.Add(this.txtApptId);
            this.pnlAppt.Controls.Add(this.lblApptService);
            this.pnlAppt.Controls.Add(this.cbApptService);
            this.pnlAppt.Controls.Add(this.lblApptDate);
            this.pnlAppt.Controls.Add(this.dtpApptDate);
            this.pnlAppt.Controls.Add(this.lblApptTime);
            this.pnlAppt.Controls.Add(this.cbApptTime);
            this.pnlAppt.Controls.Add(this.btnSubmitAppt);
            this.pnlAppt.Controls.Add(this.btnBackAppt);
            this.pnlAppt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppt.BackColor = Theme.BgSlate;
            this.pnlAppt.Visible = false;

            this.lblApptTitle.Font = Theme.HeaderFont;
            this.lblApptTitle.ForeColor = Theme.TextDark;
            this.lblApptTitle.Location = new System.Drawing.Point(0, 60);
            this.lblApptTitle.Size = new System.Drawing.Size(1024, 50);
            this.lblApptTitle.Text = "Book Appointment";
            this.lblApptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblApptId.Font = Theme.SubFont;
            this.lblApptId.ForeColor = Theme.TextDark;
            this.lblApptId.Location = new System.Drawing.Point(312, 150);
            this.lblApptId.Size = new System.Drawing.Size(200, 30);
            this.lblApptId.Text = "Student ID:";

            this.txtApptId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtApptId.Location = new System.Drawing.Point(512, 150);
            this.txtApptId.Size = new System.Drawing.Size(200, 29);

            this.lblApptService.Font = Theme.SubFont;
            this.lblApptService.ForeColor = Theme.TextDark;
            this.lblApptService.Location = new System.Drawing.Point(312, 210);
            this.lblApptService.Size = new System.Drawing.Size(200, 30);
            this.lblApptService.Text = "Service:";

            this.cbApptService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbApptService.Location = new System.Drawing.Point(512, 210);
            this.cbApptService.Size = new System.Drawing.Size(200, 29);
            this.cbApptService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApptService.Items.AddRange(new object[] { "Adding/Dropping", "ID Verification", "Document Request", "Help Desk" });

            this.lblApptDate.Font = Theme.SubFont;
            this.lblApptDate.ForeColor = Theme.TextDark;
            this.lblApptDate.Location = new System.Drawing.Point(312, 270);
            this.lblApptDate.Size = new System.Drawing.Size(200, 30);
            this.lblApptDate.Text = "Date:";

            this.dtpApptDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpApptDate.Location = new System.Drawing.Point(512, 270);
            this.dtpApptDate.Size = new System.Drawing.Size(200, 29);
            this.dtpApptDate.MinDate = System.DateTime.Today;
            this.dtpApptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblApptTime.Font = Theme.SubFont;
            this.lblApptTime.ForeColor = Theme.TextDark;
            this.lblApptTime.Location = new System.Drawing.Point(312, 330);
            this.lblApptTime.Size = new System.Drawing.Size(200, 30);
            this.lblApptTime.Text = "Time Slot:";

            this.cbApptTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbApptTime.Location = new System.Drawing.Point(512, 330);
            this.cbApptTime.Size = new System.Drawing.Size(200, 29);
            this.cbApptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApptTime.Items.AddRange(new object[] { "08:00 AM", "09:00 AM", "10:00 AM", "01:00 PM", "02:00 PM", "03:00 PM" });

            this.btnSubmitAppt.BackColor = Theme.PSU_Blue;
            this.btnSubmitAppt.FlatAppearance.BorderSize = 0;
            this.btnSubmitAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAppt.Font = Theme.BtnFont;
            this.btnSubmitAppt.ForeColor = System.Drawing.Color.White;
            this.btnSubmitAppt.Location = new System.Drawing.Point(312, 420);
            this.btnSubmitAppt.Size = new System.Drawing.Size(400, 50);
            this.btnSubmitAppt.Text = "CONFIRM APPOINTMENT";
            this.btnSubmitAppt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitAppt.Click += new System.EventHandler(this.btnSubmitAppt_Click);

            this.btnBackAppt.Text = "\u2190 Back";
            this.btnBackAppt.Font = Theme.SubFont;
            this.btnBackAppt.ForeColor = Theme.TextGray;
            this.btnBackAppt.Location = new System.Drawing.Point(20, 20);
            this.btnBackAppt.Size = new System.Drawing.Size(100, 40);
            this.btnBackAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAppt.FlatAppearance.BorderSize = 0;
            this.btnBackAppt.Click += new System.EventHandler(this.btnBackMenu_Click);

            // RATING PANEL (NO HOVER ANIMATION)
            this.pnlRating.Controls.Add(this.lblRatingTitle);
            this.pnlRating.Controls.Add(this.lblRatingSub);
            this.pnlRating.Controls.Add(this.btnRate1);
            this.pnlRating.Controls.Add(this.btnRate2);
            this.pnlRating.Controls.Add(this.btnRate3);
            this.pnlRating.Controls.Add(this.btnRate4);
            this.pnlRating.Controls.Add(this.btnRate5);
            this.pnlRating.Controls.Add(this.btnSkipRating);
            this.pnlRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRating.BackColor = Theme.BgWhite;
            this.pnlRating.Visible = false;

            this.lblRatingTitle.Font = Theme.HeaderFont;
            this.lblRatingTitle.ForeColor = Theme.PSU_Blue;
            this.lblRatingTitle.Location = new System.Drawing.Point(0, 140);
            this.lblRatingTitle.Size = new System.Drawing.Size(1024, 50);
            this.lblRatingTitle.Text = "Transaction Completed!";
            this.lblRatingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblRatingSub.Font = Theme.SubFont;
            this.lblRatingSub.ForeColor = Theme.TextGray;
            this.lblRatingSub.Location = new System.Drawing.Point(0, 200);
            this.lblRatingSub.Size = new System.Drawing.Size(1024, 35);
            this.lblRatingSub.Text = "How was your experience with the Registrar?";
            this.lblRatingSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnRate1.BackColor = Theme.PSU_Gold;
            this.btnRate1.FlatAppearance.BorderSize = 0;
            this.btnRate1.FlatAppearance.MouseOverBackColor = Theme.PSU_Gold;
            this.btnRate1.FlatAppearance.MouseDownBackColor = Theme.PSU_Gold;
            this.btnRate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnRate1.ForeColor = Theme.PSU_Blue;
            this.btnRate1.Location = new System.Drawing.Point(182, 290);
            this.btnRate1.Size = new System.Drawing.Size(120, 100);
            this.btnRate1.Text = "1";
            this.btnRate1.Tag = 1;
            this.btnRate1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRate1.Click += new System.EventHandler(this.RateButton_Click);

            this.btnRate2.BackColor = Theme.PSU_Gold;
            this.btnRate2.FlatAppearance.BorderSize = 0;
            this.btnRate2.FlatAppearance.MouseOverBackColor = Theme.PSU_Gold;
            this.btnRate2.FlatAppearance.MouseDownBackColor = Theme.PSU_Gold;
            this.btnRate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnRate2.ForeColor = Theme.PSU_Blue;
            this.btnRate2.Location = new System.Drawing.Point(317, 290);
            this.btnRate2.Size = new System.Drawing.Size(120, 100);
            this.btnRate2.Text = "2";
            this.btnRate2.Tag = 2;
            this.btnRate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRate2.Click += new System.EventHandler(this.RateButton_Click);

            this.btnRate3.BackColor = Theme.PSU_Gold;
            this.btnRate3.FlatAppearance.BorderSize = 0;
            this.btnRate3.FlatAppearance.MouseOverBackColor = Theme.PSU_Gold;
            this.btnRate3.FlatAppearance.MouseDownBackColor = Theme.PSU_Gold;
            this.btnRate3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnRate3.ForeColor = Theme.PSU_Blue;
            this.btnRate3.Location = new System.Drawing.Point(452, 290);
            this.btnRate3.Size = new System.Drawing.Size(120, 100);
            this.btnRate3.Text = "3";
            this.btnRate3.Tag = 3;
            this.btnRate3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRate3.Click += new System.EventHandler(this.RateButton_Click);

            this.btnRate4.BackColor = Theme.PSU_Gold;
            this.btnRate4.FlatAppearance.BorderSize = 0;
            this.btnRate4.FlatAppearance.MouseOverBackColor = Theme.PSU_Gold;
            this.btnRate4.FlatAppearance.MouseDownBackColor = Theme.PSU_Gold;
            this.btnRate4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnRate4.ForeColor = Theme.PSU_Blue;
            this.btnRate4.Location = new System.Drawing.Point(587, 290);
            this.btnRate4.Size = new System.Drawing.Size(120, 100);
            this.btnRate4.Text = "4";
            this.btnRate4.Tag = 4;
            this.btnRate4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRate4.Click += new System.EventHandler(this.RateButton_Click);

            this.btnRate5.BackColor = Theme.PSU_Gold;
            this.btnRate5.FlatAppearance.BorderSize = 0;
            this.btnRate5.FlatAppearance.MouseOverBackColor = Theme.PSU_Gold;
            this.btnRate5.FlatAppearance.MouseDownBackColor = Theme.PSU_Gold;
            this.btnRate5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnRate5.ForeColor = Theme.PSU_Blue;
            this.btnRate5.Location = new System.Drawing.Point(722, 290);
            this.btnRate5.Size = new System.Drawing.Size(120, 100);
            this.btnRate5.Text = "5";
            this.btnRate5.Tag = 5;
            this.btnRate5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRate5.Click += new System.EventHandler(this.RateButton_Click);

            this.btnSkipRating.BackColor = Theme.BgSlate;
            this.btnSkipRating.FlatAppearance.BorderColor = Theme.BorderGray;
            this.btnSkipRating.FlatAppearance.BorderSize = 1;
            this.btnSkipRating.FlatAppearance.MouseOverBackColor = Theme.BgSlate;
            this.btnSkipRating.FlatAppearance.MouseDownBackColor = Theme.BgSlate;
            this.btnSkipRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkipRating.Font = Theme.SubFont;
            this.btnSkipRating.ForeColor = Theme.TextGray;
            this.btnSkipRating.Location = new System.Drawing.Point(362, 460);
            this.btnSkipRating.Size = new System.Drawing.Size(300, 50);
            this.btnSkipRating.Text = "Skip";
            this.btnSkipRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkipRating.Click += new System.EventHandler(this.btnSkipRating_Click);

            this.timerReset.Interval = 1000;
            this.timerReset.Tick += new System.EventHandler(this.timerReset_Tick);
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.pnlRating);
            this.Controls.Add(this.pnlTicket);
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.pnlAppt);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSU Registrar Kiosk";
        }

        private System.Windows.Forms.Timer timerReset;
        private System.Windows.Forms.Panel pnlWelcome, pnlMainMenu, pnlId, pnlService, pnlTicket, pnlAppt, pnlRating;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcomeTitle, lblWelcomeSub, lblIdTitle, lblSvcTitle, lblTktTitle;
        private System.Windows.Forms.Label lblQueue, lblWindow, lblAhead, lblTime, lblCountdown, lblConcern;
        private System.Windows.Forms.Button btnStart, btnContinue, btnSvcAddDrop, btnSvcIdVer, btnSvcDoc, btnSvcHelp, btnSvcPrio;
        private System.Windows.Forms.TextBox txtStudentId, txtConcern;
        private System.Windows.Forms.CheckBox chkGuest;

        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnMenuQueue, btnMenuAppt, btnBackMenu, btnBackId, btnBackSvc;

        private System.Windows.Forms.Label lblApptTitle, lblApptId, lblApptService, lblApptDate, lblApptTime;
        private System.Windows.Forms.TextBox txtApptId;
        private System.Windows.Forms.ComboBox cbApptService, cbApptTime;
        private System.Windows.Forms.DateTimePicker dtpApptDate;
        private System.Windows.Forms.Button btnSubmitAppt, btnBackAppt;

        private System.Windows.Forms.Label lblRatingTitle, lblRatingSub;
        private System.Windows.Forms.Button btnRate1, btnRate2, btnRate3, btnRate4, btnRate5, btnSkipRating;
    }
}