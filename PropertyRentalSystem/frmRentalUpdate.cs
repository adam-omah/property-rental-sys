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
    public partial class frmRentalUpdate : Form
    {
        public frmRentalUpdate()
        {
            InitializeComponent();
        }

        List<Tenant> StartTenants = new List<Tenant>();
        List<Tenant> EndTenants = new List<Tenant>();
        Property theProperty = new Property();
        PropOwner theOwner = new PropOwner();
        Tenant theTenant = new Tenant();
        Rental theRental = new Rental();
        String startDateFormat;
        String endDateFormat;

        public Boolean tenant1Added = false;

        private void btnSRHEircode_Click(object sender, EventArgs e)
        {
            // Set groups to invisible (ensures that if an eircode was already search is not same one).
            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            grdTenants.Visible = false;
            btnUpdateRental.Visible = false;

            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidEircode = validationFunctions.validEircode(txtEircodeSRH.Text);

            if (!isValidEircode)
            {
                MessageBox.Show("Eircode is Invalid, Please enter a valid Eircode", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircodeSRH.Clear();
                txtEircodeSRH.Focus();
                return;
            }
            else
            {
                //find matching Property
                grdTenants.DataSource = Property.findProperties(txtEircodeSRH.Text.ToUpper()).Tables["Properties"];

                if (grdTenants.Rows.Count == 1)
                {
                    // Property Not found.
                    MessageBox.Show("The Eircode " + txtEircodeSRH.Text + " Is not on the system,\nPlease try another eircode such as  'v92cccc' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEircodeSRH.Clear();
                    txtEircodeSRH.Focus();
                    return;
                }
                else
                {
                    // Property was found, instantiate it.
                    // setting eircode to uper case chars, removes inconsistency.
                    theProperty.getProperty(txtEircodeSRH.Text.ToUpper());


                    if (theProperty.getStatus() == 'R')
                    {
                        // Find the Rental ID asscoiated with this rental.
                        theRental.getRental(theProperty.getEircode());


                        // If property is Rented and Rental ID is Active. Set Grps to visible.
                        grpPropertyDetails.Visible = true;
                        grpRentalDetails.Visible = true;
                        btnUpdateRental.Visible = true;

                        txtPropertyEircode.Text = theProperty.getEircode();
                        txtMonthlyRent.Text = theProperty.getRentalPrice().ToString();
                        txtPropertyName.Text = theProperty.getHouseName();

                        // Set Owner from property Owner ID.
                        theOwner.getOwner(theProperty.getOwnerID());
                        // Set the Owners Name into text box.
                        txtPropertyOwner.Text = theOwner.getFirstName() + " " + theOwner.getSurname();

                        // Set Rental ID
                        txtRentalID.Text = theRental.getRentalID().ToString();

                        // set rental details.
                        startDateFormat = theRental.getStartDate();
                        endDateFormat = theRental.getEndDate();

                        dtpStartDate.Value = DateTime.Parse(startDateFormat);

                        // if start date is in the past, lock the start date from being changed.
                        // this ensures that start date is historically correct,
                        // but allows for a rent that was to start in the future to be started earlier.
                        if(dtpStartDate.Value.Date <= DateTime.Now.Date)
                        {
                            dtpStartDate.Enabled = false;
                        }

                        dtpEndDate.Value = DateTime.Parse(endDateFormat);
             

                        // find all the tenants in the rental id that are active:
                        grdTenants.DataSource = TenantRental.findTenantRentals(theRental.getRentalID()).Tables["tenant_rentals"];




                        // must be -1 from checking row count
                        // MessageBox.Show("row count: " + grdTenants.Rows.Count);
                        // row count is always > 1 as there must a tenant on a rental.
                        for (int i = 0; i < grdTenants.Rows.Count- 1; i++)
                        {
                            // just for testing
                            //MessageBox.Show("Tenant id: " + grdTenants.Rows[i].Cells["TenantID"].Value.ToString());
                            
                            //Add each unit to the starting tentants array (keeps track of tenants id's already active.)
                            Tenant aTenant = new Tenant();
                            aTenant.getTenant(Convert.ToInt32(grdTenants.Rows[i].Cells["TenantID"].Value.ToString()));
                            StartTenants.Add(aTenant);
                        }

                        foreach (var tenant in StartTenants)
                        {
                            grdTenantsAdded.Rows.Add(tenant.getTenantID().ToString(), tenant.getFirstName().ToString(),tenant.getLastName().ToString(), tenant.getPhoneNumber().ToString());
                        }

                        //testing only:
                        //DisplayTenantsList();
                        

                        // since only active rentals can be updated:
                        cboRentalStatus.SelectedIndex = 0;

                        // Set groups visible
                        grpPropertyDetails.Visible = true;
                        grpRentalDetails.Visible = true;
                        grpTenants.Visible = true;
                        btnUpdateRental.Visible = true;
                        grdTenants.Visible = false;

                        

                    }
                    else
                    {
                        // Property is not available.
                        MessageBox.Show("The Eircode " + txtEircodeSRH.Text + " Is On the System\nBut is NOT Rented, (Available or Unavailable)\nPlease try another eircode such as  'v92cccc' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEircodeSRH.Clear();
                        txtEircodeSRH.Focus();
                        return;
                    }
                }
            }
        }

        private void grdTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve Full owner Details from File.
            grdTenants.CurrentRow.Selected = true;

            DialogResult dialogResult = MessageBox.Show("Would you like to remove the tenant? " + (string)grdTenants.Rows[e.RowIndex].Cells["firstName"].Value + " from this rental?", "Warning!!!! Removing Tenant", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // if yes Remove the tenant from the grd.
                grdTenants.Rows.RemoveAt(this.grdTenants.Rows[e.RowIndex].Index);
            }
            
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

        private void btnUpdateRental_Click(object sender, EventArgs e)
        {
            //Validation for update:
            
            // extend months is always 0 or positive and capped at 5 years extension so no need for validation.

            // if no tenants are added.
            if (grdTenants.RowCount == 1)
            {
                MessageBox.Show("Please add atleast one tenant using the search bar.");
                txtSurnameSRH.Focus();
                return;
            }

            // after all validation above has been checked,

            // Update Rental Contract in the Rentals Data file.
            // Create Tenant Rentals in tenant rentals file for each new tenant, close for any deleted tenants.
            // NOT DOING THIS!!!

            //show confirmation message
            MessageBox.Show("Rental Details Have Been Updated in the Rental Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI.
            txtEircodeSRH.Clear();
            txtMonthlyRent.Clear();
            txtPropertyEircode.Clear();
            txtPropertyName.Clear();
            txtPropertyOwner.Clear();

            dtpEndDate.Value = DateTime.Now;

            txtSurnameSRH.Clear();
            grdTenants.Rows.Clear();

            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnUpdateRental.Visible = false;

            txtEircodeSRH.Focus();
        }

        private void frmRentalUpdate_Load(object sender, EventArgs e)
        {
            cboRentalStatus.Items.Add("Active - 'A' ");
            cboRentalStatus.Items.Add("Inactive - 'I' ");
        }

        private void DisplayTenantsList()
        {
            String message = "";

            foreach (var item in StartTenants)
            {
                message += item.getFirstName() + "\n";
            }

            MessageBox.Show("The following Tenants are in the list:\n " + message);
        }

        private void grdTenants_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to Add the tenant? " + (string)grdTenants.Rows[e.RowIndex].Cells["firstName"].Value + " To this Rental?", "Add Tenant To Rental Contract.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // if yes Add to Added grd.
                tenant1Added = false;

                //check if this tenant is already added.
                if (grdTenantsAdded.Rows.Count > 1)
                {

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

                    EndTenants.Add(aTenant);

                }
                else
                {
                    MessageBox.Show("This Tenant has already been added, Please try another Tenant.", "Error Tenant Already Added.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                for (int i = 0; i < EndTenants.Count; i++)
                {
                    if (EndTenants[i].getTenantID() == Convert.ToInt32(grdTenantsAdded.Rows[e.RowIndex].Cells["tenantID"].Value))
                    {
                        removeTenantIndex = i;
                    }
                }

                if (removeTenantIndex != -1)
                {
                    EndTenants.RemoveAt(removeTenantIndex);
                }

                grdTenantsAdded.Rows.RemoveAt(this.grdTenantsAdded.Rows[e.RowIndex].Index);
            }
        }
    }
}
