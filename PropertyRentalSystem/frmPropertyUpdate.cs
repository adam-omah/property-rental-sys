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
    public partial class frmPropertyUpdate : Form
    {

        DataSet ds;
        PropOwner theOwner = new PropOwner();
        Property theProperty = new Property();

        // Default values for check boxes.
        char wifi = 'N';
        char gardenSpace = 'N';
        char pets = 'N';
        char ownerO = 'N';


        public frmPropertyUpdate()
        {
            InitializeComponent();
        }

        private void frmPropertyUpdate_Load(object sender, EventArgs e)
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


            // Status Values are also hard coded as these do not change and are part of the requirements.

            cboPropStatus.Items.Add("A - Available");
            cboPropStatus.Items.Add("R - Rented");
            cboPropStatus.Items.Add("I - Inactive");


        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
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


            // number up down does not allow negative values.

            //check if total rooms is more than 0
            if (numTotalRooms.Value == 0)
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

            // There is no Validation for Status as program
            // will not allow non value for status when updating.


            // Update Property in Properties Data Store.
            // normal text fields.
            // Eircode Is not to be changed as this is the property Primary key,
            // Eircode is set when property is found on search.
            
            theProperty.setTypeCode(ds.Tables[0].Rows[cboPropertyType.SelectedIndex][0].ToString());
            theProperty.setOwnerID(theOwner.getOwnerID());
            theProperty.setHouseName(txtPropertyName.Text);
            theProperty.setPropertyDescription(rtxPropertyDescription.Text);
            theProperty.setRentalPrice(Convert.ToDouble(txtMonthlyRent.Text));

            // number selections
            theProperty.setTotalRooms(Convert.ToInt32(numTotalRooms.Value));
            theProperty.setTotalBedrooms(Convert.ToInt32(numTotalBedrooms.Value));
            theProperty.setEnsuiteBedrooms(Convert.ToInt32(numEnsuiteBedrooms.Value));
            theProperty.setBathrooms(Convert.ToInt32(numTotalBathrooms.Value));
            theProperty.setParkingSpaces(Convert.ToInt32(numParkingSpaces.Value));

            // cbo
            theProperty.setHeatingSource(cboHeatingSource.Text);

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
            theProperty.setWifi(wifi.ToString());
            theProperty.setPetsAllowed(pets.ToString());
            theProperty.setOwnerOccupied(ownerO.ToString());
            theProperty.setGardenSpace(gardenSpace.ToString());

            // settting status
            theProperty.setStatus(cboPropStatus.Text.Substring(0,1));

            // Update the property.

            theProperty.updateProperty();

            // Show confirmation message.
            MessageBox.Show("Property has been sucessfully Updated in the Properties Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Reset UI.
            cboPropertyType.SelectedIndex = -1;
            cboHeatingSource.SelectedIndex = -1;
            txtPropertyName.Clear();
            txtEircode.Clear();
            txtMonthlyRent.Clear();
            rtxPropertyDescription.Clear();
            txtPropertyOwner.Clear();
            txtSurnameSRH.Clear();

            numTotalRooms.Value = 0;
            numTotalBedrooms.Value = 0;
            numTotalBathrooms.Value = 0;
            numEnsuiteBedrooms.Value = 0;
            numParkingSpaces.Value = 0;

            chkGardenSpace.Checked = false;
            chkHasWifi.Checked = false;
            chkOwnerOccupied.Checked = false;
            chkPetsAllowed.Checked = false;

            grpPropertyDetails.Visible = false;
            grpPropertyExtras.Visible = false;
            btnUpdateProperty.Visible = false;


            txtEircode.Focus();
        }

        private void btnSearchEircode_Click(object sender, EventArgs e)
        {
            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidEircode = validationFunctions.validEircode(txtEircode.Text.ToUpper());

            if (!isValidEircode)
            {
                MessageBox.Show("Eircode is Invalid, Please enter a valid Eircode", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Clear();
                txtEircode.Focus();
                return;
            }
            else
            {
                //find matching Property
                grdOwners.DataSource = Property.findProperties(txtEircode.Text.ToUpper()).Tables["Properties"];

                if (grdOwners.Rows.Count == 1)
                {
                    MessageBox.Show("The Eircode " + txtEircode.Text + " Is not on the system,\nPlease try another eircode such as  'v92cccc' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEircode.Clear();
                    txtEircode.Focus();
                    return;
                }
                else
                {
                    // Property was found, instantiate it.
                    // setting eircode to uper case chars, removes inconsistency.
                    theProperty.getProperty(txtEircode.Text.ToUpper());

                    //instantiate The Owner
                    theOwner.getOwner(theProperty.getOwnerID());

                    // Set Owner name into field.
                    txtPropertyOwner.Text = (string)theOwner.getFirstName() + " " + (string)theOwner.getSurname();

                    txtEircode.Text = theProperty.getEircode();
                    
                    txtOwnerId.Text = theProperty.getOwnerID().ToString();
                    txtMonthlyRent.Text = theProperty.getRentalPrice().ToString();

                    // set property type select to correct one.
                    for (int i = 0; i < cboPropertyType.Items.Count; i++)
                    {
                        if(cboPropertyType.Items[i].ToString().Substring(0, 2).Equals(theProperty.getTypeCode()))
                        {
                            cboPropertyType.SelectedIndex = i;
                        }
                    
                    }

                    // set Heating source select to correct one.
                    for (int i = 0; i < cboHeatingSource.Items.Count; i++)
                    {
                        if (cboHeatingSource.Items[i].ToString().Equals(theProperty.getHeatingSource()))
                        {
                            cboHeatingSource.SelectedIndex = i;
                        }

                    }

                    txtPropertyName.Text = theProperty.getHouseName();
                    rtxPropertyDescription.Text = theProperty.getPropertyDescription();

                    // setting the number values from the property found.
                    numTotalRooms.Value = theProperty.getTotalRooms();
                    numTotalBedrooms.Value = theProperty.getTotalBedrooms();
                    numTotalBathrooms.Value = theProperty.getBathrooms();
                    numEnsuiteBedrooms.Value = theProperty.getEnsuiteBedrooms();
                    numParkingSpaces.Value = theProperty.getParkingSpaces();

                    // checkboxes
                    if (theProperty.getGardenSpace() == 'Y')
                        chkGardenSpace.Checked = true;
                    else
                        chkGardenSpace.Checked = false;

                    if (theProperty.getPetsAllowed() == 'Y')
                        chkPetsAllowed.Checked = true;
                    else
                        chkPetsAllowed.Checked = false;

                    if (theProperty.getWifi() == 'Y')
                        chkHasWifi.Checked = true;
                    else
                        chkHasWifi.Checked = false;

                    if (theProperty.getOwnerOccupied() == 'Y')
                        chkOwnerOccupied.Checked = true;
                    else
                        chkOwnerOccupied.Checked = false;

                    // Status
                    if (theProperty.getStatus() == 'A')
                    {
                        cboPropStatus.SelectedIndex = 0;
                    }else if (theProperty.getStatus() == 'R')
                    {
                        cboPropStatus.SelectedIndex = 1;
                    }
                    else
                    {
                        cboPropStatus.SelectedIndex = 2;
                    }


                    grpPropertyDetails.Visible = true;
                    grpPropertyExtras.Visible = true;
                    btnUpdateProperty.Visible = true;
                }
            }
        }

        private void btnSurnameSRH_Click(object sender, EventArgs e)
        {
            // Hiding Property details if new search.
            grpPropertyDetails.Visible = false;
            grpPropertyExtras.Visible = false;
            btnUpdateProperty.Visible = false;

            //find matching Owners
            grdOwners.DataSource = PropOwner.findOwners(txtSurnameSRH.Text).Tables["Owner"];

            if (grdOwners.Rows.Count == 1)
            {
                MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Clear();
                txtSurnameSRH.Focus();
                return;
            }

            //display owners surname search grid 
            grdOwners.Visible = true;
        }

        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve Full owner Details from File.
            grdOwners.CurrentRow.Selected = true;

            txtPropertyOwner.Text = (string)grdOwners.Rows[e.RowIndex].Cells["firstName"].Value + " " + (string)grdOwners.Rows[e.RowIndex].Cells["lastName"].Value;

            // Retrieve Full owner Details from File.
            //extract the OwnerID from column zero on the selected row in grid and use to find owner
            int Id = Convert.ToInt32(grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //instantiate The Owner
            theOwner.getOwner(Id);

            txtOwnerId.Text = Id.ToString();

            // display owner details.
            grpPropertyDetails.Visible = true;
            grpPropertyExtras.Visible = true;
            btnUpdateProperty.Visible = true;
            grdOwners.Visible = false;
            txtPropertyName.Focus();
        }
    }
}
