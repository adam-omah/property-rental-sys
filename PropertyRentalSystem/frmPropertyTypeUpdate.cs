using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyRentalSystem
{
    public partial class frmPropertyTypeUpdate : Form
    {
        public frmPropertyTypeUpdate()
        {
            InitializeComponent();
        }

        private void frmPropertyTypeUpdate_Load(object sender, EventArgs e)
        {
            cboPropType.Items.Add("BO - Bungalo");
            cboPropType.Items.Add("DS - Standard Detatched");
            cboPropType.Items.Add("TH - Town House");
        }

        private void cboPropType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPropType.SelectedIndex == -1)
            {
                txtPropertyTypeDescription.Clear();
                grpUpdateType.Visible = false;
            }
            if (cboPropType.SelectedIndex == 0)
            {
                txtPropertyTypeDescription.Text = "Single Story Detached house";
                grpUpdateType.Visible = true;
            }
            if (cboPropType.SelectedIndex == 1)
            {
                txtPropertyTypeDescription.Text = "Standard Detached house";
                grpUpdateType.Visible = true;
            }
            if (cboPropType.SelectedIndex == 2)
            {
                txtPropertyTypeDescription.Text = "Town House, central location";
                grpUpdateType.Visible = true;
            }



        }

        private void btnUpdatePropType_Click(object sender, EventArgs e)
        {
            // Once button clicked 

            //check valid descritpion.

            // check for type Description empty.
            if (txtPropertyTypeDescription.Text.Equals(""))
            {
                MessageBox.Show("Property Type Description Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeDescription.Focus();
                return;
            }



            // Update Data in Data Store once validated.
            // NOT DOING THIS!

            // display confirmation Message:
            MessageBox.Show("Property Type Has Been Updated", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI

            txtPropertyTypeDescription.Clear();
            grpUpdateType.Visible = false;
            cboPropType.SelectedIndex = -1;
        }
    }
}
