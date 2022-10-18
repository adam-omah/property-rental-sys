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
    public partial class frmAddProperty : Form
    {
        public frmAddProperty()
        {
            InitializeComponent();
        }

        private void frmAddProperty_Load(object sender, EventArgs e)
        {
            // Owners with status 'A' for active are retrieved from the Owners Data store7
            // Owner id and tele phone number are retrieved along with first name last name

            cboActiveOwnerList.Items.Add("John Doe - 087 777 7777 - 124");
            cboActiveOwnerList.Items.Add("Mary O'Conner - 089 777 7777 - 58");
            cboActiveOwnerList.Items.Add("Jerry Finnerty - 085 777 7777 - 150");
            cboActiveOwnerList.Items.Add("Sarah O'Shea - 086 777 7777 - 73");

            cboPropertyType.Items.Add("BO - Bungalo");
            cboPropertyType.Items.Add("SD - Semi Detatched");
            cboPropertyType.Items.Add("DS - Standard Detatched");
            cboPropertyType.Items.Add("AP - Apartment");
            cboPropertyType.Items.Add("TH - Town House");

            cboHeatingSource.Items.Add("Oil Central Heating");
            cboHeatingSource.Items.Add("Electric Central Heating");
            cboHeatingSource.Items.Add("Heat Pump Central Heating");
            cboHeatingSource.Items.Add("Electric Radiators");
            cboHeatingSource.Items.Add("Storage Heaters");
            cboHeatingSource.Items.Add("Solid Fuel Stove");
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            // When add property is pressed
            // Validate Data Entered

            // selection lists are not empty:
            if (cboActiveOwnerList.SelectedIndex == -1)
            {
                MessageBox.Show("Active Owner must be Selected!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboActiveOwnerList.Focus();
                return;
            }

            if (cboPropertyType.SelectedIndex == -1)
            {
                MessageBox.Show("Property Type must be Selected!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPropertyType.Focus();
                return;
            }

            // Property Name or Number validation.
            if (txtPropertyName.Text.Equals(""))
            {
                MessageBox.Show("Property Must have a name or number!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyName.Focus();
                return;
            }
            if (!validPropertyName(txtPropertyName.Text))
            {
                MessageBox.Show("Property Name Invalid!\nProperty name must be English letters, spaces and 's are allowed.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyName.Focus();
                return;
            }

            // Eircode Validation: (same as for Add Owner)
            
            if (txtEircode.Text.Equals(""))
            {
                MessageBox.Show("Eircode Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }
            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidEircode = validationFunctions.validEircode(txtEircode.Text);

            if (!isValidEircode)
            {
                MessageBox.Show("Eircode is Invalid, Please enter a valid Eircode", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            // Monthly Rental Validation:

            if (txtMonthlyRent.Text.Equals(""))
            {
                MessageBox.Show("Montly Rent must be entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonthlyRent.Focus();
                return;
            }

            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidNum = validationFunctions.validNumber(txtMonthlyRent.Text);
            if (!isValidNum)
            {
                MessageBox.Show("Invalid Monthly Rent\nMust be numeric value with only one decimal .", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonthlyRent.Focus();
                return;
            }



            
            if (cboHeatingSource.SelectedIndex == -1)
            {
                MessageBox.Show("Heating Source must be Selected!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHeatingSource.Focus();
                return;
            }




            // Give property Appropriate Property ID.
            // Save Property to Properties Data Store.
            // NOT DOING THIS!
            // Show confirmation message.


            // Reset UI.
            cboActiveOwnerList.SelectedIndex = -1;
            cboPropertyType.SelectedIndex = -1;
            cboHeatingSource.SelectedIndex = -1;

        }

        private bool validNumber(string rent)
        {
            bool result = true;
            char[] rentChars = rent.ToCharArray();
            int dots = 0;

            // valid numbers must be numeric and only contain one '.' symbol

            for (int i = 0; i < rentChars.Length; i++)
            {
                if ( rentChars[i] == '.' || (rentChars[i] >= '0' && rentChars[i] <= '9'))
                {
                    if (rentChars[i] == '.')
                    {
                        if (dots == 1)
                        {
                            result = false;
                        }
                        else
                            dots++;

                    }
                }
                else
                    result = false;
            }

            return result;
        }

        

        

    }
}
