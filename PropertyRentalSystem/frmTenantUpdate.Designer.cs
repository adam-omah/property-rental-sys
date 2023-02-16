
namespace PropertyRentalSystem
{
    partial class frmTenantUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTenantUpdate));
            this.grpTenant = new System.Windows.Forms.GroupBox();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTenantStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateTenantDetails = new System.Windows.Forms.Button();
            this.txtTenantIban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSurnameSRH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTenant
            // 
            this.grpTenant.Controls.Add(this.btnHome);
            this.grpTenant.Controls.Add(this.txtTenantID);
            this.grpTenant.Controls.Add(this.label9);
            this.grpTenant.Controls.Add(this.cboTenantStatus);
            this.grpTenant.Controls.Add(this.label8);
            this.grpTenant.Controls.Add(this.btnUpdateTenantDetails);
            this.grpTenant.Controls.Add(this.txtTenantIban);
            this.grpTenant.Controls.Add(this.label6);
            this.grpTenant.Controls.Add(this.txtEmailAddress);
            this.grpTenant.Controls.Add(this.txtPhoneNumber);
            this.grpTenant.Controls.Add(this.txtLastName);
            this.grpTenant.Controls.Add(this.txtFirstName);
            this.grpTenant.Controls.Add(this.label4);
            this.grpTenant.Controls.Add(this.label3);
            this.grpTenant.Controls.Add(this.label2);
            this.grpTenant.Controls.Add(this.label7);
            this.grpTenant.Location = new System.Drawing.Point(15, 85);
            this.grpTenant.Name = "grpTenant";
            this.grpTenant.Size = new System.Drawing.Size(387, 383);
            this.grpTenant.TabIndex = 9;
            this.grpTenant.TabStop = false;
            this.grpTenant.Text = "Tenant Details";
            this.grpTenant.Visible = false;
            // 
            // txtTenantID
            // 
            this.txtTenantID.Location = new System.Drawing.Point(125, 37);
            this.txtTenantID.MaxLength = 60;
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.ReadOnly = true;
            this.txtTenantID.Size = new System.Drawing.Size(235, 22);
            this.txtTenantID.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tenant ID: ";
            // 
            // cboTenantStatus
            // 
            this.cboTenantStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenantStatus.FormattingEnabled = true;
            this.cboTenantStatus.Location = new System.Drawing.Point(139, 269);
            this.cboTenantStatus.Name = "cboTenantStatus";
            this.cboTenantStatus.Size = new System.Drawing.Size(222, 24);
            this.cboTenantStatus.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tenant Status:";
            // 
            // btnUpdateTenantDetails
            // 
            this.btnUpdateTenantDetails.Location = new System.Drawing.Point(6, 339);
            this.btnUpdateTenantDetails.Name = "btnUpdateTenantDetails";
            this.btnUpdateTenantDetails.Size = new System.Drawing.Size(226, 38);
            this.btnUpdateTenantDetails.TabIndex = 13;
            this.btnUpdateTenantDetails.Text = "Update Tenant Details";
            this.btnUpdateTenantDetails.UseVisualStyleBackColor = true;
            this.btnUpdateTenantDetails.Click += new System.EventHandler(this.btnUpdateTenantDetails_Click);
            // 
            // txtTenantIban
            // 
            this.txtTenantIban.Location = new System.Drawing.Point(89, 236);
            this.txtTenantIban.MaxLength = 34;
            this.txtTenantIban.Name = "txtTenantIban";
            this.txtTenantIban.Size = new System.Drawing.Size(272, 22);
            this.txtTenantIban.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "IBAN: ";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(145, 199);
            this.txtEmailAddress.MaxLength = 100;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(215, 22);
            this.txtEmailAddress.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(172, 155);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(126, 115);
            this.txtLastName.MaxLength = 80;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(126, 74);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "First Name: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Location = new System.Drawing.Point(150, 31);
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(180, 22);
            this.txtSurnameSRH.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tenant Surname";
            // 
            // grdTenants
            // 
            this.grdTenants.AllowUserToAddRows = false;
            this.grdTenants.AllowUserToDeleteRows = false;
            this.grdTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Location = new System.Drawing.Point(-2, 123);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.RowHeadersWidth = 51;
            this.grdTenants.RowTemplate.Height = 24;
            this.grdTenants.Size = new System.Drawing.Size(776, 192);
            this.grdTenants.TabIndex = 8;
            this.grdTenants.Visible = false;
            this.grdTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellClick);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(238, 340);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(143, 37);
            this.btnHome.TabIndex = 57;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // frmTenantUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 540);
            this.Controls.Add(this.grpTenant);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSurnameSRH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTenants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTenantUpdate";
            this.Text = "Perfect Fit Rentals - [Update Tenant]";
            this.Load += new System.EventHandler(this.frmTenantUpdate_Load);
            this.grpTenant.ResumeLayout(false);
            this.grpTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTenant;
        private System.Windows.Forms.ComboBox cboTenantStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateTenantDetails;
        private System.Windows.Forms.TextBox txtTenantIban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSurnameSRH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHome;
    }
}