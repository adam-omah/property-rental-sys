
namespace PropertyRentalSystem
{
    partial class frmOwnerUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurnameSRH = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOwner = new System.Windows.Forms.GroupBox();
            this.txtOwnerIban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHomeEircode = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateOwnerDetails = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboOwnerStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.grpOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Surname";
            // 
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Location = new System.Drawing.Point(332, 33);
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(180, 22);
            this.txtSurnameSRH.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(542, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(75, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // grdOwners
            // 
            this.grdOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.phone,
            this.id});
            this.grdOwners.Location = new System.Drawing.Point(12, 102);
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.RowHeadersWidth = 51;
            this.grdOwners.RowTemplate.Height = 24;
            this.grdOwners.Size = new System.Drawing.Size(776, 192);
            this.grdOwners.TabIndex = 3;
            this.grdOwners.Visible = false;
            this.grdOwners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOwners_CellClick);
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
            this.id.HeaderText = "Owner Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // grpOwner
            // 
            this.grpOwner.Controls.Add(this.cboOwnerStatus);
            this.grpOwner.Controls.Add(this.label8);
            this.grpOwner.Controls.Add(this.btnUpdateOwnerDetails);
            this.grpOwner.Controls.Add(this.txtOwnerIban);
            this.grpOwner.Controls.Add(this.label6);
            this.grpOwner.Controls.Add(this.txtHomeEircode);
            this.grpOwner.Controls.Add(this.txtEmailAddress);
            this.grpOwner.Controls.Add(this.txtPhoneNumber);
            this.grpOwner.Controls.Add(this.txtLastName);
            this.grpOwner.Controls.Add(this.txtFirstName);
            this.grpOwner.Controls.Add(this.label5);
            this.grpOwner.Controls.Add(this.label4);
            this.grpOwner.Controls.Add(this.label3);
            this.grpOwner.Controls.Add(this.label2);
            this.grpOwner.Controls.Add(this.label7);
            this.grpOwner.Location = new System.Drawing.Point(230, 102);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(387, 383);
            this.grpOwner.TabIndex = 4;
            this.grpOwner.TabStop = false;
            this.grpOwner.Text = "Owner Details";
            this.grpOwner.Visible = false;
            // 
            // txtOwnerIban
            // 
            this.txtOwnerIban.Location = new System.Drawing.Point(84, 235);
            this.txtOwnerIban.MaxLength = 34;
            this.txtOwnerIban.Name = "txtOwnerIban";
            this.txtOwnerIban.Size = new System.Drawing.Size(272, 22);
            this.txtOwnerIban.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "IBAN: ";
            // 
            // txtHomeEircode
            // 
            this.txtHomeEircode.Location = new System.Drawing.Point(140, 192);
            this.txtHomeEircode.MaxLength = 7;
            this.txtHomeEircode.Name = "txtHomeEircode";
            this.txtHomeEircode.Size = new System.Drawing.Size(122, 22);
            this.txtHomeEircode.TabIndex = 10;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(140, 161);
            this.txtEmailAddress.MaxLength = 100;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(215, 22);
            this.txtEmailAddress.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(167, 117);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(121, 77);
            this.txtLastName.MaxLength = 80;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(121, 36);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Home Eircode: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "First Name: ";
            // 
            // btnUpdateOwnerDetails
            // 
            this.btnUpdateOwnerDetails.Location = new System.Drawing.Point(102, 327);
            this.btnUpdateOwnerDetails.Name = "btnUpdateOwnerDetails";
            this.btnUpdateOwnerDetails.Size = new System.Drawing.Size(199, 38);
            this.btnUpdateOwnerDetails.TabIndex = 13;
            this.btnUpdateOwnerDetails.Text = "Update Owner Details";
            this.btnUpdateOwnerDetails.UseVisualStyleBackColor = true;
            this.btnUpdateOwnerDetails.Click += new System.EventHandler(this.btnUpdateOwnerDetails_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Owner Status:";
            // 
            // cboOwnerStatus
            // 
            this.cboOwnerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOwnerStatus.FormattingEnabled = true;
            this.cboOwnerStatus.Location = new System.Drawing.Point(134, 268);
            this.cboOwnerStatus.Name = "cboOwnerStatus";
            this.cboOwnerStatus.Size = new System.Drawing.Size(211, 24);
            this.cboOwnerStatus.TabIndex = 15;
            // 
            // frmOwnerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.grpOwner);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSurnameSRH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdOwners);
            this.Name = "frmOwnerUpdate";
            this.Text = "frmOwnerUpdate";
            this.Load += new System.EventHandler(this.frmOwnerUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).EndInit();
            this.grpOwner.ResumeLayout(false);
            this.grpOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurnameSRH;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.DataGridView grdOwners;
        private System.Windows.Forms.GroupBox grpOwner;
        private System.Windows.Forms.TextBox txtOwnerIban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHomeEircode;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ComboBox cboOwnerStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateOwnerDetails;
    }
}