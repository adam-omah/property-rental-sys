
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
            this.grpPayerDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEircodeSRH
            // 
            this.btnEircodeSRH.Location = new System.Drawing.Point(352, 27);
            this.btnEircodeSRH.Name = "btnEircodeSRH";
            this.btnEircodeSRH.Size = new System.Drawing.Size(75, 23);
            this.btnEircodeSRH.TabIndex = 49;
            this.btnEircodeSRH.Text = "Search Surname";
            this.btnEircodeSRH.UseVisualStyleBackColor = true;
            this.btnEircodeSRH.Click += new System.EventHandler(this.btnEircodeSRH_Click);
            // 
            // txtEircodeSRH
            // 
            this.txtEircodeSRH.Location = new System.Drawing.Point(189, 27);
            this.txtEircodeSRH.MaxLength = 7;
            this.txtEircodeSRH.Name = "txtEircodeSRH";
            this.txtEircodeSRH.Size = new System.Drawing.Size(157, 22);
            this.txtEircodeSRH.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
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
            this.grpPayerDetails.Location = new System.Drawing.Point(31, 71);
            this.grpPayerDetails.Name = "grpPayerDetails";
            this.grpPayerDetails.Size = new System.Drawing.Size(488, 134);
            this.grpPayerDetails.TabIndex = 52;
            this.grpPayerDetails.TabStop = false;
            this.grpPayerDetails.Text = "Payer Details";
            this.grpPayerDetails.Visible = false;
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(120, 49);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.ReadOnly = true;
            this.txtPropertyName.Size = new System.Drawing.Size(354, 22);
            this.txtPropertyName.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Property Name:";
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(120, 103);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(354, 22);
            this.txtMonthlyRent.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Monthly Rent: ";
            // 
            // txtActiveRental
            // 
            this.txtActiveRental.Location = new System.Drawing.Point(120, 75);
            this.txtActiveRental.Name = "txtActiveRental";
            this.txtActiveRental.ReadOnly = true;
            this.txtActiveRental.Size = new System.Drawing.Size(354, 22);
            this.txtActiveRental.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Rental ID : ";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(120, 21);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(354, 22);
            this.txtEircode.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Eircode:";
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.txtPayAmount);
            this.grpPaymentDetails.Controls.Add(this.label2);
            this.grpPaymentDetails.Controls.Add(this.label5);
            this.grpPaymentDetails.Controls.Add(this.dtpPaymentDate);
            this.grpPaymentDetails.Location = new System.Drawing.Point(31, 211);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(487, 117);
            this.grpPaymentDetails.TabIndex = 53;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            this.grpPaymentDetails.Visible = false;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(165, 32);
            this.txtPayAmount.MaxLength = 9;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(150, 22);
            this.txtPayAmount.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payment Amount : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date of Payment :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(165, 73);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(287, 22);
            this.dtpPaymentDate.TabIndex = 23;
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Location = new System.Drawing.Point(171, 334);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(208, 34);
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
            this.grdProperty.Location = new System.Drawing.Point(12, 56);
            this.grdProperty.Name = "grdProperty";
            this.grdProperty.RowHeadersWidth = 51;
            this.grdProperty.RowTemplate.Height = 24;
            this.grdProperty.Size = new System.Drawing.Size(518, 328);
            this.grdProperty.TabIndex = 55;
            this.grdProperty.Visible = false;
            this.grdProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperty_CellClick);
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 396);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.grpPayerDetails);
            this.Controls.Add(this.btnEircodeSRH);
            this.Controls.Add(this.txtEircodeSRH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdProperty);
            this.Name = "frmRecordPayment";
            this.Text = "Perfect Fit Rentals - [Record Payments]";
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
    }
}