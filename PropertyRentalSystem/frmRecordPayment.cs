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


        Property theProperty = new Property();
        Rental theRental = new Rental();
        

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
                MessageBox.Show("Invalid Payment Amount \nMust be Positive Number, only 1 . ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtEircodeSRH.Clear();
            txtMonthlyRent.Clear();
            txtEircode.Clear();
            dtpPaymentDate.Value = DateTime.Now;

            grpPayerDetails.Visible = false;
            grpPaymentDetails.Visible = false;
            btnRecordPayment.Visible = false;

            txtEircodeSRH.Focus();

        }

        private void btnEircodeSRH_Click(object sender, EventArgs e)
        {
            // reset grd.
            grdProperty.DataSource = null;
            grdProperty.Rows.Clear();
            grdProperty.Visible = false;

            //find matching Property
            grdProperty.DataSource = Property.findProperties(txtEircode.Text.ToUpper()).Tables["Properties"];

            if (grdProperty.Rows.Count == 1)
            {
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

                // Set the values in payer details to recovered details.
                txtEircode.Text = theProperty.getEircode();
                txtMonthlyRent.Text = theProperty.getRentalPrice().ToString();
                txtPropertyName.Text = theProperty.getHouseName();

                // if property is rented, instantiate the rental,

                if (theProperty.getStatus() == 'R')
                {
                    //instantiate the rental
                    theRental.getRental(txtEircodeSRH.Text.ToUpper());
                    // set the rental id to active rental.
                    txtActiveRental.Text = theRental.getRentalID().ToString();
                    
                    grdProperty.Visible = false;
                    grpPayerDetails.Visible = true;
                    grpPaymentDetails.Visible = true;
                    btnRecordPayment.Visible = true;
                }
                // if not find historic rental
                else
                {
                    // find all rentals of this 
                    //find matching Tenants
                    grdProperty.DataSource = null;
                    grdProperty.Rows.Clear();

                    grdProperty.DataSource = Rental.findRentals(theProperty.getEircode()).Tables["Rentals"];

                    if (grdProperty.Rows.Count == 1)
                    {
                        MessageBox.Show("No rentals for this eircode were found,\nPlease try another Eirocde Or create the rental first. ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    grdProperty.Visible = true;
                    grpPayerDetails.Visible = false;
                    grpPaymentDetails.Visible = false;
                    btnRecordPayment.Visible = false;
                }
            }
        }

        private void grdProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve Full owner Details from File.
            grdProperty.CurrentRow.Selected = true;

            // Retrieve Full owner Details from File.
            //extract the OwnerID from column zero on the selected row in grid and use to find owner
            int rentId = Convert.ToInt32(grdProperty.Rows[grdProperty.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //instantiate The Rental
            theRental.getRentalWithID(rentId);
            // set the rental id to active rental.
            txtActiveRental.Text = theRental.getRentalID().ToString();

            // display Payment Details again. hide grd.
            // reset grd.
            grdProperty.DataSource = null;
            grdProperty.Rows.Clear();
            grdProperty.Visible = false;

            grpPayerDetails.Visible = true;
            grpPaymentDetails.Visible = true;
            btnRecordPayment.Visible = true;
        }
    }
}
