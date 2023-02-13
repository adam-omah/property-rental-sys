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

        public Boolean tenant1Added = false;

        private void btnSRHEircode_Click(object sender, EventArgs e)
        {
            // Set groups to invisible (ensures that if an eircode was already search is not same one).
            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;
            grdTenants.Visible = false;

            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidTown = validationFunctions.validTextString(txtTownSRH.Text);

            if (!isValidTown)
            {
                MessageBox.Show("Eircode is Invalid, Please enter a valid Eircode", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTownSRH.Clear();
                txtTownSRH.Focus();
                return;
            }
            else
            {
                //find matching Property
                grdTenants.DataSource = Property.findProperties(txtTownSRH.Text.ToUpper()).Tables["Properties"];

                if (grdTenants.Rows.Count == 1)
                {
                    // Property Not found.
                    MessageBox.Show("The Eircode " + txtTownSRH.Text + " Is not on the system,\nPlease try another eircode such as  'v92cccc' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTownSRH.Clear();
                    txtTownSRH.Focus();
                    return;
                }
                else
                {
                    // Property was found, instantiate it.
                    // setting eircode to uper case chars, removes inconsistency.
                    theProperty.getProperty(txtTownSRH.Text.ToUpper());


                    if (theProperty.getStatus() == 'A')
                    {
                        // If property is available. Set Grps to visible.
                        grpPropertyDetails.Visible = true;
                        grpRentalDetails.Visible = true;
                        grpTenants.Visible = true;
                        btnCreateRental.Visible = true;

                        txtPropertyEircode.Text = theProperty.getEircode();
                        txtMonthlyRent.Text = theProperty.getRentalPrice().ToString();
                        txtAddress.Text = theProperty.getAddress();

                        // Set Owner from property Owner ID.
                        theOwner.getOwner(theProperty.getOwnerID());
                        // Set the Owners Name into text box.
                        txtPropertyOwner.Text = theOwner.getFirstName() + " " + theOwner.getSurname();


                    }
                    else
                    {
                        // Property is not available.
                        MessageBox.Show("The Eircode " + txtTownSRH.Text + " Is On the System\nBut is NOT available (either Rented or unavailable.)\nPlease try another eircode such as  'v92cccc' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTownSRH.Clear();
                        txtTownSRH.Focus();
                        return;
                    }


                }
            }
        }

        private void btnCreateRental_Click(object sender, EventArgs e)
        {

            // Validate Data.

            //Date Validation. moved to validation functions for re-use in update rental.

            // Start Date
            bool isValidStart= validationFunctions.validStartDate(dtpStartDate.Value.Date);

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
            if (grdTenantsAdded.RowCount == 1)
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
            Rental theRental = new Rental(startDateFormat, Convert.ToInt32(theOwner.getOwnerID()),endDateFormat,"A",theProperty.getEircode());

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

            grdTenants.DataSource = null;
            grdTenants.Rows.Clear();

            grdTenantsAdded.DataSource = null;
            grdTenantsAdded.Rows.Clear();

            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;

            txtTownSRH.Focus();
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
            grdTenants.DataSource = Tenant.findTenants(txtSurnameSRH.Text).Tables["Tenants"];

            if (grdTenants.Rows.Count == 1)
            {
                MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Clear();
                txtSurnameSRH.Focus();
                return;
            }

            grdTenants.Visible = true;
           

        }

  

        private void grdTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to Add the tenant? " + (string)grdTenants.Rows[e.RowIndex].Cells["firstName"].Value + " To this Rental?", "Add Tenant To Rental Contract.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // if yes Add to Added grd.
                tenant1Added = false;

                //check if this tenant is already added.
                if(grdTenantsAdded.Rows.Count > 1){

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

            DisplayTenantsList();

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
            // At start set time date time to now and future time to 12 months ahead.
            dtpStartDate.Value = DateTime.Now;
            // end date 12 months ahead default.
            dtpEndDate.Value = DateTime.Now.AddMonths(12);
        }
    }
}
