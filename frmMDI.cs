using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Billing_System
{
    public partial class frmMDI : Form
    {
        public static frmProducts Product1;
        public static frmBill Bill1;
        public static frmReport Report1;
        public static frmUtilities Utility1;
        public static int login;
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            login = 0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + "\\Furniture.mdf] SET Multi_User", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True");
            cmd = new SqlCommand("ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + "\\Decorator.mdf] SET Multi_User", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            frmLogin Login1 = new frmLogin(this);
            Login1.MdiParent = this;
            Login1.Show();
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (Product1 == null)
            {
                Product1 = new frmProducts();
                Product1.MdiParent = this;
                Product1.Show();
            }
            else
            {
                Product1.SetDesktopBounds(0, 0, 1517, 628);
                Product1.WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitApp = MessageBox.Show("Do you want to Exit?","Exit", MessageBoxButtons.YesNo);
            if (exitApp == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
                      
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (Bill1 == null)
            {
                Bill1 = new frmBill();
                Bill1.MdiParent = this;
                Bill1.Show();
            }
            else
            {
                Bill1.SetDesktopBounds(0, 0, 1194, 736);
                Bill1.WindowState = FormWindowState.Normal;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Report1 == null)
            {
                Report1 = new frmReport();
                Report1.MdiParent = this;
                Report1.Show();
            }
            else
            {
                Report1.SetDesktopBounds(0, 0, 761,305);
                Report1.WindowState = FormWindowState.Normal;
            }
        }

        private void btnUtility_Click(object sender, EventArgs e)
        {
            if (Utility1 == null)
            {
                Utility1 = new frmUtilities();
                Utility1.MdiParent = this;
                Utility1.Show();
            }
            else
            {
                Utility1.SetDesktopBounds(0, 0, 559, 289);
                Utility1.WindowState = FormWindowState.Normal;
            }
        }

        

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + "\\Furniture.mdf] SET Multi_User", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True");
            cmd = new SqlCommand("ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + "\\Decorator.mdf] SET Multi_User", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout About1 = new frmAbout();
            About1.ShowDialog();
            About1.SetDesktopBounds(200, 500,537, 411);
        }

        
    }
}
