namespace IM_FINAL_REQ
{
    partial class DisplayForm
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
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);

            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.lblRegTitle = new System.Windows.Forms.Label();
            this.lblRegNow = new System.Windows.Forms.Label();
            this.lblRegWin = new System.Windows.Forms.Label();
            this.lblRegWait = new System.Windows.Forms.Label();

            this.pnlCash = new System.Windows.Forms.Panel();
            this.lblCashTitle = new System.Windows.Forms.Label();
            this.lblCashNow = new System.Windows.Forms.Label();
            this.lblCashWin = new System.Windows.Forms.Label();
            this.lblCashWait = new System.Windows.Forms.Label();

            this.tblMain.ColumnCount = 2;
            this.tblMain.RowCount = 1;
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Padding = new System.Windows.Forms.Padding(0);
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.pnlReg, 0, 0);
            this.tblMain.Controls.Add(this.pnlCash, 1, 0);

            // REGISTRAR PANEL
            this.pnlReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReg.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReg.BackColor = Theme.PSU_Blue;
            this.pnlReg.Controls.Add(this.lblRegWait);
            this.pnlReg.Controls.Add(this.lblRegWin);
            this.pnlReg.Controls.Add(this.lblRegNow);
            this.pnlReg.Controls.Add(this.lblRegTitle);

            this.lblRegTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblRegTitle.ForeColor = Color.White;
            this.lblRegTitle.Text = "REGISTRAR";
            this.lblRegTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegTitle.Height = 80;

            this.lblRegNow.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold);
            this.lblRegNow.ForeColor = Theme.PSU_Gold;
            this.lblRegNow.Text = "---";
            this.lblRegNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegNow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegNow.Height = 200;

            this.lblRegWin.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblRegWin.ForeColor = Color.White;
            this.lblRegWin.Text = "WINDOW: -";
            this.lblRegWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegWin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegWin.Height = 80;

            this.lblRegWait.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.lblRegWait.ForeColor = Color.LightGray;
            this.lblRegWait.Text = "WAITING: ";
            this.lblRegWait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegWait.Dock = System.Windows.Forms.DockStyle.Fill;

            // CASHIER PANEL
            this.pnlCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCash.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCash.BackColor = Theme.PSU_Gold;
            this.pnlCash.Controls.Add(this.lblCashWait);
            this.pnlCash.Controls.Add(this.lblCashWin);
            this.pnlCash.Controls.Add(this.lblCashNow);
            this.pnlCash.Controls.Add(this.lblCashTitle);

            this.lblCashTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblCashTitle.ForeColor = Theme.PSU_Blue;
            this.lblCashTitle.Text = "CASHIER";
            this.lblCashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCashTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCashTitle.Height = 80;

            this.lblCashNow.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold);
            this.lblCashNow.ForeColor = Theme.PSU_Blue;
            this.lblCashNow.Text = "---";
            this.lblCashNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCashNow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCashNow.Height = 200;

            this.lblCashWin.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblCashWin.ForeColor = Color.Black;
            this.lblCashWin.Text = "WINDOW: -";
            this.lblCashWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCashWin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCashWin.Height = 80;

            this.lblCashWait.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.lblCashWait.ForeColor = Color.DimGray;
            this.lblCashWait.Text = "WAITING: ";
            this.lblCashWait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCashWait.Dock = System.Windows.Forms.DockStyle.Fill;

            this.timerRefresh.Interval = 2000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);

            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "Public Display";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
        }

        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlReg, pnlCash;
        private System.Windows.Forms.Label lblRegTitle, lblRegNow, lblRegWin, lblRegWait;
        private System.Windows.Forms.Label lblCashTitle, lblCashNow, lblCashWin, lblCashWait;
    }
}