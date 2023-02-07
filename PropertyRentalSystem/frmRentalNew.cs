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
        String dateFormat;

        public Boolean tenant1Added = false;
        public Boolean tenant2Added = false;

        private void btnSRHEircode_Click(object sender, EventArgs e)
        {
            // Set groups to invisible (ensures that if an eircode was already search is not same one).
            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;

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


                    if (theProperty.getStatus() == 'A')
                    {
                        // If property is available. Set Grps to visible.
                        grpPropertyDetails.Visible = true;
                        grpRentalDetails.Visible = true;
                        grpTenants.Visible = true;
                        btnCreateRental.Visible = true;

                        txtPropertyEircode.Text = theProperty.getEircode();
                        txtMonthlyRent.Text = theProperty.getRentalPrice().ToString();
                        txtPropertyName.Text = theProperty.getHouseName();

                        // Set Owner from property Owner ID.
                        theOwner.getOwner(theProperty.getOwnerID());
                        // Set the Owners Name into text box.
                        txtPropertyOwner.Text = theOwner.getFirstName() + " " + theOwner.getSurname();


                    }
                    else
                    {
                        // Property is not available.
                        MessageBox.Show("The Eircode " + txtEircodeSRH.Text + " Is On the System\nBut is NOT available (either Rented or unavailable.)\nPlease try another eircode such as  'v92cccc' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEircodeSRH.Clear();
                        txtEircodeSRH.Focus();
                        return;
                    }


                }
            }
        }

        private void btnCreateRental_Click(object sender, EventArgs e)
        {

            // Validate Data.

            // Date must be sometime in the futre.
            if (!(dtpStartDate.Value.Date >= DateTime.Now.Date))
            {
                MessageBox.Show("Start Date must be from today or in the future! cannot be in the past.");
                return;
            }
            // Checks if start date is greater than 3 months from start date. (for months up to month 9.)
            else if(dtpStartDate.Value.Date.Month <= 10 && dtpStartDate.Value.Date.Month > DateTime.Now.Month +2)
            {
                MessageBox.Show("Start Date must be Less than 3 months into the future, \nCurrent Month + 2 Calander Months  Regardless of Day.");
                return;
            }
            // check if month is November and not greater than febuary
            else if
                (DateTime.Now.Month == 11 && !(dtpStartDate.Value.Date.Month == 11 || dtpStartDate.Value.Date.Month == 12 ||  dtpStartDate.Value.Date.Month == 1))
            {
                MessageBox.Show("Start Date must be Less than 3 months into the future, \nCurrent Month + 2 Calander Months Regardless of Day.");
                return;
            }
            //  checks if month is december and start date nto greater than march.
            else if
                (DateTime.Now.Month == 12 && !(dtpStartDate.Value.Date.Month == 12 || dtpStartDate.Value.Date.Month == 1 || dtpStartDate.Value.Date.Month == 2))
            {
                MessageBox.Show("Start Date must be Less than 3 months into the future, \nCurrent Month + 2 Calander Months Regardless of Day.");
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
            dateFormat = String.Format("{0:dd-MMM-yy}", dtpStartDate.Value);

            // Instantiate the Rental.
            Rental theRental = new Rental(dateFormat, Convert.ToInt32(theOwner.getOwnerID()),Convert.ToInt32(numRentDuration.Value),"A",theProperty.getEircode());

            theRental.addRental();

            // update Property to Rented.

            theProperty.setStatus("R");
            theProperty.updateProperty();

            DisplayTenantsList();
            // Create Tenant Rentals in tenant rentals file for each tenant.
            for (int i = 0; i < tenants.Count; i++)
            {
                MessageBox.Show("Tenant to add: " + tenants[i].getTenantID() + "\nRental Id : " + theRental.getRentalID());
                TenantRental tRent = new TenantRental(Convert.ToInt32(theRental.getRentalID()), Convert.ToInt32(tenants[i].getTenantID()), "A");
                // add the tenant rental to tenant Rentals file.
                tRent.addTenantRental();
            }

            //show confirmation message
            MessageBox.Show("Rental Details Have Been Updated on the Rental Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI.
            txtEircodeSRH.Clear();
            txtMonthlyRent.Clear();
            txtPropertyEircode.Clear();
            txtPropertyName.Clear();
            txtPropertyOwner.Clear();

            dtpStartDate.Value = DateTime.Now;
            numRentDuration.Value = 12;

            txtSurnameSRH.Clear();
            grdTenants.DataSource.Equals(null);
            grdTenants.Visible = false;
            grdTenantsAdded.Rows.Clear();

            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;

            txtEircodeSRH.Focus();
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
    }
}
