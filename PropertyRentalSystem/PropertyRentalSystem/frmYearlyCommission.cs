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
    public partial class frmYearlyCommission : Form
    {
        public frmYearlyCommission()
        {
            InitializeComponent();
        }

        private void frmYearlyCommission_Load(object sender, EventArgs e)
        {

            // On load retrieve data from completed years of opperation:
            // for example we are using 2018 and 2019 as exmaple data.
            cboYearlyCommision.Items.Add("Year 2018");
            cboYearlyCommision.Items.Add("Year 2019");
        }

        private void cboYearlyCommision_SelectedIndexChanged(object sender, EventArgs e)
        {
            // example if year selected retrieve data from rentals for that year and produce graph:
            if(cboYearlyCommision.SelectedIndex == 0)
            {
                pboYearlyGraph.Image = Properties.Resources.Comm2018;
                pboYearlyGraph.Refresh();
                pboYearlyGraph.Visible = true;
            }

            if(cboYearlyCommision.SelectedIndex == 1)
            {
                pboYearlyGraph.Image = Properties.Resources.Comm2019;
                pboYearlyGraph.Refresh();
                pboYearlyGraph.Visible = true;
            }
        }

    }
}
