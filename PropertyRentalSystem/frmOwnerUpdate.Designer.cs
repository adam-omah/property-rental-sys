
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOwnerUpdate));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurnameSRH = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.grpOwner = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboOwnerStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdateOwnerDetails = new System.Windows.Forms.Button();
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
            this.lblOwners = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.grpOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Surname";
            // 
            // txtSurnameSRH
            // 
            this.txtSurnameSRH.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameSRH.Location = new System.Drawing.Point(161, 37);
            this.txtSurnameSRH.Margin = new System.Windows.Forms.Padding(10);
            this.txtSurnameSRH.Name = "txtSurnameSRH";
            this.txtSurnameSRH.Size = new System.Drawing.Size(180, 27);
            this.txtSurnameSRH.TabIndex = 1;
            this.txtSurnameSRH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurnameSRH_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(356, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdOwners
            // 
            this.grdOwners.AllowUserToAddRows = false;
            this.grdOwners.AllowUserToDeleteRows = false;
            this.grdOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOwners.Location = new System.Drawing.Point(12, 102);
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.RowHeadersWidth = 51;
            this.grdOwners.RowTemplate.Height = 24;
            this.grdOwners.Size = new System.Drawing.Size(800, 200);
            this.grdOwners.TabIndex = 20;
            this.grdOwners.Visible = false;
            this.grdOwners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOwners_CellClick);
            // 
            // grpOwner
            // 
            this.grpOwner.Controls.Add(this.btnHome);
            this.grpOwner.Controls.Add(this.txtOwnerID);
            this.grpOwner.Controls.Add(this.label9);
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
            this.grpOwner.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOwner.Location = new System.Drawing.Point(2, 86);
            this.grpOwner.Margin = new System.Windows.Forms.Padding(15);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(457, 408);
            this.grpOwner.TabIndex = 4;
            this.grpOwner.TabStop = false;
            this.grpOwner.Text = "Owner Details";
            this.grpOwner.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Location = new System.Drawing.Point(282, 354);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 38);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerID.Location = new System.Drawing.Point(183, 31);
            this.txtOwnerID.MaxLength = 60;
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.ReadOnly = true;
            this.txtOwnerID.Size = new System.Drawing.Size(235, 27);
            this.txtOwnerID.TabIndex = 17;
            this.txtOwnerID.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Owner ID: ";
            // 
            // cboOwnerStatus
            // 
            this.cboOwnerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOwnerStatus.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOwnerStatus.FormattingEnabled = true;
            this.cboOwnerStatus.Location = new System.Drawing.Point(208, 312);
            this.cboOwnerStatus.Name = "cboOwnerStatus";
            this.cboOwnerStatus.Size = new System.Drawing.Size(211, 28);
            this.cboOwnerStatus.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Owner Status:";
            // 
            // btnUpdateOwnerDetails
            // 
            this.btnUpdateOwnerDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateOwnerDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdateOwnerDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateOwnerDetails.FlatAppearance.BorderSize = 2;
            this.btnUpdateOwnerDetails.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOwnerDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateOwnerDetails.Location = new System.Drawing.Point(10, 354);
            this.btnUpdateOwnerDetails.Name = "btnUpdateOwnerDetails";
            this.btnUpdateOwnerDetails.Size = new System.Drawing.Size(266, 38);
            this.btnUpdateOwnerDetails.TabIndex = 10;
            this.btnUpdateOwnerDetails.Text = "Update Owner Details";
            this.btnUpdateOwnerDetails.UseVisualStyleBackColor = false;
            this.btnUpdateOwnerDetails.Click += new System.EventHandler(this.btnUpdateOwnerDetails_Click);
            // 
            // txtOwnerIban
            // 
            this.txtOwnerIban.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerIban.Location = new System.Drawing.Point(123, 272);
            this.txtOwnerIban.MaxLength = 34;
            this.txtOwnerIban.Name = "txtOwnerIban";
            this.txtOwnerIban.Size = new System.Drawing.Size(296, 27);
            this.txtOwnerIban.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "IBAN: ";
            // 
            // txtHomeEircode
            // 
            this.txtHomeEircode.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeEircode.Location = new System.Drawing.Point(203, 222);
            this.txtHomeEircode.MaxLength = 7;
            this.txtHomeEircode.Name = "txtHomeEircode";
            this.txtHomeEircode.Size = new System.Drawing.Size(159, 27);
            this.txtHomeEircode.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(203, 181);
            this.txtEmailAddress.MaxLength = 100;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(215, 27);
            this.txtEmailAddress.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(230, 147);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(189, 27);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(184, 107);
            this.txtLastName.MaxLength = 80;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 27);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(184, 66);
            this.txtFirstName.MaxLength = 60;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 27);
            this.txtFirstName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Home Eircode: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "First Name: ";
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwners.Location = new System.Drawing.Point(12, 69);
            this.lblOwners.Margin = new System.Windows.Forms.Padding(10);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(281, 20);
            this.lblOwners.TabIndex = 21;
            this.lblOwners.Text = "Please Click on an owner to select : ";
            this.lblOwners.Visible = false;
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome1.Location = new System.Drawing.Point(161, 69);
            this.btnHome1.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(180, 40);
            this.btnHome1.TabIndex = 22;
            this.btnHome1.Text = "Back To Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // frmOwnerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(821, 521);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.lblOwners);
            this.Controls.Add(this.grpOwner);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSurnameSRH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdOwners);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOwnerUpdate";
            this.Text = "PFR - [Update Owner]";
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
        private System.Windows.Forms.Button btnSearch;
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
        private System.Windows.Forms.ComboBox cboOwnerStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdateOwnerDetails;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblOwners;
        private System.Windows.Forms.Button btnHome1;
    }
}