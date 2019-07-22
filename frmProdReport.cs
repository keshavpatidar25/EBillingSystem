using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Billing_System
{
    public partial class frmProdReport : Form
    {
        public frmProdReport()
        {
            InitializeComponent();
        }

        private void frmProdReport_Load(object sender, EventArgs e)
        {
            
        }

        private void frmProdReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReport.ProdReport1 = null;
        }

        private void CrystalReportProduct1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
