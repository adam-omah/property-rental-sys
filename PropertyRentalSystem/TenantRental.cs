using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalSystem
{
    class TenantRental
    {
        private int rentalID;
        private int tenantID;
        private string status;

        public TenantRental(int rentalID, int tenantID, String status)
        {
            this.rentalID = rentalID;
            this.tenantID = tenantID;
            this.status = status;
        }

        public void addTenantRental()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Tenant_Rentals Values (" +
                this.rentalID + "," +
                this.tenantID + ",'" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findActiveTenantRentals(int rentalID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM tenant_rentals " +
                "WHERE RENTALID = " + rentalID  + " AND status = 'A'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tenant_rentals");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet findAllTenantRentals(int rentalID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM tenant_rentals " +
                "WHERE RENTALID = " + rentalID ;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "tenant_rentals");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static void updateTenantRental(int rentalID, int tenantID,String status)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Tenant_Rentals SET " +
                "rentalId = " + rentalID + "," +
                "tenantId = " + tenantID + "," +
                "status = '" + status + "' " +
                "WHERE tenantId = " + tenantID + " AND rentalID = " + rentalID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public String getStatus()
        {
            return status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }


        public int getRentalID()
        {
            return rentalID;
        }

        public void setRentalID(int rentalID)
        {
            this.rentalID = rentalID;
        }

        public int getTenantID()
        {
            return tenantID;
        }

        public void setTenantID(int tenantID)
        {
            this.tenantID = tenantID;
        }

    }
}
