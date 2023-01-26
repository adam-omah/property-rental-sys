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
        DataSet ds;
        PropertyType thePropertyType = new PropertyType();

        public frmPropertyTypeUpdate()
        {
            InitializeComponent();
        }

        private void frmPropertyTypeUpdate_Load(object sender, EventArgs e)
        {
            LoadPropertyTypes();
        }

        private void LoadPropertyTypes()
        {
            //Load TypeCodes into ComboBox
            ds = PropertyType.getTypes();
            cboPropType.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // Adds each item to the drop down, substring limits description to 20 chars.
                cboPropType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1].ToString().Substring(0, 20));
            }
        }

        private void cboPropType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPropType.SelectedIndex == -1)
            {
                txtPropertyTypeDescription.Clear();
                grpUpdateType.Visible = false;
            }
            else
            {
                // Access the data set and get the description.
                txtPropertyTypeDescription.Text = ds.Tables[0].Rows[cboPropType.SelectedIndex][1].ToString();
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
            thePropertyType.setTypeCode(ds.Tables[0].Rows[cboPropType.SelectedIndex][0].ToString());
            thePropertyType.setDescription(txtPropertyTypeDescription.Text);

            thePropertyType.updateType();

            // display confirmation Message:
            MessageBox.Show("Property Type Has Been Updated", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI

            txtPropertyTypeDescription.Clear();
            grpUpdateType.Visible = false;

            LoadPropertyTypes();

            cboPropType.SelectedIndex = -1;


        }
    }
}
