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

            if (!PropertyType.TypeCodeExists(txtPropertyTypeCode.Text.ToUpper()))
            {
                MessageBox.Show("Property Type Code " + txtPropertyTypeCode.Text.ToUpper() + " Already Exists,\nPlease try another type Code", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeCode.Focus();
                return;
            }
            if (txtPropertyTypeCode.Text.ToUpper().Equals("XX"))
            {
                MessageBox.Show("Property Type Code 'XX' is Reserved to represent No Type Selected,\nPlease try another type Code", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtPropertyTypeDescription.Text.Length < 5)
            {
                MessageBox.Show("Property Type Description Must longer than 5 characthers.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeDescription.Focus();
                return;
            }

            if (txtPropertyTypeDescription.Text.Length > 200)
            {
                MessageBox.Show("Property Type Description Must less than 200 characthers", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeDescription.Focus();
                return;
            }

            bool isValidDescript = validationFunctions.validTextString(txtPropertyTypeDescription.Text);
            if (!isValidDescript)
            {
                MessageBox.Show("Type Description can only be normal english characthers and not jsut numbers", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyTypeDescription.Focus();
                return;
            }



            // Save to Data Store once validated.
            // set type code to upper case, validate description with ' allowance.
            PropertyType newType = new PropertyType(txtPropertyTypeCode.Text.ToUpper(), validationFunctions.SQLApostrophe(txtPropertyTypeDescription.Text));

            newType.addPropertyType();
            

            // display confirmation Message:
            MessageBox.Show("Property Type Has Been Added", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI
            txtPropertyTypeCode.Clear();
            txtPropertyTypeDescription.Clear();
            txtPropertyTypeCode.Focus();
        }

        private void frmPropertyTypeAdd_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // moves up 100 units so that its expansion is allowed for.
            this.Top -= 100;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
