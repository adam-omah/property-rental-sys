
namespace PropertyRentalSystem
{
    partial class frmPropertyTypeUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyTypeUpdate));
            this.grpUpdateType = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUpdatePropType = new System.Windows.Forms.Button();
            this.txtPropertyTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPropType = new System.Windows.Forms.ComboBox();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.grpUpdateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateType
            // 
            this.grpUpdateType.Controls.Add(this.btnHome);
            this.grpUpdateType.Controls.Add(this.btnUpdatePropType);
            this.grpUpdateType.Controls.Add(this.txtPropertyTypeDescription);
            this.grpUpdateType.Controls.Add(this.label2);
            this.grpUpdateType.Location = new System.Drawing.Point(16, 109);
            this.grpUpdateType.Name = "grpUpdateType";
            this.grpUpdateType.Size = new System.Drawing.Size(463, 180);
            this.grpUpdateType.TabIndex = 1;
            this.grpUpdateType.TabStop = false;
            this.grpUpdateType.Text = "Update Property Type";
            this.grpUpdateType.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(269, 121);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 40);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUpdatePropType
            // 
            this.btnUpdatePropType.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePropType.Location = new System.Drawing.Point(20, 121);
            this.btnUpdatePropType.Name = "btnUpdatePropType";
            this.btnUpdatePropType.Size = new System.Drawing.Size(249, 40);
            this.btnUpdatePropType.TabIndex = 4;
            this.btnUpdatePropType.Text = "Update Type";
            this.btnUpdatePropType.UseVisualStyleBackColor = true;
            this.btnUpdatePropType.Click += new System.EventHandler(this.btnUpdatePropType_Click);
            // 
            // txtPropertyTypeDescription
            // 
            this.txtPropertyTypeDescription.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyTypeDescription.Location = new System.Drawing.Point(21, 77);
            this.txtPropertyTypeDescription.Name = "txtPropertyTypeDescription";
            this.txtPropertyTypeDescription.Size = new System.Drawing.Size(418, 27);
            this.txtPropertyTypeDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property Type Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Property Type Code To Update:";
            // 
            // cboPropType
            // 
            this.cboPropType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropType.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPropType.FormattingEnabled = true;
            this.cboPropType.Location = new System.Drawing.Point(41, 53);
            this.cboPropType.Margin = new System.Windows.Forms.Padding(40);
            this.cboPropType.Name = "cboPropType";
            this.cboPropType.Size = new System.Drawing.Size(410, 28);
            this.cboPropType.TabIndex = 2;
            this.cboPropType.SelectedIndexChanged += new System.EventHandler(this.cboPropType_SelectedIndexChanged);
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome1.Location = new System.Drawing.Point(156, 100);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(180, 40);
            this.btnHome1.TabIndex = 8;
            this.btnHome1.Text = "Back To Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // frmPropertyTypeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(491, 301);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPropType);
            this.Controls.Add(this.grpUpdateType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPropertyTypeUpdate";
            this.Text = "Perfect Fit Rentals - [Update Property Type]";
            this.Load += new System.EventHandler(this.frmPropertyTypeUpdate_Load);
            this.grpUpdateType.ResumeLayout(false);
            this.grpUpdateType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateType;
        private System.Windows.Forms.Button btnUpdatePropType;
        private System.Windows.Forms.TextBox txtPropertyTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPropType;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHome1;
    }
}