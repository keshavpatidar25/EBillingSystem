namespace E_Billing_System
{
    partial class frmUtilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilities));
            this.tableLayoutPanelBillReport = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnRestoreDatabase = new System.Windows.Forms.Button();
            this.btnBackupDatabase = new System.Windows.Forms.Button();
            this.progressBarUtility = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanelBillReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBillReport
            // 
            this.tableLayoutPanelBillReport.ColumnCount = 2;
            this.tableLayoutPanelBillReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBillReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBillReport.Controls.Add(this.btnClose, 1, 1);
            this.tableLayoutPanelBillReport.Controls.Add(this.btnChangePass, 0, 1);
            this.tableLayoutPanelBillReport.Controls.Add(this.btnRestoreDatabase, 1, 0);
            this.tableLayoutPanelBillReport.Controls.Add(this.btnBackupDatabase, 0, 0);
            this.tableLayoutPanelBillReport.Location = new System.Drawing.Point(39, 29);
            this.tableLayoutPanelBillReport.Name = "tableLayoutPanelBillReport";
            this.tableLayoutPanelBillReport.RowCount = 2;
            this.tableLayoutPanelBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBillReport.Size = new System.Drawing.Size(468, 165);
            this.tableLayoutPanelBillReport.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(237, 85);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 77);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(3, 85);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(228, 77);
            this.btnChangePass.TabIndex = 2;
            this.btnChangePass.Text = "Change &Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnRestoreDatabase
            // 
            this.btnRestoreDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestoreDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDatabase.Location = new System.Drawing.Point(237, 3);
            this.btnRestoreDatabase.Name = "btnRestoreDatabase";
            this.btnRestoreDatabase.Size = new System.Drawing.Size(228, 76);
            this.btnRestoreDatabase.TabIndex = 1;
            this.btnRestoreDatabase.Text = "&Restore Database";
            this.btnRestoreDatabase.UseVisualStyleBackColor = true;
            this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
            // 
            // btnBackupDatabase
            // 
            this.btnBackupDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackupDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupDatabase.Location = new System.Drawing.Point(3, 3);
            this.btnBackupDatabase.Name = "btnBackupDatabase";
            this.btnBackupDatabase.Size = new System.Drawing.Size(228, 76);
            this.btnBackupDatabase.TabIndex = 0;
            this.btnBackupDatabase.Text = "&Backup Database";
            this.btnBackupDatabase.UseVisualStyleBackColor = true;
            this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
            // 
            // progressBarUtility
            // 
            this.progressBarUtility.Location = new System.Drawing.Point(42, 200);
            this.progressBarUtility.Maximum = 10000000;
            this.progressBarUtility.Name = "progressBarUtility";
            this.progressBarUtility.Size = new System.Drawing.Size(462, 30);
            this.progressBarUtility.TabIndex = 6;
            this.progressBarUtility.Visible = false;
            // 
            // frmUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 242);
            this.Controls.Add(this.progressBarUtility);
            this.Controls.Add(this.tableLayoutPanelBillReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUtilities";
            this.Text = "Utilities";
            this.Load += new System.EventHandler(this.frmUtilities_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUtilities_FormClosed);
            this.tableLayoutPanelBillReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBillReport;
        private System.Windows.Forms.Button btnBackupDatabase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnRestoreDatabase;
        private System.Windows.Forms.ProgressBar progressBarUtility;
    }
}