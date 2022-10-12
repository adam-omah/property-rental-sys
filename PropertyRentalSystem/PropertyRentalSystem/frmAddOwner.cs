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
    public partial class frmAddOwner : Form
    {
        public frmAddOwner()
        {
            InitializeComponent();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            // On CLick Validate Add Owner Details.

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

            if (!validPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number Must Be Valid", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            
            //not made yet.


            // checks Valid email
            if (txtEmailAddress.Text.Equals(""))
            {
                MessageBox.Show("Email Address Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (!validEmailAddres(txtEmailAddress.Text))
            {
                MessageBox.Show("Email entered is not valid", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



            if (!validEircode(txtHomeEircode.Text))
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
            if (!validIban(txtOwnerIban.Text))
            {

            }


            // Set Owner status to 'A' for Active,
            // Assign Owner an Owner ID.


            // Save to Data Store once validated.
            // NOT DOING THIS!

            // display confirmation Message:
            MessageBox.Show("Owner Has Been Added", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private bool validIban(string iban)
        {
            Boolean result = true;
            char[] ibanChars = iban.ToCharArray();

            //Iban's can vary between 22 and 34 characthers.
            // in Ireland the standard IBAN is 22 characthers in length.
            // there is other patterns involved but in the interest of simplicity
            // I am only adding simple validation. testing length and components.

            if (iban.Length < 22 && iban.Length > 34)
            {
                result = false;
            }


            // Iban must be composed of only numbers or letters:

            for (int i = 0; i < ibanChars.Length; i++)
            {
                if ((ibanChars[i] >= 'a' && ibanChars[i] <= 'z') || (ibanChars[i] >= 'A' && ibanChars[i] <= 'Z') ||
                    (ibanChars[i] >= '0' && ibanChars[i] <= '9'))
                {

                }
                else
                    result = false;
            }

            return result;
        }

        private bool validPhoneNumber(string phone)
        {
            Boolean result = true;
            char[] phoneChars = phone.ToCharArray();
            int plusCount = 0;

            for(int i =0; i < phoneChars.Length; i++)
            {
                if(phoneChars[i] >= '0' && phoneChars[i] <= '9')
                {

                }
                else
                {
                    if(phoneChars[i] == '+' && plusCount < 1)
                    {
                        plusCount++;
                    }
                    else
                    {
                        result = false;
                        return result;
                    }
                }
            }


            return result;
        }

        private bool validEircode(string eircode)
        {
            Boolean result = true;
            char[] eircodeChars = eircode.ToCharArray();

            if (eircode.Length != 7)
            {
                result = false;
                return result;
            }
                

            // checks if first value is a letter
            if ((eircodeChars[0] >= 'a' && eircodeChars[0] <= 'z') || (eircodeChars[0] >= 'A' && eircodeChars[0] <= 'Z'))
            {

            }
            else
            {
                result = false;
                return result;
            }
                

            // checks if following two are numbers:
            if ((eircodeChars[1] >= '0' && eircodeChars[1] <= '9') || (eircodeChars[2] >= '0' && eircodeChars[2] <= '9'))
            {

            }
            else
            {
                result = false;
                return result;
            }

            // check if last 4 chars are letters or numbers
            for (int i = 3; i < eircodeChars.Length; i++)
            {
                if ((eircodeChars[i] >= 'a' && eircodeChars[i] <= 'z') || (eircodeChars[i] >= 'A' && eircodeChars[i] <= 'Z') ||
                    (eircodeChars[i] >= '0' && eircodeChars[i] <= '9'))
                {

                }
                else
                {
                    result = false;
                    return result;
                }
            }

            // if result makes it to here and is still true will return true eircode is valid.
            return result;
        }

        private bool validEmailAddres(String email)
        {
            Boolean result = true;
            int indexAt = email.IndexOf('@');
            int indexDot = email.IndexOf('.');
            int indexSpace = email.IndexOf(' ');
            char[] emailChars = email.ToCharArray();

            if (email.Equals("") || indexAt == -1 || indexDot == -1 || indexSpace != -1)
            {
                result = false;
            }

            // tests that the email char is valid allowed chars for email.
            // there is more but i am using a simple validation assuming standard emails.
            for(int i =0; i < emailChars.Length; i++)
            {
                if ((emailChars[i] >= 'a' && emailChars[i] <= 'z') || (emailChars[i] >= 'A' && emailChars[i] <= 'Z')
                    || (emailChars[i] >= '0' && emailChars[i] <= '9') || emailChars[i] == '@' || emailChars[i] == '.' ||
                    emailChars[i] == '_' || emailChars[i] == '-')
                {

                }
                else
                    result = false;
            }


            

            return result;
        }
    }
}
