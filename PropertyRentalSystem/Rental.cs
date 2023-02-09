using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalSystem
{
    class Rental
    {
        private int rentalID;
        private String startDate;
        private String endDate;
        private String status;
        private int ownerID;
        private String eircode;

        public Rental()
        {
            rentalID = 0;
            startDate = "01-MAY-20";
            endDate = "01-MAY-21";
            status = "I";
            eircode = "fffffff";
        }

        public Rental(String startDate, int ownerID, String endDate, String status, String eircode)
        {

            this.eircode = eircode;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.ownerID = ownerID;

            // Connecting to DB to get new RentalID for Rental,
            // As Rental Records are not fully deleted count is usable.
            // Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Select * From Rentals";
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

            this.rentalID = count + 1;
        }

        public void addRental()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Rentals Values (" +
                this.rentalID + "," +
                this.ownerID + ",'" +
                this.eircode + "','" +
                this.startDate + "','" +
                this.endDate + "','" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getRental(String eircode)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM rentals WHERE eircode = '" + eircode + "' AND status = 'A'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setRentalID(dr.GetInt32(0));
            setOwnerID(dr.GetInt32(1));
            setEircode(dr.GetString(2));
            setStartDate(dr.GetString(3));
            setEndDate(dr.GetString(4));
            setStatus(dr.GetString(5));

            //close DB
            conn.Close();
        }

       


        public int getRentalID()
        {
            return rentalID;
        }

        public int getOwnerID()
        {
            return ownerID;
        }

        public void setOwnerID(int ownerID)
        {
            this.ownerID = ownerID;
        }

        public void setRentalID(int rentalID)
        {
            this.rentalID = rentalID;
        }

        public String getEircode()
        {
            return eircode;
        }

        public void setEircode(String eircode)
        {
            this.eircode = eircode;
        }

        public String getStartDate()
        {
            return startDate;
        }

        public void setStartDate(String startDate)
        {
            this.startDate = startDate;
        }

        public String getEndDate()
        {
            return endDate;
        }

        public void setEndDate(String endDate)
        {
            this.endDate = endDate;
        }

        public String getStatus()
        {
            return status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }
    }
}
