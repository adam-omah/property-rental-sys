using System;
using System.Collections;
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
    public partial class frmRentalNew : Form
    {
        public frmRentalNew()
        {
            InitializeComponent();
        }

        List<Tenant> tenants = new List<Tenant>();
        Property theProperty = new Property();
        PropOwner theOwner = new PropOwner();
        Tenant theTenant = new Tenant();
        String startDateFormat;
        String endDateFormat;
        DataSet dsTypes;

        public Boolean tenant1Added = false;

        // this is search town town now, for some reason the name never changed even though on form the btn is called different.
        private void btnSRHEircode_Click(object sender, EventArgs e)
        {
            // Set groups to invisible (ensures that if an eircode was already search is not same one).
            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;
            btnHome.Visible = false;
            grdTenants.Visible = false;
            lblTenants.Visible = false;
            lblRentals.Visible = false;

            btnHome1.Visible = true;

            grdProperties.DataSource = null;
            grdProperties.Rows.Clear();



            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidTown = validationFunctions.validTextString(txtTownSRH.Text);

            if (!isValidTown)
            {
                MessageBox.Show("Town is Invalid!\nA Town must contain English letters, also spaces and 's are allowed.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTownSRH.Clear();
                txtTownSRH.Focus();
                return;
            }
            else
            {
                //find matching Properties

                if(cboPropertyType.SelectedIndex == 0)
                {
                    // no search by type is selected.
                    grdProperties.DataSource = Property.findPropertiesByTown(validationFunctions.SQLApostrophe(txtTownSRH.Text.ToUpper())).Tables["Properties"];
                }
                else
                {
                    //type is selected.
                    grdProperties.DataSource = Property.findPropertiesByTownType(validationFunctions.SQLApostrophe(txtTownSRH.Text.ToUpper()),
                        cboPropertyType.Items[cboPropertyType.SelectedIndex].ToString().Substring(0,2)).Tables["Properties"];
                }

                if (grdProperties.Rows.Count == 0)
                {
                    grdProperties.Visible = false;
                    // Property Not found.
                    MessageBox.Show("The Town " + txtTownSRH.Text + " Has no Available properties to Rent\nPlease try another Town such as  'Tralee' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTownSRH.Clear();
                    txtTownSRH.Focus();
                    return;
                }
                else
                {
                    grdProperties.Visible = true;
                    lblRentals.Visible = true;
                    btnHome1.Visible = false;
                }
            }
        }

        private void btnCreateRental_Click(object sender, EventArgs e)
        {

            // Validate Data.

            //Date Validation. moved to validation functions for re-use in update rental.

            // Start Date
            bool isValidStart = validationFunctions.validStartDate(dtpStartDate.Value.Date);

            if (!isValidStart)
            {
                MessageBox.Show("Invalid Start date, Must be Time in futurue and no greater than 3 months in future.");
                dtpStartDate.Focus();
                return;
            }

            // end date validation, requires start date to be checked first.
            bool isValidEnd = validationFunctions.validEndDate(dtpEndDate.Value.Date, dtpStartDate.Value.Date);

            if (!isValidEnd)
            {
                MessageBox.Show("Invalid End date, Must be minimum 1 month ahead of start date, and maximum 10 years ahead.");
                dtpStartDate.Focus();
                return;
            }



            // if no tenants are added.
            if (grdTenantsAdded.RowCount == 0)
            {
                MessageBox.Show("Please add atleast one tenant using the search bar.");
                txtSurnameSRH.Focus();
                return;
            }

            // after all validation above has been checked,

            // Save Rental Contract to Rentals Data file.
            startDateFormat = String.Format("{0:dd-MMM-yy}", dtpStartDate.Value);
            endDateFormat = String.Format("{0:dd-MMM-yy}", dtpEndDate.Value);

            // Instantiate the Rental.
            Rental theRental = new Rental(startDateFormat, Convert.ToInt32(theOwner.getOwnerID()), endDateFormat, "A", theProperty.getEircode());

            theRental.addRental();

            // update Property to Rented.

            theProperty.setStatus("R");
            theProperty.updateProperty();

            // was used for testing:
            // DisplayTenantsList();

            // find all the tenants in the rental id that are active:
            grdTenants.DataSource = TenantRental.findAllTenantRentals(theRental.getRentalID()).Tables["tenant_rentals"];

            // Create Tenant Rentals in tenant rentals file for each tenant.
            for (int i = 0; i < tenants.Count; i++)
            {
                // message box was for testing purpose.

                // if A tenant rental already exits:


                //MessageBox.Show("Tenant to add: " + tenants[i].getTenantID() + "\nRental Id : " + theRental.getRentalID());
                TenantRental tRent = new TenantRental(Convert.ToInt32(theRental.getRentalID()),
                    Convert.ToInt32(tenants[i].getTenantID()),
                    "A");
                // add the tenant rental to tenant Rentals file.
                tRent.addTenantRental();
            }

            //show confirmation message
            MessageBox.Show("Rental Details Have Been Updated on the Rental Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI.
            txtTownSRH.Clear();
            txtMonthlyRent.Clear();
            txtPropertyEircode.Clear();
            txtAddress.Clear();
            txtPropertyOwner.Clear();

            dtpStartDate.Value = DateTime.Now;
            // end date 12 months ahead default.
            dtpEndDate.Value = DateTime.Now.AddMonths(12);

            txtSurnameSRH.Clear();
            grdTenants.Visible = false;
            lblTenants.Visible = true;
            ResetGrids();

            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;
            btnHome.Visible = false;
            btnHome1.Visible = true;

            cboPropertyType.SelectedIndex = 0;

            txtTownSRH.Focus();
        }

        private void ResetGrids()
        {
            grdTenants.DataSource = null;
            grdTenants.Rows.Clear();

            grdTenantsAdded.DataSource = null;
            grdTenantsAdded.Rows.Clear();

            grdProperties.DataSource = null;
            grdProperties.Rows.Clear();
        }

        private void btnSRHTenants_Click(object sender, EventArgs e)
        {
            //validate Surname entered.

            if (txtSurnameSRH.Text.Equals(""))
            {
                MessageBox.Show("A Surname Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Focus();
                return;
            }

            //find matching Tenants
            grdTenants.DataSource = Tenant.findTenants(txtSurnameSRH.Text.ToUpper()).Tables["Tenants"];

            if (grdTenants.Rows.Count == 0)
            {
                MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Clear();
                txtSurnameSRH.Focus();
                return;
            }

            grdTenants.Visible = true;
            lblTenants.Visible = true;

        }

  

        private void grdTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to Add the tenant? " + (string)grdTenants.Rows[e.RowIndex].Cells["firstName"].Value + " To this Rental?", "Add Tenant To Rental Contract.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // if yes Add to Added grd.
                tenant1Added = false;

                //check if this tenant is already added.
                if(grdTenantsAdded.Rows.Count > 0){

                    for (int i = 0; i < grdTenantsAdded.Rows.Count; i++)
                    {
                        // Checks if Tenant has already been added.
                        if (Convert.ToInt32(grdTenantsAdded.Rows[i].Cells["tenantID"].Value) == Convert.ToInt32(grdTenants.Rows[e.RowIndex].Cells["TenantID"].Value))
                        {
                            tenant1Added = true;
                        }

                    }

                }
                if (!tenant1Added)
                {
                    //add to grd.
                    grdTenantsAdded.Rows.Add(grdTenants.Rows[e.RowIndex].Cells["TenantID"].Value.ToString(), (string)grdTenants.Rows[e.RowIndex].Cells["firstName"].Value, (string)grdTenants.Rows[e.RowIndex].Cells["lastName"].Value, grdTenants.Rows[e.RowIndex].Cells["phone"].Value.ToString());
                    // add to the tenants array.

                    Tenant aTenant = new Tenant();


                    aTenant.getTenant(Convert.ToInt32(grdTenants.Rows[e.RowIndex].Cells["TenantID"].Value.ToString()));

                    tenants.Add(aTenant);

                }
                else
                {
                    MessageBox.Show("This Tenant has already been added, Please try another Tenant.","Error Tenant Already Added.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurnameSRH.Focus();
                    return;
                }

            }
        }

        private void grdTenantsAdded_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grdTenantsAdded.CurrentRow.Selected = true;

            DialogResult dialogResult = MessageBox.Show("Would you like to remove the tenant? " + (string)grdTenantsAdded.Rows[e.RowIndex].Cells["firstName"].Value + " from this rental?", "Warning!!!! Removing Tenant", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // if yes Remove the tenant from the grd.

                // find index of tenant in tenants list.
                int removeTenantIndex = -1;
                for (int i = 0; i < tenants.Count; i++)
                {
                    if (tenants[i].getTenantID() == Convert.ToInt32(grdTenantsAdded.Rows[e.RowIndex].Cells["tenantID"].Value))
                    {
                        removeTenantIndex = i;
                    }
                }

                if (removeTenantIndex != -1)
                {
                    tenants.RemoveAt(removeTenantIndex);
                }

                grdTenantsAdded.Rows.RemoveAt(this.grdTenantsAdded.Rows[e.RowIndex].Index);
            }

            //DisplayTenantsList();

        }

        private void DisplayTenantsList()
        {
            String message = "";

            foreach (var item in tenants)
            {
                message += item.getFirstName() + "\n";
            }

            MessageBox.Show("The following Tenants are in the list:\n " + message);
        }

        private void frmRentalNew_Load(object sender, EventArgs e)
        {
            // Centre on screen
            this.CenterToScreen();
            // moves up 150 units so that its expansion is allowed for.
            this.Top -= 150;
            this.Left -= 100;

            // At start set time date time to now and future time to 12 months ahead.
            dtpStartDate.Value = DateTime.Now;
            // end date 12 months ahead default.
            dtpEndDate.Value = DateTime.Now.AddMonths(12);

            
            //Load TypeCodes into ComboBox
            dsTypes = PropertyType.getTypes();

            cboPropertyType.Items.Clear();
            for (int i = 0; i < dsTypes.Tables[0].Rows.Count; i++)
            {

                // Checks length of description, if more than 15, substring, if not use all.
                if (dsTypes.Tables[0].Rows[i][1].ToString().Length > 15)
                {
                    cboPropertyType.Items.Add(dsTypes.Tables[0].Rows[i][0] + " - " + dsTypes.Tables[0].Rows[i][1].ToString().Substring(0, 15));
                }
                else
                {
                    cboPropertyType.Items.Add(dsTypes.Tables[0].Rows[i][0] + " - " + dsTypes.Tables[0].Rows[i][1].ToString());
                }

            }

            // insert this at the start.
            cboPropertyType.Items.Insert(0, "XX - No Property Type");


            // set search by type to none.
            cboPropertyType.SelectedIndex = 0;


            txtTownSRH.Focus();
        }

        private void grdProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // instantiate th property Selected.
            theProperty.getProperty(grdProperties.Rows[e.RowIndex].Cells["eircode"].Value.ToString().ToUpper());


            if (theProperty.getStatus() == 'A')
            {
                // If property is available. Set Grps to visible.
                lblRentals.Visible = false;
                grpPropertyDetails.Visible = true;
                grpRentalDetails.Visible = true;
                grpTenants.Visible = true;
                btnCreateRental.Visible = true;
                btnHome.Visible = true;
                btnHome1.Visible = false;

                //hide properties grd
                grdProperties.Visible = false;

                txtPropertyEircode.Text = theProperty.getEircode();
                txtMonthlyRent.Text = theProperty.getRentalPrice().ToString();
                txtAddress.Text = theProperty.getAddress();

                // Set Owner from property Owner ID.
                theOwner.getOwner(theProperty.getOwnerID());
                // Set the Owners Name into text box.
                txtPropertyOwner.Text = theOwner.getFirstName() + " " + theOwner.getSurname();

                dtpStartDate.Focus();

            }
            else {
                MessageBox.Show("The Property Selected is not available to rent, Please select another property", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTownSRH.Focus();
                return;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTownSRH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnSRHEircode_Click(sender, e);
        }

        private void txtSurnameSRH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnSRHTenants_Click(sender, e);
        }
    }
}
