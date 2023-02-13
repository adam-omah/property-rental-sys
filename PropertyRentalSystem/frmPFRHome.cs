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
    public partial class frmPFRHome : Form
    {
        public frmPFRHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mnuPFRAddPropertyType_Click(object sender, EventArgs e)
        {
            var addPropertyType = new frmPropertyTypeAdd();
            addPropertyType.Show();
        }

        private void mnuAddOwner_Click(object sender, EventArgs e)
        {
            var addOwner = new frmOwnerAdd();
            addOwner.Show();
        }

        private void mnuPFRAddProperty_Click(object sender, EventArgs e)
        {
            var addProperty = new frmPropertyAdd();
            addProperty.Show();
        }

        private void mnuAddTenant_Click(object sender, EventArgs e)
        {
            var addTenant = new frmTenantAdd();
            addTenant.Show();
        }

        private void mnuUpdateOwner_Click(object sender, EventArgs e)
        {
            var updateOwner = new frmOwnerUpdate();
            updateOwner.Show();
        }

        private void mnuPFRUpdatePropertyType_Click(object sender, EventArgs e)
        {
            var propertyTypeUpdate = new frmPropertyTypeUpdate();
            propertyTypeUpdate.Show();
        }

        private void mnuUpdateTenant_Click(object sender, EventArgs e)
        {
            var updateTenant = new frmTenantUpdate();
            updateTenant.Show();
        }

        private void mnuPFRUpdateProperty_Click(object sender, EventArgs e)
        {
            var updateProperty = new frmPropertyUpdate();
            updateProperty.Show();
        }

        private void mnuCreateRental_Click(object sender, EventArgs e)
        {
            var createRental = new frmRentalNew();
            createRental.Show();
        }

        private void mnuUpdateRental_Click(object sender, EventArgs e)
        {
            var updateRental = new frmRentalUpdate();
            updateRental.Show();
        }

        private void mnuRecordPayment_Click(object sender, EventArgs e)
        {
            var recordPayment = new frmRecordPayment();
            recordPayment.Show();
        }

        private void mnuYearlyCommission_Click(object sender, EventArgs e)
        {
            var yearlyCommissionReports = new frmYearlyCommission();
            yearlyCommissionReports.Show();
        }

        private void mnuRentalsInYear_Click(object sender, EventArgs e)
        {
            var rentalsYearReport = new frmRentalsYear();
            rentalsYearReport.Show();
        }

        private void mnuListItems_Click(object sender, EventArgs e)
        {

        }
    }
}
