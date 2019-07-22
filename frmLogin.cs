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
    public partial class frmLogin : Form
    {
        frmMDI MDI2;
        public frmLogin(frmMDI MDI3)
        {
            InitializeComponent();
            MDI2 = MDI3;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbCompany.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("User Id or Password not entered");
                    return;
                }
                SqlConnection con = new SqlConnection();
                if (cmbCompany.Text == "ABC Furnitures")
                {
                    con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
                    frmMDI.login = 1;
                }
                else
                {
                    con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
                    frmMDI.login = 2;
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) count from Login where user_id = @id and pass = @pas", con);
                cmd.Parameters.AddWithValue("@id", txtUser.Text);
                cmd.Parameters.AddWithValue("@pas", txtPass.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if ((Convert.ToInt32(dr[0].ToString())) == 0)
                    MessageBox.Show("Invalid Username or Password");
                else
                {
                    MDI2.panelMDI.Visible = true;
                    MDI2.btnBill.Visible = true;
                    MDI2.btnExit.Visible = true;
                    MDI2.btnAbout.Visible = true;
                    MDI2.btnLogout.Visible = true;
                    MDI2.btnProduct.Visible = true;
                    MDI2.btnReport.Visible = true;
                    MDI2.btnUtility.Visible = true;
                    MDI2.btnBill.Enabled = true;
                    MDI2.btnExit.Enabled = true;
                    MDI2.btnAbout.Enabled = true;
                    MDI2.btnLogout.Enabled = true;
                    MDI2.btnProduct.Enabled = true;
                    MDI2.btnReport.Enabled = true;
                    MDI2.btnUtility.Enabled = true;
                    if (frmMDI.login == 1)
                        MDI2.lblCompany.Text = "ABC Furnitures";
                    else
                        MDI2.lblCompany.Text = "ABC Decorators";
                    this.Close();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected Error Occurred. Please try again after sometime");
            }
        }

    }
}
