
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
            this.mnuPFRMainMenu = new System.Windows.Forms.MenuStrip();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRUpdateProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRAddPropertyType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPFRUpdatePropertyType = new System.Windows.Forms.ToolStripMenuItem();
            this.ownersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateRental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateRental = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyProfitAndLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.produceEstateAgentEarningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddEstateAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateEstateAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuPFRMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPFRMainMenu
            // 
            this.mnuPFRMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPFRMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.ownersToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.tenantsToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuPFRMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuPFRMainMenu.Name = "mnuPFRMainMenu";
            this.mnuPFRMainMenu.Size = new System.Drawing.Size(610, 28);
            this.mnuPFRMainMenu.TabIndex = 0;
            this.mnuPFRMainMenu.Text = "menuStrip1";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPFRAddProperty,
            this.mnuPFRUpdateProperty,
            this.mnuPFRAddPropertyType,
            this.mnuPFRUpdatePropertyType});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // mnuPFRAddProperty
            // 
            this.mnuPFRAddProperty.Name = "mnuPFRAddProperty";
            this.mnuPFRAddProperty.Size = new System.Drawing.Size(236, 26);
            this.mnuPFRAddProperty.Text = "Add Property";
            this.mnuPFRAddProperty.Click += new System.EventHandler(this.mnuPFRAddProperty_Click);
            // 
            // mnuPFRUpdateProperty
            // 
            this.mnuPFRUpdateProperty.Name = "mnuPFRUpdateProperty";
            this.mnuPFRUpdateProperty.Size = new System.Drawing.Size(236, 26);
            this.mnuPFRUpdateProperty.Text = "Update Property";
            // 
            // mnuPFRAddPropertyType
            // 
            this.mnuPFRAddPropertyType.Name = "mnuPFRAddPropertyType";
            this.mnuPFRAddPropertyType.Size = new System.Drawing.Size(236, 26);
            this.mnuPFRAddPropertyType.Text = "Add Property Type";
            this.mnuPFRAddPropertyType.Click += new System.EventHandler(this.mnuPFRAddPropertyType_Click);
            // 
            // mnuPFRUpdatePropertyType
            // 
            this.mnuPFRUpdatePropertyType.Name = "mnuPFRUpdatePropertyType";
            this.mnuPFRUpdatePropertyType.Size = new System.Drawing.Size(236, 26);
            this.mnuPFRUpdatePropertyType.Text = "Update Property Type";
            // 
            // ownersToolStripMenuItem
            // 
            this.ownersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddOwner,
            this.mnuUpdateOwner});
            this.ownersToolStripMenuItem.Name = "ownersToolStripMenuItem";
            this.ownersToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ownersToolStripMenuItem.Text = "Owners";
            // 
            // mnuAddOwner
            // 
            this.mnuAddOwner.Name = "mnuAddOwner";
            this.mnuAddOwner.Size = new System.Drawing.Size(188, 26);
            this.mnuAddOwner.Text = "Add Owner";
            this.mnuAddOwner.Click += new System.EventHandler(this.mnuAddOwner_Click);
            // 
            // mnuUpdateOwner
            // 
            this.mnuUpdateOwner.Name = "mnuUpdateOwner";
            this.mnuUpdateOwner.Size = new System.Drawing.Size(188, 26);
            this.mnuUpdateOwner.Text = "Update Owner";
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateRental,
            this.mnuUpdateRental});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // mnuCreateRental
            // 
            this.mnuCreateRental.Name = "mnuCreateRental";
            this.mnuCreateRental.Size = new System.Drawing.Size(247, 26);
            this.mnuCreateRental.Text = "Create Rental Contract";
            // 
            // mnuUpdateRental
            // 
            this.mnuUpdateRental.Name = "mnuUpdateRental";
            this.mnuUpdateRental.Size = new System.Drawing.Size(247, 26);
            this.mnuUpdateRental.Text = "Update Rental Contract";
            // 
            // tenantsToolStripMenuItem
            // 
            this.tenantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddTenant,
            this.mnuUpdateTenant});
            this.tenantsToolStripMenuItem.Name = "tenantsToolStripMenuItem";
            this.tenantsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.tenantsToolStripMenuItem.Text = "Tenants";
            // 
            // mnuAddTenant
            // 
            this.mnuAddTenant.Name = "mnuAddTenant";
            this.mnuAddTenant.Size = new System.Drawing.Size(189, 26);
            this.mnuAddTenant.Text = "Add Tenant";
            // 
            // mnuUpdateTenant
            // 
            this.mnuUpdateTenant.Name = "mnuUpdateTenant";
            this.mnuUpdateTenant.Size = new System.Drawing.Size(189, 26);
            this.mnuUpdateTenant.Text = "Update Tenant";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyProfitAndLoss,
            this.produceEstateAgentEarningsToolStripMenuItem,
            this.mnuAddEstateAgent,
            this.mnuUpdateEstateAgent});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuYearlyProfitAndLoss
            // 
            this.mnuYearlyProfitAndLoss.Name = "mnuYearlyProfitAndLoss";
            this.mnuYearlyProfitAndLoss.Size = new System.Drawing.Size(294, 26);
            this.mnuYearlyProfitAndLoss.Text = "Produce Yearly Profit and Loss";
            // 
            // produceEstateAgentEarningsToolStripMenuItem
            // 
            this.produceEstateAgentEarningsToolStripMenuItem.Name = "produceEstateAgentEarningsToolStripMenuItem";
            this.produceEstateAgentEarningsToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.produceEstateAgentEarningsToolStripMenuItem.Text = "Produce Estate Agent Earnings";
            // 
            // mnuAddEstateAgent
            // 
            this.mnuAddEstateAgent.Name = "mnuAddEstateAgent";
            this.mnuAddEstateAgent.Size = new System.Drawing.Size(294, 26);
            this.mnuAddEstateAgent.Text = "Add Estate Agent";
            // 
            // mnuUpdateEstateAgent
            // 
            this.mnuUpdateEstateAgent.Name = "mnuUpdateEstateAgent";
            this.mnuUpdateEstateAgent.Size = new System.Drawing.Size(294, 26);
            this.mnuUpdateEstateAgent.Text = "Update Estate Agent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PropertyRentalSystem.Properties.Resources.IKEA_TINY_HOME;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPFRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuPFRMainMenu);
            this.MainMenuStrip = this.mnuPFRMainMenu;
            this.Name = "frmPFRHome";
            this.Text = "Perfect Fit Rentals - [ Home ]";
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
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyProfitAndLoss;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem produceEstateAgentEarningsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEstateAgent;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateEstateAgent;
    }
}

