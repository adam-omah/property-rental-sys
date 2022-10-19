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
            bool isValidNum = validationFunctions.validPositiveNumber(txtMonthlyRent.Text);
            if (!isValidNum)
            {
                MessageBox.Show("Invalid Monthly Rent\nMust be Positive Numeric value with only one decimal .", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonthlyRent.Focus();
                return;
            }


            // check if property Description is empty
            if (rtxPropertyDescription.Text.Equals(""))
            {
                MessageBox.Show("Property Description must be entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxPropertyDescription.Focus();
                return;
            }


            // number up down does not allow negative values.

            //check if total rooms is more than 0
            if(numTotalRooms.Value == 0)
            {
                MessageBox.Show("A property must have atleast One Room!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTotalRooms.Focus();
                return;
            }

            // check if total bedrooms is more than total rooms.
            if (numTotalRooms.Value < numTotalBedrooms.Value)
            {
                MessageBox.Show("Number of bedrooms cannot be greater than total rooms!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTotalBedrooms.Focus();
                return;
            }
            // check if Ensuite bedrooms is more than total Bedrooms.
            if (numTotalBedrooms.Value < numEnsuiteBedrooms.Value)
            {
                MessageBox.Show("Number of Ensuite Bedrooms cannot be greater than Total Bedrooms!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numEnsuiteBedrooms.Focus();
                return;
            }

            // check if total ensuite bedrooms is more than total bathrooms.
            if (numTotalBathrooms.Value < numEnsuiteBedrooms.Value)
            {
                MessageBox.Show("Number of Ensuite Bedrooms cannot be greater than Total Bathrooms!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numEnsuiteBedrooms.Focus();
                return;
            }

            // check if total bedrooms + total bathrooms is more than total rooms.
            if (numTotalRooms.Value < (numTotalBedrooms.Value + numTotalBathrooms.Value))
            {
                MessageBox.Show("Number of bedrooms and bathrooms cannot be greater than total rooms!\nIncrease total rooms or rectify bedrooms/bathrooms", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTotalRooms.Focus();
                return;
            }

            // check if heating source was selected.
            if (cboHeatingSource.SelectedIndex == -1)
            {
                MessageBox.Show("Heating Source must be Selected!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHeatingSource.Focus();
                return;
            }



            // Give property Appropriate Property ID.
            // Set Property status to Available.
            // Save Property to Properties Data Store.
            // NOT DOING THIS!


            // Show confirmation message.
            MessageBox.Show("Property has been sucessfully added to the Properties Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Reset UI.
            cboActiveOwnerList.SelectedIndex = -1;
            cboPropertyType.SelectedIndex = -1;
            cboHeatingSource.SelectedIndex = -1;
            txtPropertyName.Clear();
            txtEircode.Clear();
            txtMonthlyRent.Clear();
            rtxPropertyDescription.Clear();

            numTotalRooms.Value = 0;
            numTotalBedrooms.Value = 0;
            numTotalBathrooms.Value = 0;
            numEnsuiteBedrooms.Value = 0;
            numParkingSpaces.Value = 0;

            chkGardenSpace.Checked = false;
            chkHasWifi.Checked = false;
            chkOwnerOccupied.Checked = false;
            chkPetsAllowed.Checked = false;


            txtPropertyName.Focus();

        }

        private bool validPropertyName(string text)
        {
            bool result = true;
            Char[] nameChars = text.ToCharArray();


            for (int i = 0; i < nameChars.Length; i++)
            {
                // Allowed chars in property name are normal english letters &
                // spaces, numbers and 's.
                if (nameChars[i] == '\'' || nameChars[i] == ' '
                    || (nameChars[i] >= 'a' && nameChars[i] <= 'z') || (nameChars[i] >= 'A' && nameChars[i] <= 'Z')
                    || (nameChars[i] >= '0' && nameChars[i] <= '9'))
                {

                }
                else
                    result = false;
            }


            return result;
        }  

    }
}
