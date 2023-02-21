
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
            this.btnHome = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnAddPropertyType);
            this.groupBox1.Controls.Add(this.txtPropertyTypeDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPropertyTypeCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Property Type";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(281, 154);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(159, 40);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddPropertyType
            // 
            this.btnAddPropertyType.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPropertyType.Location = new System.Drawing.Point(22, 154);
            this.btnAddPropertyType.Name = "btnAddPropertyType";
            this.btnAddPropertyType.Size = new System.Drawing.Size(253, 40);
            this.btnAddPropertyType.TabIndex = 4;
            this.btnAddPropertyType.Text = "Add Property Type";
            this.btnAddPropertyType.UseVisualStyleBackColor = true;
            this.btnAddPropertyType.Click += new System.EventHandler(this.btnAddPropertyType_Click);
            // 
            // txtPropertyTypeDescription
            // 
            this.txtPropertyTypeDescription.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyTypeDescription.Location = new System.Drawing.Point(22, 109);
            this.txtPropertyTypeDescription.Name = "txtPropertyTypeDescription";
            this.txtPropertyTypeDescription.Size = new System.Drawing.Size(418, 27);
            this.txtPropertyTypeDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property Type Description:";
            // 
            // txtPropertyTypeCode
            // 
            this.txtPropertyTypeCode.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyTypeCode.Location = new System.Drawing.Point(189, 34);
            this.txtPropertyTypeCode.MaxLength = 2;
            this.txtPropertyTypeCode.Name = "txtPropertyTypeCode";
            this.txtPropertyTypeCode.Size = new System.Drawing.Size(86, 27);
            this.txtPropertyTypeCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
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
            this.Load += new System.EventHandler(this.frmPropertyTypeAdd_Load);
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
        private System.Windows.Forms.Button btnHome;
    }
}