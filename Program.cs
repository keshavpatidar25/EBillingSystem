using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace E_Billing_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmMDI MDI1 = new frmMDI();
            Application.Run(MDI1);
        }
    }
}
