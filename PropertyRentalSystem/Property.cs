using System;
using System.Collections.Generic;
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
        private int standardBedrooms;
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
            rentalPrice = 100.00f;
            propertyDescription = "None";
            totalRooms = 0;
            standardBedrooms = 0;
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
            this.standardBedrooms = standardBedrooms;
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

        public int getStandardBedrooms()
        {
            return standardBedrooms;
        }

        public void setStandardBedrooms(int standardBedrooms)
        {
            this.standardBedrooms = standardBedrooms;
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

        public void setGardenSpace(char gardenSpace)
        {
            this.gardenSpace = gardenSpace;
        }

        public char getPetsAllowed()
        {
            return petsAllowed;
        }

        public void setPetsAllowed(char petsAllowed)
        {
            this.petsAllowed = petsAllowed;
        }

        public char getWifi()
        {
            return wifi;
        }

        public void setWifi(char wifi)
        {
            this.wifi = wifi;
        }

        public char getOwnerOccupied()
        {
            return ownerOccupied;
        }

        public void setOwnerOccupied(char ownerOccupied)
        {
            this.ownerOccupied = ownerOccupied;
        }

        public char getStatus()
        {
            return status;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }
    }
}
