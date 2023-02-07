using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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
