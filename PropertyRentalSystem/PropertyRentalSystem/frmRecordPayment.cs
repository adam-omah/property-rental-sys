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
    public partial class frmRecordPayment : Form
    {
        public frmRecordPayment()
        {
            InitializeComponent();
        }

        private void btnSRHTenants_Click(object sender, EventArgs e)
        {
            //validate phone number entered.

            if (txtSRHTenant.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Must Be Entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSRHTenant.Focus();
                return;
            }

            // moved validation of Phone numbers in helper class.
            bool isValidPhone = validationFunctions.validPhoneNumber(txtSRHTenant.Text);
            if (!isValidPhone)
            {
                MessageBox.Show("Phone Number Must Be Valid,\nLarger than 7 numbers and can only have one +, no spaces!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSRHTenant.Focus();
                return;
            }

            // if valid phone retrieve data from the tenants file + the rental information from their active tenant Rental.
            if (txtSRHTenant.Text.Equals("0877777777"))
            {
                txtTenantName.Text = "Adam O'Mahony";
                txtMonthlyRent.Text = "500";
                txtActiveRental.Text = "Bird's Cottage";
                grpPayerDetails.Visible = true;
                grpPaymentDetails.Visible = true;
                btnRecordPayment.Visible = true;
            }
            else if (txtSRHTenant.Text.Equals("0879999999"))
            {
                txtTenantName.Text = "Billy El";
                txtMonthlyRent.Text = "400";
                txtActiveRental.Text = "57, Lee Accomodation";
                grpPayerDetails.Visible = true;
                grpPaymentDetails.Visible = true;
                btnRecordPayment.Visible = true;
            }
            else
            {
                MessageBox.Show("A tenant with that phone number was not found. \n Try 0877777777 or 0879999999 for example", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSRHTenant.Focus();
                return;
            }
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {

            // Validate Data.

            // Date must be sometime in the futre.
            if (dtpPaymentDate.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Payment Date must be from today or in the Past! cannot be in the Future.");
                return;
            }

            // Check is payment amount valid.
            if (txtPayAmount.Text.Equals(""))
            {
                MessageBox.Show("Payment Amount must be entered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPayAmount.Focus();
                return;
            }

            // moved validation of numbers to a public helper class to make it more gloabl.
            bool isValidNum = validationFunctions.validPositiveNumber(txtPayAmount.Text);
            if (!isValidNum)
            {
                MessageBox.Show("Invalid Payment Amount \nMust be Positive Numeric value with only one decimal .", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPayAmount.Focus();
                return;
            }


            // after all validation above has been checked,

            // Save Payment in the Payments Data file.
            // NOT DOING THIS!!!

            //show confirmation message
            MessageBox.Show("Payment Details Have Been Recorded in the Payments Data Store", "Confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // reset UI.

            txtPayAmount.Clear();
            txtSRHTenant.Clear();
            txtMonthlyRent.Clear();
            txtTenantName.Clear();
            dtpPaymentDate.Value = DateTime.Now;

            grpPayerDetails.Visible = false;
            grpPaymentDetails.Visible = false;
            btnRecordPayment.Visible = false;

            txtSRHTenant.Focus();

        }
    }
}
