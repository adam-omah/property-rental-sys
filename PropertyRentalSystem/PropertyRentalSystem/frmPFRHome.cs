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
            var addPropertyType = new frmAddPropertyType();
            addPropertyType.Show();
        }

        private void mnuAddOwner_Click(object sender, EventArgs e)
        {
            var addOwner = new frmAddOwner();
            addOwner.Show();
        }
    }
}
