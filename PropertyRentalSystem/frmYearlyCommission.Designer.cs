
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyCommission));
            this.cboYearlyCommision = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chtCommision = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtCommision)).BeginInit();
            this.SuspendLayout();
            // 
            // cboYearlyCommision
            // 
            this.cboYearlyCommision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearlyCommision.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYearlyCommision.FormattingEnabled = true;
            this.cboYearlyCommision.Location = new System.Drawing.Point(202, 14);
            this.cboYearlyCommision.Margin = new System.Windows.Forms.Padding(25);
            this.cboYearlyCommision.Name = "cboYearlyCommision";
            this.cboYearlyCommision.Size = new System.Drawing.Size(298, 28);
            this.cboYearlyCommision.TabIndex = 0;
            this.cboYearlyCommision.SelectedIndexChanged += new System.EventHandler(this.cboYearlyCommision_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select a year :";
            // 
            // chtCommision
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCommision.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCommision.Legends.Add(legend1);
            this.chtCommision.Location = new System.Drawing.Point(21, 62);
            this.chtCommision.Margin = new System.Windows.Forms.Padding(25);
            this.chtCommision.Name = "chtCommision";
            this.chtCommision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chtCommision.Series.Add(series1);
            this.chtCommision.Series.Add(series2);
            this.chtCommision.Size = new System.Drawing.Size(1200, 600);
            this.chtCommision.TabIndex = 2;
            this.chtCommision.Text = "Year 2020";
            title1.Name = "GraphTitle";
            title1.Text = "Test";
            this.chtCommision.Titles.Add(title1);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(514, 10);
            this.btnHome.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(159, 36);
            this.btnHome.TabIndex = 57;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmYearlyCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1474, 720);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.chtCommision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboYearlyCommision);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyCommission";
            this.Text = "Perfect Fit Rentals - [Yearly Commission Report]";
            this.Load += new System.EventHandler(this.frmYearlyCommission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCommision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboYearlyCommision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCommision;
        private System.Windows.Forms.Button btnHome;
    }
}