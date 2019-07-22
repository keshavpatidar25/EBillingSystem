namespace E_Billing_System
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.tabControlAddProduct = new System.Windows.Forms.TabControl();
            this.tabAddProdType = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddProdType = new System.Windows.Forms.Button();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.lblProdType = new System.Windows.Forms.Label();
            this.tabAddNewProd = new System.Windows.Forms.TabPage();
            this.tablePanelProduct2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDiscount1 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProd1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.cmbProdType1 = new System.Windows.Forms.ComboBox();
            this.txtProdId1 = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProdType1 = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControlAddProduct.SuspendLayout();
            this.tabAddProdType.SuspendLayout();
            this.tabAddNewProd.SuspendLayout();
            this.tablePanelProduct2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddProduct
            // 
            this.tabControlAddProduct.Controls.Add(this.tabAddProdType);
            this.tabControlAddProduct.Controls.Add(this.tabAddNewProd);
            this.tabControlAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAddProduct.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddProduct.Name = "tabControlAddProduct";
            this.tabControlAddProduct.SelectedIndex = 0;
            this.tabControlAddProduct.Size = new System.Drawing.Size(898, 588);
            this.tabControlAddProduct.TabIndex = 0;
            this.tabControlAddProduct.SelectedIndexChanged += new System.EventHandler(this.tabControlAddProduct_SelectedIndexChanged);
            // 
            // tabAddProdType
            // 
            this.tabAddProdType.Controls.Add(this.btnCancel);
            this.tabAddProdType.Controls.Add(this.btnReset);
            this.tabAddProdType.Controls.Add(this.btnAddProdType);
            this.tabAddProdType.Controls.Add(this.txtProdType);
            this.tabAddProdType.Controls.Add(this.lblProdType);
            this.tabAddProdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddProdType.Location = new System.Drawing.Point(4, 38);
            this.tabAddProdType.Name = "tabAddProdType";
            this.tabAddProdType.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProdType.Size = new System.Drawing.Size(890, 546);
            this.tabAddProdType.TabIndex = 0;
            this.tabAddProdType.Text = "Add New Product Type";
            this.tabAddProdType.UseVisualStyleBackColor = true;
            this.tabAddProdType.Click += new System.EventHandler(this.tabAddProdType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(559, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(232, 56);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(321, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(232, 56);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddProdType
            // 
            this.btnAddProdType.Location = new System.Drawing.Point(83, 265);
            this.btnAddProdType.Name = "btnAddProdType";
            this.btnAddProdType.Size = new System.Drawing.Size(232, 56);
            this.btnAddProdType.TabIndex = 3;
            this.btnAddProdType.Text = "&Add New Product";
            this.btnAddProdType.UseVisualStyleBackColor = true;
            this.btnAddProdType.Click += new System.EventHandler(this.btnAddProdType_Click);
            // 
            // txtProdType
            // 
            this.txtProdType.Location = new System.Drawing.Point(395, 109);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.Size = new System.Drawing.Size(376, 34);
            this.txtProdType.TabIndex = 2;
            this.txtProdType.TextChanged += new System.EventHandler(this.txtProdType_TextChanged);
            // 
            // lblProdType
            // 
            this.lblProdType.AutoSize = true;
            this.lblProdType.Location = new System.Drawing.Point(107, 109);
            this.lblProdType.Name = "lblProdType";
            this.lblProdType.Size = new System.Drawing.Size(213, 29);
            this.lblProdType.TabIndex = 1;
            this.lblProdType.Text = "New Product Type";
            this.lblProdType.Click += new System.EventHandler(this.lblProdType_Click);
            // 
            // tabAddNewProd
            // 
            this.tabAddNewProd.Controls.Add(this.tablePanelProduct2);
            this.tabAddNewProd.Location = new System.Drawing.Point(4, 38);
            this.tabAddNewProd.Name = "tabAddNewProd";
            this.tabAddNewProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddNewProd.Size = new System.Drawing.Size(890, 546);
            this.tabAddNewProd.TabIndex = 1;
            this.tabAddNewProd.Text = "Add New Product";
            this.tabAddNewProd.UseVisualStyleBackColor = true;
            this.tabAddNewProd.Click += new System.EventHandler(this.tabAddNewProd_Click);
            // 
            // tablePanelProduct2
            // 
            this.tablePanelProduct2.ColumnCount = 2;
            this.tablePanelProduct2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.53872F));
            this.tablePanelProduct2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.46128F));
            this.tablePanelProduct2.Controls.Add(this.txtDiscount1, 1, 4);
            this.tablePanelProduct2.Controls.Add(this.txtPrice1, 1, 3);
            this.tablePanelProduct2.Controls.Add(this.btnAddProd, 0, 5);
            this.tablePanelProduct2.Controls.Add(this.label1, 0, 4);
            this.tablePanelProduct2.Controls.Add(this.label2, 0, 3);
            this.tablePanelProduct2.Controls.Add(this.label3, 0, 2);
            this.tablePanelProduct2.Controls.Add(this.txtProd1, 1, 2);
            this.tablePanelProduct2.Controls.Add(this.label4, 0, 1);
            this.tablePanelProduct2.Controls.Add(this.label5, 0, 0);
            this.tablePanelProduct2.Controls.Add(this.btnCancel1, 1, 5);
            this.tablePanelProduct2.Controls.Add(this.cmbProdType1, 1, 1);
            this.tablePanelProduct2.Controls.Add(this.txtProdId1, 1, 0);
            this.tablePanelProduct2.Location = new System.Drawing.Point(142, 29);
            this.tablePanelProduct2.Name = "tablePanelProduct2";
            this.tablePanelProduct2.RowCount = 6;
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tablePanelProduct2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.3F));
            this.tablePanelProduct2.Size = new System.Drawing.Size(607, 488);
            this.tablePanelProduct2.TabIndex = 4;
            this.tablePanelProduct2.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanelProduct2_Paint);
            // 
            // txtDiscount1
            // 
            this.txtDiscount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount1.Location = new System.Drawing.Point(243, 327);
            this.txtDiscount1.Name = "txtDiscount1";
            this.txtDiscount1.Size = new System.Drawing.Size(361, 34);
            this.txtDiscount1.TabIndex = 8;
            this.txtDiscount1.TextChanged += new System.EventHandler(this.txtDiscount1_TextChanged);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice1.Location = new System.Drawing.Point(243, 246);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(361, 34);
            this.txtPrice1.TabIndex = 7;
            this.txtPrice1.TextChanged += new System.EventHandler(this.txtPrice1_TextChanged);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(6, 408);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(228, 77);
            this.btnAddProd.TabIndex = 9;
            this.btnAddProd.Text = "&Add New Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Discount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProd1
            // 
            this.txtProd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd1.Location = new System.Drawing.Point(243, 165);
            this.txtProd1.Name = "txtProd1";
            this.txtProd1.Size = new System.Drawing.Size(361, 34);
            this.txtProd1.TabIndex = 6;
            this.txtProd1.TextChanged += new System.EventHandler(this.txtProd1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Location = new System.Drawing.Point(302, 408);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(243, 77);
            this.btnCancel1.TabIndex = 12;
            this.btnCancel1.Text = "&Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // cmbProdType1
            // 
            this.cmbProdType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdType1.FormattingEnabled = true;
            this.cmbProdType1.Location = new System.Drawing.Point(243, 84);
            this.cmbProdType1.Name = "cmbProdType1";
            this.cmbProdType1.Size = new System.Drawing.Size(361, 37);
            this.cmbProdType1.TabIndex = 5;
            this.cmbProdType1.SelectedIndexChanged += new System.EventHandler(this.cmbProdType1_SelectedIndexChanged);
            // 
            // txtProdId1
            // 
            this.txtProdId1.Location = new System.Drawing.Point(243, 3);
            this.txtProdId1.Name = "txtProdId1";
            this.txtProdId1.ReadOnly = true;
            this.txtProdId1.Size = new System.Drawing.Size(361, 34);
            this.txtProdId1.TabIndex = 4;
            this.txtProdId1.TextChanged += new System.EventHandler(this.txtProdId1_TextChanged);
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
            // txtProdId
            // 
            this.txtProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdId.Location = new System.Drawing.Point(243, 3);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.ReadOnly = true;
            this.txtProdId.Size = new System.Drawing.Size(361, 34);
            this.txtProdId.TabIndex = 4;
            this.txtProdId.TextChanged += new System.EventHandler(this.txtProdId_TextChanged);
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
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(302, 348);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(243, 63);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit Product";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(243, 279);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(361, 34);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
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
            this.lblDiscount.Click += new System.EventHandler(this.lblDiscount_Click);
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
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(243, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(361, 34);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
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
            this.lblProd1.Click += new System.EventHandler(this.lblProd1_Click);
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(243, 141);
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            this.txtProd.Size = new System.Drawing.Size(361, 34);
            this.txtProd.TabIndex = 6;
            this.txtProd.TextChanged += new System.EventHandler(this.txtProd_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(243, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(361, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.lblProdType1.Click += new System.EventHandler(this.lblProdType1_Click);
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
            this.lblProdId.Click += new System.EventHandler(this.lblProdId_Click);
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
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 588);
            this.Controls.Add(this.tabControlAddProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProduct";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddProduct_FormClosed);
            this.tabControlAddProduct.ResumeLayout(false);
            this.tabAddProdType.ResumeLayout(false);
            this.tabAddProdType.PerformLayout();
            this.tabAddNewProd.ResumeLayout(false);
            this.tablePanelProduct2.ResumeLayout(false);
            this.tablePanelProduct2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddProduct;
        private System.Windows.Forms.TabPage tabAddProdType;
        private System.Windows.Forms.TabPage tabAddNewProd;
        private System.Windows.Forms.Button btnAddProdType;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.Label lblProdType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tablePanelProduct2;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProd1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProdType1;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbProdType1;
        private System.Windows.Forms.TextBox txtDiscount1;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtProdId1;

    }
}