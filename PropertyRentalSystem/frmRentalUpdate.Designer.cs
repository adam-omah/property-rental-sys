
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentalUpdate));
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
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.lblTenants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdTenantsAdded = new System.Windows.Forms.DataGridView();
            this.tenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSRHTenants = new System.Windows.Forms.Button();
            this.txtSurnameSRH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboRentalStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.grpPropertyDetails.SuspendLayout();
            this.grpTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantsAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.grpRentalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateRental
            // 
            this.btnUpdateRental.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRental.Location = new System.Drawing.Point(41, 452);
            this.btnUpdateRental.Name = "btnUpdateRental";
            this.btnUpdateRental.Size = new System.Drawing.Size(324, 47);
            this.btnUpdateRental.TabIndex = 11;
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
            this.grpPropertyDetails.Font = new System.Drawing.Font("Leelawadee", 10F);
            this.grpPropertyDetails.Location = new System.Drawing.Point(20, 51);
            this.grpPropertyDetails.Name = "grpPropertyDetails";
            this.grpPropertyDetails.Size = new System.Drawing.Size(536, 170);
            this.grpPropertyDetails.TabIndex = 54;
            this.grpPropertyDetails.TabStop = false;
            this.grpPropertyDetails.Text = "Property Details";
            this.grpPropertyDetails.Visible = false;
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(176, 127);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(354, 27);
            this.txtMonthlyRent.TabIndex = 49;
            this.txtMonthlyRent.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Monthly Rent:";
            // 
            // txtPropertyEircode
            // 
            this.txtPropertyEircode.Location = new System.Drawing.Point(176, 94);
            this.txtPropertyEircode.Name = "txtPropertyEircode";
            this.txtPropertyEircode.ReadOnly = true;
            this.txtPropertyEircode.Size = new System.Drawing.Size(354, 27);
            this.txtPropertyEircode.TabIndex = 47;
            this.txtPropertyEircode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Property Eircode:";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(176, 61);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.ReadOnly = true;
            this.txtPropertyName.Size = new System.Drawing.Size(354, 27);
            this.txtPropertyName.TabIndex = 45;
            this.txtPropertyName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Address:";
            // 
            // txtPropertyOwner
            // 
            this.txtPropertyOwner.Location = new System.Drawing.Point(176, 28);
            this.txtPropertyOwner.Name = "txtPropertyOwner";
            this.txtPropertyOwner.ReadOnly = true;
            this.txtPropertyOwner.Size = new System.Drawing.Size(354, 27);
            this.txtPropertyOwner.TabIndex = 43;
            this.txtPropertyOwner.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Property Owner:";
            // 
            // btnSRHEircode
            // 
            this.btnSRHEircode.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRHEircode.Location = new System.Drawing.Point(394, 12);
            this.btnSRHEircode.Margin = new System.Windows.Forms.Padding(15);
            this.btnSRHEircode.Name = "btnSRHEircode";
            this.btnSRHEircode.Size = new System.Drawing.Size(75, 27);
            this.btnSRHEircode.TabIndex = 2;
            this.btnSRHEircode.Text = "Search Surname";
            this.btnSRHEircode.UseVisualStyleBackColor = true;
            this.btnSRHEircode.Click += new System.EventHandler(this.btnSRHEircode_Click);
            // 
            // txtEircodeSRH
            // 
            this.txtEircodeSRH.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircodeSRH.Location = new System.Drawing.Point(198, 12);
            this.txtEircodeSRH.MaxLength = 7;
            this.txtEircodeSRH.Name = "txtEircodeSRH";
            this.txtEircodeSRH.Size = new System.Drawing.Size(188, 27);
            this.txtEircodeSRH.TabIndex = 1;
            this.txtEircodeSRH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEircodeSRH_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Search By Eircode:";
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.lblTenants);
            this.grpTenants.Controls.Add(this.label7);
            this.grpTenants.Controls.Add(this.grdTenantsAdded);
            this.grpTenants.Controls.Add(this.btnSRHTenants);
            this.grpTenants.Controls.Add(this.txtSurnameSRH);
            this.grpTenants.Controls.Add(this.label9);
            this.grpTenants.Controls.Add(this.grdTenants);
            this.grpTenants.Font = new System.Drawing.Font("Leelawadee", 10F);
            this.grpTenants.Location = new System.Drawing.Point(574, 15);
            this.grpTenants.Margin = new System.Windows.Forms.Padding(15);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(599, 519);
            this.grpTenants.TabIndex = 57;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Tenants";
            this.grpTenants.Visible = false;
            // 
            // lblTenants
            // 
            this.lblTenants.AutoSize = true;
            this.lblTenants.Location = new System.Drawing.Point(6, 50);
            this.lblTenants.Name = "lblTenants";
            this.lblTenants.Size = new System.Drawing.Size(253, 20);
            this.lblTenants.TabIndex = 51;
            this.lblTenants.Text = "Click A Tenant to Add to Rental:";
            this.lblTenants.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tenants Added (Click A Tenant To Remove):";
            // 
            // grdTenantsAdded
            // 
            this.grdTenantsAdded.AllowUserToAddRows = false;
            this.grdTenantsAdded.AllowUserToDeleteRows = false;
            this.grdTenantsAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenantsAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenantsAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantID,
            this.firstName,
            this.lastName,
            this.phone});
            this.grdTenantsAdded.Location = new System.Drawing.Point(6, 313);
            this.grdTenantsAdded.Name = "grdTenantsAdded";
            this.grdTenantsAdded.RowHeadersWidth = 51;
            this.grdTenantsAdded.RowTemplate.Height = 24;
            this.grdTenantsAdded.Size = new System.Drawing.Size(587, 195);
            this.grdTenantsAdded.TabIndex = 10;
            this.grdTenantsAdded.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenantsAdded_CellClick);
            // 
            // tenantID
            // 
            this.tenantID.HeaderText = "Tenant ID";
            this.tenantID.MinimumWidth = 6;
            this.tenantID.Name = "tenantID";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // btnSRHTenants
            // 
            this.btnSRHTenants.Location = new System.Drawing.Point(457, 16);
            this.btnSRHTenants.Name = "btnSRHTenants";
            this.btnSRHTenants.Size = new System.Drawing.Size(75, 27);
            this.btnSRHTenants.TabIndex = 5;
            this.btnSRHTenants.Text = "Search Surname";
            this.btnSRHTenants.UseVisualStyleBackColor = true;
            this.btnSRHTenants.Click += new System.EventHandler(this.btnSRHTenants_Click_1);
            // 
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Location = new System.Drawing.Point(225, 16);
            this.txtSurnameSRH.MaxLength = 10;
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(226, 27);
            this.txtSurnameSRH.TabIndex = 4;
            this.txtSurnameSRH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurnameSRH_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Find Tenant By Surname:";
            // 
            // grdTenants
            // 
            this.grdTenants.AllowUserToAddRows = false;
            this.grdTenants.AllowUserToDeleteRows = false;
            this.grdTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Location = new System.Drawing.Point(6, 73);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.RowHeadersWidth = 51;
            this.grdTenants.RowTemplate.Height = 24;
            this.grdTenants.Size = new System.Drawing.Size(587, 214);
            this.grdTenants.TabIndex = 9;
            this.grdTenants.Visible = false;
            this.grdTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellClick_1);
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.txtRentalID);
            this.grpRentalDetails.Controls.Add(this.label8);
            this.grpRentalDetails.Controls.Add(this.cboRentalStatus);
            this.grpRentalDetails.Controls.Add(this.label10);
            this.grpRentalDetails.Controls.Add(this.dtpEndDate);
            this.grpRentalDetails.Controls.Add(this.label6);
            this.grpRentalDetails.Controls.Add(this.label5);
            this.grpRentalDetails.Controls.Add(this.dtpStartDate);
            this.grpRentalDetails.Font = new System.Drawing.Font("Leelawadee", 10F);
            this.grpRentalDetails.Location = new System.Drawing.Point(20, 227);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Size = new System.Drawing.Size(536, 199);
            this.grpRentalDetails.TabIndex = 60;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            this.grpRentalDetails.Visible = false;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(196, 39);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new System.Drawing.Size(287, 27);
            this.txtRentalID.TabIndex = 51;
            this.txtRentalID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Rental ID:";
            // 
            // cboRentalStatus
            // 
            this.cboRentalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentalStatus.FormattingEnabled = true;
            this.cboRentalStatus.Location = new System.Drawing.Point(196, 156);
            this.cboRentalStatus.Name = "cboRentalStatus";
            this.cboRentalStatus.Size = new System.Drawing.Size(287, 28);
            this.cboRentalStatus.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Status:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(196, 119);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(287, 27);
            this.dtpEndDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rent End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rent Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(196, 79);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(287, 27);
            this.dtpStartDate.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(371, 452);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 47);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome1.Location = new System.Drawing.Point(197, 49);
            this.btnHome1.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(189, 36);
            this.btnHome1.TabIndex = 3;
            this.btnHome1.Text = "Back To Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // frmRentalUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1181, 543);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.grpRentalDetails);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.btnUpdateRental);
            this.Controls.Add(this.grpPropertyDetails);
            this.Controls.Add(this.btnSRHEircode);
            this.Controls.Add(this.txtEircodeSRH);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentalUpdate";
            this.Text = "Perfect Fit Rentals - [Update Rental]";
            this.Load += new System.EventHandler(this.frmRentalUpdate_Load);
            this.grpPropertyDetails.ResumeLayout(false);
            this.grpPropertyDetails.PerformLayout();
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantsAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdTenantsAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button btnSRHTenants;
        private System.Windows.Forms.TextBox txtSurnameSRH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.ComboBox cboRentalStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Label lblTenants;
    }
}