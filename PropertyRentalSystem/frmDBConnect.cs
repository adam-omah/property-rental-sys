using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PropertyRentalSystem
{
    public partial class frmDBConnect : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmDBConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            conn.Open();
            lblStatus.Text = "Open";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
            lblStatus.Text = "Closed";
        }
    }
}
