
PROMPT Dropping tables.....

DROP TABLE Years_Opened;

DROP TABLE Payments;

DROP TABLE Tenant_Rentals;

DROP TABLE Rentals;

DROP TABLE Properties;

DROP TABLE heating_Sources;

DROP TABLE PropertyTypes;

DROP TABLE Tenants;

DROP TABLE owners;

PROMPT Creating tables.....

CREATE TABLE Owners (
ownerID number (5), 
firstName varchar2 (20),
lastName varchar2(20),
phoneNumber number (10),
email varchar2 (50),
eircode varchar2 (7),
IBAN varchar2(34),
status char DEFAULT 'A' Check (status = 'A' or status= 'I'),
constraint pk_onwers primary Key (ownerID));

CREATE TABLE Tenants(
TenantID number (5),
firstName varchar2 (25) NOT NULL,
lastName varchar2 (30) NOT NULL,
phone Numeric (10) NOT NULL,
email varchar2  (50) NOT NULL,
iban varchar2 (34) NOT NULL,
status char default 'A' Check (status = 'A' or status= 'I'),
constraint pk_tenants primary key (tenantID)
);

CREATE TABLE PropertyTypes(
typeCode varchar2 (2),
description varchar2 (200),
CONSTRAINT pk_propertyType primary key (typeCode)
);

CREATE TABLE heating_Sources(
heatingID NUMBER (2),
heatingName varchar2(30),
CONSTRAINT pk_heating PRIMARY KEY (heatingID)
);

CREATE TABLE Properties(
eircode varchar2 (7),
typeCode varchar2 (2) Not NULL,
ownerID NUMBER(2) not null,
town varchar2(50) NOT NULL,
address varchar2(100) NOT NULL,
description varchar2(200) NOT NULL,
monthlyRent NUMBER (10)NOT NULL CHECK(monthlyRent >0),
totalRooms NUMBER (3) NOT NULL CHECK(totalRooms > 0),
bathrooms Number (3),
bedrooms NUMBER(2),
ensuiteBedrooms NUMBER(2),
parkingSpaces NUMBER (2),
heatingSource NUMBER(2),
gardenSpace char DEFAULT 'N' check(gardenSpace = 'N' or gardenSpace = 'Y')NOT NULL,
petsAllowed char DEFAULT 'N' check(petsAllowed = 'N' or petsAllowed = 'Y')NOT NULL,
wifi char DEFAULT 'N' check(wifi = 'N' or wifi = 'Y')NOT NULL,
ownerOccupied char DEFAULT 'N' check(ownerOccupied = 'N' or ownerOccupied = 'Y')NOT NULL,
status char default 'A' Check (status = 'A' or status= 'I' or status = 'R')NOT NULL,
CONSTRAINT pk_property Primary Key (eircode),
CONSTRAINT fk_heatingSource FOREIGN KEY (heatingSource) REFERENCES Heating_Sources,
CONSTRAINT fk_ownerID foreign Key (ownerID) References Owners,
CONSTRAINT fk_typeCode Foreign Key (typeCode) References PropertyTypes 
);

CREATE TABLE Rentals (
rentalID NUMBER (5),
OwnerID NUMBER (5) NOT NULL,
eircode VARCHAR2 (7) NOT NULL,
startDate DATE NOT NULL,
endDate DATE NOT NULL,
status CHAR DEFAULT 'A' CHECK(status = 'A' or status= 'I') NOT NULL,
CONSTRAINT pk_rentals PRIMARY KEY (rentalID),
CONSTRAINT fk_Owner FOREIGN KEY (ownerID) REFERENCES Owners,
CONSTRAINT fk_property FOREIGN KEY (eircode) REFERENCES Properties
);

CREATE TABLE Tenant_Rentals(
rentalID number(5),
tenantID number(5),
status CHAR DEFAULT 'A' CHECK(status = 'A' or status= 'I') NOT NULL, 
CONSTRAINT pk_tenant_rentals PRIMARY KEY (rentalID,tenantID),
CONSTRAINT fk_rentalID FOREIGN KEY (RentalID) REFERENCES Rentals,
CONSTRAINT fk_tenantID FOREIGN KEY (TenantID) REFERENCES Tenants
);

CREATE TABLE Payments(
payID NUMBER (5),
rentalID NUMBER (5) NOT NULL,
amount NUMBER (10,2) NOT NULL CHECK(amount >0),
payDate DATE NOT NULL,
CONSTRAINT pk_payments PRIMARY KEY (PayID),
CONSTRAINT fk_Pyaments_rentalID FOREIGN KEY (rentalID) REFERENCES Rentals
);

CREATE TABLE Years_Opened(
YearID Number (4),
CONSTRAINT pk_years_opened PRIMARY KEY (YearID)
);

COMMIT;