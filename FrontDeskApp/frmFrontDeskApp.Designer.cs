namespace FrontDeskApp
{
    partial class frmFrontDeskApp
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
            this.dgvStorageTransaction = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelTransaction = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddStorageTransaction = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboLoadType = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLargeTotalCount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLargeCurrentCount = new System.Windows.Forms.Label();
            this.lblMediumTotalCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMediumCurrentCount = new System.Windows.Forms.Label();
            this.lblSmallTotalCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSmallCurrentCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdTransaction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStorageTransaction
            // 
            this.dgvStorageTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageTransaction.Location = new System.Drawing.Point(66, 786);
            this.dgvStorageTransaction.Name = "dgvStorageTransaction";
            this.dgvStorageTransaction.Size = new System.Drawing.Size(677, 148);
            this.dgvStorageTransaction.TabIndex = 2;
            this.dgvStorageTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorageTransaction_CellClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(66, 316);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(677, 150);
            this.dgvCustomers.TabIndex = 3;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(162, 83);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(162, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(162, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Location = new System.Drawing.Point(66, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(78, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelTransaction);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.btnAddStorageTransaction);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.cboLoadType);
            this.groupBox2.Controls.Add(this.cboCustomer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(66, 526);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 254);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Storage Transaction";
            // 
            // btnCancelTransaction
            // 
            this.btnCancelTransaction.Location = new System.Drawing.Point(115, 215);
            this.btnCancelTransaction.Name = "btnCancelTransaction";
            this.btnCancelTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTransaction.TabIndex = 15;
            this.btnCancelTransaction.Text = "Cancel";
            this.btnCancelTransaction.UseVisualStyleBackColor = true;
            this.btnCancelTransaction.Click += new System.EventHandler(this.btnCancelTransaction_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(140, 124);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(165, 20);
            this.txtQuantity.TabIndex = 20;
            // 
            // btnAddStorageTransaction
            // 
            this.btnAddStorageTransaction.Location = new System.Drawing.Point(230, 215);
            this.btnAddStorageTransaction.Name = "btnAddStorageTransaction";
            this.btnAddStorageTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnAddStorageTransaction.TabIndex = 14;
            this.btnAddStorageTransaction.Text = "Add";
            this.btnAddStorageTransaction.UseVisualStyleBackColor = true;
            this.btnAddStorageTransaction.Click += new System.EventHandler(this.btnAddStorageTransaction_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DisplayMember = "Text";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(140, 167);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(165, 21);
            this.cboStatus.TabIndex = 19;
            this.cboStatus.ValueMember = "Value";
            // 
            // cboLoadType
            // 
            this.cboLoadType.DisplayMember = "Text";
            this.cboLoadType.FormattingEnabled = true;
            this.cboLoadType.Location = new System.Drawing.Point(140, 78);
            this.cboLoadType.Name = "cboLoadType";
            this.cboLoadType.Size = new System.Drawing.Size(165, 21);
            this.cboLoadType.TabIndex = 18;
            this.cboLoadType.ValueMember = "Value";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DisplayMember = "Text";
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(140, 37);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(165, 21);
            this.cboCustomer.TabIndex = 17;
            this.cboCustomer.ValueMember = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Load Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(396, 81);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 15;
            this.txtIdCustomer.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLargeTotalCount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblLargeCurrentCount);
            this.groupBox3.Controls.Add(this.lblMediumTotalCount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblMediumCurrentCount);
            this.groupBox3.Controls.Add(this.lblSmallTotalCount);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblSmallCurrentCount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(460, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 205);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage Capacity";
            // 
            // lblLargeTotalCount
            // 
            this.lblLargeTotalCount.AutoSize = true;
            this.lblLargeTotalCount.Location = new System.Drawing.Point(129, 144);
            this.lblLargeTotalCount.Name = "lblLargeTotalCount";
            this.lblLargeTotalCount.Size = new System.Drawing.Size(19, 13);
            this.lblLargeTotalCount.TabIndex = 11;
            this.lblLargeTotalCount.Text = "00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(111, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "/";
            // 
            // lblLargeCurrentCount
            // 
            this.lblLargeCurrentCount.AutoSize = true;
            this.lblLargeCurrentCount.Location = new System.Drawing.Point(86, 144);
            this.lblLargeCurrentCount.Name = "lblLargeCurrentCount";
            this.lblLargeCurrentCount.Size = new System.Drawing.Size(19, 13);
            this.lblLargeCurrentCount.TabIndex = 9;
            this.lblLargeCurrentCount.Text = "00";
            // 
            // lblMediumTotalCount
            // 
            this.lblMediumTotalCount.AutoSize = true;
            this.lblMediumTotalCount.Location = new System.Drawing.Point(129, 86);
            this.lblMediumTotalCount.Name = "lblMediumTotalCount";
            this.lblMediumTotalCount.Size = new System.Drawing.Size(19, 13);
            this.lblMediumTotalCount.TabIndex = 8;
            this.lblMediumTotalCount.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "/";
            // 
            // lblMediumCurrentCount
            // 
            this.lblMediumCurrentCount.AutoSize = true;
            this.lblMediumCurrentCount.Location = new System.Drawing.Point(86, 86);
            this.lblMediumCurrentCount.Name = "lblMediumCurrentCount";
            this.lblMediumCurrentCount.Size = new System.Drawing.Size(19, 13);
            this.lblMediumCurrentCount.TabIndex = 6;
            this.lblMediumCurrentCount.Text = "00";
            // 
            // lblSmallTotalCount
            // 
            this.lblSmallTotalCount.AutoSize = true;
            this.lblSmallTotalCount.Location = new System.Drawing.Point(129, 40);
            this.lblSmallTotalCount.Name = "lblSmallTotalCount";
            this.lblSmallTotalCount.Size = new System.Drawing.Size(19, 13);
            this.lblSmallTotalCount.TabIndex = 5;
            this.lblSmallTotalCount.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "/";
            // 
            // lblSmallCurrentCount
            // 
            this.lblSmallCurrentCount.AutoSize = true;
            this.lblSmallCurrentCount.Location = new System.Drawing.Point(86, 40);
            this.lblSmallCurrentCount.Name = "lblSmallCurrentCount";
            this.lblSmallCurrentCount.Size = new System.Drawing.Size(19, 13);
            this.lblSmallCurrentCount.TabIndex = 3;
            this.lblSmallCurrentCount.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Large";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Medium";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Small";
            // 
            // txtIdTransaction
            // 
            this.txtIdTransaction.Location = new System.Drawing.Point(267, 500);
            this.txtIdTransaction.Name = "txtIdTransaction";
            this.txtIdTransaction.Size = new System.Drawing.Size(165, 20);
            this.txtIdTransaction.TabIndex = 21;
            this.txtIdTransaction.Visible = false;
            // 
            // frmFrontDeskApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 946);
            this.Controls.Add(this.txtIdTransaction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dgvStorageTransaction);
            this.Name = "frmFrontDeskApp";
            this.Text = "FrontDeskApp";
            this.Load += new System.EventHandler(this.frmFrontDeskApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStorageTransaction;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddStorageTransaction;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboLoadType;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLargeTotalCount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblLargeCurrentCount;
        private System.Windows.Forms.Label lblMediumTotalCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMediumCurrentCount;
        private System.Windows.Forms.Label lblSmallTotalCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSmallCurrentCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelTransaction;
        private System.Windows.Forms.TextBox txtIdTransaction;
    }
}

