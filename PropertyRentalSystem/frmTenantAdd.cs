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
    public partial class frmTenantAdd : Form
    {
        public frmTenantAdd()
        {
            InitializeComponent();
        }

        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            // On CLick Validate Add Tenant Details.
            // Very similar to add Owner however there is no Eircode.

            // checks name fields
            //check first name.
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if(txtFirstName.Text.Length > 25)
            {
                MessageBox.Show("First Name Can only have 25 characthers max","Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            // Save to Data Store once validated.
            // Set Tenant Status to 'A' for active, Tenant ID is assigned in Tenants.cs
            Tenant aTenant = new Tenant(validationFunctions.SQLApostrophe(txtFirstName.Text), validationFunctions.SQLApostrophe(txtLastName.Text), Convert.ToInt32(txtPhoneNumber.Text),
                txtEmailAddress.Text, txtTenantIban.Text, "A");

            //invoke the method to add the data to the Products table
            aTenant.addTenant();


            // display confirmation Message:
            MessageBox.Show("Tenant Has Been Added to the Tenants Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtTenantIban.Clear();
            //Reset focus to first name.
            txtFirstName.Focus();

        }
    }
}
