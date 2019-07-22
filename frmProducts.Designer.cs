namespace E_Billing_System
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.tablePanelProduct1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProdType = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.cmbProdType = new System.Windows.Forms.ComboBox();
            this.lstProd = new System.Windows.Forms.ListBox();
            this.tablePanelProduct2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.lblProdType1 = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tablePanelProduct1.SuspendLayout();
            this.tablePanelProduct2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanelProduct1
            // 
            this.tablePanelProduct1.ColumnCount = 2;
            this.tablePanelProduct1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.55882F));
            this.tablePanelProduct1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.44118F));
            this.tablePanelProduct1.Controls.Add(this.lblProdType, 0, 0);
            this.tablePanelProduct1.Controls.Add(this.lblProd, 0, 1);
            this.tablePanelProduct1.Controls.Add(this.cmbProdType, 1, 0);
            this.tablePanelProduct1.Controls.Add(this.lstProd, 1, 1);
            this.tablePanelProduct1.Location = new System.Drawing.Point(75, 50);
            this.tablePanelProduct1.Name = "tablePanelProduct1";
            this.tablePanelProduct1.RowCount = 2;
            this.tablePanelProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05494F));
            this.tablePanelProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.94505F));
            this.tablePanelProduct1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelProduct1.Size = new System.Drawing.Size(680, 488);
            this.tablePanelProduct1.TabIndex = 2;
            // 
            // lblProdType
            // 
            this.lblProdType.AutoSize = true;
            this.lblProdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdType.Location = new System.Drawing.Point(3, 0);
            this.lblProdType.Name = "lblProdType";
            this.lblProdType.Size = new System.Drawing.Size(157, 29);
            this.lblProdType.TabIndex = 1;
            this.lblProdType.Text = "Product Type";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(3, 97);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(96, 29);
            this.lblProd.TabIndex = 2;
            this.lblProd.Text = "Product";
            // 
            // cmbProdType
            // 
            this.cmbProdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdType.FormattingEnabled = true;
            this.cmbProdType.Location = new System.Drawing.Point(169, 3);
            this.cmbProdType.Name = "cmbProdType";
            this.cmbProdType.Size = new System.Drawing.Size(508, 37);
            this.cmbProdType.TabIndex = 2;
            this.cmbProdType.SelectedIndexChanged += new System.EventHandler(this.cmbProdType_SelectedIndexChanged);
            // 
            // lstProd
            // 
            this.lstProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProd.FormattingEnabled = true;
            this.lstProd.ItemHeight = 29;
            this.lstProd.Location = new System.Drawing.Point(169, 100);
            this.lstProd.Name = "lstProd";
            this.lstProd.Size = new System.Drawing.Size(508, 381);
            this.lstProd.TabIndex = 3;
            this.lstProd.SelectedIndexChanged += new System.EventHandler(this.lstProd_SelectedIndexChanged);
            // 
            // tablePanelProduct2
            // 
            this.tablePanelProduct2.ColumnCount = 2;
            this.tablePanelProduct2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.53872F));
            this.tablePanelProduct2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.46128F));
            this.tablePanelProduct2.Controls.Add(this.txtProdId, 1, 0);
            this.tablePanelProduct2.Controls.Add(this.btnAdd, 0, 5);
            this.tablePanelProduct2.Controls.Add(this.txtDiscount, 1, 4);
            this.tablePanelProduct2.Controls.Add(this.lblDiscount, 0, 4);
            this.tablePanelProduct2.Controls.Add(this.lblPrice, 0, 3);
            this.tablePanelProduct2.Controls.Add(this.txtPrice, 1, 3);
            this.tablePanelProduct2.Controls.Add(this.lblProd1, 0, 2);
            this.tablePanelProduct2.Controls.Add(this.txtProd, 1, 2);
            this.tablePanelProduct2.Controls.Add(this.txtProdType, 1, 1);
            this.tablePanelProduct2.Controls.Add(this.lblProdType1, 0, 1);
            this.tablePanelProduct2.Controls.Add(this.lblProdId, 0, 0);
            this.tablePanelProduct2.Controls.Add(this.btnClose, 1, 6);
            this.tablePanelProduct2.Controls.Add(this.btnRemove, 0, 6);
            this.tablePanelProduct2.Controls.Add(this.btnEdit, 1, 5);
            this.tablePanelProduct2.Location = new System.Drawing.Point(818, 50);
            this.tablePanelProduct2.Name = "tablePanelProduct2";
            this.tablePanelProduct2.RowCount = 7;
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.3F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.3F));
            this.tablePanelProduct2.Size = new System.Drawing.Size(607, 488);
            this.tablePanelProduct2.TabIndex = 3;
            // 
            // txtProdId
            // 
            this.txtProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdId.Location = new System.Drawing.Point(243, 3);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.ReadOnly = true;
            this.txtProdId.Size = new System.Drawing.Size(361, 34);
            this.txtProdId.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 63);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add New Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(243, 279);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(361, 34);
            this.txtDiscount.TabIndex = 8;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(3, 276);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(106, 29);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 207);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(243, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(361, 34);
            this.txtPrice.TabIndex = 7;
            // 
            // lblProd1
            // 
            this.lblProd1.AutoSize = true;
            this.lblProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd1.Location = new System.Drawing.Point(3, 138);
            this.lblProd1.Name = "lblProd1";
            this.lblProd1.Size = new System.Drawing.Size(96, 29);
            this.lblProd1.TabIndex = 9;
            this.lblProd1.Text = "Product";
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(243, 141);
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            this.txtProd.Size = new System.Drawing.Size(361, 34);
            this.txtProd.TabIndex = 6;
            // 
            // txtProdType
            // 
            this.txtProdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdType.Location = new System.Drawing.Point(243, 72);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.ReadOnly = true;
            this.txtProdType.Size = new System.Drawing.Size(361, 34);
            this.txtProdType.TabIndex = 5;
            // 
            // lblProdType1
            // 
            this.lblProdType1.AutoSize = true;
            this.lblProdType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdType1.Location = new System.Drawing.Point(3, 69);
            this.lblProdType1.Name = "lblProdType1";
            this.lblProdType1.Size = new System.Drawing.Size(157, 29);
            this.lblProdType1.TabIndex = 8;
            this.lblProdType1.Text = "Product Type";
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdId.Location = new System.Drawing.Point(3, 0);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(122, 29);
            this.lblProdId.TabIndex = 11;
            this.lblProdId.Text = "Product Id";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(302, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(243, 68);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(6, 417);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(228, 68);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "&Remove Product";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(306, 348);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(234, 63);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit Product";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 581);
            this.Controls.Add(this.tablePanelProduct2);
            this.Controls.Add(this.tablePanelProduct1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.EnabledChanged += new System.EventHandler(this.frmProducts_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProducts_FormClosed);
            this.tablePanelProduct1.ResumeLayout(false);
            this.tablePanelProduct1.PerformLayout();
            this.tablePanelProduct2.ResumeLayout(false);
            this.tablePanelProduct2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanelProduct1;
        private System.Windows.Forms.ListBox lstProd;
        private System.Windows.Forms.Label lblProdType;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.ComboBox cmbProdType;
        private System.Windows.Forms.TableLayoutPanel tablePanelProduct2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label lblProdType1;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
    }
}