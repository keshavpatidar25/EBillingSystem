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
    public partial class frmEditProduct : Form
    {
        string selectedProdType;
        public frmEditProduct(string s)
        {
            InitializeComponent();
            btnEditProd.Enabled = false;
            selectedProdType = s;
        }

        public frmEditProduct(string id, string prodtype, string prod, string price, string discount)
        {
            InitializeComponent();
            txtProdId1.Text = id;
            selectedProdType = prodtype;
            txtProd1.Text = prod;
            txtPrice1.Text = price;
            txtDiscount1.Text = discount;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProdType.Text = "";
            cmbProdType.SelectedIndex = 0;
        }

        private void frmEditProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMDI.Product1.Enabled = true;
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            cmbProdTypeDataEnter();
            
        }

        private void cmbProdTypeDataEnter()
        {
            cmbProdType.Items.Clear();
            cmbProdType1.Items.Clear();
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Prod_Type from Product_Type order by Prod_Type", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProdType.Items.Add(dr[0].ToString());
                cmbProdType1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cmbProdType.SelectedIndex = 0;
            cmbProdType1.SelectedIndex = 0;
            for (int i = 0; i < cmbProdType1.Items.Count; i++)
            {
                if (selectedProdType.Trim().Equals(cmbProdType1.Items[i].ToString().Trim()))
                    cmbProdType1.SelectedIndex = i;
            }
            con.Close();
        }

        private void btnEditProdType_Click(object sender, EventArgs e)
        {
            if (txtProdType.Text == "")
            {
                MessageBox.Show("Product Type Not Entered");
                return;
            }
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd0 = new SqlCommand("Select count(*) from Product_Type where Prod_Type = @prodtype", con);
            cmd0.Parameters.AddWithValue("@prodtype", txtProdType.Text);
            SqlDataReader dr0 = cmd0.ExecuteReader();
            dr0.Read();
            if ((Convert.ToInt32(dr0[0].ToString())) != 0)
            {
                MessageBox.Show("Product Type already exists.");
                return;
            }
            dr0.Close();
            SqlCommand cmd1 = new SqlCommand("Update Product_Type set Prod_Type=@name where Prod_Type=@oldname", con);
            cmd1.Parameters.AddWithValue("@oldname", cmbProdType.Text);
            cmd1.Parameters.AddWithValue("@name", txtProdType.Text);
            if (Convert.ToBoolean(cmd1.ExecuteNonQuery()))
            {
                MessageBox.Show("Product Type Updated Successfully.");
                if (selectedProdType.Trim().Equals(cmbProdType.Text.Trim()))
                    selectedProdType = txtProdType.Text;
            }
            else
                MessageBox.Show("Product Type Cannot be Updated.");
            cmbProdTypeDataEnter();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            int id, pTypeId;
            float price, discount;
            if ((txtProdId1.Text == "") || (txtProd1.Text == "") || (txtPrice1.Text == "") || (txtDiscount1.Text == ""))
            {
                MessageBox.Show("Insufficient Data.");
                return;
            }
            if ((!Single.TryParse(txtPrice1.Text, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out price))
                || (!Single.TryParse(txtDiscount1.Text, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out discount)))
            {

                MessageBox.Show("Invalid Values Entered");
                return;
            }
            if (!((price > 0) && (price < 100000)))
            {
                MessageBox.Show("Error : Price should be greater than 0 and less than 100000");
                return;
            }
            if (!((discount >= 0) && (discount <= 99)))
            {
                MessageBox.Show("Error : Discount should be between 0 and 99");
                return;
            }
            id = Convert.ToInt32(txtProdId1.Text);
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Prod_Type_Id from Product_Type where Prod_Type=@prodtype", con);
            cmd.Parameters.AddWithValue("@prodtype", cmbProdType1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            pTypeId = Convert.ToInt32(dr[0].ToString());
            dr.Close();
            SqlCommand cmd0 = new SqlCommand("Select count(*) from Product where Prod_Type_Id=@pid and Prod_Name=@name", con);
            cmd0.Parameters.AddWithValue("@name", txtProd1.Text);
            cmd0.Parameters.AddWithValue("@pid", pTypeId);
            dr = cmd0.ExecuteReader();
            dr.Read();
            if ((Convert.ToInt32(dr[0].ToString()) != 0)&&(!selectedProdType.Trim().Equals(cmbProdType1.Text.Trim())))
            {
                MessageBox.Show("Same Product already exist in this product type.");
                return;
            }
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Update Product set Prod_Name = @name, Prod_Type_Id = @prodId, Price = @price, Discount = @discount where Prod_Id = @id", con);
            cmd1.Parameters.AddWithValue("@name", txtProd1.Text);
            cmd1.Parameters.AddWithValue("@prodId", pTypeId);
            cmd1.Parameters.AddWithValue("@price", price);
            cmd1.Parameters.AddWithValue("@discount", discount);
            cmd1.Parameters.AddWithValue("@id", id);
            if (Convert.ToBoolean(cmd1.ExecuteNonQuery()))
            {
                MessageBox.Show("Product Updated Successfully.");
                selectedProdType = cmbProdType1.Text;
            }
            else
                MessageBox.Show("Product Cannot be Updated.");

        }

        private void txtPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProd1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
