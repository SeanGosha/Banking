namespace SDG.Banking.UI
{
    partial class frmCustomerInformation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeposits = new System.Windows.Forms.DataGridView();
            this.dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnEditDeposit = new System.Windows.Forms.Button();
            this.btnAddDeposit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditWithdrawal = new System.Windows.Forms.Button();
            this.btnAddWithdrawal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDisplayDeposits = new System.Windows.Forms.Button();
            this.btnDisplayWithdrawals = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // dgvDeposits
            // 
            this.dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposits.Location = new System.Drawing.Point(31, 243);
            this.dgvDeposits.Name = "dgvDeposits";
            this.dgvDeposits.RowTemplate.Height = 25;
            this.dgvDeposits.Size = new System.Drawing.Size(555, 169);
            this.dgvDeposits.TabIndex = 4;
            // 
            // dgvWithdrawals
            // 
            this.dgvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawals.Location = new System.Drawing.Point(31, 475);
            this.dgvWithdrawals.Name = "dgvWithdrawals";
            this.dgvWithdrawals.RowTemplate.Height = 25;
            this.dgvWithdrawals.Size = new System.Drawing.Size(555, 169);
            this.dgvWithdrawals.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deposits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Withdrawals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(637, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(637, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(637, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "SSN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(637, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(637, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Birth Date:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(754, 272);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 21);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(754, 304);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 21);
            this.txtLastName.TabIndex = 14;
            // 
            // txtSSN
            // 
            this.txtSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSSN.Location = new System.Drawing.Point(754, 336);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(140, 21);
            this.txtSSN.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(754, 400);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(140, 21);
            this.dtpBirthDate.TabIndex = 17;
            // 
            // btnEditDeposit
            // 
            this.btnEditDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDeposit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditDeposit.Location = new System.Drawing.Point(167, 423);
            this.btnEditDeposit.Name = "btnEditDeposit";
            this.btnEditDeposit.Size = new System.Drawing.Size(130, 25);
            this.btnEditDeposit.TabIndex = 19;
            this.btnEditDeposit.Text = "Edit Deposit";
            this.btnEditDeposit.UseVisualStyleBackColor = false;
            this.btnEditDeposit.Click += new System.EventHandler(this.btnEditDeposit_Click);
            // 
            // btnAddDeposit
            // 
            this.btnAddDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeposit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDeposit.Location = new System.Drawing.Point(31, 423);
            this.btnAddDeposit.Name = "btnAddDeposit";
            this.btnAddDeposit.Size = new System.Drawing.Size(130, 25);
            this.btnAddDeposit.TabIndex = 20;
            this.btnAddDeposit.Text = "Add Deposit";
            this.btnAddDeposit.UseVisualStyleBackColor = false;
            this.btnAddDeposit.Click += new System.EventHandler(this.btnAddDeposit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(515, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 25);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditWithdrawal
            // 
            this.btnEditWithdrawal.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWithdrawal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditWithdrawal.Location = new System.Drawing.Point(167, 653);
            this.btnEditWithdrawal.Name = "btnEditWithdrawal";
            this.btnEditWithdrawal.Size = new System.Drawing.Size(130, 25);
            this.btnEditWithdrawal.TabIndex = 22;
            this.btnEditWithdrawal.Text = "Edit Withdrawal";
            this.btnEditWithdrawal.UseVisualStyleBackColor = false;
            this.btnEditWithdrawal.Click += new System.EventHandler(this.btnEditWithdrawal_Click);
            // 
            // btnAddWithdrawal
            // 
            this.btnAddWithdrawal.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWithdrawal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddWithdrawal.Location = new System.Drawing.Point(31, 653);
            this.btnAddWithdrawal.Name = "btnAddWithdrawal";
            this.btnAddWithdrawal.Size = new System.Drawing.Size(130, 25);
            this.btnAddWithdrawal.TabIndex = 23;
            this.btnAddWithdrawal.Text = "Add Withdrawal";
            this.btnAddWithdrawal.UseVisualStyleBackColor = false;
            this.btnAddWithdrawal.Click += new System.EventHandler(this.btnAddWithdrawal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 725);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(754, 368);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(140, 21);
            this.lblID.TabIndex = 25;
            // 
            // btnDisplayDeposits
            // 
            this.btnDisplayDeposits.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisplayDeposits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayDeposits.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayDeposits.Location = new System.Drawing.Point(456, 423);
            this.btnDisplayDeposits.Name = "btnDisplayDeposits";
            this.btnDisplayDeposits.Size = new System.Drawing.Size(130, 25);
            this.btnDisplayDeposits.TabIndex = 27;
            this.btnDisplayDeposits.Text = "Display Deposits";
            this.btnDisplayDeposits.UseVisualStyleBackColor = false;
            this.btnDisplayDeposits.Click += new System.EventHandler(this.btnDisplayDeposits_Click);
            // 
            // btnDisplayWithdrawals
            // 
            this.btnDisplayWithdrawals.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisplayWithdrawals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayWithdrawals.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayWithdrawals.Location = new System.Drawing.Point(455, 653);
            this.btnDisplayWithdrawals.Name = "btnDisplayWithdrawals";
            this.btnDisplayWithdrawals.Size = new System.Drawing.Size(130, 25);
            this.btnDisplayWithdrawals.TabIndex = 26;
            this.btnDisplayWithdrawals.Text = "Display Withdrawals";
            this.btnDisplayWithdrawals.UseVisualStyleBackColor = false;
            this.btnDisplayWithdrawals.Click += new System.EventHandler(this.btnDisplayWithdrawals_Click);
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAge.Location = new System.Drawing.Point(754, 432);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(140, 21);
            this.lblAge.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(637, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Age:";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(31, 42);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(869, 169);
            this.dgvCustomers.TabIndex = 35;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(686, 514);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(154, 25);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(686, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 25);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(686, 606);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 25);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // frmCustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 747);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnDisplayDeposits);
            this.Controls.Add(this.btnDisplayWithdrawals);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddWithdrawal);
            this.Controls.Add(this.btnEditWithdrawal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddDeposit);
            this.Controls.Add(this.btnEditDeposit);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvWithdrawals);
            this.Controls.Add(this.dgvDeposits);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "frmCustomerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.frmCustomerInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvDeposits;
        private DataGridView dgvWithdrawals;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSSN;
        private DateTimePicker dtpBirthDate;
        private Button btnEditDeposit;
        private Button btnAddDeposit;
        private Button btnExit;
        private Button btnEditWithdrawal;
        private Button btnAddWithdrawal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Label lblID;
        private Button btnDisplayDeposits;
        private Button btnDisplayWithdrawals;
        private Label lblAge;
        private Label label9;
        private DataGridView dgvCustomers;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
    }
}