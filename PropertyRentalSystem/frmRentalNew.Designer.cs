
namespace PropertyRentalSystem
{
    partial class frmRentalNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentalNew));
            this.btnSRHTown = new System.Windows.Forms.Button();
            this.txtTownSRH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPropertyDetails = new System.Windows.Forms.GroupBox();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPropertyEircode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPropertyOwner = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.btnSRHTenants = new System.Windows.Forms.Button();
            this.txtSurnameSRH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateRental = new System.Windows.Forms.Button();
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grdTenantsAdded = new System.Windows.Forms.DataGridView();
            this.tenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.grpPropertyDetails.SuspendLayout();
            this.grpRentalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.grpTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantsAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSRHTown
            // 
            this.btnSRHTown.Location = new System.Drawing.Point(390, 31);
            this.btnSRHTown.Name = "btnSRHTown";
            this.btnSRHTown.Size = new System.Drawing.Size(106, 48);
            this.btnSRHTown.TabIndex = 34;
            this.btnSRHTown.Text = "Search Town";
            this.btnSRHTown.UseVisualStyleBackColor = true;
            this.btnSRHTown.Click += new System.EventHandler(this.btnSRHEircode_Click);
            // 
            // txtTownSRH
            // 
            this.txtTownSRH.Location = new System.Drawing.Point(184, 44);
            this.txtTownSRH.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txtTownSRH.MaxLength = 7;
            this.txtTownSRH.Name = "txtTownSRH";
            this.txtTownSRH.Size = new System.Drawing.Size(188, 22);
            this.txtTownSRH.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Search By Town:";
            // 
            // grpPropertyDetails
            // 
            this.grpPropertyDetails.Controls.Add(this.txtMonthlyRent);
            this.grpPropertyDetails.Controls.Add(this.label3);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyEircode);
            this.grpPropertyDetails.Controls.Add(this.label2);
            this.grpPropertyDetails.Controls.Add(this.txtAddress);
            this.grpPropertyDetails.Controls.Add(this.label1);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyOwner);
            this.grpPropertyDetails.Controls.Add(this.label13);
            this.grpPropertyDetails.Location = new System.Drawing.Point(13, 95);
            this.grpPropertyDetails.Name = "grpPropertyDetails";
            this.grpPropertyDetails.Size = new System.Drawing.Size(502, 143);
            this.grpPropertyDetails.TabIndex = 43;
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
            this.label3.Location = new System.Drawing.Point(27, 111);
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
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Property Eircode: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(129, 52);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(354, 22);
            this.txtAddress.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Address: ";
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
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.dtpEndDate);
            this.grpRentalDetails.Controls.Add(this.label6);
            this.grpRentalDetails.Controls.Add(this.label5);
            this.grpRentalDetails.Controls.Add(this.dtpStartDate);
            this.grpRentalDetails.Location = new System.Drawing.Point(12, 248);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Size = new System.Drawing.Size(502, 107);
            this.grpRentalDetails.TabIndex = 44;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            this.grpRentalDetails.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(144, 61);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(287, 22);
            this.dtpEndDate.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rent End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rent Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(144, 21);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(287, 22);
            this.dtpStartDate.TabIndex = 21;
            // 
            // grdTenants
            // 
            this.grdTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Location = new System.Drawing.Point(6, 53);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.RowHeadersWidth = 51;
            this.grdTenants.RowTemplate.Height = 24;
            this.grdTenants.Size = new System.Drawing.Size(489, 180);
            this.grdTenants.TabIndex = 45;
            this.grdTenants.Visible = false;
            this.grdTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellClick);
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
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Location = new System.Drawing.Point(186, 19);
            this.txtSurnameSRH.MaxLength = 10;
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(226, 22);
            this.txtSurnameSRH.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Find Tenant By Surname:";
            // 
            // btnCreateRental
            // 
            this.btnCreateRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRental.Location = new System.Drawing.Point(140, 389);
            this.btnCreateRental.Name = "btnCreateRental";
            this.btnCreateRental.Size = new System.Drawing.Size(232, 47);
            this.btnCreateRental.TabIndex = 49;
            this.btnCreateRental.Text = "Create Rental";
            this.btnCreateRental.UseVisualStyleBackColor = true;
            this.btnCreateRental.Visible = false;
            this.btnCreateRental.Click += new System.EventHandler(this.btnCreateRental_Click);
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.label8);
            this.grpTenants.Controls.Add(this.grdTenantsAdded);
            this.grpTenants.Controls.Add(this.btnSRHTenants);
            this.grpTenants.Controls.Add(this.txtSurnameSRH);
            this.grpTenants.Controls.Add(this.label7);
            this.grpTenants.Controls.Add(this.grdTenants);
            this.grpTenants.Location = new System.Drawing.Point(531, 12);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(501, 448);
            this.grpTenants.TabIndex = 50;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Tenants";
            this.grpTenants.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tenants Added:";
            // 
            // grdTenantsAdded
            // 
            this.grdTenantsAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenantsAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenantsAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantID,
            this.firstName,
            this.lastName,
            this.phone});
            this.grdTenantsAdded.Location = new System.Drawing.Point(6, 256);
            this.grdTenantsAdded.Name = "grdTenantsAdded";
            this.grdTenantsAdded.RowHeadersWidth = 51;
            this.grdTenantsAdded.RowTemplate.Height = 24;
            this.grdTenantsAdded.Size = new System.Drawing.Size(489, 180);
            this.grdTenantsAdded.TabIndex = 49;
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
            // grdProperties
            // 
            this.grdProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(3, 88);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.RowHeadersWidth = 51;
            this.grdProperties.RowTemplate.Height = 24;
            this.grdProperties.Size = new System.Drawing.Size(628, 372);
            this.grdProperties.TabIndex = 51;
            this.grdProperties.Visible = false;
            // 
            // frmRentalNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1047, 472);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.btnCreateRental);
            this.Controls.Add(this.grpPropertyDetails);
            this.Controls.Add(this.btnSRHTown);
            this.Controls.Add(this.txtTownSRH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpRentalDetails);
            this.Controls.Add(this.grdProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentalNew";
            this.Text = "Perfect Fit Rentals - [New Rental]";
            this.Load += new System.EventHandler(this.frmRentalNew_Load);
            this.grpPropertyDetails.ResumeLayout(false);
            this.grpPropertyDetails.PerformLayout();
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantsAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSRHTown;
        private System.Windows.Forms.TextBox txtTownSRH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpPropertyDetails;
        private System.Windows.Forms.TextBox txtPropertyEircode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPropertyOwner;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.Button btnSRHTenants;
        private System.Windows.Forms.TextBox txtSurnameSRH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateRental;
        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grdTenantsAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView grdProperties;
    }
}