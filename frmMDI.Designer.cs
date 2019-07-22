namespace E_Billing_System
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelMDI = new System.Windows.Forms.Panel();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnUtility = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.panelMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Enabled = false;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(179, 94);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "&Products";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Visible = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelMDI
            // 
            this.panelMDI.Controls.Add(this.lblCompany);
            this.panelMDI.Controls.Add(this.btnLogout);
            this.panelMDI.Controls.Add(this.btnExit);
            this.panelMDI.Controls.Add(this.btnAbout);
            this.panelMDI.Controls.Add(this.btnUtility);
            this.panelMDI.Controls.Add(this.btnReport);
            this.panelMDI.Controls.Add(this.btnBill);
            this.panelMDI.Controls.Add(this.btnProduct);
            this.panelMDI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMDI.Location = new System.Drawing.Point(0, 0);
            this.panelMDI.Name = "panelMDI";
            this.panelMDI.Size = new System.Drawing.Size(1544, 94);
            this.panelMDI.TabIndex = 4;
            this.panelMDI.Visible = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(1544, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(0, 38);
            this.lblCompany.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(702, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 94);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Enabled = false;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1053, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 94);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Enabled = false;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(877, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(179, 94);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnUtility
            // 
            this.btnUtility.Enabled = false;
            this.btnUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtility.Location = new System.Drawing.Point(527, 0);
            this.btnUtility.Name = "btnUtility";
            this.btnUtility.Size = new System.Drawing.Size(179, 94);
            this.btnUtility.TabIndex = 6;
            this.btnUtility.Text = "&Utilities";
            this.btnUtility.UseVisualStyleBackColor = true;
            this.btnUtility.Visible = false;
            this.btnUtility.Click += new System.EventHandler(this.btnUtility_Click);
            // 
            // btnReport
            // 
            this.btnReport.Enabled = false;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(351, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(179, 94);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "&Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBill
            // 
            this.btnBill.Enabled = false;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(175, 0);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(179, 94);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "&Billing";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Visible = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1544, 540);
            this.Controls.Add(this.panelMDI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "E-Billing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            this.panelMDI.ResumeLayout(false);
            this.panelMDI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnProduct;
        public System.Windows.Forms.Panel panelMDI;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnUtility;
        public System.Windows.Forms.Button btnReport;
        public System.Windows.Forms.Button btnBill;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblCompany;


    }
}

