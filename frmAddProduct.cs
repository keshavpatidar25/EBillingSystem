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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProdType.Text = "";
        }

        private void btnAddProdType_Click(object sender, EventArgs e)
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
            SqlCommand cmd0 = new SqlCommand("Select count(*) from Product_Type where Prod_Type = @prodtype",con);
            cmd0.Parameters.AddWithValue("@prodtype",txtProdType.Text);
            SqlDataReader dr0 = cmd0.ExecuteReader();
            dr0.Read();
            if((Convert.ToInt32(dr0[0].ToString()))!=0)
            {
                MessageBox.Show("Product Type already exists.");
                return;
            }
            dr0.Close();
            SqlCommand cmd = new SqlCommand("Select max(Prod_Type_Id) from Product_Type", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int c = (Convert.ToInt32(dr[0].ToString())) + 1;
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Insert into Product_Type Values(@id,@name)", con);
            cmd1.Parameters.AddWithValue("@id", c);
            cmd1.Parameters.AddWithValue("@name", txtProdType.Text);
            if(Convert.ToBoolean(cmd1.ExecuteNonQuery()))
                MessageBox.Show("Product Type Inserted Successfully.");
            else
                MessageBox.Show("Product Type Cannot be Inserted.");
            tabControlEnterProdType();
        }

        private void frmAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMDI.Product1.Enabled = true;
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabAddNewProd_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAddProduct_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void tabControlEnterProdType()
        {
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
                cmbProdType1.Items.Add(dr[0].ToString());
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Select max(Prod_Id)+1 from Product", con);
            dr = cmd1.ExecuteReader();
            dr.Read();
            txtProdId1.Text = dr[0].ToString();
            dr.Close();
            cmbProdType1.SelectedIndex = 0;
            txtPrice1.Text = "";
            txtProd1.Text="";
            txtDiscount1.Text="";
            con.Close();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            int id,pTypeId;
            float price, discount;
            if ((txtProdId1.Text=="")||(txtProd1.Text=="")||(txtPrice1.Text=="")||(txtDiscount1.Text==""))
            {
                MessageBox.Show("Insufficient Data.");
                return;
            }
            if ((!Single.TryParse(txtPrice1.Text, System.Globalization.NumberStyles.Any,System.Globalization.NumberFormatInfo.InvariantInfo, out price))
                || (!Single.TryParse(txtDiscount1.Text, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out discount)))
            {

                MessageBox.Show("Invalid Values Entered");
                return;
            }
            if(!((price>0) && (price<100000)))
            {
                MessageBox.Show("Error : Price should be greater than 0 and less than 100000");
                return;
            }
            if(!((discount>=0) && (discount<=99)))
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
            SqlCommand cmd1 = new SqlCommand("Insert into Product values (@id,@name,@type, @price, @discount)",con);
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@name", txtProd1.Text);
            cmd1.Parameters.AddWithValue("@type", pTypeId);
            cmd1.Parameters.AddWithValue("@price", price);
            cmd1.Parameters.AddWithValue("@discount", discount);
            if (Convert.ToBoolean(cmd1.ExecuteNonQuery()))
                MessageBox.Show("Product Inserted Successfully.");
            else
                MessageBox.Show("Product Cannot be Inserted.");
            tabControlEnterProdType();
            con.Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            tabControlEnterProdType();
        }

        private void tabControlAddProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabAddProdType_Click(object sender, EventArgs e)
        {

        }

        private void txtProdType_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProdType_Click(object sender, EventArgs e)
        {

        }

        private void tablePanelProduct2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDiscount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtProd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbProdType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProdId1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void txtProdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProd1_Click(object sender, EventArgs e)
        {

        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProdType1_Click(object sender, EventArgs e)
        {

        }

        private void lblProdId_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

    }
}
