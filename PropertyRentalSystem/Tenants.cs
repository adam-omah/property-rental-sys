using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace PropertyRentalSystem
{
    class Tenants
    {
        private int tenantID;
        private String firstName;
        private String surname;

        public Tenants(int tenantID, string firstName, string surname)
        {
            this.tenantID = tenantID;
            this.firstName = firstName;
            this.surname = surname;
        }

        public static DataSet getAllTenants()
        {
            // Connect to Oracle
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            // Create SQL String Query

            String sqlQuery = "Select tenantID, firstName,surname FROM Tenants";

            // Connect Dataset to the database

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter dataAd = new OracleDataAdapter(cmd);
            

            DataSet ds = new DataSet();
            // fill the data set using the adapter.
            dataAd.Fill(ds, "tenants");

            // if your data isnt showing, May need to commit changes to the database.
            // and restart visual studio. 
           

            return ds;
        }
    }
}
