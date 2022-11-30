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
    public partial class frmRentalsYear : Form
    {
        public frmRentalsYear()
        {
            InitializeComponent();
        }

        private void frmRentalsYear_Load(object sender, EventArgs e)
        {
            // On load retrieve data from completed years of opperation:
            // for example we are using 2018 and 2019 as exmaple data.
            cboRentalsInYear.Items.Add("Year 2018");
            cboRentalsInYear.Items.Add("Year 2019");
        }

        private void cboRentalsInYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // example if year selected retrieve data from rentals for that year and produce graph:
            if (cboRentalsInYear.SelectedIndex == 0)
            {
                pboRentalsGraph.Image = Properties.Resources.Rentals2018;
                pboRentalsGraph.Refresh();
                pboRentalsGraph.Visible = true;
            }

            if (cboRentalsInYear.SelectedIndex == 1)
            {
                pboRentalsGraph.Image = Properties.Resources.Rentals2019;
                pboRentalsGraph.Refresh();
                pboRentalsGraph.Visible = true;
            }
        }
    }
}
