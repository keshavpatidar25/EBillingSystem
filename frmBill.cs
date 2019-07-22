using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace E_Billing_System
{
    public partial class frmBill : Form
    {

        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMDI.Bill1 = null;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            txtBillDate.Text = DateTime.Now.ToLongDateString();
            txtBillAmt.Text = "";
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select max(Bill_No)+1 from Bill", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0].ToString() == "")
                txtBillNo.Text = "1";
            else
                txtBillNo.Text = dr[0].ToString();
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Select Prod_Type from Product_Type",con);
            dr = cmd1.ExecuteReader();
            while(dr.Read())
                cmbProdType.Items.Add(dr[0].ToString());
            dr.Close();
            con.Close();

        }

        private void tabPageNewBill_Click(object sender, EventArgs e)
        {

        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            Form TempMDI = this.MdiParent;
            this.Close();
            frmMDI.Bill1 = new frmBill();
            frmMDI.Bill1.MdiParent = TempMDI;
            frmMDI.Bill1.Show();
            frmMDI.Bill1.SetDesktopBounds(0, 0, 1194, 736);
            TempMDI = null;
        }

        private void radioCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDD.Checked)
            {
                lblDDBank.Enabled = true;
                lblDDDate.Enabled = true;
                lblDDNo.Enabled = true;
                lblDDBank.Visible = true;
                lblDDDate.Visible = true;
                lblDDNo.Visible = true;
                txtDDBank.Enabled = true;
                txtDDNo.Enabled = true;
                dateTimeDDDate.Enabled = true;
                txtDDBank.Visible = true;
                txtDDNo.Visible = true;
                dateTimeDDDate.Visible = true;
            }
            else
            {
                lblDDBank.Enabled = false;
                lblDDDate.Enabled = false;
                lblDDNo.Enabled = false;
                lblDDBank.Visible = false;
                lblDDDate.Visible = false;
                lblDDNo.Visible = false;
                txtDDBank.Enabled = false;
                txtDDNo.Enabled = false;
                dateTimeDDDate.Enabled = false;
                txtDDBank.Visible = false;
                txtDDNo.Visible = false;
                dateTimeDDDate.Visible = false;
            }
        }

        private void dataGridViewBillProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewBillProd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int qty;
            float price, discount, prodamt,totalamt=0.00f;
            if (e.RowIndex == -1)
                return;
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            foreach (DataGridViewRow row in dataGridViewBillProd.Rows)
            {
                if (row.Cells[0].Selected == true)
                {
                    if (e.ColumnIndex == 0)
                    {
                        (row.Cells[1] as DataGridViewComboBoxCell).Value = "";
                        (row.Cells[2] as DataGridViewTextBoxCell).Value = "";
                        (row.Cells[3] as DataGridViewTextBoxCell).Value = "";
                        (row.Cells[4] as DataGridViewTextBoxCell).Value = "";
                        (row.Cells[5] as DataGridViewTextBoxCell).Value = "";
                        (row.Cells[1] as DataGridViewComboBoxCell).Items.Clear();
                        cmd = new SqlCommand("Select Prod_Name from Product where Prod_Type_Id=(Select Prod_Type_Id from Product_Type where Prod_Type= @prodtype)", con);
                        cmd.Parameters.AddWithValue("@prodtype", (row.Cells[0] as DataGridViewComboBoxCell).Value.ToString());
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                            (row.Cells[1] as DataGridViewComboBoxCell).Items.Add(dr[0].ToString());
                        dr.Close();
                    }
             
                }
            }
            if (e.ColumnIndex == 1)
            {

                cmd = new SqlCommand("Select Price,Discount from Product where Prod_Name = @prodname and Prod_Type_Id=(Select Prod_Type_Id from Product_Type where Prod_Type= @prodtype)", con);
                cmd.Parameters.AddWithValue("@prodtype", dataGridViewBillProd[0, e.RowIndex].Value.ToString());
                cmd.Parameters.AddWithValue("@prodname", dataGridViewBillProd[1, e.RowIndex].Value.ToString());
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dataGridViewBillProd[3, e.RowIndex].Value = dr[0].ToString();
                    dataGridViewBillProd[4, e.RowIndex].Value = dr[1].ToString();
                }
            }
            try
            {
                if ((dataGridViewBillProd[2, e.RowIndex].Value.ToString().Trim() == "") || (dataGridViewBillProd[2, e.RowIndex].Value == null))
                    dataGridViewBillProd[2, e.RowIndex].Value = 0;
            }
            catch (NullReferenceException)
            {
                dataGridViewBillProd[2, e.RowIndex].Value = 0;
            }
            try
            {
                
                if (!int.TryParse(dataGridViewBillProd[2, e.RowIndex].Value.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out qty))
                {
                    qty = 0;
                    dataGridViewBillProd[2, e.RowIndex].Value = qty;
                }
                if(qty<0)
                {
                    qty = 0;
                    MessageBox.Show("Quantity cannot be negative");
                    dataGridViewBillProd[2, e.RowIndex].Value = qty;
                }
                else if (qty > 9999)
                {
                    qty = 0;
                    MessageBox.Show("Quantity limit is 9999");
                    dataGridViewBillProd[2, e.RowIndex].Value = qty;
                }
                if (!Single.TryParse(dataGridViewBillProd[3, e.RowIndex].Value.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out price))
                {
                    price = 0.00F;
                    dataGridViewBillProd[3, e.RowIndex].Value = price;
                }
                if (!Single.TryParse(dataGridViewBillProd[4, e.RowIndex].Value.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out discount))
                {
                    discount = 0.00f;
                    dataGridViewBillProd[4, e.RowIndex].Value = discount;
                }
            }
            catch (NullReferenceException)
            {
                qty = 0;
                price = 0.00F;
                discount = 0.00F;
                dataGridViewBillProd[2, e.RowIndex].Value = qty;
                dataGridViewBillProd[3, e.RowIndex].Value = price;
                dataGridViewBillProd[4, e.RowIndex].Value = discount;
            }
            prodamt = (price - (price * discount / 100)) * qty;
            dataGridViewBillProd[5, e.RowIndex].Value = prodamt;
            
            foreach (DataGridViewRow row1 in dataGridViewBillProd.Rows)
                totalamt+=Convert.ToSingle(row1.Cells[5].Value);
            txtBillAmt.Text = totalamt.ToString();
            con.Close();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            int count=Convert.ToInt32(dataGridViewBillProd.RowCount)-1,i,j,id;
            
            for(i=0;i<count;i++)
            {
                if ((dataGridViewBillProd[0, i].Value.ToString().Trim() == "") || (dataGridViewBillProd[1, i].Value.ToString().Trim() == ""))
                {
                    MessageBox.Show("Value not entered.");
                    return;
                }
            }

            for(i=0;i<count;i++)
            {
                for(j=0;j<count;j++)
                {
                    if (i!=j)
                    {
                        if ((dataGridViewBillProd[0,i].Value.Equals(dataGridViewBillProd[0,j].Value)) && (dataGridViewBillProd[1,i].Value.Equals(dataGridViewBillProd[1,j].Value)))
                        {
                            MessageBox.Show("Same Product Selected More Than Once.");
                            return;
                        }
                    }
                }
            }
            if (txtCustomer.Text == "" || txtCustomerAdd.Text == "" || txtBillAmt.Text == "")
            {
                MessageBox.Show("Some values not entered.");
                return;
            }
            if (radioDD.Checked)
            {
                if (txtDDBank.Text == "" || txtDDNo.Text == "")
                {
                    MessageBox.Show("Some values not entered.");
                    return;
                }
                if ((Convert.ToInt32(txtDDNo.Text) < 100000) || (Convert.ToInt32(txtDDNo.Text) > 999999))
                {
                    MessageBox.Show("DD Number should be of 6 digits.");
                    return;
                }
                if (dateTimeDDDate.Value.Date > Convert.ToDateTime(txtBillDate.Text).Date)
                {
                    MessageBox.Show("DD Date cannot be more than Bill Date");
                    return;
                }
            }
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd,cmd1,cmd2;
            SqlDataReader dr;
            if (radioDD.Checked)
            {
                cmd1 = new SqlCommand("Insert Into Bill Values(@billno,@billdate,@billamt,@cust,@custadd,1,@ddno,@dddate,@ddbank)", con);
                cmd1.Parameters.AddWithValue("@billno", Convert.ToInt32(txtBillNo.Text));
                cmd1.Parameters.AddWithValue("@billdate", Convert.ToDateTime(txtBillDate.Text).Date);
                cmd1.Parameters.AddWithValue("@billamt", Convert.ToSingle(txtBillAmt.Text));
                cmd1.Parameters.AddWithValue("@cust", txtCustomer.Text);
                cmd1.Parameters.AddWithValue("@custadd", txtCustomerAdd.Text);
                cmd1.Parameters.AddWithValue("@ddno", Convert.ToInt32(txtDDNo.Text));
                cmd1.Parameters.AddWithValue("@dddate", dateTimeDDDate.Value.Date);
                cmd1.Parameters.AddWithValue("@ddbank", txtDDBank.Text);
            }
            else
            {
                cmd1 = new SqlCommand("Insert Into Bill Values(@billno,@billdate,@billamt,@cust,@custadd,0,null,null,null)", con);
                cmd1.Parameters.AddWithValue("@billno", Convert.ToInt32(txtBillNo.Text));
                cmd1.Parameters.AddWithValue("@billdate", Convert.ToDateTime(txtBillDate.Text).Date);
                cmd1.Parameters.AddWithValue("@billamt", Convert.ToSingle(txtBillAmt.Text));
                cmd1.Parameters.AddWithValue("@cust", txtCustomer.Text);
                cmd1.Parameters.AddWithValue("@custadd", txtCustomerAdd.Text);
            }

            if (Convert.ToBoolean(cmd1.ExecuteNonQuery()))
            {
                for (i = 0; i < count; i++)
                {
                    try
                    {
                        cmd2 = new SqlCommand("Select Prod_Id from Product where Prod_Name = @prodname and Prod_Type_Id = (Select Prod_Type_Id from Product_Type where Prod_Type = @prodtype)", con);
                        cmd2.Parameters.AddWithValue("@prodname", dataGridViewBillProd[1, i].Value);
                        cmd2.Parameters.AddWithValue("@prodtype", dataGridViewBillProd[0, i].Value);
                        dr = cmd2.ExecuteReader();
                        dr.Read();
                        id = Convert.ToInt32(dr[0].ToString());
                        dr.Close();
                        cmd = new SqlCommand("Insert Into Bill_Product Values(@billno,@prodid,@qty,@price,@discount,@amt)", con);
                        cmd.Parameters.AddWithValue("@billno", Convert.ToInt32(txtBillNo.Text));
                        cmd.Parameters.AddWithValue("@prodid", id);
                        cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(dataGridViewBillProd[2, i].Value.ToString()));
                        cmd.Parameters.AddWithValue("@price", Convert.ToSingle(dataGridViewBillProd[3, i].Value.ToString()));
                        cmd.Parameters.AddWithValue("@discount", Convert.ToSingle(dataGridViewBillProd[4, i].Value.ToString()));
                        cmd.Parameters.AddWithValue("@amt", Convert.ToSingle(dataGridViewBillProd[5, i].Value.ToString()));
                        Convert.ToBoolean(cmd.ExecuteNonQuery());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Unexpected Error : "+ex.Message);
                        cmd2 = new SqlCommand("Delete from Bill where Bill_No=@billno",con);
                        cmd2.Parameters.AddWithValue("@billno", Convert.ToInt32(txtBillNo.Text));
                        cmd2.ExecuteNonQuery();
                        cmd2 = new SqlCommand("Delete from Bill_Product where Bill_No=@billno",con);
                        cmd2.Parameters.AddWithValue("@billno", Convert.ToInt32(txtBillNo.Text));
                        cmd2.ExecuteNonQuery();
                        return;
                    }
                }
                MessageBox.Show("Bill Saved Successfully");
                btnSaveBill.Enabled=false;
                btnPrintBill.Enabled = true;
                txtCustomer.ReadOnly = true;
                txtCustomerAdd.ReadOnly = true;
                txtDDBank.ReadOnly = true;
                txtDDNo.ReadOnly = true;
                dateTimeDDDate.Enabled = false;
                dataGridViewBillProd.Enabled = false;
                radioCash.Enabled = false;
                radioDD.Enabled = false;
            }
            else
                MessageBox.Show("Bill Could Not Be Saved");
            con.Close();
        }

        private void txtDDNo_TextChanged(object sender, EventArgs e)
        {
            int ddno;
            if (txtDDNo.Text != "")
            {
                if ((!Int32.TryParse(txtDDNo.Text, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out ddno))||(txtDDNo.Text.Length>6))
                {
                    txtDDNo.Text = txtDDNo.Text.Substring(0, txtDDNo.Text.Length - 1);
                    txtDDNo.Select(txtDDNo.Text.Length, 0);
                }
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            int rowcount = Convert.ToInt32(dataGridViewBillProd.RowCount)-1;
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            ws.Cells[1, 1] = "Company Name : ";
            ws.Cells[1,4]= "Company Address : ";
            ws.Cells[2,1] = "Company Number : ";
            if (frmMDI.login == 1)
            {
                ws.Cells[1, 2] = "ABC Furnitures";
                ws.Cells[1,5]="50, Business Tower";
                ws.Cells[2,2]="+91-8899889989";
            }
            else
            {
                ws.Cells[1, 2] = "ABC Decorators";
                ws.Cells[1,5]="90, Business Tower";
                ws.Cells[2,2]="+91-7788997788";
            }
            ws.Cells[3, 1] = "Bill No : ";
            ws.Cells[3,2]=txtBillNo.Text;
            ws.Cells[4, 1] = "Bill Date : ";
            ws.Cells[4, 2] = txtBillDate.Text;
            ws.Cells[5, 1] = "Customer Name : ";
            ws.Cells[5, 2] = txtCustomer.Text;
            ws.Cells[6, 1] = "Customer Address : ";
            ws.Cells[6, 2] = txtCustomerAdd.Text;
            ws.Cells[7, 1] = "Total Amt : ";
            ws.Cells[7, 2] = txtBillAmt.Text;
            if (radioCash.Checked)
            {
                ws.Cells[8, 1] = "Payment Mode : ";
                ws.Cells[8, 2] = "Cash";
            }
            else
            {
                ws.Cells[8, 1] = "Payment Mode : ";
                ws.Cells[8, 2] = "DD";
                ws.Cells[8, 4] = "DD Number : ";
                ws.Cells[8, 5] = txtDDNo.Text;
                ws.Cells[9, 1] = "DD Date : ";
                ws.Cells[9, 2] = dateTimeDDDate.Value.ToLongDateString();
                ws.Cells[9, 4] = "DD Bank : ";
                ws.Cells[9, 5] = txtDDBank.Text;
            }

            ws.Cells[11, 1] = "Product Type";
            ws.Cells[11, 2] = "Product Name";
            ws.Cells[11, 3] = "Qty";
            ws.Cells[11, 4] = "Price";
            ws.Cells[11, 5] = "Discount %";
            ws.Cells[11, 6] = "Product Amt";

            for (int i = 0, j=12; i < rowcount; i++,j++) 
            {
                for(int z=1;z<=6;z++)
                    ws.Cells[j,z]=(dataGridViewBillProd[z-1,i].Value);
                
            }
            try
            {
                ws.get_Range("A1", "F30").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Cells.Columns.AutoFit();
                ws.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                ws.PrintOut(Type.Missing, Type.Missing, 1, false, Type.Missing, false, Type.Missing, Type.Missing);
                wb.Close(false, Type.Missing, Type.Missing);
                xla.Quit();
            }
            catch (Exception)
            {
                wb.Close(false, Type.Missing, Type.Missing);
                xla.Quit();
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewBill1_Click(object sender, EventArgs e)
        {
            if (txtBillNo1.Text == "")
            {
                MessageBox.Show("Bill Number Not Entered");
                return;
            }
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Bill where Bill_No = @billno", con);
            cmd.Parameters.AddWithValue("@billno", txtBillNo1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int count = Convert.ToInt32(dr[0].ToString());
            if(count==0)
            {
                MessageBox.Show("Invalid Bill Number");
                return;
            }
            dr.Close();
            cmd = new SqlCommand("Select * From Bill where Bill_No = @billno",con);
            cmd.Parameters.AddWithValue("@billno", txtBillNo1.Text);
            dr = cmd.ExecuteReader();
            dr.Read();
            txtBillDate1.Text = Convert.ToDateTime(dr[1]).ToLongDateString();
            txtBillAmt1.Text=dr[2].ToString();
            txtCustomer1.Text=dr[3].ToString();
            txtCustomerAdd1.Text=dr[4].ToString();
            if (Convert.ToInt32(dr[5].ToString()) == 0)
            {
                radioCash1.Checked = true;
                txtDDBank1.Visible = false;
                txtDDNo1.Visible = false;
                txtDDDate1.Visible = false;
                txtDDBank1.Enabled = false;
                txtDDNo1.Enabled = false;
                txtDDDate1.Enabled = false;
                lblDDBank1.Visible = false;
                lblDDNo1.Visible = false;
                lblDDDate1.Visible = false;
            }
            else
            {
                radioDD1.Checked = true;
                txtDDBank1.Visible = true;
                txtDDNo1.Visible = true;
                txtDDDate1.Visible = true;
                txtDDBank1.Enabled = true;
                txtDDNo1.Enabled = true;
                txtDDDate1.Enabled = true;
                lblDDDate1.Visible = true;
                lblDDNo1.Visible = true;
                lblDDBank1.Visible = true;
                lblDDDate1.Enabled = true;
                lblDDNo1.Enabled = true;
                lblDDBank1.Enabled = true;
                txtDDNo1.Text = dr[6].ToString();
                txtDDDate1.Text = Convert.ToDateTime(dr[7]).ToLongDateString();
                txtDDBank1.Text = dr[8].ToString();
            }
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Select Prod_Type 'Product Type', Prod_Name 'Product', Qty, PB.Price 'Price/Unit', PB.Discount 'Discount%',Amt 'Amount' From Bill_Product PB, Product P, Product_Type PT where Bill_No=@billno and PB.Prod_Id = P.Prod_Id and P.Prod_Type_Id=PT.Prod_Type_Id", con);
            cmd1.Parameters.AddWithValue("@billno", txtBillNo1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewBillProd1.DataSource = ds.Tables[0];
            dataGridViewBillProd1.Columns[0].Width = 190;
            dataGridViewBillProd1.Columns[1].Width = 280;
            dataGridViewBillProd1.Columns[2].Width = 100;
            dataGridViewBillProd1.Columns[3].Width = 130;
            dataGridViewBillProd1.Columns[4].Width = 130;
            dataGridViewBillProd1.Columns[5].Width = 140;
            btnPrintBill1.Enabled = true;
            con.Close();
        }

        private void txtBillNo1_TextChanged(object sender, EventArgs e)
        {
            int billno;
            if (txtBillNo1.Text != "")
            {
                if ((!Int32.TryParse(txtBillNo1.Text, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out billno)) || (txtBillNo1.Text.Length > 7))
                {
                    txtBillNo1.Text = txtBillNo1.Text.Substring(0, txtBillNo1.Text.Length - 1);
                    txtBillNo1.Select(txtBillNo1.Text.Length, 0);
                }
            }
            btnPrintBill1.Enabled = false;
        }

        private void btnPrintBill1_Click(object sender, EventArgs e)
        {
            int rowcount = Convert.ToInt32(dataGridViewBillProd1.RowCount);
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            ws.Cells[1, 1] = "Company Name : ";
            ws.Cells[1, 4] = "Company Address : ";
            ws.Cells[2, 1] = "Company Number : ";
            if (frmMDI.login == 1)
            {
                ws.Cells[1, 2] = "ABC Furnitures";
                ws.Cells[1, 5] = "50, Business Tower";
                ws.Cells[2, 2] = "+91-8899889989";
            }
            else
            {
                ws.Cells[1, 2] = "ABC Decorators";
                ws.Cells[1, 5] = "90, Business Tower";
                ws.Cells[2, 2] = "+91-7788997788";
            }
            ws.Cells[3, 1] = "Bill No : ";
            ws.Cells[3, 2] = txtBillNo1.Text;
            ws.Cells[4, 1] = "Bill Date : ";
            ws.Cells[4, 2] = txtBillDate1.Text;
            ws.Cells[5, 1] = "Customer Name : ";
            ws.Cells[5, 2] = txtCustomer1.Text;
            ws.Cells[6, 1] = "Customer Address : ";
            ws.Cells[6, 2] = txtCustomerAdd1.Text;
            ws.Cells[7, 1] = "Total Amt : ";
            ws.Cells[7, 2] = txtBillAmt1.Text;
            if (radioCash1.Checked)
            {
                ws.Cells[8, 1] = "Payment Mode : ";
                ws.Cells[8, 2] = "Cash";
            }
            else
            {
                ws.Cells[8, 1] = "Payment Mode : ";
                ws.Cells[8, 2] = "DD";
                ws.Cells[8, 4] = "DD Number : ";
                ws.Cells[8, 5] = txtDDNo1.Text;
                ws.Cells[9, 1] = "DD Date : ";
                ws.Cells[9, 2] = txtDDDate1.Text;
                ws.Cells[9, 4] = "DD Bank : ";
                ws.Cells[9, 5] = txtDDBank1.Text;
            }

            ws.Cells[11, 1] = "Product Type";
            ws.Cells[11, 2] = "Product Name";
            ws.Cells[11, 3] = "Qty";
            ws.Cells[11, 4] = "Price";
            ws.Cells[11, 5] = "Discount %";
            ws.Cells[11, 6] = "Product Amt";

            for (int i = 0, j = 12; i < rowcount; i++, j++)
            {
                for (int z = 1; z <= 6; z++)
                    ws.Cells[j, z] = (dataGridViewBillProd1[z - 1, i].Value);

            }
            try
            {
                ws.get_Range("A1", "F30").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Cells.Columns.AutoFit();
                ws.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                ws.PrintOut(Type.Missing, Type.Missing, 1, false, Type.Missing, false, Type.Missing, Type.Missing);
                wb.Close(false, Type.Missing, Type.Missing);
                xla.Quit();
            }
            catch (Exception)
            {
                wb.Close(false, Type.Missing, Type.Missing);
                xla.Quit();
            }
        }
    }
}
