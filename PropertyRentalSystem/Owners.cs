using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PropertyRentalSystem
{
    class Owners
    {
        private int ownerID;
        private String firstName;
        private String lastName;
        private Int64 phoneNumber;
        private String email;
        private String eircode;
        private String iban;
        private char status;

        public Owners()
        {
            this.ownerID = 0;
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = 0;
            this.email = "";
            this.eircode = "";
            this.iban = "";
            this.status = 'I';
        }

        public Owners( string firstName, string lastName, Int64 phone, string email, string eircode, string iban, char status)
        {
            

            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phone;
            this.email = email;
            this.eircode = eircode;
            this.iban = iban;
            this.status = status;

            // Connecting to DB to get new Owner ID for onwer,
            // As owner Records are not fully deleted count is usable.

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Select * From Owners";
            conn.Open();

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            int count = 0;

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

            this.ownerID = count + 1;

        }

        

        public void addOwner()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Owners Values (" +
                this.ownerID + ",'" +
                this.firstName + "','" +
                this.lastName + "'," +
                this.phoneNumber + ",'" +
                this.email + "','" +
                this.eircode + "','" +
                this.iban + "','" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findOwners(String surname)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ownerID, firstName, lastName, phoneNumber FROM owners " +
                "WHERE lastName LIKE '%" + validationFunctions.SQLApostrophe(surname) + "%' ORDER BY firstName";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "owner");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getOwner(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM owners WHERE ownerID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setOwnerID(dr.GetInt32(0));
            setFirstName(dr.GetString(1));
            setSurname(dr.GetString(2));
            setPhone(dr.GetInt64(3));
            setEmail(dr.GetString(4));
            setEircode(dr.GetString(5));
            setIban(dr.GetString(6));
            setStatus(dr.GetString(7));

            //close DB
            conn.Close();
        }

        public void updateOwner()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Owners SET " +
                "ownerId = " + this.ownerID + "," +
                "firstName = '" + this.firstName + "'," +
                "lastName = '" + this.lastName + "'," +
                "phoneNumber = " + this.phoneNumber + "," +
                "email = '" + this.email + "'," +
                "eircode = '" + this.eircode + "'," +
                "iban = '" + this.iban + "'," +
                "status = '" + this.status + "' " +
                "WHERE ownerId = " + this.ownerID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet getAllOwners()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ownerID, firstName, surname, phoneNumber " +
                "FROM owners ORDER BY surname";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "owner");

            //Close db connection
            conn.Close();

            return ds;
        }

        //getters
        public int getOwnerID() { return this.ownerID; }
        public String getFirstName() { return this.firstName; }

        public String getSurname() { return this.lastName; }

        public Int64 getPhoneNumber() { return this.phoneNumber; }

        public String getEmail() { return this.email; }

        public String getEircode() { return this.eircode; }

        public String getIban() { return this.iban; }

        public char getStatus() { return this.status; }


        //setters
        public void setOwnerID(int OwnerID) { ownerID = OwnerID; }
        public void setFirstName(String FirstName) { firstName = FirstName; }

        public void setSurname(String Surname) { lastName = Surname; }

        public void setPhone(Int64 PhoneNumber) { phoneNumber = PhoneNumber; }

        public void setEmail (String Email) { email = Email; }

        public  void setEircode(String Eircode) { eircode = Eircode; }

        public void setIban(String IBAN) { iban = IBAN; }

        public void setStatus(String Status) { status = Status[0]; }


        public override bool Equals(object obj)
        {
            return obj is Owners owner &&
                   ownerID == owner.ownerID &&
                   firstName == owner.firstName &&
                   lastName == owner.lastName &&
                   phoneNumber == owner.phoneNumber;
        }
    }
}
