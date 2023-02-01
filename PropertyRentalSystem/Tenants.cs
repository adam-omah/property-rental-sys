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

        public class Tenant
        {
            private int tenantID;
            private String firstName;
            private String lastName;
            private long phoneNumber;
            private String email;
            private String iban;
            private String status;

            public Tenant()
            {
                this.tenantID = 0;
                this.firstName = "firstName";
                this.lastName = "lastName";
                this.phoneNumber = 080000000;
                this.email = "email";
                this.iban = "iban";
                this.status = "I";
            }

            public Tenant(String firstName, String lastName, long phoneNumber, String email, String iban, String status)
            {
                int count = 0;

                this.firstName = firstName;
                this.lastName = lastName;
                this.phoneNumber = phoneNumber;
                this.email = email;
                this.iban = iban;
                this.status = status;

                // Connecting to DB to get new Tenant ID for tenants,
                // As tenant Records are not fully deleted count is usable.

                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "Select * From Tenants";
                conn.Open();

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                

                // Using Reader to go through each record to count ther number of rows.
                // I tried using a COunt Sql query however that kept giving a cast type error.
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    // Calls reader each time to go through the records.
                    while (reader.Read())
                    {
                        count++;
                    }
                }

                this.tenantID = count + 1;

            }


            public void addTenant()
            {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();

                //Define the SQL query to be executed
                String sqlQuery = "INSERT INTO Tenants Values (" +
                    this.tenantID + ",'" +
                    this.firstName + "','" +
                    this.lastName + "'," +
                    this.phoneNumber + ",'" +
                    this.email + "','" +
                    this.iban + "','" +
                    this.status + "')";

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);


                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
            }

            public static DataSet findTenants(String surname)
            {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //Define the SQL query to be executed
                String sqlQuery = "SELECT TenantID, firstName, lastName, phoneNumber FROM Tenants " +
                    "WHERE lastName LIKE '%" + surname + "%' ORDER BY firstName";

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds, "Tenants");

                //Close db connection
                conn.Close();

                return ds;
            }

            public void getTenant(int Id)
            {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //Define the SQL query to be executed
                String sqlQuery = "SELECT * FROM Tenants WHERE TenantID = " + Id;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                //set the instance variables with values from data reader
                setTenantID(dr.GetInt32(0));
                setFirstName(dr.GetString(1));
                setLastName(dr.GetString(2));
                setPhoneNumber(dr.GetInt64(3));
                setEmail(dr.GetString(4));
                setIban(dr.GetString(5));
                setStatus(dr.GetString(6));

                //close DB
                conn.Close();
            }

            public void updateTenant()
            {
                //Open a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                //Define the SQL query to be executed
                String sqlQuery = "UPDATE Tenants SET " +
                    "TenantId = " + this.tenantID + "," +
                    "firstName = '" + this.firstName + "'," +
                    "lastName = '" + this.lastName + "'," +
                    "phoneNumber = " + this.phoneNumber + "," +
                    "email = '" + this.email + "'," +
                    "iban = '" + this.iban + "'," +
                    "status = '" + this.status + "' " +
                    "WHERE TenantId = " + this.tenantID;

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
            }


            public int getTenantID()
            {
                return tenantID;
            }

            public void setTenantID(int tenantID)
            {
                this.tenantID = tenantID;
            }

            public String getFirstName()
            {
                return firstName;
            }

            public void setFirstName(String firstName)
            {
                this.firstName = firstName;
            }

            public String getLastName()
            {
                return lastName;
            }

            public void setLastName(String lastName)
            {
                this.lastName = lastName;
            }

            public long getPhoneNumber()
            {
                return phoneNumber;
            }

            public void setPhoneNumber(long phoneNumber)
            {
                this.phoneNumber = phoneNumber;
            }

            public String getEmail()
            {
                return email;
            }

            public void setEmail(String email)
            {
                this.email = email;
            }

            public String getIban()
            {
                return iban;
            }

            public void setIban(String iban)
            {
                this.iban = iban;
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
