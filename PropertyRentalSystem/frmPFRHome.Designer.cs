
namespace PropertyRentalSystem
{
    partial class frmPFRHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPFRHome));
            this.mnuPFRMainMenu = new System.Windows.Forms.MenuStrip();
            this.ownersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRUpdateProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRAddPropertyType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRUpdatePropertyType = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateRental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateRental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyCommission = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentalsInYear = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuPFRMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPFRMainMenu
            // 
            this.mnuPFRMainMenu.BackColor = System.Drawing.Color.White;
            this.mnuPFRMainMenu.Font = new System.Drawing.Font("Leelawadee", 12F);
            this.mnuPFRMainMenu.GripMargin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.mnuPFRMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPFRMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ownersToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.tenantsToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuPFRMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuPFRMainMenu.Name = "mnuPFRMainMenu";
            this.mnuPFRMainMenu.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.mnuPFRMainMenu.Size = new System.Drawing.Size(782, 32);
            this.mnuPFRMainMenu.TabIndex = 0;
            this.mnuPFRMainMenu.Text = "menuStrip1";
            // 
            // ownersToolStripMenuItem
            // 
            this.ownersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddOwner,
            this.mnuUpdateOwner});
            this.ownersToolStripMenuItem.Name = "ownersToolStripMenuItem";
            this.ownersToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.ownersToolStripMenuItem.Text = "Owners";
            // 
            // mnuAddOwner
            // 
            this.mnuAddOwner.Name = "mnuAddOwner";
            this.mnuAddOwner.Size = new System.Drawing.Size(224, 28);
            this.mnuAddOwner.Text = "Add Owner";
            this.mnuAddOwner.Click += new System.EventHandler(this.mnuAddOwner_Click);
            // 
            // mnuUpdateOwner
            // 
            this.mnuUpdateOwner.Name = "mnuUpdateOwner";
            this.mnuUpdateOwner.Size = new System.Drawing.Size(224, 28);
            this.mnuUpdateOwner.Text = "Update Owner";
            this.mnuUpdateOwner.Click += new System.EventHandler(this.mnuUpdateOwner_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPFRAddProperty,
            this.mnuPFRUpdateProperty,
            this.mnuPFRAddPropertyType,
            this.mnuPFRUpdatePropertyType});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // mnuPFRAddProperty
            // 
            this.mnuPFRAddProperty.Name = "mnuPFRAddProperty";
            this.mnuPFRAddProperty.Size = new System.Drawing.Size(287, 28);
            this.mnuPFRAddProperty.Text = "Add Property";
            this.mnuPFRAddProperty.Click += new System.EventHandler(this.mnuPFRAddProperty_Click);
            // 
            // mnuPFRUpdateProperty
            // 
            this.mnuPFRUpdateProperty.Name = "mnuPFRUpdateProperty";
            this.mnuPFRUpdateProperty.Size = new System.Drawing.Size(287, 28);
            this.mnuPFRUpdateProperty.Text = "Update Property";
            this.mnuPFRUpdateProperty.Click += new System.EventHandler(this.mnuPFRUpdateProperty_Click);
            // 
            // mnuPFRAddPropertyType
            // 
            this.mnuPFRAddPropertyType.Name = "mnuPFRAddPropertyType";
            this.mnuPFRAddPropertyType.Size = new System.Drawing.Size(287, 28);
            this.mnuPFRAddPropertyType.Text = "Add Property Type";
            this.mnuPFRAddPropertyType.Click += new System.EventHandler(this.mnuPFRAddPropertyType_Click);
            // 
            // mnuPFRUpdatePropertyType
            // 
            this.mnuPFRUpdatePropertyType.Name = "mnuPFRUpdatePropertyType";
            this.mnuPFRUpdatePropertyType.Size = new System.Drawing.Size(287, 28);
            this.mnuPFRUpdatePropertyType.Text = "Update Property Type";
            this.mnuPFRUpdatePropertyType.Click += new System.EventHandler(this.mnuPFRUpdatePropertyType_Click);
            // 
            // tenantsToolStripMenuItem
            // 
            this.tenantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddTenant,
            this.mnuUpdateTenant});
            this.tenantsToolStripMenuItem.Name = "tenantsToolStripMenuItem";
            this.tenantsToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.tenantsToolStripMenuItem.Text = "Tenants";
            // 
            // mnuAddTenant
            // 
            this.mnuAddTenant.Name = "mnuAddTenant";
            this.mnuAddTenant.Size = new System.Drawing.Size(224, 28);
            this.mnuAddTenant.Text = "Add Tenant";
            this.mnuAddTenant.Click += new System.EventHandler(this.mnuAddTenant_Click);
            // 
            // mnuUpdateTenant
            // 
            this.mnuUpdateTenant.Name = "mnuUpdateTenant";
            this.mnuUpdateTenant.Size = new System.Drawing.Size(224, 28);
            this.mnuUpdateTenant.Text = "Update Tenant";
            this.mnuUpdateTenant.Click += new System.EventHandler(this.mnuUpdateTenant_Click);
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateRental,
            this.mnuUpdateRental,
            this.mnuRecordPayment});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // mnuCreateRental
            // 
            this.mnuCreateRental.Name = "mnuCreateRental";
            this.mnuCreateRental.Size = new System.Drawing.Size(299, 28);
            this.mnuCreateRental.Text = "Create Rental Contract";
            this.mnuCreateRental.Click += new System.EventHandler(this.mnuCreateRental_Click);
            // 
            // mnuUpdateRental
            // 
            this.mnuUpdateRental.Name = "mnuUpdateRental";
            this.mnuUpdateRental.Size = new System.Drawing.Size(299, 28);
            this.mnuUpdateRental.Text = "Update Rental Contract";
            this.mnuUpdateRental.Click += new System.EventHandler(this.mnuUpdateRental_Click);
            // 
            // mnuRecordPayment
            // 
            this.mnuRecordPayment.Name = "mnuRecordPayment";
            this.mnuRecordPayment.Size = new System.Drawing.Size(299, 28);
            this.mnuRecordPayment.Text = "Record Payment";
            this.mnuRecordPayment.Click += new System.EventHandler(this.mnuRecordPayment_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyCommission,
            this.mnuRentalsInYear});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuYearlyCommission
            // 
            this.mnuYearlyCommission.Name = "mnuYearlyCommission";
            this.mnuYearlyCommission.Size = new System.Drawing.Size(401, 28);
            this.mnuYearlyCommission.Text = "Produce Yearly Commission Report";
            this.mnuYearlyCommission.Click += new System.EventHandler(this.mnuYearlyCommission_Click);
            // 
            // mnuRentalsInYear
            // 
            this.mnuRentalsInYear.Name = "mnuRentalsInYear";
            this.mnuRentalsInYear.Size = new System.Drawing.Size(401, 28);
            this.mnuRentalsInYear.Text = "Produce Rentals In Year Report";
            this.mnuRentalsInYear.Click += new System.EventHandler(this.mnuRentalsInYear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PropertyRentalSystem.Properties.Resources.IKEA_TINY_HOME;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPFRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuPFRMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPFRMainMenu;
            this.Name = "frmPFRHome";
            this.Text = "Perfect Fit Rentals - [ Home ]";
            this.Load += new System.EventHandler(this.frmPFRHome_Load);
            this.mnuPFRMainMenu.ResumeLayout(false);
            this.mnuPFRMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPFRMainMenu;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPFRAddProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuPFRUpdateProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuPFRAddPropertyType;
        private System.Windows.Forms.ToolStripMenuItem mnuPFRUpdatePropertyType;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateRental;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateRental;
        private System.Windows.Forms.ToolStripMenuItem ownersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddOwner;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateOwner;
        private System.Windows.Forms.ToolStripMenuItem tenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTenant;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTenant;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyCommission;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuRentalsInYear;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordPayment;
    }
}

