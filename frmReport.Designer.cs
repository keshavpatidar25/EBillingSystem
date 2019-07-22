namespace E_Billing_System
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.btnProductList = new System.Windows.Forms.Button();
            this.tableLayoutPanelReport = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBillListDate = new System.Windows.Forms.Button();
            this.btnBillListBillNo = new System.Windows.Forms.Button();
            this.tableLayoutPanelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductList
            // 
            this.btnProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.Location = new System.Drawing.Point(3, 3);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(309, 79);
            this.btnProductList.TabIndex = 0;
            this.btnProductList.Text = "&Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // tableLayoutPanelReport
            // 
            this.tableLayoutPanelReport.ColumnCount = 2;
            this.tableLayoutPanelReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReport.Controls.Add(this.btnClose, 0, 1);
            this.tableLayoutPanelReport.Controls.Add(this.btnProductList, 0, 0);
            this.tableLayoutPanelReport.Controls.Add(this.btnBillListDate, 1, 0);
            this.tableLayoutPanelReport.Controls.Add(this.btnBillListBillNo, 0, 1);
            this.tableLayoutPanelReport.Location = new System.Drawing.Point(56, 35);
            this.tableLayoutPanelReport.Name = "tableLayoutPanelReport";
            this.tableLayoutPanelReport.RowCount = 2;
            this.tableLayoutPanelReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReport.Size = new System.Drawing.Size(631, 171);
            this.tableLayoutPanelReport.TabIndex = 1;
            this.tableLayoutPanelReport.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelReport_Paint);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(318, 88);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(310, 80);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBillListDate
            // 
            this.btnBillListDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBillListDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillListDate.Location = new System.Drawing.Point(318, 3);
            this.btnBillListDate.Name = "btnBillListDate";
            this.btnBillListDate.Size = new System.Drawing.Size(310, 79);
            this.btnBillListDate.TabIndex = 3;
            this.btnBillListDate.Text = "Bill &List  Using Date";
            this.btnBillListDate.UseVisualStyleBackColor = true;
            this.btnBillListDate.Click += new System.EventHandler(this.btnBillListDate_Click);
            // 
            // btnBillListBillNo
            // 
            this.btnBillListBillNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBillListBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillListBillNo.Location = new System.Drawing.Point(3, 88);
            this.btnBillListBillNo.Name = "btnBillListBillNo";
            this.btnBillListBillNo.Size = new System.Drawing.Size(309, 80);
            this.btnBillListBillNo.TabIndex = 4;
            this.btnBillListBillNo.Text = "&Bill List  Using Bill Number";
            this.btnBillListBillNo.UseVisualStyleBackColor = true;
            this.btnBillListBillNo.Click += new System.EventHandler(this.btnBillListBillNo_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(743, 258);
            this.Controls.Add(this.tableLayoutPanelReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReport_FormClosed);
            this.tableLayoutPanelReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReport;
        private System.Windows.Forms.Button btnBillListBillNo;
        private System.Windows.Forms.Button btnBillListDate;
        private System.Windows.Forms.Button btnClose;
    }
}