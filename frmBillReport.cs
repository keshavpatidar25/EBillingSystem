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
    public partial class frmBillReport : Form
    {
        public frmBillReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int i = 1;
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True";
            con.Open();
            if (dateTimeBillFrom.Value.Date > dateTimeBillTill.Value.Date)
            {
                MessageBox.Show("Bill From Date cannot be greater than Bill To Date.");
                return;
            }
            SqlCommand cmd = new SqlCommand("Select count(*) From Bill where Bill_Date Between @billfrom and @billtill", con);
            cmd.Parameters.AddWithValue("@billfrom", dateTimeBillFrom.Value.Date);
            cmd.Parameters.AddWithValue("@billtill", dateTimeBillTill.Value.Date);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (Convert.ToInt32(dr[0].ToString()) == 0)
            {
                MessageBox.Show("No Bills Found in this Range.");
                return;
            }
            dr.Close();
            cmd = new SqlCommand("Select * From Bill where Bill_Date Between @billfrom and @billtill", con);
            SqlCommand cmd1;
            cmd.Parameters.AddWithValue("@billfrom", dateTimeBillFrom.Value.Date);
            cmd.Parameters.AddWithValue("@billtill", dateTimeBillTill.Value.Date);
            dr = cmd.ExecuteReader();
            SqlDataAdapter da;
            DataSet ds;
            DataRow dRow1;
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;
            
            
            while (dr.Read())
            {
                ws.Cells[i, 1] = "Company Name : ";
                ws.Cells[(i++), 4] = "Company Address : ";
                ws.Cells[i, 1] = "Company Number : ";
                if (frmMDI.login == 1)
                {
                    ws.Cells[(i-1), 2] = "ABC Furnitures";
                    ws.Cells[(i-1), 5] = "50, Business Tower";
                    ws.Cells[i, 2] = "+91-8899889989";
                }
                else
                {
                    ws.Cells[(i-1), 2] = "ABC Decorators";
                    ws.Cells[(i-1), 5] = "90, Business Tower";
                    ws.Cells[i, 2] = "+91-7788997788";
                }
                i += 3;
                ws.Cells[i, 1] = "Bill No : ";
                ws.Cells[(i++), 2] = dr[0].ToString().Trim();
                ws.Cells[i, 1] = "Bill Date : ";
                ws.Cells[(i++), 2] = Convert.ToDateTime(dr[1]).ToLongDateString().Trim();
                ws.Cells[i, 1] = "Customer Name : ";
                ws.Cells[(i++), 2] = dr[3].ToString().Trim();
                ws.Cells[i, 1] = "Customer Address : ";
                ws.Cells[(i++), 2] = dr[4].ToString().Trim();
                ws.Cells[i, 1] = "Total Amt : ";
                ws.Cells[(i++), 2] = dr[2].ToString().Trim();
                if (Convert.ToInt32(dr[5].ToString()) == 0)
                {
                    ws.Cells[i, 1] = "Payment Mode : ";
                    ws.Cells[(i++), 2] = "Cash";
                }
                else
                {
                    ws.Cells[i, 1] = "Payment Mode : ";
                    ws.Cells[i, 2] = "DD";
                    ws.Cells[i, 4] = "DD Number : ";
                    ws.Cells[(i++), 5] = dr[6].ToString().Trim();
                    ws.Cells[i, 1] = "DD Date : ";
                    ws.Cells[i, 2] = Convert.ToDateTime(dr[7]).ToLongDateString().Trim();
                    ws.Cells[i, 4] = "DD Bank : ";
                    ws.Cells[(i++), 5] = dr[8].ToString().Trim();
                }
                i++;
                ws.Cells[i, 1] = "Product Type";
                ws.Cells[i, 2] = "Product Name";
                ws.Cells[i, 3] = "Qty";
                ws.Cells[i, 4] = "Price";
                ws.Cells[i, 5] = "Discount %";
                ws.Cells[(i++), 6] = "Product Amt";

                cmd1 = new SqlCommand("Select Prod_Type 'Product Type', Prod_Name 'Product', Qty, PB.Price 'Price/Unit', PB.Discount 'Discount%',Amt 'Amount' From Bill_Product PB, Product P, Product_Type PT where Bill_No=@billno and PB.Prod_Id = P.Prod_Id and P.Prod_Type_Id=PT.Prod_Type_Id", con);
                cmd1.Parameters.AddWithValue("@billno", Convert.ToInt32(dr[0].ToString()));
                da = new SqlDataAdapter(cmd1);
                ds = new DataSet();
                da.Fill(ds);
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++, i++)
                {
                    dRow1 = ds.Tables[0].Rows[j];
                    ws.Cells[i, 1] = dRow1[0].ToString().Trim();
                    ws.Cells[i, 2] = dRow1[1].ToString().Trim();
                    ws.Cells[i, 3] = dRow1[2].ToString().Trim();
                    ws.Cells[i, 4] = dRow1[3].ToString().Trim();
                    ws.Cells[i, 5] = dRow1[4].ToString().Trim();
                    ws.Cells[i, 6] = dRow1[5].ToString().Trim();
                }
                i += 3;
                ws.get_Range("A" + i.ToString(), "G" + i.ToString()).PageBreak = 1;
            }
            try
            {
                ws.get_Range("A1", "F10000").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Cells.Columns.AutoFit();
                ws.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                ws.PageSetup.CenterFooter = "&P/&N";
                xla.Visible = true;
            }
            catch (Exception)
            {
                wb.Close(false, Type.Missing, Type.Missing);
                xla.Quit();
            }
            dr.Close();
            con.Close();
        }
    }
}
