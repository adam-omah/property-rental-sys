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
    public partial class frmOwnerAdd : Form
    {
        public frmOwnerAdd()
        {
            InitializeComponent();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            // On CLick Validate Add Owner Details.

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

            bool isFirstName = validationFunctions.validTextString(txtFirstName.Text);
            if (!isFirstName)
            {
                MessageBox.Show("First Name can only be normal english characthers and not jsut numbers", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool isLastName = validationFunctions.validTextString(txtLastName.Text);
            if (!isLastName)
            {
                MessageBox.Show("Last Name can only be normal english characthers and not jsut numbers", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Phone Number Must Be Valid,\nAt least than 7 digits and max 15 digits, no spaces!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Email entered is not valid format. \nsmith@exmaple.ie is a valid format.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }

            // eircode validation:

            if (txtHomeEircode.Text.Equals(""))
            {
                MessageBox.Show("Eircode Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHomeEircode.Focus();
                return;
            }

            // moved validation of Eircode to a public helper class to make it more gloabl.
            bool isValidEircode = validationFunctions.validEircode(txtHomeEircode.Text);

            if (!isValidEircode)
            {
                MessageBox.Show("Eircode is Invalid, Please enter a valid Eircode", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHomeEircode.Focus();
                return;
            }

            // IBAN Validation:
            if (txtOwnerIban.Text.Equals(""))
            {
                MessageBox.Show("IBAN Must be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerIban.Focus();
                return;
            }


            // moved validation of Iban to a public helper class
            bool isValidIban = validationFunctions.validIban(txtOwnerIban.Text);

            if (!isValidIban)
            {
                MessageBox.Show("Valid IBAN Must be entered!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerIban.Focus();
                return;
            }


            //Create an instance of Owner and instantiate with values from form controls
            // Set Owner Status to 'A' for active, Owner ID is assigned in Owners.cs
            PropOwner aOwner = new PropOwner(validationFunctions.SQLApostrophe(txtFirstName.Text.ToUpper()), validationFunctions.SQLApostrophe(txtLastName.Text.ToUpper()), Convert.ToInt64(txtPhoneNumber.Text),
                txtEmailAddress.Text, txtHomeEircode.Text,txtOwnerIban.Text, 'A');

            //invoke the method to add the data to the Products table
            aOwner.addOwner();


            // display confirmation Message:
            MessageBox.Show("Owner Has Been Added to the Owners Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtHomeEircode.Clear();
            txtPhoneNumber.Clear();
            txtOwnerIban.Clear();
            //Reset focus to first name.
            txtFirstName.Focus();

        }

        private void frmOwnerAdd_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOwner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnAddOwner_Click(sender, e);
        }

        private void btnHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnHome_Click(sender, e);
        }
    }
}
