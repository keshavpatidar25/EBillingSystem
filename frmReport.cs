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
using Microsoft.Office.Interop.Excel;

namespace E_Billing_System
{
    public partial class frmReport : Form
    {
        
        public static frmProdReport ProdReport1;

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMDI.Report1 = null;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;
            cmd = new SqlCommand("Select Prod_Id, Prod_Name, P.Prod_Type_Id, Prod_Type, Price, Discount From Product P, Product_Type PT Where P.Prod_Type_Id=PT.Prod_Type_Id order by Prod_Id,Prod_Name,P.Prod_Type_Id", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            ds.WriteXml("Product1.xml");
            if (ProdReport1 != null)
                ProdReport1.Close();
            ProdReport1 = new frmProdReport();
            ProdReport1.MdiParent = this.MdiParent;
            ProdReport1.Show();
            ProdReport1.SetDesktopBounds(150, 100, 1539, 801);
            con.Close();
        }

        private void tableLayoutPanelReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBillListBillNo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            if (frmMDI.login == 1)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Furniture.mdf;Integrated Security=True;User Instance=True";
            else if (frmMDI.login == 2)
                con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Decorator.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            SqlCommand cmd;
            string input;
            int id;
            input = Interaction.InputBox("Enter the Bill Number", "Bill Number", "", 500, 400);
            if ((!Int32.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out id)))
            {
                MessageBox.Show("Invalid Bill Number");
                return;
            }
            cmd = new SqlCommand("Select count(*) From Bill where Bill_No=@billno", con);
            cmd.Parameters.AddWithValue("@billno", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (Convert.ToInt32(dr[0].ToString()) == 0)
            {
                MessageBox.Show("Invalid Bill Number");
                return;
            }
            dr.Close();
            cmd = new SqlCommand("Select * From Bill where Bill_No = @billno", con);
            cmd.Parameters.AddWithValue("@billno", id);
            dr = cmd.ExecuteReader();
            dr.Read();
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
            ws.Cells[3, 2] = dr[0].ToString();
            ws.Cells[4, 1] = "Bill Date : ";
            ws.Cells[4, 2] = Convert.ToDateTime(dr[1]).ToLongDateString();
            ws.Cells[5, 1] = "Customer Name : ";
            ws.Cells[5, 2] = dr[3].ToString();
            ws.Cells[6, 1] = "Customer Address : ";
            ws.Cells[6, 2] = dr[4].ToString();
            ws.Cells[7, 1] = "Total Amt : ";
            ws.Cells[7, 2] = dr[2].ToString();
            if (Convert.ToInt32(dr[5].ToString())==0)
            {
                ws.Cells[8, 1] = "Payment Mode : ";
                ws.Cells[8, 2] = "Cash";
            }
            else
            {
                ws.Cells[8, 1] = "Payment Mode : ";
                ws.Cells[8, 2] = "DD";
                ws.Cells[8, 4] = "DD Number : ";
                ws.Cells[8, 5] = dr[6].ToString();
                ws.Cells[9, 1] = "DD Date : ";
                ws.Cells[9, 2] = Convert.ToDateTime(dr[7]).ToLongDateString();
                ws.Cells[9, 4] = "DD Bank : ";
                ws.Cells[9, 5] = dr[8].ToString();
            }

            ws.Cells[11, 1] = "Product Type";
            ws.Cells[11, 2] = "Product Name";
            ws.Cells[11, 3] = "Qty";
            ws.Cells[11, 4] = "Price";
            ws.Cells[11, 5] = "Discount %";
            ws.Cells[11, 6] = "Product Amt";

            dr.Close();
            cmd = new SqlCommand("Select Prod_Type 'Product Type', Prod_Name 'Product', Qty, PB.Price 'Price/Unit', PB.Discount 'Discount%',Amt 'Amount' From Bill_Product PB, Product P, Product_Type PT where Bill_No=@billno and PB.Prod_Id = P.Prod_Id and P.Prod_Type_Id=PT.Prod_Type_Id", con);
            cmd.Parameters.AddWithValue("@billno", id);
            dr = cmd.ExecuteReader();
            int i=12;
            while (dr.Read())
            {
                ws.Cells[i, 1] = dr[0].ToString();
                ws.Cells[i, 2] = dr[1].ToString();
                ws.Cells[i, 3] = dr[2].ToString();
                ws.Cells[i, 4] = dr[3].ToString();
                ws.Cells[i, 5] = dr[4].ToString();
                ws.Cells[i, 6] = dr[5].ToString();
                i++;
            }
            dr.Close();
            try
            {
                ws.get_Range("A1", "F30").Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                ws.Cells.Columns.AutoFit();
                ws.PageSetup.Orientation = XlPageOrientation.xlLandscape;
                xla.Visible = true;
            }
            catch (Exception)
            {
                wb.Close(false, Type.Missing, Type.Missing);
                xla.Quit();
            }
            con.Close();
        }

        private void btnBillListDate_Click(object sender, EventArgs e)
        {
            frmBillReport BillReport1 = new frmBillReport();
            BillReport1.ShowDialog();
        }
    }
}
