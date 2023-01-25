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
    public partial class frmRentalNew : Form
    {
        public frmRentalNew()
        {
            InitializeComponent();
        }

        public Boolean tenant1Added = false;
        public Boolean tenant2Added = false;

        private void btnSRHEircode_Click(object sender, EventArgs e)
        {
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
                if (txtEircodeSRH.Text.Equals("V92FFFF") || txtEircodeSRH.Text.Equals("v92ffff"))
                {
                    txtPropertyOwner.Text = "Adam O'Mahony";
                    txtPropertyName.Text = "Birds Cottage";
                    txtPropertyEircode.Text = txtEircodeSRH.Text.ToUpper();
                    txtMonthlyRent.Text = "500";
                    grpPropertyDetails.Visible = true;
                    grpRentalDetails.Visible = true;
                    grpTenants.Visible = true;
                    btnCreateRental.Visible = true;

                }
                else
                {
                    MessageBox.Show("Property with that Eircode Not Found Or is Unavailable, Please try another Eircode Such as V92FFFF ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEircodeSRH.Clear();
                    txtEircodeSRH.Focus();
                    return;
                }
            }
        }

        private void btnCreateRental_Click(object sender, EventArgs e)
        {

            // Validate Data.

            // Date must be sometime in the futre.
            if (dtpStartDate.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Start Date must be from today or in the future! cannot be in the past.");
                return;
            }


            // direct debit must be set up before a rental contract can be made.
            // first months rent / deposit can be paid in cash though.
            if(chkDirectDebit.Checked == false)
            {
                MessageBox.Show("Please set up the direct debit for the tenants, this is an external process.");
                return;
            }
            
            // if no tenants are added.
            if(grdTenants.RowCount == 1)
            {
                MessageBox.Show("Please add atleast one tenant using the search bar.");
                txtSRHTenant.Focus();
                return;
            }

            // after all validation above has been checked,

            // Save Rental Contract to Rentals Data file.
            // Create Tenant Rentals in tenant rentals file for each tenant.
            // NOT DOING THIS!!!

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
            chkDepositPaid.Checked = false;
            chkDirectDebit.Checked = false;

            txtSRHTenant.Clear();
            grdTenants.Rows.Clear();

            grpPropertyDetails.Visible = false;
            grpRentalDetails.Visible = false;
            grpTenants.Visible = false;
            btnCreateRental.Visible = false;

            txtEircodeSRH.Focus();
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

            // if valid phone 
            if (txtSRHTenant.Text.Equals("0877777777"))
            {
                if (tenant1Added == false){
                    grdTenants.Rows.Add("Adam", "Smith", "0877777777", 123);
                    grdTenants.Visible = true;
                    tenant1Added = true;
                }
                else
                {
                    MessageBox.Show("This Tenant was already added", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSRHTenant.Focus();
                    return;
                }
            }else if (txtSRHTenant.Text.Equals("0879999999"))
            {
                if (tenant2Added == false)
                {
                    grdTenants.Rows.Add("Helena", "Smith", "0877777777", 123);
                    grdTenants.Visible = true;
                    tenant2Added = true;
                }
                else
                {
                    MessageBox.Show("This Tenant was already added", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSRHTenant.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("A tenant with that phone number was not found. \n Try 0877777777 or 0879999999 for example", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSRHTenant.Focus();
                return;
            }

          

        }
    }
}
