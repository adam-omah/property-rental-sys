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
    public partial class frmListTenants : Form
    {
        public frmListTenants()
        {
            InitializeComponent();
        }

        private void frmListTenants_Load(object sender, EventArgs e)
        {
            // Retrieve all the data from our table. and insert into grid.

            grdTenants.DataSource = Tenants.getAllTenants().Tables["tenants"];


        }
    }
}
