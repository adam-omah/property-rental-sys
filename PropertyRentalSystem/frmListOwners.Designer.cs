
namespace PropertyRentalSystem
{
    partial class frmListOwners
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
            this.grpListItems = new System.Windows.Forms.GroupBox();
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.grpListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListItems
            // 
            this.grpListItems.Controls.Add(this.grdOwners);
            this.grpListItems.Location = new System.Drawing.Point(27, 66);
            this.grpListItems.Name = "grpListItems";
            this.grpListItems.Size = new System.Drawing.Size(663, 301);
            this.grpListItems.TabIndex = 0;
            this.grpListItems.TabStop = false;
            this.grpListItems.Text = "List Items";
            // 
            // grdOwners
            // 
            this.grdOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOwners.Location = new System.Drawing.Point(6, 45);
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.RowHeadersWidth = 51;
            this.grdOwners.RowTemplate.Height = 24;
            this.grdOwners.Size = new System.Drawing.Size(651, 250);
            this.grdOwners.TabIndex = 5;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.grpListItems);
            this.Name = "frmList";
            this.Text = "frmList";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.grpListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListItems;
        private System.Windows.Forms.DataGridView grdOwners;
    }
}