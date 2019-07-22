using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace E_Billing_System
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void cmbProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProd.Items.Clear();
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Prod_Id,Prod_Name,P.Prod_Type_Id,Price,Discount,Prod_Type from Product P,Product_Type PT where P.Prod_Type_Id = PT.Prod_Type_Id and Prod_Type = @ProdType  order by Prod_Name", con);
            cmd.Parameters.AddWithValue("@ProdType", cmbProdType.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                lstProd.Items.Add(dr["Prod_Name"]);
            if(lstProd.Items.Count!=0)
                lstProd.SelectedIndex = 0;
            con.Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            cmbProdType.Items.Clear();
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login ==2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Prod_Type from Product_Type order by Prod_Type", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
                cmbProdType.Items.Add(dr[0].ToString());
            cmbProdType.SelectedIndex = 0;
            lstProd.SelectedIndex = 0;
            con.Close();
        }

        private void frmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMDI.Product1 = null;
        }

        private void lstProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProdType.Text = cmbProdType.Text;
            txtProd.Text = lstProd.Text;
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Prod_Id,Prod_Name,P.Prod_Type_Id,Price,Discount,Prod_Type from Product P,Product_Type PT where P.Prod_Type_Id = PT.Prod_Type_Id and Prod_Type = @ProdType and Prod_Name = @ProdName  order by Prod_Name", con);
            cmd.Parameters.AddWithValue("@ProdType", cmbProdType.Text);
            cmd.Parameters.AddWithValue("@ProdName", lstProd.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtProdId.Text = dr["Prod_Id"].ToString();
            txtPrice.Text = dr["Price"].ToString();
            txtDiscount.Text = dr["Discount"].ToString();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct AddProduct = new frmAddProduct();
            AddProduct.MdiParent = this.MdiParent;
            AddProduct.Show();
            this.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProduct EditProduct;
            if((txtProdId.Text=="")||(lstProd.Items.Count==0))
                EditProduct = new frmEditProduct(cmbProdType.Text);
            else
                EditProduct = new frmEditProduct(txtProdId.Text,txtProdType.Text, txtProd.Text, txtPrice.Text,txtDiscount.Text);
            EditProduct.MdiParent = this.MdiParent;
            EditProduct.Show();
            this.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string choice;
            choice = Interaction.InputBox("Press 1 to remove the selected Product.\nPress 2 to remove selected Product Type.\nElse to cancel.\nWarning : Removing Product Type will remove all its Products.", "Remove Product", "", 500, 400);
            if (choice.Equals("1"))
            {
                if (lstProd.Items.Count == 0)
                {
                    MessageBox.Show("Please Select Product to delete.");
                    return;
                }
                try
                {
                    SqlConnection con = new SqlConnection();
                    if (frmMDI.login == 1)
                        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
                    else if (frmMDI.login == 2)
                        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Product where Prod_Id=@id", con);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProdId.Text));
                    if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                        MessageBox.Show("Product Deleted Successfully.");
                    else
                        MessageBox.Show("Product Cannot be Deleted.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot Delete this Product as this Product is associated with any of previous bills");
                }
                this.OnLoad(new EventArgs());
            }
            else if (choice.Equals("2"))
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    if (frmMDI.login == 1)
                        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
                    else if (frmMDI.login == 2)
                        con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Product_Type where Prod_Type=@pType", con);
                    cmd.Parameters.AddWithValue("@pType", cmbProdType.Text);
                    if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                        MessageBox.Show("Product Type Deleted Successfully.");
                    else
                        MessageBox.Show("Product Type Cannot be Deleted.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot Delete this Product Type as this Product Type is associated with any of previous bills");
                }
                this.OnLoad(new EventArgs());
            }
        }
    }
}
