using Oracle.ManagedDataAccess.Client;
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

        private String year;
        private DataSet dsYears;
        // Commision Rate of 5%
        private float commissionRate = 0.075f;

        private void frmYearlyCommission_Load(object sender, EventArgs e)
        {
            chtCommision.Visible = false;
            // On load retrieve data from completed years of opperation:

            dsYears = Admin.getYears();
            cboYearlyCommision.Items.Clear();
            for (int i = 0; i < dsYears.Tables[0].Rows.Count; i++)
            {
                    // Add each year to the cbo.
                    cboYearlyCommision.Items.Add("Year - " + dsYears.Tables[0].Rows[i][0].ToString());

            }

        }

        private void cboYearlyCommision_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changes Year to just last 2 chars to make it work for oracle sql format.
            year = cboYearlyCommision.Items[cboYearlyCommision.SelectedIndex].ToString().Substring(7, 4);

            displayYearGraph(year.Substring(2,2));

        }

        private void displayYearGraph(String yearShort)
        {
            String strSQL = "SELECT SUM(amount), to_Char(PAYDATE,'MM') AS Month FROM " +
                "PAYMENTS where PAYDATE LIKE '%-" + yearShort + "' GROUP BY to_Char(PAYDATE,'MM') ORDER BY Month";
            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);


            myConn.Close();


            if (dt.Rows.Count == 0)
            {
                chtCommision.Visible = false;
                MessageBox.Show("No Data for selected year.", "Error");
                return;
            }

            //Array size to the count of months.
            string[] Months = new string[dt.Rows.Count];
            decimal[] Rent = new decimal[dt.Rows.Count];
            decimal[] Commision = new decimal[dt.Rows.Count];
            decimal totalRent = 0;
            decimal totalCommision = 0;



            //Fill each Array, Months , Rental Paid, Commision, add to totals.
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Months[i] = Admin.getMonth(Convert.ToInt32(dt.Rows[i][1]));
                Rent[i] = Convert.ToDecimal(dt.Rows[i][0]);
                Commision[i] = Convert.ToDecimal(Rent[i] * Convert.ToDecimal(commissionRate));

                totalCommision += Commision[i];
                totalRent += Rent[i];

            }


            chtCommision.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtCommision.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtCommision.ChartAreas[0].AxisX.Interval = 1;
            chtCommision.Series[0].LegendText = "Rent in €";
            chtCommision.Series[0].Points.DataBindXY(Months, Rent);
            chtCommision.Series[1].LegendText = "Commission in €";
            chtCommision.Series[1].Points.DataBindXY(Months, Commision);
            chtCommision.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            chtCommision.Series[0].Label = "#VAL";
            chtCommision.Series[1].Label = "#VAL";
            chtCommision.Titles.Clear();
            chtCommision.Titles.Add("Year of " + year);
            chtCommision.Titles.Add("Total Rent: €" + totalRent.ToString("N2"));
            chtCommision.Titles.Add("Total Commision: €" + totalCommision.ToString("N2"));
            chtCommision.Visible = true;

        }
        
        
    }
}
