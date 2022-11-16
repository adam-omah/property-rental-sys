
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
            this.grpUpdateType = new System.Windows.Forms.GroupBox();
            this.btnUpdatePropType = new System.Windows.Forms.Button();
            this.txtPropertyTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPropType = new System.Windows.Forms.ComboBox();
            this.grpUpdateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateType
            // 
            this.grpUpdateType.Controls.Add(this.btnUpdatePropType);
            this.grpUpdateType.Controls.Add(this.txtPropertyTypeDescription);
            this.grpUpdateType.Controls.Add(this.label2);
            this.grpUpdateType.Location = new System.Drawing.Point(26, 264);
            this.grpUpdateType.Name = "grpUpdateType";
            this.grpUpdateType.Size = new System.Drawing.Size(463, 180);
            this.grpUpdateType.TabIndex = 1;
            this.grpUpdateType.TabStop = false;
            this.grpUpdateType.Text = "Update Property Type";
            this.grpUpdateType.Visible = false;
            // 
            // btnUpdatePropType
            // 
            this.btnUpdatePropType.Location = new System.Drawing.Point(19, 120);
            this.btnUpdatePropType.Name = "btnUpdatePropType";
            this.btnUpdatePropType.Size = new System.Drawing.Size(139, 40);
            this.btnUpdatePropType.TabIndex = 4;
            this.btnUpdatePropType.Text = "Update Type";
            this.btnUpdatePropType.UseVisualStyleBackColor = true;
            this.btnUpdatePropType.Click += new System.EventHandler(this.btnUpdatePropType_Click);
            // 
            // txtPropertyTypeDescription
            // 
            this.txtPropertyTypeDescription.Location = new System.Drawing.Point(15, 75);
            this.txtPropertyTypeDescription.Name = "txtPropertyTypeDescription";
            this.txtPropertyTypeDescription.Size = new System.Drawing.Size(418, 22);
            this.txtPropertyTypeDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property Type Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Property Type Code";
            // 
            // cboPropType
            // 
            this.cboPropType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPropType.FormattingEnabled = true;
            this.cboPropType.Location = new System.Drawing.Point(41, 53);
            this.cboPropType.Name = "cboPropType";
            this.cboPropType.Size = new System.Drawing.Size(410, 24);
            this.cboPropType.TabIndex = 2;
            this.cboPropType.SelectedIndexChanged += new System.EventHandler(this.cboPropType_SelectedIndexChanged);
            // 
            // frmPropertyTypeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPropType);
            this.Controls.Add(this.grpUpdateType);
            this.Name = "frmPropertyTypeUpdate";
            this.Text = "frmPropertyTypeUpdate";
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
    }
}