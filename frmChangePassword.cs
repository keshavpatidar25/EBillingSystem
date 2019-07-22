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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if((txtNewPass.Text=="")||(txtOldPass.Text=="")||(txtReEnterPass.Text==""))
            {
                MessageBox.Show("Some values not entered.");
                this.DialogResult = DialogResult.None;
                return;
            }
            if(!txtNewPass.Text.Equals(txtReEnterPass.Text))
            {
                MessageBox.Show("New Passwords donot match.");
                this.DialogResult = DialogResult.None;
                return;
            }
            if(txtNewPass.Text.Equals(txtOldPass.Text))
            {
                MessageBox.Show("Old Password and New Password are same.");
                this.DialogResult = DialogResult.None;
                return;
            }

            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Pass from Login where User_Id = 'admin'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr[0].ToString().Trim().Equals(txtOldPass.Text))
            {
                MessageBox.Show("Wrong Password.");
                this.DialogResult = DialogResult.None;
                return;
            }
            dr.Close();
            cmd = new SqlCommand("Update Login Set Pass = @newpass Where User_Id = 'admin'", con);
            cmd.Parameters.AddWithValue("@newpass", txtNewPass.Text);
            if(Convert.ToBoolean(cmd.ExecuteNonQuery()))
                MessageBox.Show("Password Changed Successfully");
            else
                MessageBox.Show("Password Cannot Be Changed");
            con.Close(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtReEnterPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

       

        
    }
}
