
namespace PropertyRentalSystem
{
    partial class frmRecordPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordPayment));
            this.btnEircodeSRH = new System.Windows.Forms.Button();
            this.txtEircodeSRH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPayerDetails = new System.Windows.Forms.GroupBox();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActiveRental = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.grdProperty = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.lblProperties = new System.Windows.Forms.Label();
            this.grpPayerDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEircodeSRH
            // 
            this.btnEircodeSRH.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEircodeSRH.Location = new System.Drawing.Point(379, 24);
            this.btnEircodeSRH.Name = "btnEircodeSRH";
            this.btnEircodeSRH.Size = new System.Drawing.Size(75, 27);
            this.btnEircodeSRH.TabIndex = 49;
            this.btnEircodeSRH.Text = "Search Eircode";
            this.btnEircodeSRH.UseVisualStyleBackColor = true;
            this.btnEircodeSRH.Click += new System.EventHandler(this.btnEircodeSRH_Click);
            // 
            // txtEircodeSRH
            // 
            this.txtEircodeSRH.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircodeSRH.Location = new System.Drawing.Point(216, 24);
            this.txtEircodeSRH.MaxLength = 7;
            this.txtEircodeSRH.Name = "txtEircodeSRH";
            this.txtEircodeSRH.Size = new System.Drawing.Size(157, 27);
            this.txtEircodeSRH.TabIndex = 51;
            this.txtEircodeSRH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEircodeSRH_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Find Rental by Eircode:";
            // 
            // grpPayerDetails
            // 
            this.grpPayerDetails.Controls.Add(this.txtPropertyName);
            this.grpPayerDetails.Controls.Add(this.label4);
            this.grpPayerDetails.Controls.Add(this.txtMonthlyRent);
            this.grpPayerDetails.Controls.Add(this.label3);
            this.grpPayerDetails.Controls.Add(this.txtActiveRental);
            this.grpPayerDetails.Controls.Add(this.label1);
            this.grpPayerDetails.Controls.Add(this.txtEircode);
            this.grpPayerDetails.Controls.Add(this.label13);
            this.grpPayerDetails.Location = new System.Drawing.Point(30, 74);
            this.grpPayerDetails.Name = "grpPayerDetails";
            this.grpPayerDetails.Size = new System.Drawing.Size(488, 140);
            this.grpPayerDetails.TabIndex = 52;
            this.grpPayerDetails.TabStop = false;
            this.grpPayerDetails.Text = "Payer Details";
            this.grpPayerDetails.Visible = false;
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyName.Location = new System.Drawing.Point(146, 45);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.ReadOnly = true;
            this.txtPropertyName.Size = new System.Drawing.Size(336, 27);
            this.txtPropertyName.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Property Name:";
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyRent.Location = new System.Drawing.Point(146, 106);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(336, 27);
            this.txtMonthlyRent.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Monthly Rent: ";
            // 
            // txtActiveRental
            // 
            this.txtActiveRental.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActiveRental.Location = new System.Drawing.Point(146, 75);
            this.txtActiveRental.Name = "txtActiveRental";
            this.txtActiveRental.ReadOnly = true;
            this.txtActiveRental.Size = new System.Drawing.Size(336, 27);
            this.txtActiveRental.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Rental ID : ";
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(146, 16);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(336, 27);
            this.txtEircode.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = "Eircode:";
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.txtPayAmount);
            this.grpPaymentDetails.Controls.Add(this.label2);
            this.grpPaymentDetails.Controls.Add(this.label5);
            this.grpPaymentDetails.Controls.Add(this.dtpPaymentDate);
            this.grpPaymentDetails.Location = new System.Drawing.Point(30, 220);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(487, 117);
            this.grpPaymentDetails.TabIndex = 53;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            this.grpPaymentDetails.Visible = false;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayAmount.Location = new System.Drawing.Point(165, 35);
            this.txtPayAmount.MaxLength = 9;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(150, 27);
            this.txtPayAmount.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payment Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date of Payment :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Location = new System.Drawing.Point(165, 73);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(287, 27);
            this.dtpPaymentDate.TabIndex = 23;
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordPayment.Location = new System.Drawing.Point(30, 343);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(323, 36);
            this.btnRecordPayment.TabIndex = 54;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            this.btnRecordPayment.Visible = false;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // grdProperty
            // 
            this.grdProperty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperty.Location = new System.Drawing.Point(12, 87);
            this.grdProperty.Margin = new System.Windows.Forms.Padding(15);
            this.grdProperty.Name = "grdProperty";
            this.grdProperty.RowHeadersWidth = 51;
            this.grdProperty.RowTemplate.Height = 24;
            this.grdProperty.Size = new System.Drawing.Size(928, 297);
            this.grdProperty.TabIndex = 55;
            this.grdProperty.Visible = false;
            this.grdProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperty_CellClick);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(359, 343);
            this.btnHome.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(159, 36);
            this.btnHome.TabIndex = 56;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome1.Location = new System.Drawing.Point(216, 57);
            this.btnHome1.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(157, 36);
            this.btnHome1.TabIndex = 57;
            this.btnHome1.Text = "Back To Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(12, 64);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(197, 20);
            this.lblProperties.TabIndex = 58;
            this.lblProperties.Text = "Click on Rental to Select:";
            this.lblProperties.Visible = false;
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 396);
            this.Controls.Add(this.btnHome1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.grpPayerDetails);
            this.Controls.Add(this.btnEircodeSRH);
            this.Controls.Add(this.txtEircodeSRH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdProperty);
            this.Controls.Add(this.lblProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecordPayment";
            this.Text = "Perfect Fit Rentals - [Record Payments]";
            this.Load += new System.EventHandler(this.frmRecordPayment_Load);
            this.grpPayerDetails.ResumeLayout(false);
            this.grpPayerDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEircodeSRH;
        private System.Windows.Forms.TextBox txtEircodeSRH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPayerDetails;
        private System.Windows.Forms.TextBox txtActiveRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdProperty;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Label lblProperties;
    }
}