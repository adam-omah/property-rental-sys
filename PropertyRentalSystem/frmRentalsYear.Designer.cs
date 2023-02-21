
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentalsYear));
            this.label1 = new System.Windows.Forms.Label();
            this.cboRentalsInYear = new System.Windows.Forms.ComboBox();
            this.chtRentalsInYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtRentalsInYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Select a year :";
            // 
            // cboRentalsInYear
            // 
            this.cboRentalsInYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRentalsInYear.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRentalsInYear.FormattingEnabled = true;
            this.cboRentalsInYear.Location = new System.Drawing.Point(208, 14);
            this.cboRentalsInYear.Name = "cboRentalsInYear";
            this.cboRentalsInYear.Size = new System.Drawing.Size(298, 28);
            this.cboRentalsInYear.TabIndex = 1;
            this.cboRentalsInYear.SelectedIndexChanged += new System.EventHandler(this.cboRentalsInYear_SelectedIndexChanged);
            // 
            // chtRentalsInYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRentalsInYear.ChartAreas.Add(chartArea1);
            this.chtRentalsInYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chtRentalsInYear.Legends.Add(legend1);
            this.chtRentalsInYear.Location = new System.Drawing.Point(30, 60);
            this.chtRentalsInYear.Margin = new System.Windows.Forms.Padding(25);
            this.chtRentalsInYear.Name = "chtRentalsInYear";
            this.chtRentalsInYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chtRentalsInYear.Series.Add(series1);
            this.chtRentalsInYear.Series.Add(series2);
            this.chtRentalsInYear.Size = new System.Drawing.Size(1200, 600);
            this.chtRentalsInYear.TabIndex = 6;
            this.chtRentalsInYear.Text = "Year 2020";
            title1.Name = "GraphTitle";
            title1.Text = "Test";
            this.chtRentalsInYear.Titles.Add(title1);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(521, 9);
            this.btnHome.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(159, 36);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Back To Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmRentalsYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1332, 693);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.chtRentalsInYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRentalsInYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentalsYear";
            this.Text = "Perfect Fit Rentals - [Rentals Per Year Report]";
            this.Load += new System.EventHandler(this.frmRentalsYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtRentalsInYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRentalsInYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRentalsInYear;
        private System.Windows.Forms.Button btnHome;
    }
}