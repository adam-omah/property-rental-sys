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
    public partial class frmPropertyTypeAdd : Form
    {

        public frmPropertyTypeAdd()
        {
            InitializeComponent();
        }


        private void btnAddPropertyType_Click(object sender, EventArgs e)
        {

            // once add property type is clicked:

            // validation:
            // check for type code empty.
            if (txtPropertyTypeCode.Text.Equals(""))
            {
                MessageBox.Show("Property Type Code Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeCode.Focus();
                return;
            }

            //check if code is 2 chars long 
            if (txtPropertyTypeCode.Text.Length < 2 || txtPropertyTypeCode.Text.Length > 2)
            {
                MessageBox.Show("Property Type Code Must Be 2 characters long", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeCode.Focus();
                return;
            }

            //Check to see if Code already Exists.

            if (!PropertyType.TypeCodeExists(txtPropertyTypeCode.Text))
            {
                MessageBox.Show("Property Type Code 'SD' Already Exists", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeCode.Focus();
                return;
            }


            // check for type Description empty.
            if (txtPropertyTypeDescription.Text.Equals(""))
            {
                MessageBox.Show("Property Type Description Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeDescription.Focus();
                return;
            }



            // Save to Data Store once validated.

            PropertyType newType = new PropertyType(txtPropertyTypeCode.Text,txtPropertyTypeDescription.Text);

            newType.addPropertyType();
            

            // display confirmation Message:
            MessageBox.Show("Property Type Has Been Added", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI
            txtPropertyTypeCode.Clear();
            txtPropertyTypeDescription.Clear();
            txtPropertyTypeCode.Focus();
        }
    }
}
