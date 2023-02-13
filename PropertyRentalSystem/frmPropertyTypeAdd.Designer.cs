
namespace PropertyRentalSystem
{
    partial class frmPropertyTypeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyTypeAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPropertyType = new System.Windows.Forms.Button();
            this.txtPropertyTypeDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropertyTypeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPropertyType);
            this.groupBox1.Controls.Add(this.txtPropertyTypeDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPropertyTypeCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Property Type";
            // 
            // btnAddPropertyType
            // 
            this.btnAddPropertyType.Location = new System.Drawing.Point(27, 161);
            this.btnAddPropertyType.Name = "btnAddPropertyType";
            this.btnAddPropertyType.Size = new System.Drawing.Size(139, 40);
            this.btnAddPropertyType.TabIndex = 4;
            this.btnAddPropertyType.Text = "Add Property Type";
            this.btnAddPropertyType.UseVisualStyleBackColor = true;
            this.btnAddPropertyType.Click += new System.EventHandler(this.btnAddPropertyType_Click);
            // 
            // txtPropertyTypeDescription
            // 
            this.txtPropertyTypeDescription.Location = new System.Drawing.Point(23, 116);
            this.txtPropertyTypeDescription.Name = "txtPropertyTypeDescription";
            this.txtPropertyTypeDescription.Size = new System.Drawing.Size(418, 22);
            this.txtPropertyTypeDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property Type Description:";
            // 
            // txtPropertyTypeCode
            // 
            this.txtPropertyTypeCode.Location = new System.Drawing.Point(164, 41);
            this.txtPropertyTypeCode.MaxLength = 2;
            this.txtPropertyTypeCode.Name = "txtPropertyTypeCode";
            this.txtPropertyTypeCode.Size = new System.Drawing.Size(44, 22);
            this.txtPropertyTypeCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poperty Type Code:";
            // 
            // frmPropertyTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 248);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPropertyTypeAdd";
            this.Text = "Perfect Fit Rentals - [Add Property Type]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPropertyType;
        private System.Windows.Forms.TextBox txtPropertyTypeDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPropertyTypeCode;
        private System.Windows.Forms.Label label1;
    }
}