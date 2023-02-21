
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
            this.lblTenants = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grdTenantsAdded = new System.Windows.Forms.DataGridView();
            this.tenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPropertyType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRentals = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.grpPropertyDetails.SuspendLayout();
            this.grpRentalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.grpTenants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenantsAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSRHTown
            // 
            this.btnSRHTown.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRHTown.Location = new System.Drawing.Point(405, 27);
            this.btnSRHTown.Margin = new System.Windows.Forms.Padding(10);
            this.btnSRHTown.Name = "btnSRHTown";
            this.btnSRHTown.Size = new System.Drawing.Size(106, 63);
            this.btnSRHTown.TabIndex = 3;
            this.btnSRHTown.Text = "Search Rentals";
            this.btnSRHTown.UseVisualStyleBackColor = true;
            this.btnSRHTown.Click += new System.EventHandler(this.btnSRHEircode_Click);
            // 
            // txtTownSRH
            // 
            this.txtTownSRH.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTownSRH.Location = new System.Drawing.Point(179, 31);
            this.txtTownSRH.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txtTownSRH.MaxLength = 50;
            this.txtTownSRH.Name = "txtTownSRH";
            this.txtTownSRH.Size = new System.Drawing.Size(188, 27);
            this.txtTownSRH.TabIndex = 1;
            this.txtTownSRH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTownSRH_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Search By Town:";
            // 
            // grpPropertyDetails
            // 
            this.grpPropertyDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpPropertyDetails.Controls.Add(this.txtMonthlyRent);
            this.grpPropertyDetails.Controls.Add(this.label3);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyEircode);
            this.grpPropertyDetails.Controls.Add(this.label2);
            this.grpPropertyDetails.Controls.Add(this.txtAddress);
            this.grpPropertyDetails.Controls.Add(this.label1);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyOwner);
            this.grpPropertyDetails.Controls.Add(this.label13);
            this.grpPropertyDetails.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPropertyDetails.Location = new System.Drawing.Point(12, 125);
            this.grpPropertyDetails.Name = "grpPropertyDetails";
            this.grpPropertyDetails.Size = new System.Drawing.Size(568, 178);
            this.grpPropertyDetails.TabIndex = 43;
            this.grpPropertyDetails.TabStop = false;
            this.grpPropertyDetails.Text = "Property Details";
            this.grpPropertyDetails.Visible = false;
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyRent.Location = new System.Drawing.Point(170, 130);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(373, 27);
            this.txtMonthlyRent.TabIndex = 49;
            this.txtMonthlyRent.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Monthly Rent: ";
            // 
            // txtPropertyEircode
            // 
            this.txtPropertyEircode.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyEircode.Location = new System.Drawing.Point(170, 97);
            this.txtPropertyEircode.Name = "txtPropertyEircode";
            this.txtPropertyEircode.ReadOnly = true;
            this.txtPropertyEircode.Size = new System.Drawing.Size(373, 27);
            this.txtPropertyEircode.TabIndex = 47;
            this.txtPropertyEircode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Property Eircode: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(170, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(373, 27);
            this.txtAddress.TabIndex = 45;
            this.txtAddress.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Address: ";
            // 
            // txtPropertyOwner
            // 
            this.txtPropertyOwner.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyOwner.Location = new System.Drawing.Point(170, 31);
            this.txtPropertyOwner.Name = "txtPropertyOwner";
            this.txtPropertyOwner.ReadOnly = true;
            this.txtPropertyOwner.Size = new System.Drawing.Size(373, 27);
            this.txtPropertyOwner.TabIndex = 43;
            this.txtPropertyOwner.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Property Owner: ";
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRentalDetails.Controls.Add(this.dtpEndDate);
            this.grpRentalDetails.Controls.Add(this.label6);
            this.grpRentalDetails.Controls.Add(this.label5);
            this.grpRentalDetails.Controls.Add(this.dtpStartDate);
            this.grpRentalDetails.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRentalDetails.Location = new System.Drawing.Point(13, 313);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Size = new System.Drawing.Size(567, 107);
            this.grpRentalDetails.TabIndex = 44;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            this.grpRentalDetails.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(223, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(287, 27);
            this.dtpEndDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rent End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rent Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(223, 23);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(287, 27);
            this.dtpStartDate.TabIndex = 5;
            // 
            // grdTenants
            // 
            this.grdTenants.AllowUserToAddRows = false;
            this.grdTenants.AllowUserToDeleteRows = false;
            this.grdTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Location = new System.Drawing.Point(14, 88);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.RowHeadersWidth = 51;
            this.grdTenants.RowTemplate.Height = 24;
            this.grdTenants.Size = new System.Drawing.Size(592, 203);
            this.grdTenants.TabIndex = 45;
            this.grdTenants.Visible = false;
            this.grdTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellClick);
            // 
            // btnSRHTenants
            // 
            this.btnSRHTenants.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRHTenants.Location = new System.Drawing.Point(469, 22);
            this.btnSRHTenants.Name = "btnSRHTenants";
            this.btnSRHTenants.Size = new System.Drawing.Size(104, 27);
            this.btnSRHTenants.TabIndex = 8;
            this.btnSRHTenants.Text = "Search Surname";
            this.btnSRHTenants.UseVisualStyleBackColor = true;
            this.btnSRHTenants.Click += new System.EventHandler(this.btnSRHTenants_Click);
            // 
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameSRH.Location = new System.Drawing.Point(237, 22);
            this.txtSurnameSRH.MaxLength = 10;
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(226, 27);
            this.txtSurnameSRH.TabIndex = 7;
            this.txtSurnameSRH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurnameSRH_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Find Tenant By Surname:";
            // 
            // btnCreateRental
            // 
            this.btnCreateRental.Font = new System.Drawing.Font("Leelawadee", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRental.Location = new System.Drawing.Point(12, 426);
            this.btnCreateRental.Name = "btnCreateRental";
            this.btnCreateRental.Size = new System.Drawing.Size(390, 47);
            this.btnCreateRental.TabIndex = 10;
            this.btnCreateRental.Text = "Create Rental";
            this.btnCreateRental.UseVisualStyleBackColor = true;
            this.btnCreateRental.Visible = false;
            this.btnCreateRental.Click += new System.EventHandler(this.btnCreateRental_Click);
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.lblTenants);
            this.grpTenants.Controls.Add(this.label8);
            this.grpTenants.Controls.Add(this.grdTenantsAdded);
            this.grpTenants.Controls.Add(this.btnSRHTenants);
            this.grpTenants.Controls.Add(this.txtSurnameSRH);
            this.grpTenants.Controls.Add(this.label7);
            this.grpTenants.Controls.Add(this.grdTenants);
            this.grpTenants.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTenants.Location = new System.Drawing.Point(586, 12);
            this.grpTenants.Margin = new System.Windows.Forms.Padding(15);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(612, 510);
            this.grpTenants.TabIndex = 50;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Tenants";
            this.grpTenants.Visible = false;
            // 
            // lblTenants
            // 
            this.lblTenants.AutoSize = true;
            this.lblTenants.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenants.Location = new System.Drawing.Point(10, 65);
            this.lblTenants.Name = "lblTenants";
            this.lblTenants.Size = new System.Drawing.Size(253, 20);
            this.lblTenants.TabIndex = 51;
            this.lblTenants.Text = "Click A Tenant to Add to Rental:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tenants Added (Click A Tenant To Remove):";
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
            this.grdTenantsAdded.Location = new System.Drawing.Point(14, 324);
            this.grdTenantsAdded.Name = "grdTenantsAdded";
            this.grdTenantsAdded.RowHeadersWidth = 51;
            this.grdTenantsAdded.RowTemplate.Height = 24;
            this.grdTenantsAdded.Size = new System.Drawing.Size(592, 180);
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
            this.grdProperties.AllowUserToAddRows = false;
            this.grdProperties.AllowUserToDeleteRows = false;
            this.grdProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(3, 146);
            this.grdProperties.Margin = new System.Windows.Forms.Padding(15);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.RowHeadersWidth = 51;
            this.grdProperties.RowTemplate.Height = 24;
            this.grdProperties.Size = new System.Drawing.Size(928, 340);
            this.grdProperties.TabIndex = 51;
            this.grdProperties.Visible = false;
            this.grdProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperties_CellClick);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(408, 426);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 47);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Property Type:";
            // 
            // cboPropertyType
            // 
            this.cboPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropertyType.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPropertyType.FormattingEnabled = true;
            this.cboPropertyType.Location = new System.Drawing.Point(179, 62);
            this.cboPropertyType.Name = "cboPropertyType";
            this.cboPropertyType.Size = new System.Drawing.Size(188, 28);
            this.cboPropertyType.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPropertyType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSRHTown);
            this.groupBox1.Controls.Add(this.txtTownSRH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Rentals";
            // 
            // lblRentals
            // 
            this.lblRentals.AutoSize = true;
            this.lblRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentals.Location = new System.Drawing.Point(8, 125);
            this.lblRentals.Name = "lblRentals";
            this.lblRentals.Size = new System.Drawing.Size(303, 20);
            this.lblRentals.TabIndex = 65;
            this.lblRentals.Text = "Please Select a Rental from list below :";
            this.lblRentals.Visible = false;
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome1.Location = new System.Drawing.Point(191, 125);
            this.btnHome1.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(188, 36);
            this.btnHome1.TabIndex = 4;
            this.btnHome1.Text = "Back To Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // frmRentalNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1210, 564);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.btnCreateRental);
            this.Controls.Add(this.grpPropertyDetails);
            this.Controls.Add(this.grpRentalDetails);
            this.Controls.Add(this.grdProperties);
            this.Controls.Add(this.lblRentals);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblTenants;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPropertyType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRentals;
        private System.Windows.Forms.Button btnHome1;
    }
}