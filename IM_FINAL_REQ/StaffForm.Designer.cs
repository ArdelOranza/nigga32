using System.Drawing;
using System.Windows.Forms;

namespace IM_FINAL_REQ
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private PictureBox picLogoSmall;
        private Label lblTitle;
        private ComboBox cbWindow;
        private Label lblWindowSelect;
        private Panel pnlLeft;
        private Label lblNowServingHeader;
        private Label lblCurrentNumber;
        private Label lblCurrentStudent;
        private Label lblCurrentStatus;
        private Label lblLastCalled;
        private Button btnNext;
        private Button btnAction1;
        private Button btnAction2;
        private Button btnSkip;
        private Panel pnlRight;
        private Label lblQueueHeader;
        private DataGridView dgvQueue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            picLogoSmall = new PictureBox();
            lblTitle = new Label();
            lblWindowSelect = new Label();
            cbWindow = new ComboBox();
            pnlLeft = new Panel();
            lblNowServingHeader = new Label();
            lblCurrentNumber = new Label();
            lblCurrentStudent = new Label();
            lblCurrentStatus = new Label();
            lblLastCalled = new Label();
            btnNext = new Button();
            btnAction1 = new Button();
            btnAction2 = new Button();
            btnSkip = new Button();
            pnlRight = new Panel();
            lblQueueHeader = new Label();
            dgvQueue = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoSmall).BeginInit();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(picLogoSmall);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblWindowSelect);
            pnlHeader.Controls.Add(cbWindow);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(940, 70);
            pnlHeader.TabIndex = 2;
            pnlHeader.Paint += PnlHeader_Paint;
            // 
            // picLogoSmall
            picLogoSmall.Location = new Point(20, 12);
            picLogoSmall.Name = "picLogoSmall";
            picLogoSmall.Size = new Size(45, 45);
            picLogoSmall.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoSmall.TabIndex = 0;
            picLogoSmall.TabStop = false;
            // 
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(75, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Registrar Window 1";
            // 
            // lblWindowSelect
            lblWindowSelect.AutoSize = true;
            lblWindowSelect.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWindowSelect.ForeColor = Color.FromArgb(71, 85, 105);
            lblWindowSelect.Location = new Point(620, 25);
            lblWindowSelect.Name = "lblWindowSelect";
            lblWindowSelect.Size = new Size(112, 19);
            lblWindowSelect.TabIndex = 2;
            lblWindowSelect.Text = "Select Window:";
            // 
            // cbWindow
            cbWindow.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWindow.Font = new Font("Segoe UI", 11F);
            cbWindow.Location = new Point(735, 21);
            cbWindow.Name = "cbWindow";
            cbWindow.Size = new Size(180, 28);
            cbWindow.TabIndex = 3;
            cbWindow.SelectedIndexChanged += cbWindow_SelectedIndexChanged;
            // 
            // pnlLeft
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(lblNowServingHeader);
            pnlLeft.Controls.Add(lblCurrentNumber);
            pnlLeft.Controls.Add(lblCurrentStudent);
            pnlLeft.Controls.Add(lblCurrentStatus);
            pnlLeft.Controls.Add(lblLastCalled);
            pnlLeft.Controls.Add(btnNext);
            pnlLeft.Controls.Add(btnAction1);
            pnlLeft.Controls.Add(btnAction2);
            pnlLeft.Controls.Add(btnSkip);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 70);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(360, 510);
            pnlLeft.TabIndex = 1;
            pnlLeft.Paint += PnlLeft_Paint;
            // 
            // lblNowServingHeader
            lblNowServingHeader.AutoSize = true;
            lblNowServingHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNowServingHeader.ForeColor = Color.FromArgb(100, 116, 139);
            lblNowServingHeader.Location = new Point(25, 20);
            lblNowServingHeader.Name = "lblNowServingHeader";
            lblNowServingHeader.Size = new Size(149, 19);
            lblNowServingHeader.TabIndex = 0;
            lblNowServingHeader.Text = "CURRENTLY SERVING";
            // 
            // lblCurrentNumber
            lblCurrentNumber.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblCurrentNumber.ForeColor = Color.FromArgb(30, 58, 138);
            lblCurrentNumber.Location = new Point(20, 45);
            lblCurrentNumber.Name = "lblCurrentNumber";
            lblCurrentNumber.Size = new Size(320, 65);
            lblCurrentNumber.TabIndex = 1;
            lblCurrentNumber.Text = "---";
            // 
            // lblCurrentStudent
            lblCurrentStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCurrentStudent.ForeColor = Color.FromArgb(15, 23, 42);
            lblCurrentStudent.Location = new Point(25, 115);
            lblCurrentStudent.Name = "lblCurrentStudent";
            lblCurrentStudent.Size = new Size(310, 25);
            lblCurrentStudent.TabIndex = 2;
            lblCurrentStudent.Text = "No Active Ticket";
            // 
            // lblCurrentStatus
            lblCurrentStatus.Font = new Font("Segoe UI", 10F);
            lblCurrentStatus.ForeColor = Color.FromArgb(71, 85, 105);
            lblCurrentStatus.Location = new Point(25, 145);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(310, 60);
            lblCurrentStatus.TabIndex = 3;
            lblCurrentStatus.Text = "Click 'Call Next' to start.";
            // 
            // lblLastCalled
            lblLastCalled.BackColor = Color.FromArgb(241, 245, 249);
            lblLastCalled.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastCalled.ForeColor = Color.FromArgb(15, 23, 42);
            lblLastCalled.Location = new Point(25, 215);
            lblLastCalled.Name = "lblLastCalled";
            lblLastCalled.Size = new Size(310, 35);
            lblLastCalled.TabIndex = 4;
            lblLastCalled.Text = "READY TO CALL";
            lblLastCalled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            btnNext.BackColor = Color.FromArgb(30, 58, 138);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(25, 265);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(310, 50);
            btnNext.TabIndex = 5;
            btnNext.Text = "CALL NEXT (F1)";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnAction1
            btnAction1.BackColor = Color.FromArgb(22, 163, 74);
            btnAction1.FlatAppearance.BorderSize = 0;
            btnAction1.FlatStyle = FlatStyle.Flat;
            btnAction1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAction1.ForeColor = Color.White;
            btnAction1.Location = new Point(25, 330);
            btnAction1.Name = "btnAction1";
            btnAction1.Size = new Size(310, 45);
            btnAction1.TabIndex = 6;
            btnAction1.Text = "COMPLETE (NO PAYMENT)";
            btnAction1.UseVisualStyleBackColor = false;
            btnAction1.Click += btnAction1_Click;
            // 
            // btnAction2
            btnAction2.BackColor = Color.FromArgb(234, 179, 8);
            btnAction2.FlatAppearance.BorderSize = 0;
            btnAction2.FlatStyle = FlatStyle.Flat;
            btnAction2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAction2.ForeColor = Color.White;
            btnAction2.Location = new Point(25, 385);
            btnAction2.Name = "btnAction2";
            btnAction2.Size = new Size(310, 45);
            btnAction2.TabIndex = 7;
            btnAction2.Text = "SEND TO CASHIER";
            btnAction2.UseVisualStyleBackColor = false;
            btnAction2.Click += btnAction2_Click;
            // 
            // btnSkip
            btnSkip.BackColor = Color.FromArgb(220, 38, 38);
            btnSkip.FlatAppearance.BorderSize = 0;
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSkip.ForeColor = Color.White;
            btnSkip.Location = new Point(25, 440);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(310, 45);
            btnSkip.TabIndex = 8;
            btnSkip.Text = "SKIP TICKET";
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
            // 
            // pnlRight
            pnlRight.BackColor = Color.FromArgb(248, 250, 252);
            pnlRight.Controls.Add(lblQueueHeader);
            pnlRight.Controls.Add(dgvQueue);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(360, 70);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(25);
            pnlRight.Size = new Size(580, 510);
            pnlRight.TabIndex = 0;
            // 
            // lblQueueHeader
            lblQueueHeader.AutoSize = true;
            lblQueueHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQueueHeader.ForeColor = Color.FromArgb(15, 23, 42);
            lblQueueHeader.Location = new Point(25, 20);
            lblQueueHeader.Name = "lblQueueHeader";
            lblQueueHeader.Size = new Size(124, 21);
            lblQueueHeader.TabIndex = 0;
            lblQueueHeader.Text = "Waiting Queue";
            // 
            // dgvQueue
            dgvQueue.AllowUserToAddRows = false;
            dgvQueue.AllowUserToDeleteRows = false;
            dgvQueue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQueue.BackgroundColor = Color.White;
            dgvQueue.BorderStyle = BorderStyle.None;
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Location = new Point(25, 55);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.ReadOnly = true;
            dgvQueue.RowHeadersVisible = false;
            dgvQueue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQueue.Size = new Size(530, 430);
            dgvQueue.TabIndex = 1;
            // StaffForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 580);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlHeader);
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Terminal - Queue Management System";
            Load += StaffForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoSmall).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            ResumeLayout(false);
        }
    }
}