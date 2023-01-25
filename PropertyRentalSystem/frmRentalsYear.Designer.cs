
namespace PropertyRentalSystem
{
    partial class frmRentalsYear
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
            this.pboRentalsGraph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRentalsInYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboRentalsGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // pboRentalsGraph
            // 
            this.pboRentalsGraph.Location = new System.Drawing.Point(12, 39);
            this.pboRentalsGraph.Name = "pboRentalsGraph";
            this.pboRentalsGraph.Size = new System.Drawing.Size(1038, 541);
            this.pboRentalsGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboRentalsGraph.TabIndex = 5;
            this.pboRentalsGraph.TabStop = false;
            this.pboRentalsGraph.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Select a year :";
            // 
            // cboRentalsInYear
            // 
            this.cboRentalsInYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentalsInYear.FormattingEnabled = true;
            this.cboRentalsInYear.Location = new System.Drawing.Point(467, 9);
            this.cboRentalsInYear.Name = "cboRentalsInYear";
            this.cboRentalsInYear.Size = new System.Drawing.Size(298, 24);
            this.cboRentalsInYear.TabIndex = 3;
            this.cboRentalsInYear.SelectedIndexChanged += new System.EventHandler(this.cboRentalsInYear_SelectedIndexChanged);
            // 
            // frmRentalsYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 590);
            this.Controls.Add(this.pboRentalsGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRentalsInYear);
            this.Name = "frmRentalsYear";
            this.Text = "Perfect Fit Rentals - [Rentals Per Year Report]";
            this.Load += new System.EventHandler(this.frmRentalsYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboRentalsGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboRentalsGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRentalsInYear;
    }
}