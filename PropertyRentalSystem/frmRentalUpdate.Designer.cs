
namespace PropertyRentalSystem
{
    partial class frmRentalUpdate
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
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.btnSRHTenants = new System.Windows.Forms.Button();
            this.txtSRHTenant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateRental = new System.Windows.Forms.Button();
            this.grpPropertyDetails = new System.Windows.Forms.GroupBox();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPropertyEircode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPropertyOwner = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSRHEircode = new System.Windows.Forms.Button();
            this.txtEircodeSRH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.chkDirectDebit = new System.Windows.Forms.CheckBox();
            this.chkDepositPaid = new System.Windows.Forms.CheckBox();
            this.numRentDuration = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.grpTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.grpPropertyDetails.SuspendLayout();
            this.grpRentalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.btnSRHTenants);
            this.grpTenants.Controls.Add(this.txtSRHTenant);
            this.grpTenants.Controls.Add(this.label7);
            this.grpTenants.Controls.Add(this.grdTenants);
            this.grpTenants.Location = new System.Drawing.Point(21, 351);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(501, 239);
            this.grpTenants.TabIndex = 57;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Tenants";
            this.grpTenants.Visible = false;
            // 
            // btnSRHTenants
            // 
            this.btnSRHTenants.Location = new System.Drawing.Point(418, 19);
            this.btnSRHTenants.Name = "btnSRHTenants";
            this.btnSRHTenants.Size = new System.Drawing.Size(75, 23);
            this.btnSRHTenants.TabIndex = 46;
            this.btnSRHTenants.Text = "Search Surname";
            this.btnSRHTenants.UseVisualStyleBackColor = true;
            this.btnSRHTenants.Click += new System.EventHandler(this.btnSRHTenants_Click);
            // 
            // txtSRHTenant
            // 
            this.txtSRHTenant.Location = new System.Drawing.Point(224, 19);
            this.txtSRHTenant.MaxLength = 10;
            this.txtSRHTenant.Name = "txtSRHTenant";
            this.txtSRHTenant.Size = new System.Drawing.Size(188, 22);
            this.txtSRHTenant.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Find Tenant By Phone Number:";
            // 
            // grdTenants
            // 
            this.grdTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.phone,
            this.id});
            this.grdTenants.Location = new System.Drawing.Point(6, 53);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.RowHeadersWidth = 51;
            this.grdTenants.RowTemplate.Height = 24;
            this.grdTenants.Size = new System.Drawing.Size(489, 180);
            this.grdTenants.TabIndex = 45;
            this.grdTenants.Visible = false;
            this.grdTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellClick);
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Surname";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone Number";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // id
            // 
            this.id.HeaderText = "Tenant Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // btnUpdateRental
            // 
            this.btnUpdateRental.Location = new System.Drawing.Point(163, 596);
            this.btnUpdateRental.Name = "btnUpdateRental";
            this.btnUpdateRental.Size = new System.Drawing.Size(232, 28);
            this.btnUpdateRental.TabIndex = 56;
            this.btnUpdateRental.Text = "Update Rental";
            this.btnUpdateRental.UseVisualStyleBackColor = true;
            this.btnUpdateRental.Visible = false;
            this.btnUpdateRental.Click += new System.EventHandler(this.btnUpdateRental_Click);
            // 
            // grpPropertyDetails
            // 
            this.grpPropertyDetails.Controls.Add(this.txtMonthlyRent);
            this.grpPropertyDetails.Controls.Add(this.label3);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyEircode);
            this.grpPropertyDetails.Controls.Add(this.label2);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyName);
            this.grpPropertyDetails.Controls.Add(this.label1);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyOwner);
            this.grpPropertyDetails.Controls.Add(this.label13);
            this.grpPropertyDetails.Location = new System.Drawing.Point(20, 41);
            this.grpPropertyDetails.Name = "grpPropertyDetails";
            this.grpPropertyDetails.Size = new System.Drawing.Size(502, 143);
            this.grpPropertyDetails.TabIndex = 54;
            this.grpPropertyDetails.TabStop = false;
            this.grpPropertyDetails.Text = "Property Details";
            this.grpPropertyDetails.Visible = false;
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(129, 108);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(354, 22);
            this.txtMonthlyRent.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Monthly Rent: ";
            // 
            // txtPropertyEircode
            // 
            this.txtPropertyEircode.Location = new System.Drawing.Point(129, 80);
            this.txtPropertyEircode.Name = "txtPropertyEircode";
            this.txtPropertyEircode.ReadOnly = true;
            this.txtPropertyEircode.Size = new System.Drawing.Size(354, 22);
            this.txtPropertyEircode.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Property Eircode: ";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(129, 52);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.ReadOnly = true;
            this.txtPropertyName.Size = new System.Drawing.Size(354, 22);
            this.txtPropertyName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Property Name: ";
            // 
            // txtPropertyOwner
            // 
            this.txtPropertyOwner.Location = new System.Drawing.Point(129, 25);
            this.txtPropertyOwner.Name = "txtPropertyOwner";
            this.txtPropertyOwner.ReadOnly = true;
            this.txtPropertyOwner.Size = new System.Drawing.Size(354, 22);
            this.txtPropertyOwner.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Property Owner: ";
            // 
            // btnSRHEircode
            // 
            this.btnSRHEircode.Location = new System.Drawing.Point(375, 12);
            this.btnSRHEircode.Name = "btnSRHEircode";
            this.btnSRHEircode.Size = new System.Drawing.Size(75, 23);
            this.btnSRHEircode.TabIndex = 51;
            this.btnSRHEircode.Text = "Search Surname";
            this.btnSRHEircode.UseVisualStyleBackColor = true;
            this.btnSRHEircode.Click += new System.EventHandler(this.btnSRHEircode_Click);
            // 
            // txtEircodeSRH
            // 
            this.txtEircodeSRH.Location = new System.Drawing.Point(179, 12);
            this.txtEircodeSRH.MaxLength = 7;
            this.txtEircodeSRH.Name = "txtEircodeSRH";
            this.txtEircodeSRH.Size = new System.Drawing.Size(188, 22);
            this.txtEircodeSRH.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Search By Eircode:";
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.chkDirectDebit);
            this.grpRentalDetails.Controls.Add(this.chkDepositPaid);
            this.grpRentalDetails.Controls.Add(this.numRentDuration);
            this.grpRentalDetails.Controls.Add(this.label6);
            this.grpRentalDetails.Controls.Add(this.label5);
            this.grpRentalDetails.Controls.Add(this.dtpEndDate);
            this.grpRentalDetails.Location = new System.Drawing.Point(19, 194);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Size = new System.Drawing.Size(502, 151);
            this.grpRentalDetails.TabIndex = 55;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            this.grpRentalDetails.Visible = false;
            // 
            // chkDirectDebit
            // 
            this.chkDirectDebit.AutoSize = true;
            this.chkDirectDebit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDirectDebit.Location = new System.Drawing.Point(28, 108);
            this.chkDirectDebit.Name = "chkDirectDebit";
            this.chkDirectDebit.Size = new System.Drawing.Size(155, 21);
            this.chkDirectDebit.TabIndex = 26;
            this.chkDirectDebit.Text = "Direct Debit Set Up:";
            this.chkDirectDebit.UseVisualStyleBackColor = true;
            // 
            // chkDepositPaid
            // 
            this.chkDepositPaid.AutoSize = true;
            this.chkDepositPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDepositPaid.Location = new System.Drawing.Point(28, 81);
            this.chkDepositPaid.Name = "chkDepositPaid";
            this.chkDepositPaid.Size = new System.Drawing.Size(196, 21);
            this.chkDepositPaid.TabIndex = 25;
            this.chkDepositPaid.Text = "First Month / Depoist Paid:";
            this.chkDepositPaid.UseVisualStyleBackColor = true;
            // 
            // numRentDuration
            // 
            this.numRentDuration.Location = new System.Drawing.Point(216, 53);
            this.numRentDuration.Name = "numRentDuration";
            this.numRentDuration.Size = new System.Drawing.Size(83, 22);
            this.numRentDuration.TabIndex = 24;
            this.numRentDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Extend End Date (Months) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rent End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(144, 21);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(287, 22);
            this.dtpEndDate.TabIndex = 21;
            // 
            // frmRentalUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 641);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.btnUpdateRental);
            this.Controls.Add(this.grpPropertyDetails);
            this.Controls.Add(this.btnSRHEircode);
            this.Controls.Add(this.txtEircodeSRH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpRentalDetails);
            this.Name = "frmRentalUpdate";
            this.Text = "Perfect Fit Rentals - [Update Rental]";
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.grpPropertyDetails.ResumeLayout(false);
            this.grpPropertyDetails.PerformLayout();
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.Button btnSRHTenants;
        private System.Windows.Forms.TextBox txtSRHTenant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnUpdateRental;
        private System.Windows.Forms.GroupBox grpPropertyDetails;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPropertyEircode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPropertyOwner;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSRHEircode;
        private System.Windows.Forms.TextBox txtEircodeSRH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.CheckBox chkDirectDebit;
        private System.Windows.Forms.CheckBox chkDepositPaid;
        private System.Windows.Forms.NumericUpDown numRentDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}