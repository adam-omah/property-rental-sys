
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
            this.btnSRHTenants = new System.Windows.Forms.Button();
            this.txtSRHTenant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPayerDetails = new System.Windows.Forms.GroupBox();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActiveRental = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.grpPayerDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSRHTenants
            // 
            this.btnSRHTenants.Location = new System.Drawing.Point(430, 27);
            this.btnSRHTenants.Name = "btnSRHTenants";
            this.btnSRHTenants.Size = new System.Drawing.Size(75, 23);
            this.btnSRHTenants.TabIndex = 49;
            this.btnSRHTenants.Text = "Search Surname";
            this.btnSRHTenants.UseVisualStyleBackColor = true;
            this.btnSRHTenants.Click += new System.EventHandler(this.btnSRHTenants_Click);
            // 
            // txtSRHTenant
            // 
            this.txtSRHTenant.Location = new System.Drawing.Point(236, 27);
            this.txtSRHTenant.MaxLength = 10;
            this.txtSRHTenant.Name = "txtSRHTenant";
            this.txtSRHTenant.Size = new System.Drawing.Size(188, 22);
            this.txtSRHTenant.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Find Tenant By Phone Number:";
            // 
            // grpPayerDetails
            // 
            this.grpPayerDetails.Controls.Add(this.txtMonthlyRent);
            this.grpPayerDetails.Controls.Add(this.label3);
            this.grpPayerDetails.Controls.Add(this.txtActiveRental);
            this.grpPayerDetails.Controls.Add(this.label1);
            this.grpPayerDetails.Controls.Add(this.txtTenantName);
            this.grpPayerDetails.Controls.Add(this.label13);
            this.grpPayerDetails.Location = new System.Drawing.Point(31, 71);
            this.grpPayerDetails.Name = "grpPayerDetails";
            this.grpPayerDetails.Size = new System.Drawing.Size(488, 108);
            this.grpPayerDetails.TabIndex = 52;
            this.grpPayerDetails.TabStop = false;
            this.grpPayerDetails.Text = "Payer Details";
            this.grpPayerDetails.Visible = false;
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(120, 76);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.ReadOnly = true;
            this.txtMonthlyRent.Size = new System.Drawing.Size(354, 22);
            this.txtMonthlyRent.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Monthly Rent: ";
            // 
            // txtActiveRental
            // 
            this.txtActiveRental.Location = new System.Drawing.Point(120, 48);
            this.txtActiveRental.Name = "txtActiveRental";
            this.txtActiveRental.ReadOnly = true;
            this.txtActiveRental.Size = new System.Drawing.Size(354, 22);
            this.txtActiveRental.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Active Rental : ";
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(120, 21);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.ReadOnly = true;
            this.txtTenantName.Size = new System.Drawing.Size(354, 22);
            this.txtTenantName.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Tenant Paying : ";
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
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(165, 32);
            this.txtPayAmount.MaxLength = 16;
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
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 396);
            this.Controls.Add(this.btnRecordPayment);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.grpPayerDetails);
            this.Controls.Add(this.btnSRHTenants);
            this.Controls.Add(this.txtSRHTenant);
            this.Controls.Add(this.label7);
            this.Name = "frmRecordPayment";
            this.Text = "frmRecordPayment";
            this.grpPayerDetails.ResumeLayout(false);
            this.grpPayerDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSRHTenants;
        private System.Windows.Forms.TextBox txtSRHTenant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPayerDetails;
        private System.Windows.Forms.TextBox txtActiveRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecordPayment;
    }
}