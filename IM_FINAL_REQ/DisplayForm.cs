using System;
using System.Linq;
using System.Windows.Forms;

namespace IM_FINAL_REQ
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        // THIS FIXES THE CS1061 ERROR FOR DisplayForm_Load
        private void DisplayForm_Load(object sender, EventArgs e)
        {
            timerRefresh.Start();
            RefreshDisplay();
        }

        // THIS FIXES THE CS1061 ERROR FOR timerRefresh_Tick
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            // REGISTRAR
            var regNow = QueueManager.GetServingTicket(Department.Registrar);
            if (regNow != null)
            {
                lblRegNow.Text = regNow.Number;
                lblRegWin.Text = "WINDOW " + regNow.Window;
            }
            else
            {
                lblRegNow.Text = "---";
                lblRegWin.Text = "WINDOW -";
            }

            var regWait = QueueManager.GetWaitingList(Department.Registrar);
            lblRegWait.Text = "WAITING:\n\n" + (regWait.Count == 0 ? "Empty" : string.Join("   ", regWait.Select(t => t.Number)));

            // CASHIER
            var cashNow = QueueManager.GetServingTicket(Department.Cashier);
            if (cashNow != null)
            {
                lblCashNow.Text = cashNow.Number;
                lblCashWin.Text = "WINDOW " + cashNow.Window;
            }
            else
            {
                lblCashNow.Text = "---";
                lblCashWin.Text = "WINDOW -";
            }

            var cashWait = QueueManager.GetWaitingList(Department.Cashier);
            lblCashWait.Text = "WAITING:\n\n" + (cashWait.Count == 0 ? "Empty" : string.Join("   ", cashWait.Select(t => t.Number)));
        }
    }
}