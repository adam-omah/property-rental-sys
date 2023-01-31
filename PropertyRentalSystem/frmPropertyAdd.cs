using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PropertyRentalSystem
{
    public partial class frmPropertyAdd : Form
    {

        DataSet ds;
        Owners theOwner = new Owners();

        // Default values for check boxes.
        char wifi = 'N';
        char gardenSpace = 'N';
        char pets = 'N';
        char ownerO = 'N';



        public frmPropertyAdd()
        {
            InitializeComponent();
        }

        private void frmAddProperty_Load(object sender, EventArgs e)
        {


            // Load Property Types and Type Codes.

            //Load TypeCodes into ComboBox
            ds = PropertyType.getTypes();
            cboPropertyType.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // Checks length of description, if more than 15, substring, if not use all.
                if (ds.Tables[0].Rows[i][1].ToString().Length > 15)
                {
                    cboPropertyType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1].ToString().Substring(0, 15));
                }
                else
                {
                    cboPropertyType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1].ToString());
                }

            }


            // These values are hard coded in as they are the only options.
            // in reality a heating type could be added as an option or this field would be a txt field,
            // I think a drop down works better for this section as it keeps everything simple to use for the end user.
            cboHeatingSource.Items.Add("Oil Central Heating");
            cboHeatingSource.Items.Add("Electric Central Heating");
            cboHeatingSource.Items.Add("Heat Pump Central Heating");
            cboHeatingSource.Items.Add("Electric Radiators");
            cboHeatingSource.Items.Add("Storage Heaters");
            cboHeatingSource.Items.Add("Solid Fuel Stove");
            cboHeatingSource.Items.Add("Geothermal");
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            // When add property is pressed
            // Validate Data Entered

            // Owner not selected:
            if (txtPropertyOwner.Text.Equals(""))
            {
                MessageBox.Show("No Owner Selected.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPropertyOwner.Focus();
                return;
            }

            // property type is empty:

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

            bool isValidName = validationFunctions.validPropertyName(txtPropertyName.Text);
            if (!isValidName)
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
            bool isValidNum = validationFunctions.validPositiveInt(txtMonthlyRent.Text);
            if (!isValidNum)
            {
                MessageBox.Show("Invalid Monthly Rent\nMust be Positive Number, only 1 . ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(rtxPropertyDescription.Text.Length >= 200)
            {
                MessageBox.Show("Property Descriptionis too long, Please keep below 200 chars.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxPropertyDescription.Focus();
                return;
            }else if(rtxPropertyDescription.Text.Length <= 10)
            {
                MessageBox.Show("Property Descriptionis too short, Please enter at least 10 chars.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Save Property to Properties Data Store.

            Property aProperty = new Property();

            // normal text fields.
            // setting eircode to uper case chars, removes inconsistency.
            aProperty.setEircode(txtEircode.Text.ToUpper());
            aProperty.setTypeCode(ds.Tables[0].Rows[cboPropertyType.SelectedIndex][0].ToString());
            aProperty.setOwnerID(theOwner.getOwnerID());
            aProperty.setHouseName(txtPropertyName.Text);
            aProperty.setPropertyDescription(rtxPropertyDescription.Text);
            aProperty.setRentalPrice(Convert.ToDouble(txtMonthlyRent.Text));

            // number selections
            aProperty.setTotalRooms(Convert.ToInt32(numTotalRooms.Value));
            aProperty.setTotalBedrooms(Convert.ToInt32(numTotalBedrooms.Value));
            aProperty.setEnsuiteBedrooms(Convert.ToInt32(numEnsuiteBedrooms.Value));
            aProperty.setBathrooms(Convert.ToInt32(numTotalBathrooms.Value));
            aProperty.setParkingSpaces(Convert.ToInt32(numParkingSpaces.Value));

            // cbo
            aProperty.setHeatingSource(cboHeatingSource.Text);

            // yes no options
            if (chkHasWifi.Checked)
                wifi = 'Y';
            else
                wifi = 'N';

            if (chkOwnerOccupied.Checked)
                ownerO = 'Y';
            else
                ownerO = 'N';

            if (chkGardenSpace.Checked)
                gardenSpace = 'Y';
            else
                gardenSpace = 'N';

            if (chkPetsAllowed.Checked)
                pets = 'Y';
            else
                pets = 'N';

            // set char values
            aProperty.setWifi(wifi.ToString());
            aProperty.setPetsAllowed(pets.ToString());
            aProperty.setOwnerOccupied(ownerO.ToString());
            aProperty.setGardenSpace(gardenSpace.ToString());
            // settting status to A for available.
            aProperty.setStatus("A");




            //invoke the method to add the data to the Products table
            aProperty.addProperty();


            // Show confirmation message.
            MessageBox.Show("Property has been sucessfully added to the Properties Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Reset UI.
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

            //set visiables
            grpPropertyDetails.Visible = false;
            grpPropertyExtras.Visible = false;
            btnAddProperty.Visible = false;

            txtSurnameSRH.Focus();

        }


        private void btnSurnameSRH_Click(object sender, EventArgs e)
        {

                //find matching Owners
                grdOwners.DataSource = Owners.findOwners(txtSurnameSRH.Text).Tables["Owner"];

                if (grdOwners.Rows.Count == 1)
                {
                    MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurnameSRH.Clear();
                    txtSurnameSRH.Focus();
                    return;
                }


                //display owners surname search grid 
                grdOwners.Visible = true;

                // Hide other grps if second time searching
                grpPropertyDetails.Visible = false;
                grpPropertyExtras.Visible = false;
                btnAddProperty.Visible = false;
            
        }

        private void grdOwners_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve Full owner Details from File.
            //extract the OwnerID from column zero on the selected row in grid and use tof ind owner
            int Id = Convert.ToInt32(grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //instantiate The Owner
            theOwner.getOwner(Id);

            // Set Owner name into field.
            txtPropertyOwner.Text = (string)theOwner.getFirstName() + " " + (string)theOwner.getSurname();

            // display owner details.
            grpPropertyDetails.Visible = true;
            grpPropertyExtras.Visible = true;
            btnAddProperty.Visible = true;
            grdOwners.Visible = false;
            txtPropertyName.Focus();
        }
    }
}
