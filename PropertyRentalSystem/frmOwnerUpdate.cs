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
        PropOwner theOwner = new PropOwner();

        public frmOwnerUpdate()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Hiding Owner details if new search.
            grpOwner.Visible = false;

            //find matching Owners
            grdOwners.DataSource = PropOwner.findOwners(txtSurnameSRH.Text.ToUpper()).Tables["Owner"];

            if (grdOwners.Rows.Count == 0)
            {
                MessageBox.Show("The surname " + txtSurnameSRH.Text + " Was not found,\nPlease try another surname such as  'Smith' ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurnameSRH.Clear();
                txtSurnameSRH.Focus();
                grdOwners.Visible = false;
                btnHome1.Visible = true;
                return;
            }


            //display owners surname search grid 
            grdOwners.Visible = true;
            lblOwners.Visible = true;
            btnHome1.Visible = false;


        }

        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Retrieve Full owner Details from File.
            //extract the OwnerID from column zero on the selected row in grid and use to find owner
            int Id = Convert.ToInt32(grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //instantiate The Owner
            theOwner.getOwner(Id);

            // these values will be retrieved from the data store in the future however for now it is simply populated:
            txtOwnerID.Text = theOwner.getOwnerID().ToString();
            txtFirstName.Text = theOwner.getFirstName();
            txtLastName.Text = theOwner.getSurname();
            txtPhoneNumber.Text = theOwner.getPhoneNumber().ToString();
            txtEmailAddress.Text = theOwner.getEmail();
            txtHomeEircode.Text = theOwner.getEircode();
            txtOwnerIban.Text = theOwner.getIban();


            // Set Status based on owner status.
            if(theOwner.getStatus() == 'A')
            {
                cboOwnerStatus.SelectedIndex = 0;
            }
            else
            {
                cboOwnerStatus.SelectedIndex = 1;
            }
            


            // display owner details.
            grpOwner.Visible = true;
            txtFirstName.Focus();

            // hiding surname search grid after selection:
            grdOwners.Visible = false;
            lblOwners.Visible = false;

        }

        private void frmOwnerUpdate_Load(object sender, EventArgs e)
        {
            // Centre on screen
            this.CenterToScreen();
            // moves up 150 units so that its expansion is allowed for.
            this.Top -= 150;

            // loading the possible Owner Status's :
            cboOwnerStatus.Items.Add("Active - 'A' ");
            cboOwnerStatus.Items.Add("Inactive - 'I' ");

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
            if (txtFirstName.Text.Length > 25)
            {
                MessageBox.Show("First Name Can only have 25 characthers max", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            bool isFirstName = validationFunctions.validTextString(txtFirstName.Text);
            if (!isFirstName)
            {
                MessageBox.Show("First Name Must not be only numbers", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            // checks last name.
            if (txtLastName.Text.Length > 30)
            {
                MessageBox.Show("Last Name Can only have 30 characthers max", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }
            bool isLastName = validationFunctions.validTextString(txtLastName.Text);
            if (!isLastName)
            {
                MessageBox.Show("Last Name Must not be only numbers", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




            // Save to Data Store once validated.
            //Set the object variables
            theOwner.setOwnerID(Convert.ToInt32(txtOwnerID.Text));
            theOwner.setFirstName(validationFunctions.SQLApostrophe(txtFirstName.Text.ToUpper()));
            theOwner.setSurname(validationFunctions.SQLApostrophe(txtLastName.Text.ToUpper()));
            theOwner.setPhone(Convert.ToInt64(txtPhoneNumber.Text));
            theOwner.setEmail(txtEmailAddress.Text);
            // setting eircode to uper case chars, removes inconsistency.
            theOwner.setEircode(txtHomeEircode.Text.ToUpper());
            theOwner.setIban(txtOwnerIban.Text);
            theOwner.setStatus(cboOwnerStatus.Text.Substring(0, 1));
            // update called
            theOwner.updateOwner();

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
            btnHome1.Visible = true;

            //Reset focus to Search field.
            txtSurnameSRH.Focus();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // txt searches if key down is enter.
        private void txtSurnameSRH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnSearch_Click(sender, e);
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
