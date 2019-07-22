namespace E_Billing_System
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanelChangePass = new System.Windows.Forms.TableLayoutPanel();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblReEnterPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangePass
            // 
            this.btnChangePass.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(3, 186);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(232, 55);
            this.btnChangePass.TabIndex = 12;
            this.btnChangePass.Text = "Change &Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(241, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(233, 55);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanelChangePass
            // 
            this.tableLayoutPanelChangePass.ColumnCount = 2;
            this.tableLayoutPanelChangePass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChangePass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelChangePass.Controls.Add(this.txtReEnterPass, 1, 2);
            this.tableLayoutPanelChangePass.Controls.Add(this.txtNewPass, 1, 1);
            this.tableLayoutPanelChangePass.Controls.Add(this.btnClose, 0, 3);
            this.tableLayoutPanelChangePass.Controls.Add(this.btnChangePass, 0, 3);
            this.tableLayoutPanelChangePass.Controls.Add(this.lblOldPass, 0, 0);
            this.tableLayoutPanelChangePass.Controls.Add(this.lblNewPass, 0, 1);
            this.tableLayoutPanelChangePass.Controls.Add(this.lblReEnterPass, 0, 2);
            this.tableLayoutPanelChangePass.Controls.Add(this.txtOldPass, 1, 0);
            this.tableLayoutPanelChangePass.Location = new System.Drawing.Point(32, 48);
            this.tableLayoutPanelChangePass.Name = "tableLayoutPanelChangePass";
            this.tableLayoutPanelChangePass.RowCount = 4;
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelChangePass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelChangePass.Size = new System.Drawing.Size(477, 244);
            this.tableLayoutPanelChangePass.TabIndex = 3;
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterPass.Location = new System.Drawing.Point(241, 125);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.PasswordChar = '*';
            this.txtReEnterPass.Size = new System.Drawing.Size(233, 34);
            this.txtReEnterPass.TabIndex = 11;
            this.txtReEnterPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReEnterPass_KeyPress);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(241, 64);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(233, 34);
            this.txtNewPass.TabIndex = 10;
            this.txtNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPass_KeyPress);
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(3, 0);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(165, 29);
            this.lblOldPass.TabIndex = 6;
            this.lblOldPass.Text = "Old Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(3, 61);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(176, 29);
            this.lblNewPass.TabIndex = 7;
            this.lblNewPass.Text = "New Password";
            // 
            // lblReEnterPass
            // 
            this.lblReEnterPass.AutoSize = true;
            this.lblReEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReEnterPass.Location = new System.Drawing.Point(3, 122);
            this.lblReEnterPass.Name = "lblReEnterPass";
            this.lblReEnterPass.Size = new System.Drawing.Size(220, 29);
            this.lblReEnterPass.TabIndex = 8;
            this.lblReEnterPass.Text = "Re Enter Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(241, 3);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(233, 34);
            this.txtOldPass.TabIndex = 9;
            this.txtOldPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldPass_KeyPress);
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnChangePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(544, 353);
            this.Controls.Add(this.tableLayoutPanelChangePass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.tableLayoutPanelChangePass.ResumeLayout(false);
            this.tableLayoutPanelChangePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChangePass;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblReEnterPass;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;

    }
}