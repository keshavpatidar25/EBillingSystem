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
    public partial class frmUtilities : Form
    {
        public frmUtilities()
        {
            InitializeComponent();
        }

        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                if (frmMDI.login == 1)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True"))
                    {
                        cmd = new SqlCommand(@"backup database [" + System.IO.Directory.GetCurrentDirectory() + @"\Furniture.mdf] to disk=@path with format", con);
                        cmd.Parameters.AddWithValue("@path", @"" + System.IO.Directory.GetCurrentDirectory() + @"\..\..\Database Backup\Furniture.bak");
                        con.Open();
                        if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                            MessageBox.Show("Furniture Database Backup Successfull");
                        else
                            MessageBox.Show("Furniture Database Backup Unsuccessfull");
                        con.Close();
                    }
                }
                else if (frmMDI.login == 2)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True"))
                    {
                        cmd = new SqlCommand(@"backup database [" + System.IO.Directory.GetCurrentDirectory() + @"\Decorator.mdf] to disk=@path with format", con);
                        cmd.Parameters.AddWithValue("@path", @"" + System.IO.Directory.GetCurrentDirectory() + @"\..\..\Database Backup\Decorator.bak");
                        con.Open();
                        if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                            MessageBox.Show("Decorator Database Backup Successfull");
                        else
                            MessageBox.Show("Decorator Database Backup Unsuccessfull");
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected Error Occured. Please try again after some time.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUtilities_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMDI.Utility1 = null;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePass1 = new frmChangePassword();
            ChangePass1.ShowDialog();
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            this.Parent.Enabled = false;
            SqlCommand cmd;
            if (frmMDI.login == 1)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True"))
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand(@"ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + @"\Furniture.mdf] SET Single_User WITH Rollback Immediate", con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(@"USE [master]; RESTORE DATABASE [" + System.IO.Directory.GetCurrentDirectory() + @"\Furniture.mdf] FROM DISK = @path WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10", con);
                        cmd.Parameters.AddWithValue("@path", @"" + System.IO.Directory.GetCurrentDirectory() + @"\..\..\Database Backup\Furniture.bak");
                        if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                            MessageBox.Show("Furniture Database Restore Successfull.\nApplication will again restart.");
                        else
                            MessageBox.Show("Furniture Database Restore Unsuccessfull");
                        cmd = new SqlCommand(@"ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + @"\Furniture.mdf] SET Multi_User", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        progressBarUtility.Visible = true;
                        for (int i = 0; i <= 10000000; i++)
                            progressBarUtility.Value = i;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Cannot Restore Furniture Database as Backup File not found. Application will Restart.");
                    }
                }
            }
            else if (frmMDI.login == 2)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True"))
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand(@"ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + @"\Decorator.mdf] SET Single_User WITH Rollback Immediate", con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(@"USE [master]; RESTORE DATABASE [" + System.IO.Directory.GetCurrentDirectory() + @"\Decorator.mdf] FROM DISK = @path WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10", con);
                        cmd.Parameters.AddWithValue("@path", @"" + System.IO.Directory.GetCurrentDirectory() + @"\..\..\Database Backup\Decorator.bak");
                        if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                            MessageBox.Show("Decorator Database Restore Successfull.\nApplication will again restart.");
                        else
                            MessageBox.Show("Decorator Database Restore Unsuccessfull");
                        cmd = new SqlCommand(@"ALTER DATABASE [" + System.IO.Directory.GetCurrentDirectory() + @"\Decorator.mdf] SET Multi_User", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        progressBarUtility.Visible = true;
                        for (int i = 0; i <= 10000000; i++)
                            progressBarUtility.Value = i;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Cannot Restore Decorator Database as Backup File not found. Application will Restart.");
                    }
                }
            }
            
            Application.Restart();
        }

        private void frmUtilities_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
