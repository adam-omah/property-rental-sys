
namespace PropertyRentalSystem
{
    partial class frmYearlyCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyCommission));
            this.cboYearlyCommision = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboYearlyGraph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboYearlyGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // cboYearlyCommision
            // 
            this.cboYearlyCommision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearlyCommision.FormattingEnabled = true;
            this.cboYearlyCommision.Location = new System.Drawing.Point(467, 12);
            this.cboYearlyCommision.Name = "cboYearlyCommision";
            this.cboYearlyCommision.Size = new System.Drawing.Size(298, 24);
            this.cboYearlyCommision.TabIndex = 0;
            this.cboYearlyCommision.SelectedIndexChanged += new System.EventHandler(this.cboYearlyCommision_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select a year :";
            // 
            // pboYearlyGraph
            // 
            this.pboYearlyGraph.Location = new System.Drawing.Point(12, 42);
            this.pboYearlyGraph.Name = "pboYearlyGraph";
            this.pboYearlyGraph.Size = new System.Drawing.Size(1038, 541);
            this.pboYearlyGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboYearlyGraph.TabIndex = 2;
            this.pboYearlyGraph.TabStop = false;
            this.pboYearlyGraph.Visible = false;
            // 
            // frmYearlyCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1062, 595);
            this.Controls.Add(this.pboYearlyGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboYearlyCommision);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyCommission";
            this.Text = "Perfect Fit Rentals - [Yearly Commission Report]";
            this.Load += new System.EventHandler(this.frmYearlyCommission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboYearlyGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboYearlyCommision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboYearlyGraph;
    }
}