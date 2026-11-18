using System;
using System.Windows.Forms;

namespace IM_FINAL_REQ
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try { using (var cn = Db.Open()) { } }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to XAMPP MySQL: " + ex.Message);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new DisplayForm().Show();

            new StaffForm().Show();

            Application.Run(new KioskForm());
        }
    }
}