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
    public partial class frmOwnerUpdate : Form
    {
        public frmOwnerUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSurnameSRH.Text.Equals("Smith") || txtSurnameSRH.Text.Equals("smith"))
            {
                // Find matching owners with surname.
                // retrieves owners with matching surnames from owners data file:
                grdOwners.Rows.Add("John", "Smith", "0877777777", 123);
                grdOwners.Rows.Add("Sarah", "Smith", "0867777777", 103);
                grdOwners.Rows.Add("Mary", "Smith", "0857777777", 134);
                grdOwners.Rows.Add("Jason", "Smith", "0897777777", 79);


                //display owners surname search grid 
                grdOwners.Visible = true;

                // Hiding Owner details if new search.
                grpOwner.Visible = false;
            }
            else
            {
                MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Clear();
                txtSurnameSRH.Focus();
                return;
            }
            
        }

        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve Full owner Details from File.
            // Place retrieved data into the update details UI.
            grdOwners.CurrentRow.Selected = true;
            txtFirstName.Text = (string)grdOwners.Rows[e.RowIndex].Cells["firstName"].Value;
            txtLastName.Text = (string)grdOwners.Rows[e.RowIndex].Cells["lastName"].Value;
            txtPhoneNumber.Text = (string)grdOwners.Rows[e.RowIndex].Cells["phone"].Value;

            // these values will be retrieved from the data store in the future however for now it is simply populated:
            txtEmailAddress.Text = "Smith123@example.ie";
            txtHomeEircode.Text = "V92FFFF";
            txtOwnerIban.Text = "AIBK123456789123456789";
            cboOwnerStatus.SelectedIndex = 0;


            // display owner details.
            grpOwner.Visible = true;

            // hiding surname search grid after selection:
            grdOwners.Visible = false;

        }

        private void frmOwnerUpdate_Load(object sender, EventArgs e)
        {
            // loading the possible Owner Status's :
            cboOwnerStatus.Items.Add(" Active - 'A' ");
            cboOwnerStatus.Items.Add(" Inactive - 'I' ");

        }

        private void btnUpdateOwnerDetails_Click(object sender, EventArgs e)
        {
            // on click validation is same as add owner but with the addition of the status field.

            // checks name fields
            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First Name Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last Name Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
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
            bool isValidEmail = validationFunctions.validEmailAddres(txtEmailAddress.Text);

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
                MessageBox.Show("Valid IBAN Must be entered! Please check IBAN again.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerIban.Focus();
                return;
            }


            // Set Owner status to 'A' for Active,
            // Assign Owner an Owner ID.

            // Save to Data Store once validated.
            // NOT DOING THIS!

            // display confirmation Message:
            MessageBox.Show("Owner Details have been updated \nAnd Updated in the Owners Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtHomeEircode.Clear();
            txtPhoneNumber.Clear();
            txtOwnerIban.Clear();
            cboOwnerStatus.SelectedIndex = -1;
            txtSurnameSRH.Clear();

            // Hide Update Details again.
            grpOwner.Visible = false;
            grdOwners.Visible = false;

            //Reset focus to Search field.
            txtSurnameSRH.Focus();

        }

    }
}
