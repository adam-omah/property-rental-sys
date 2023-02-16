
namespace PropertyRentalSystem
{
    partial class frmPropertyAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyAdd));
            this.grpPropertyDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPropertyOwner = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtxPropertyDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPropertyType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPropertyExtras = new System.Windows.Forms.GroupBox();
            this.cboHeatingSource = new System.Windows.Forms.ComboBox();
            this.chkOwnerOccupied = new System.Windows.Forms.CheckBox();
            this.chkPetsAllowed = new System.Windows.Forms.CheckBox();
            this.chkHasWifi = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkGardenSpace = new System.Windows.Forms.CheckBox();
            this.numParkingSpaces = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numTotalBathrooms = new System.Windows.Forms.NumericUpDown();
            this.numEnsuiteBedrooms = new System.Windows.Forms.NumericUpDown();
            this.numTotalBedrooms = new System.Windows.Forms.NumericUpDown();
            this.numTotalRooms = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnSurnameSRH = new System.Windows.Forms.Button();
            this.txtSurnameSRH = new System.Windows.Forms.TextBox();
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpPropertyDetails.SuspendLayout();
            this.grpPropertyExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParkingSpaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnsuiteBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPropertyDetails
            // 
            this.grpPropertyDetails.Controls.Add(this.txtAddress);
            this.grpPropertyDetails.Controls.Add(this.label14);
            this.grpPropertyDetails.Controls.Add(this.txtPropertyOwner);
            this.grpPropertyDetails.Controls.Add(this.label13);
            this.grpPropertyDetails.Controls.Add(this.rtxPropertyDescription);
            this.grpPropertyDetails.Controls.Add(this.label6);
            this.grpPropertyDetails.Controls.Add(this.txtMonthlyRent);
            this.grpPropertyDetails.Controls.Add(this.label5);
            this.grpPropertyDetails.Controls.Add(this.txtEircode);
            this.grpPropertyDetails.Controls.Add(this.label4);
            this.grpPropertyDetails.Controls.Add(this.txtTown);
            this.grpPropertyDetails.Controls.Add(this.label3);
            this.grpPropertyDetails.Controls.Add(this.cboPropertyType);
            this.grpPropertyDetails.Controls.Add(this.label2);
            this.grpPropertyDetails.Location = new System.Drawing.Point(26, 67);
            this.grpPropertyDetails.Name = "grpPropertyDetails";
            this.grpPropertyDetails.Size = new System.Drawing.Size(520, 391);
            this.grpPropertyDetails.TabIndex = 4;
            this.grpPropertyDetails.TabStop = false;
            this.grpPropertyDetails.Text = "Property Details";
            this.grpPropertyDetails.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 143);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 22);
            this.txtAddress.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Street Address :";
            // 
            // txtPropertyOwner
            // 
            this.txtPropertyOwner.Location = new System.Drawing.Point(120, 40);
            this.txtPropertyOwner.Name = "txtPropertyOwner";
            this.txtPropertyOwner.ReadOnly = true;
            this.txtPropertyOwner.Size = new System.Drawing.Size(354, 22);
            this.txtPropertyOwner.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Property Owner: ";
            // 
            // rtxPropertyDescription
            // 
            this.rtxPropertyDescription.Location = new System.Drawing.Point(8, 266);
            this.rtxPropertyDescription.Name = "rtxPropertyDescription";
            this.rtxPropertyDescription.Size = new System.Drawing.Size(480, 111);
            this.rtxPropertyDescription.TabIndex = 10;
            this.rtxPropertyDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Property Description: ";
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(158, 209);
            this.txtMonthlyRent.MaxLength = 9;
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.Size = new System.Drawing.Size(150, 22);
            this.txtMonthlyRent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monthly Rental Price: ";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(120, 174);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(188, 22);
            this.txtEircode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eircode: ";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(120, 115);
            this.txtTown.MaxLength = 50;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(290, 22);
            this.txtTown.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Town:";
            // 
            // cboPropertyType
            // 
            this.cboPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropertyType.FormattingEnabled = true;
            this.cboPropertyType.Location = new System.Drawing.Point(120, 76);
            this.cboPropertyType.Name = "cboPropertyType";
            this.cboPropertyType.Size = new System.Drawing.Size(188, 24);
            this.cboPropertyType.Sorted = true;
            this.cboPropertyType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Surname: ";
            // 
            // grpPropertyExtras
            // 
            this.grpPropertyExtras.Controls.Add(this.cboHeatingSource);
            this.grpPropertyExtras.Controls.Add(this.chkOwnerOccupied);
            this.grpPropertyExtras.Controls.Add(this.chkPetsAllowed);
            this.grpPropertyExtras.Controls.Add(this.chkHasWifi);
            this.grpPropertyExtras.Controls.Add(this.label11);
            this.grpPropertyExtras.Controls.Add(this.chkGardenSpace);
            this.grpPropertyExtras.Controls.Add(this.numParkingSpaces);
            this.grpPropertyExtras.Controls.Add(this.label12);
            this.grpPropertyExtras.Controls.Add(this.numTotalBathrooms);
            this.grpPropertyExtras.Controls.Add(this.numEnsuiteBedrooms);
            this.grpPropertyExtras.Controls.Add(this.numTotalBedrooms);
            this.grpPropertyExtras.Controls.Add(this.numTotalRooms);
            this.grpPropertyExtras.Controls.Add(this.label10);
            this.grpPropertyExtras.Controls.Add(this.label9);
            this.grpPropertyExtras.Controls.Add(this.label8);
            this.grpPropertyExtras.Controls.Add(this.label7);
            this.grpPropertyExtras.Location = new System.Drawing.Point(27, 475);
            this.grpPropertyExtras.Name = "grpPropertyExtras";
            this.grpPropertyExtras.Size = new System.Drawing.Size(521, 153);
            this.grpPropertyExtras.TabIndex = 11;
            this.grpPropertyExtras.TabStop = false;
            this.grpPropertyExtras.Text = "Property Extras";
            this.grpPropertyExtras.Visible = false;
            // 
            // cboHeatingSource
            // 
            this.cboHeatingSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeatingSource.FormattingEnabled = true;
            this.cboHeatingSource.ItemHeight = 16;
            this.cboHeatingSource.Location = new System.Drawing.Point(352, 57);
            this.cboHeatingSource.Name = "cboHeatingSource";
            this.cboHeatingSource.Size = new System.Drawing.Size(136, 24);
            this.cboHeatingSource.Sorted = true;
            this.cboHeatingSource.TabIndex = 17;
            // 
            // chkOwnerOccupied
            // 
            this.chkOwnerOccupied.AutoSize = true;
            this.chkOwnerOccupied.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOwnerOccupied.Location = new System.Drawing.Point(352, 126);
            this.chkOwnerOccupied.Name = "chkOwnerOccupied";
            this.chkOwnerOccupied.Size = new System.Drawing.Size(139, 21);
            this.chkOwnerOccupied.TabIndex = 21;
            this.chkOwnerOccupied.Text = "Owner Occupied:";
            this.chkOwnerOccupied.UseVisualStyleBackColor = true;
            // 
            // chkPetsAllowed
            // 
            this.chkPetsAllowed.AutoSize = true;
            this.chkPetsAllowed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPetsAllowed.Location = new System.Drawing.Point(232, 126);
            this.chkPetsAllowed.Name = "chkPetsAllowed";
            this.chkPetsAllowed.Size = new System.Drawing.Size(114, 21);
            this.chkPetsAllowed.TabIndex = 20;
            this.chkPetsAllowed.Text = "Pets Allowed:";
            this.chkPetsAllowed.UseVisualStyleBackColor = true;
            // 
            // chkHasWifi
            // 
            this.chkHasWifi.AutoSize = true;
            this.chkHasWifi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasWifi.Location = new System.Drawing.Point(363, 90);
            this.chkHasWifi.Name = "chkHasWifi";
            this.chkHasWifi.Size = new System.Drawing.Size(114, 21);
            this.chkHasWifi.TabIndex = 19;
            this.chkHasWifi.Text = "Wifi Included:";
            this.chkHasWifi.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Heating Source: ";
            // 
            // chkGardenSpace
            // 
            this.chkGardenSpace.AutoSize = true;
            this.chkGardenSpace.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGardenSpace.Location = new System.Drawing.Point(228, 90);
            this.chkGardenSpace.Name = "chkGardenSpace";
            this.chkGardenSpace.Size = new System.Drawing.Size(126, 21);
            this.chkGardenSpace.TabIndex = 18;
            this.chkGardenSpace.Text = "Garden Space:";
            this.chkGardenSpace.UseVisualStyleBackColor = true;
            // 
            // numParkingSpaces
            // 
            this.numParkingSpaces.Location = new System.Drawing.Point(361, 29);
            this.numParkingSpaces.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numParkingSpaces.Name = "numParkingSpaces";
            this.numParkingSpaces.Size = new System.Drawing.Size(57, 22);
            this.numParkingSpaces.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Parking Spaces: ";
            // 
            // numTotalBathrooms
            // 
            this.numTotalBathrooms.Location = new System.Drawing.Point(137, 91);
            this.numTotalBathrooms.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTotalBathrooms.Name = "numTotalBathrooms";
            this.numTotalBathrooms.Size = new System.Drawing.Size(57, 22);
            this.numTotalBathrooms.TabIndex = 14;
            // 
            // numEnsuiteBedrooms
            // 
            this.numEnsuiteBedrooms.Location = new System.Drawing.Point(137, 119);
            this.numEnsuiteBedrooms.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numEnsuiteBedrooms.Name = "numEnsuiteBedrooms";
            this.numEnsuiteBedrooms.Size = new System.Drawing.Size(57, 22);
            this.numEnsuiteBedrooms.TabIndex = 15;
            // 
            // numTotalBedrooms
            // 
            this.numTotalBedrooms.Location = new System.Drawing.Point(137, 58);
            this.numTotalBedrooms.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTotalBedrooms.Name = "numTotalBedrooms";
            this.numTotalBedrooms.Size = new System.Drawing.Size(57, 22);
            this.numTotalBedrooms.TabIndex = 13;
            // 
            // numTotalRooms
            // 
            this.numTotalRooms.Location = new System.Drawing.Point(137, 27);
            this.numTotalRooms.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTotalRooms.Name = "numTotalRooms";
            this.numTotalRooms.Size = new System.Drawing.Size(57, 22);
            this.numTotalRooms.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Bathrooms: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ensuite Bedrooms: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Bedooms: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Rooms: ";
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(26, 634);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(329, 28);
            this.btnAddProperty.TabIndex = 22;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Visible = false;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnSurnameSRH
            // 
            this.btnSurnameSRH.Location = new System.Drawing.Point(398, 23);
            this.btnSurnameSRH.Name = "btnSurnameSRH";
            this.btnSurnameSRH.Size = new System.Drawing.Size(75, 23);
            this.btnSurnameSRH.TabIndex = 2;
            this.btnSurnameSRH.Text = "Search Surname";
            this.btnSurnameSRH.UseVisualStyleBackColor = true;
            this.btnSurnameSRH.Click += new System.EventHandler(this.btnSurnameSRH_Click);
            // 
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Location = new System.Drawing.Point(192, 24);
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(180, 22);
            this.txtSurnameSRH.TabIndex = 1;
            // 
            // grdOwners
            // 
            this.grdOwners.AllowUserToAddRows = false;
            this.grdOwners.AllowUserToDeleteRows = false;
            this.grdOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOwners.Location = new System.Drawing.Point(12, 55);
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.RowHeadersWidth = 51;
            this.grdOwners.RowTemplate.Height = 24;
            this.grdOwners.Size = new System.Drawing.Size(554, 192);
            this.grdOwners.TabIndex = 3;
            this.grdOwners.Visible = false;
            this.grdOwners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOwners_CellClick_1);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(361, 634);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(187, 28);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmPropertyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 668);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtSurnameSRH);
            this.Controls.Add(this.btnSurnameSRH);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.grpPropertyExtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpPropertyDetails);
            this.Controls.Add(this.grdOwners);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPropertyAdd";
            this.Text = "Perfect Fit Rentals - [Add Property]";
            this.Load += new System.EventHandler(this.frmAddProperty_Load);
            this.grpPropertyDetails.ResumeLayout(false);
            this.grpPropertyDetails.PerformLayout();
            this.grpPropertyExtras.ResumeLayout(false);
            this.grpPropertyExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParkingSpaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnsuiteBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPropertyDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPropertyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.RichTextBox rtxPropertyDescription;
        private System.Windows.Forms.GroupBox grpPropertyExtras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numTotalBathrooms;
        private System.Windows.Forms.NumericUpDown numEnsuiteBedrooms;
        private System.Windows.Forms.NumericUpDown numTotalBedrooms;
        private System.Windows.Forms.NumericUpDown numTotalRooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkGardenSpace;
        private System.Windows.Forms.NumericUpDown numParkingSpaces;
        private System.Windows.Forms.CheckBox chkOwnerOccupied;
        private System.Windows.Forms.CheckBox chkPetsAllowed;
        private System.Windows.Forms.CheckBox chkHasWifi;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSurnameSRH;
        private System.Windows.Forms.ComboBox cboHeatingSource;
        private System.Windows.Forms.TextBox txtSurnameSRH;
        private System.Windows.Forms.TextBox txtPropertyOwner;
        private System.Windows.Forms.DataGridView grdOwners;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHome;
    }
}