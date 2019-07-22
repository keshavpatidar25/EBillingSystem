namespace E_Billing_System
{
    partial class frmBillReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillReport));
            this.tableLayoutPanelBillReport = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimeBillTill = new System.Windows.Forms.DateTimePicker();
            this.lblBillFrom = new System.Windows.Forms.Label();
            this.lblBillTill = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dateTimeBillFrom = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelBillReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBillReport
            // 
            this.tableLayoutPanelBillReport.ColumnCount = 2;
            this.tableLayoutPanelBillReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBillReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBillReport.Controls.Add(this.btnCancel, 1, 2);
            this.tableLayoutPanelBillReport.Controls.Add(this.dateTimeBillTill, 1, 1);
            this.tableLayoutPanelBillReport.Controls.Add(this.lblBillFrom, 0, 0);
            this.tableLayoutPanelBillReport.Controls.Add(this.lblBillTill, 0, 1);
            this.tableLayoutPanelBillReport.Controls.Add(this.btnGenerateReport, 0, 2);
            this.tableLayoutPanelBillReport.Controls.Add(this.dateTimeBillFrom, 1, 0);
            this.tableLayoutPanelBillReport.Location = new System.Drawing.Point(87, 45);
            this.tableLayoutPanelBillReport.Name = "tableLayoutPanelBillReport";
            this.tableLayoutPanelBillReport.RowCount = 3;
            this.tableLayoutPanelBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelBillReport.Size = new System.Drawing.Size(520, 206);
            this.tableLayoutPanelBillReport.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(263, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(254, 64);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimeBillTill
            // 
            this.dateTimeBillTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBillTill.Location = new System.Drawing.Point(263, 71);
            this.dateTimeBillTill.Name = "dateTimeBillTill";
            this.dateTimeBillTill.Size = new System.Drawing.Size(254, 34);
            this.dateTimeBillTill.TabIndex = 4;
            // 
            // lblBillFrom
            // 
            this.lblBillFrom.AutoSize = true;
            this.lblBillFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillFrom.Location = new System.Drawing.Point(3, 0);
            this.lblBillFrom.Name = "lblBillFrom";
            this.lblBillFrom.Size = new System.Drawing.Size(110, 29);
            this.lblBillFrom.TabIndex = 0;
            this.lblBillFrom.Text = "Bill From";
            // 
            // lblBillTill
            // 
            this.lblBillTill.AutoSize = true;
            this.lblBillTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTill.Location = new System.Drawing.Point(3, 68);
            this.lblBillTill.Name = "lblBillTill";
            this.lblBillTill.Size = new System.Drawing.Size(87, 29);
            this.lblBillTill.TabIndex = 1;
            this.lblBillTill.Text = "Bill Till";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(3, 139);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(254, 64);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "&Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dateTimeBillFrom
            // 
            this.dateTimeBillFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBillFrom.Location = new System.Drawing.Point(263, 3);
            this.dateTimeBillFrom.Name = "dateTimeBillFrom";
            this.dateTimeBillFrom.Size = new System.Drawing.Size(254, 34);
            this.dateTimeBillFrom.TabIndex = 3;
            // 
            // frmBillReport
            // 
            this.AcceptButton = this.btnGenerateReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(680, 303);
            this.Controls.Add(this.tableLayoutPanelBillReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillReport";
            this.Text = "Bill Report";
            this.tableLayoutPanelBillReport.ResumeLayout(false);
            this.tableLayoutPanelBillReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBillReport;
        private System.Windows.Forms.Label lblBillFrom;
        private System.Windows.Forms.Label lblBillTill;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dateTimeBillFrom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimeBillTill;
    }
}