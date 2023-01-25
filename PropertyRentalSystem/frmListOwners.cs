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
    public partial class frmListOwners : Form
    {
        public frmListOwners()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            //retrieve all data from Owners table
            grdOwners.DataSource = Owners.getAllOwners().Tables["owner"];

        }
    }
}
