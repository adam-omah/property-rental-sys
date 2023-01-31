using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRentalSystem
{
    class Property
    {
        private String eircode;
        private int ownerID;
        private String typeCode;
        private String houseName;
        private double rentalPrice;
        private String propertyDescription;
        private int totalRooms;
        private int totalBedrooms;
        private int ensuiteBedrooms;
        private int bathrooms;
        private int parkingSpaces;
        private String heatingSource;
        private char gardenSpace;
        private char petsAllowed;
        private char wifi;
        private char ownerOccupied;

        private char status;

        public Property()
        {
            eircode = "NA";
            ownerID = 1;
            houseName = "none";
            rentalPrice = 100;
            propertyDescription = "None";
            totalRooms = 0;
            totalBedrooms = 0;
            ensuiteBedrooms = 0;
            bathrooms = 0;
            parkingSpaces = 0;
            heatingSource = "None";
            gardenSpace = 'N';
            petsAllowed = 'N';
            wifi = 'N';
            ownerOccupied = 'N';
            status = 'I';
        }

        public Property(String eircode, int ownerID, String typeCode, String houseName, double rentalPrice, String propertyDescription, int totalRooms, int standardBedrooms, int ensuiteBedrooms, int bathrooms, int parkingSpaces, String heatingSource, char gardenSpace, char petsAllowed, char wifi, char ownerOccupied, char status)
        {
            this.eircode = eircode;
            this.ownerID = ownerID;
            this.typeCode = typeCode;
            this.houseName = houseName;
            this.rentalPrice = rentalPrice;
            this.propertyDescription = propertyDescription;
            this.totalRooms = totalRooms;
            this.totalBedrooms = standardBedrooms;
            this.ensuiteBedrooms = ensuiteBedrooms;
            this.bathrooms = bathrooms;
            this.parkingSpaces = parkingSpaces;
            this.heatingSource = heatingSource;
            this.gardenSpace = gardenSpace;
            this.petsAllowed = petsAllowed;
            this.wifi = wifi;
            this.ownerOccupied = ownerOccupied;
            this.status = status;
        }

        public void addProperty()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Properties Values (\'" +
                this.eircode + "','" +
                this.typeCode + "'," +
                this.ownerID + ",'" +
                this.houseName + "','" +
                this.propertyDescription + "'," +
                this.rentalPrice + "," +
                this.totalRooms + "," +
                this.bathrooms + "," +
                this.totalBedrooms + "," +
                this.ensuiteBedrooms + "," +
                this.parkingSpaces + ",'" +
                this.heatingSource + "','" +
                this.gardenSpace + "','" +
                this.petsAllowed + "','" +
                this.wifi + "','" +
                this.ownerOccupied + "','" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);


            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateProperty()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Properties SET " +
                "eircode = '" + this.eircode + "'," +
                "typeCode = '" + this.typeCode + "'," +
                "ownerId = " + this.ownerID + "," +
                "houseName = '" + this.houseName + "'," +
                "description = '" + this.propertyDescription + "'," +
                "monthlyRent = " + this.rentalPrice + "," +
                "totalRooms = " + this.totalRooms + "," +
                "bathrooms = " + this.bathrooms + "," +
                "bedrooms = " + this.totalBedrooms + "," +
                "ensuiteBedrooms = " + this.ensuiteBedrooms + "," +
                "parkingSpaces = " + this.parkingSpaces + "," +
                "heatingSource = '" + this.heatingSource + "'," +
                "gardenSpace = '" + this.gardenSpace + "'," +
                "petsAllowed = '" + this.petsAllowed + "'," +
                "wifi = '" + this.wifi + "'," +
                "ownerOccupied = '" + this.ownerOccupied + "'," +
                "status = '" + this.status + "' " +
                "WHERE eircode = '" + this.eircode +"'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getProperty(String eircode)
        {


            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            


            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Properties WHERE eircode = '" + eircode + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setEircode(dr.GetString(0));
            setTypeCode(dr.GetString(1));
            setOwnerID(dr.GetInt32(2));
            setHouseName(dr.GetString(3));
            setPropertyDescription(dr.GetString(4));
            setRentalPrice(dr.GetDouble(5));
            setTotalRooms(dr.GetInt32(6));
            setBathrooms(dr.GetInt32(7));
            setTotalBedrooms(dr.GetInt32(8));
            setEnsuiteBedrooms(dr.GetInt32(9));
            setParkingSpaces(dr.GetInt32(10));
            setHeatingSource(dr.GetString(11));
            setGardenSpace(dr.GetString(12));
            setPetsAllowed(dr.GetString(13));
            setWifi(dr.GetString(14));
            setOwnerOccupied(dr.GetString(15));
            setStatus(dr.GetString(16));

            //close DB
            conn.Close();
        }

        public static DataSet findProperties(String eircode)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT OwnerID, Eircode, housename FROM Properties " +
                "WHERE eircode LIKE '%" + eircode + "%'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            

            DataSet ds = new DataSet();
            da.Fill(ds, "properties");

            //Close db connection
            conn.Close();

            return ds;
        }

        public String getEircode()
        {
            return eircode;
        }

        public void setEircode(String eircode)
        {
            this.eircode = eircode;
        }

        public int getOwnerID()
        {
            return ownerID;
        }

        public void setOwnerID(int ownerID)
        {
            this.ownerID = ownerID;
        }

        public String getTypeCode()
        {
            return typeCode;
        }

        public void setTypeCode(String typeCode)
        {
            this.typeCode = typeCode;
        }

        public String getHouseName()
        {
            return houseName;
        }

        public void setHouseName(String houseName)
        {
            this.houseName = houseName;
        }

        public double getRentalPrice()
        {
            return rentalPrice;
        }

        public void setRentalPrice(double rentalPrice)
        {
            this.rentalPrice = rentalPrice;
        }

        public String getPropertyDescription()
        {
            return propertyDescription;
        }

        public void setPropertyDescription(String propertyDescription)
        {
            this.propertyDescription = propertyDescription;
        }

        public int getTotalRooms()
        {
            return totalRooms;
        }

        public void setTotalRooms(int totalRooms)
        {
            this.totalRooms = totalRooms;
        }

        public int getTotalBedrooms()
        {
            return totalBedrooms;
        }

        public void setTotalBedrooms(int totalBedrooms)
        {
            this.totalBedrooms = totalBedrooms;
        }

        public int getEnsuiteBedrooms()
        {
            return ensuiteBedrooms;
        }

        public void setEnsuiteBedrooms(int ensuiteBedrooms)
        {
            this.ensuiteBedrooms = ensuiteBedrooms;
        }

        public int getBathrooms()
        {
            return bathrooms;
        }

        public void setBathrooms(int bathrooms)
        {
            this.bathrooms = bathrooms;
        }

        public int getParkingSpaces()
        {
            return parkingSpaces;
        }

        public void setParkingSpaces(int parkingSpaces)
        {
            this.parkingSpaces = parkingSpaces;
        }

        public String getHeatingSource()
        {
            return heatingSource;
        }

        public void setHeatingSource(String heatingSource)
        {
            this.heatingSource = heatingSource;
        }

        public char getGardenSpace()
        {
            return gardenSpace;
        }

        public void setGardenSpace(String gardenSpace)
        {
            this.gardenSpace = gardenSpace[0];
        }

        public char getPetsAllowed()
        {
            return petsAllowed;
        }

        public void setPetsAllowed(String petsAllowed)
        {
            this.petsAllowed = petsAllowed[0];
        }

        public char getWifi()
        {
            return wifi;
        }

        public void setWifi(String wifi)
        {
            this.wifi = wifi[0];
        }

        public char getOwnerOccupied()
        {
            return ownerOccupied;
        }

        public void setOwnerOccupied(String ownerOccupied)
        {
            this.ownerOccupied = ownerOccupied[0];
        }

        public char getStatus()
        {
            return status;
        }

        public void setStatus(String status)
        {
            this.status = status[0];
        }
    }
}
