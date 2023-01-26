using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalSystem
{
    class PropertyType
    {
        private String typeCode;
        private String description;

        public PropertyType()
        {
            this.typeCode = "na";
            this.description = "N/a";
        }

        public PropertyType(String typeCode, String description)
        {
            this.typeCode = typeCode;
            this.description = description;
        }

        public static bool TypeCodeExists(String typeCode)
        {
            bool result = true;

            // check if type code exists....
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "Select * From PropertyTypes";
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
                    if (reader.GetString(0).Equals(typeCode))
                    {
                        result = false;
                    }
                }
            }


            return result;
        }

        public void addPropertyType()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO PropertyTypes Values (\'" +
                this.typeCode + "','" +
                this.description + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateType()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE PropertyTypes SET " +
                "TypeCode = '" + this.typeCode + "'," +
                "description = '" + this.description + "' " +
                "WHERE TypeCode = '" + this.typeCode + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet getTypes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM PropertyTypes ORDER BY TypeCode";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "PropertyTypes");

            //Close db connection
            conn.Close();

            return ds;
        }


        public String getTypeCode()
        {
            return typeCode;
        }

        public void setTypeCode(String typeCode)
        {
            this.typeCode = typeCode;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }
    }
}
