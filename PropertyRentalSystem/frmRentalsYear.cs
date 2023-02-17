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
    public partial class frmRentalsYear : Form
    {
        public frmRentalsYear()
        {
            InitializeComponent();
        }


        private String year;
        private DataSet dsYears;



        private void frmRentalsYear_Load(object sender, EventArgs e)
        {

            // Centre on screen
            this.CenterToScreen();
            // moves up 300 units so that its expansion is allowed for.
            this.Top -= 300;

            chtRentalsInYear.Visible = false;
            // On load retrieve data from completed years of opperation:

            dsYears = Admin.getYears();
            cboRentalsInYear.Items.Clear();
            for (int i = 0; i < dsYears.Tables[0].Rows.Count; i++)
            {
                // Add each year to the cbo.
                cboRentalsInYear.Items.Add("Year - " + dsYears.Tables[0].Rows[i][0].ToString());

            }
        }

        private void cboRentalsInYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changes Year to just last 2 chars to make it work for oracle sql format.
            year = cboRentalsInYear.Items[cboRentalsInYear.SelectedIndex].ToString().Substring(7, 4);

            displayYearGraph(year.Substring(2, 2));
        }

        private void displayYearGraph(String yearShort)
        {
            String strSQL = "SELECT Count(rentalID), to_Char(StartDate,'MM') AS Month FROM " +
                "Rentals where StartDate LIKE '%-" + yearShort + "' GROUP BY to_Char(StartDate,'MM') ORDER BY Month";
            DataTable dtStart = new DataTable();

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dtStart);


            myConn.Close();

            String strSQLEnd = "SELECT Count(rentalID), to_Char(EndDate,'MM') AS Month FROM " +
                "Rentals where EndDate LIKE '%-" + yearShort + "' GROUP BY to_Char(EndDate,'MM') ORDER BY Month";
            DataTable dtEnd = new DataTable();

            myConn = new OracleConnection(DBConnect.oradb);
            cmd = new OracleCommand(strSQLEnd, myConn);
            da = new OracleDataAdapter(cmd);
            da.Fill(dtEnd);


            myConn.Close();


            if (dtStart.Rows.Count == 0)
            {
                chtRentalsInYear.Visible = false;
                MessageBox.Show("No Data for selected year.", "Error");
                return;
            }

            //Array size to the count of months.
            string[] MonthStart = new string[dtStart.Rows.Count];
            Int32[] Rentals = new Int32[dtStart.Rows.Count];
            int totalRent = 0;

            string[] MonthEnd = new string[dtEnd.Rows.Count];
            Int32[] RentalsEnding = new Int32[dtEnd.Rows.Count];
            int totalEnd = 0;
            // decimal totalCommision = 0;



            //Fill each Array, Months , Rentals Sarting, add to total.
            for (int i = 0; i < dtStart.Rows.Count; i++)
            {
                MonthStart[i] = Admin.getMonth(Convert.ToInt32(dtStart.Rows[i][1]));
                Rentals[i] = Convert.ToInt32(dtStart.Rows[i][0]);

                totalRent += Rentals[i];
            }

            //Fill each Array, Months end , Rentals ended, add to total.
            for (int i = 0; i < dtEnd.Rows.Count; i++)
            {
                MonthEnd[i] = Admin.getMonth(Convert.ToInt32(dtEnd.Rows[i][1]));
                RentalsEnding[i] = Convert.ToInt32(dtEnd.Rows[i][0]);

                totalEnd += RentalsEnding[i];
            }


            chtRentalsInYear.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtRentalsInYear.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtRentalsInYear.ChartAreas[0].AxisX.Interval = 1;
            chtRentalsInYear.Series[0].LegendText = "Rentals Starting Per Month";
            chtRentalsInYear.Series[0].Points.DataBindXY(MonthStart, Rentals);
            chtRentalsInYear.Series[1].LegendText = "Rentals Ending Per month";
            chtRentalsInYear.Series[1].Points.DataBindXY(MonthEnd, RentalsEnding);
            chtRentalsInYear.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            chtRentalsInYear.Series[0].Label = "#VAL";
            chtRentalsInYear.Series[1].Label = "#VAL";
            chtRentalsInYear.Titles.Clear();
            chtRentalsInYear.Titles.Add("Year of " + year);
            chtRentalsInYear.Titles.Add("Total Rentals Started " + totalRent.ToString());
            chtRentalsInYear.Titles.Add("Total Rentals Ending " + totalEnd.ToString());

            chtRentalsInYear.Visible = true;

        }

    }
}
