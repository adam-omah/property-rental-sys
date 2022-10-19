﻿
namespace PropertyRentalSystem
{
    partial class frmAddProperty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxPropertyDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPropertyType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboActiveOwnerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.cboHeatingSource = new System.Windows.Forms.ComboBox();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParkingSpaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnsuiteBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxPropertyDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMonthlyRent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEircode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPropertyName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboPropertyType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboActiveOwnerList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Details";
            // 
            // rtxPropertyDescription
            // 
            this.rtxPropertyDescription.Location = new System.Drawing.Point(8, 239);
            this.rtxPropertyDescription.Name = "rtxPropertyDescription";
            this.rtxPropertyDescription.Size = new System.Drawing.Size(480, 122);
            this.rtxPropertyDescription.TabIndex = 11;
            this.rtxPropertyDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Property Description: ";
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(158, 186);
            this.txtMonthlyRent.MaxLength = 16;
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.Size = new System.Drawing.Size(150, 22);
            this.txtMonthlyRent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monthly Rental Price: ";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(120, 151);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(188, 22);
            this.txtEircode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eircode: ";
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(184, 113);
            this.txtPropertyName.MaxLength = 100;
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(290, 22);
            this.txtPropertyName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Property Name or Number:";
            // 
            // cboPropertyType
            // 
            this.cboPropertyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropertyType.FormattingEnabled = true;
            this.cboPropertyType.Location = new System.Drawing.Point(120, 76);
            this.cboPropertyType.Name = "cboPropertyType";
            this.cboPropertyType.Size = new System.Drawing.Size(188, 24);
            this.cboPropertyType.Sorted = true;
            this.cboPropertyType.TabIndex = 3;
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
            // cboActiveOwnerList
            // 
            this.cboActiveOwnerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActiveOwnerList.FormattingEnabled = true;
            this.cboActiveOwnerList.Location = new System.Drawing.Point(120, 40);
            this.cboActiveOwnerList.Name = "cboActiveOwnerList";
            this.cboActiveOwnerList.Size = new System.Drawing.Size(354, 24);
            this.cboActiveOwnerList.Sorted = true;
            this.cboActiveOwnerList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Owner: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOwnerOccupied);
            this.groupBox2.Controls.Add(this.chkPetsAllowed);
            this.groupBox2.Controls.Add(this.chkHasWifi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.chkGardenSpace);
            this.groupBox2.Controls.Add(this.numParkingSpaces);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numTotalBathrooms);
            this.groupBox2.Controls.Add(this.numEnsuiteBedrooms);
            this.groupBox2.Controls.Add(this.numTotalBedrooms);
            this.groupBox2.Controls.Add(this.numTotalRooms);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(19, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Extras";
            // 
            // chkOwnerOccupied
            // 
            this.chkOwnerOccupied.AutoSize = true;
            this.chkOwnerOccupied.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOwnerOccupied.Location = new System.Drawing.Point(352, 126);
            this.chkOwnerOccupied.Name = "chkOwnerOccupied";
            this.chkOwnerOccupied.Size = new System.Drawing.Size(139, 21);
            this.chkOwnerOccupied.TabIndex = 15;
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
            this.chkPetsAllowed.TabIndex = 14;
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
            this.chkHasWifi.TabIndex = 13;
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
            this.chkGardenSpace.TabIndex = 11;
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
            this.numParkingSpaces.TabIndex = 10;
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
            this.numTotalBathrooms.TabIndex = 7;
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
            this.numEnsuiteBedrooms.TabIndex = 6;
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
            this.numTotalBedrooms.TabIndex = 5;
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
            this.numTotalRooms.TabIndex = 4;
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
            // cboHeatingSource
            // 
            this.cboHeatingSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeatingSource.FormattingEnabled = true;
            this.cboHeatingSource.Location = new System.Drawing.Point(371, 444);
            this.cboHeatingSource.Name = "cboHeatingSource";
            this.cboHeatingSource.Size = new System.Drawing.Size(136, 24);
            this.cboHeatingSource.Sorted = true;
            this.cboHeatingSource.TabIndex = 12;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(168, 543);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(232, 28);
            this.btnAddProperty.TabIndex = 13;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // frmAddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 583);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.cboHeatingSource);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddProperty";
            this.Text = "Perfect Fit Rentals - [Add Property]";
            this.Load += new System.EventHandler(this.frmAddProperty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParkingSpaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnsuiteBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboActiveOwnerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPropertyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.RichTextBox rtxPropertyDescription;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.ComboBox cboHeatingSource;
        private System.Windows.Forms.CheckBox chkOwnerOccupied;
        private System.Windows.Forms.CheckBox chkPetsAllowed;
        private System.Windows.Forms.CheckBox chkHasWifi;
        private System.Windows.Forms.Button btnAddProperty;
    }
}