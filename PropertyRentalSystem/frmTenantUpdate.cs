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
    public partial class frmTenantUpdate : Form
    {
        public frmTenantUpdate()
        {
            InitializeComponent();
        }

        Tenant theTenant = new Tenant();

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            //find matching Tenants
            grdTenants.DataSource = Tenant.findTenants(txtSurnameSRH.Text).Tables["Tenants"];

            if (grdTenants.Rows.Count == 0)
            {
                MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Clear();
                txtSurnameSRH.Focus();
                return;
            }

            //display Tenants surname search grid 
            grdTenants.Visible = true;

            // Hiding Tenant details if new search.
            grpTenant.Visible = false;
            
        }

        private void grdTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve Full Tenant Details from File.
            //extract the TenantID from column zero on the selected row in grid and use tof ind Tenant
            int Id = Convert.ToInt32(grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //instantiate The Tenant
            theTenant.getTenant(Id);

            // these values will be retrieved from the data store in the future however for now it is simply populated:
            txtTenantID.Text = theTenant.getTenantID().ToString();
            txtFirstName.Text = theTenant.getFirstName();
            txtLastName.Text = theTenant.getLastName();
            txtPhoneNumber.Text = theTenant.getPhoneNumber().ToString();
            txtEmailAddress.Text = theTenant.getEmail();
            txtTenantIban.Text = theTenant.getIban();


            // Set Status based on Tenant status.
            if (theTenant.getStatus().Substring(0,1).Equals("A"))
            {
                cboTenantStatus.SelectedIndex = 0;
            }
            else
            {
                cboTenantStatus.SelectedIndex = 1;
            }


            // display Tenant details.
            grpTenant.Visible = true;

            // hiding surname search grid after selection:
            grdTenants.Visible = false;
        }



        private void frmTenantUpdate_Load(object sender, EventArgs e)
        {
            // loading the possible Tenant Status's :
            cboTenantStatus.Items.Add("Active - 'A' ");
            cboTenantStatus.Items.Add("Inactive - 'I' ");
        }

        private void btnUpdateTenantDetails_Click(object sender, EventArgs e)
        {
            // On CLick Validate Add Tenant Details.
            // Very similar to add Tenant however there is no Eircode.

            // checks name fields
            //check first name.
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtFirstName.Text.Length > 25)
            {
                MessageBox.Show("First Name Can only have 25 characthers max", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            // checks last name.
            if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last Name Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }
            if (txtLastName.Text.Length > 30)
            {
                MessageBox.Show("Last Name Can only have 30 characthers max", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            //checks valid phone number:

            if (txtPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            // moved validation of Phone numbers to a public helper class.
            bool isValidPhone = validationFunctions.validPhoneNumber(txtPhoneNumber.Text);
            if (!isValidPhone)
            {
                MessageBox.Show("Phone Number Must Be Valid,\nLarger than 7 numbers and can only have one +, no spaces!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }


            // checks Valid email
            if (txtEmailAddress.Text.Equals(""))
            {
                MessageBox.Show("Email Address Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }

            // moved validation of Email to a public helper class.
            bool isValidEmail = validationFunctions.validEmail(txtEmailAddress.Text);

            if (!isValidEmail)
            {
                MessageBox.Show("Email entered is not valid", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }



            // IBAN Validation:
            if (txtTenantIban.Text.Equals(""))
            {
                MessageBox.Show("IBAN Must be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenantIban.Focus();
                return;
            }
            // moved validation of Iban to a public helper class
            bool isValidIban = validationFunctions.validIban(txtTenantIban.Text);

            if (!isValidIban)
            {
                MessageBox.Show("Valid IBAN Must be entered!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenantIban.Focus();
                return;
            }


            // Update Tenant in Tenants Data Store once validated.

            //instantiate the object variables
            theTenant.setTenantID(Convert.ToInt32(txtTenantID.Text));
            theTenant.setFirstName(validationFunctions.SQLApostrophe(txtFirstName.Text));
            theTenant.setLastName(validationFunctions.SQLApostrophe(txtLastName.Text));
            theTenant.setPhoneNumber(Convert.ToInt32(txtPhoneNumber.Text));
            theTenant.setEmail(txtEmailAddress.Text);
            // setting eircode to uper case chars, removes inconsistency.
            theTenant.setIban(txtTenantIban.Text);
            theTenant.setStatus(cboTenantStatus.Text.Substring(0, 1));

            theTenant.updateTenant();

            // display confirmation Message:
            MessageBox.Show("Tenant Details Have Been Updated on the Tenants Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            txtTenantID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtTenantIban.Clear();
            //Reset focus to first name.
            txtSurnameSRH.Clear();

            // Hide Update Details again.
            grpTenant.Visible = false;
            grdTenants.Visible = false;

            //Reset focus to Search field.
            txtSurnameSRH.Focus();
        }

        
    }
}
