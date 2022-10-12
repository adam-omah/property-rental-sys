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
    public partial class frmAddProperty : Form
    {
        public frmAddProperty()
        {
            InitializeComponent();
        }

        private void frmAddProperty_Load(object sender, EventArgs e)
        {
            // Owners with status 'A' for active are retrieved from the Owners Data store7
            // Owner id and tele phone number are retrieved along with first name last name

            cboActiveOwnerList.Items.Add("John Doe - 087 777 7777 - 124");
            cboActiveOwnerList.Items.Add("Mary O'Conner - 089 777 7777 - 58");
            cboActiveOwnerList.Items.Add("Jerry Finnerty - 085 777 7777 - 150");
            cboActiveOwnerList.Items.Add("Sarah O'Shea - 086 777 7777 - 73");

            cboPropertyType.Items.Add("BO - Bungalo");
            cboPropertyType.Items.Add("SD - Semi Detatched");
            cboPropertyType.Items.Add("DS - Standard Detatched");
            cboPropertyType.Items.Add("AP - Apartment");
            cboPropertyType.Items.Add("TH - Town House");
        }


    }
}
