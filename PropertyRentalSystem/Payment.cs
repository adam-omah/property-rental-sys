using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace PropertyRentalSystem
{
    class Payment
    {

        private int payID;
        private int rentID;
        private double amount;
        private String payDate;

        public Payment(int rentID, double amount, String payDate)
        {
            this.rentID = rentID;
            this.amount = amount;
            this.payDate = payDate;


            // Connecting to DB to get new RentalID for Rental,
            // As Rental Records are not fully deleted count is usable.
            // Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Select * From Payments";
            conn.Open();

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            int count = 0;

            // Using Reader to go through each record to count ther number of rows.
            // I tried using a Count Sql query however that kept giving a cast type error.
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                // Calls reader each time to go through the records.
                while (reader.Read())
                {
                    count++;
                }
            }

            this.payID = count + 1;

        }

        public void addPayment()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Payments Values (" +
                this.payID + "," +
                this.rentID + "," +
                this.amount + ",'" +
                this.payDate + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public int getPayID()
        {
            return payID;
        }

        public void setPayID(int payID)
        {
            this.payID = payID;
        }

        public int getRentID()
        {
            return rentID;
        }

        public void setRentID(int rentID)
        {
            this.rentID = rentID;
        }

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public String getDate()
        {
            return payDate;
        }

        public void setDate(String date)
        {
            this.payDate = date;
        }
    }
}
