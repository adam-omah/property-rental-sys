PROMPT Removing table Data.....

DELETE FROM Years_Opened;

DELETE FROM Payments;

DELETE FROM Tenant_Rentals;

DELETE FROM Rentals;

DELETE FROM Properties;

DELETE FROM heating_sources;

DELETE FROM PropertyTypes;

DELETE FROM Tenants;

DELETE FROM owners;

PROMPT Adding Owners...

INSERT INTO Owners VALUES 
(1,'Adam','SMITH',870606066,'adam@adam.com','V92FFFF','IE64IRCE92050112345678','A');


INSERT INTO Owners VALUES 
(2,'Eric','HAL',875555555,'eric@eric.com','V92LLLL','IE64IRCE92050112345678','A');

INSERT INTO Owners VALUES 
(3,'James','CLIFF',870606066,'james@james.com','V92JJJJ','IE64IRCE92050112345678','A');


PROMPT Adding Property Types...

INSERT INTO propertyTypes
Values ('BG', 'Bungalo');

INSERT INTO propertyTypes
Values ('SD', 'Semi-Detatched');

INSERT INTO propertyTypes
Values ('DH', 'Detatched house');

INSERT INTO propertyTypes
Values ('TH', 'Town House');

INSERT INTO propertyTypes
Values ('CH', 'Country House');

INSERT INTO propertyTypes
Values ('AP', 'Apartment/Flat');

PROMPT Adding HEating Sources...

INSERT INTO heating_sources VALUES (1,'Oil Central Heating');
INSERT INTO heating_sources VALUES (2,'Heat Pump Central Heating');
INSERT INTO heating_sources VALUES (3,'Electric Radiators');
INSERT INTO heating_sources VALUES (4,'Storage Heaters');
INSERT INTO heating_sources VALUES (5,'Solid Fuel Stove');
INSERT INTO heating_sources VALUES (6,'Geothermal');


PROMPT Adding Properties...

INSERT INTO Properties
Values('V92CCCC','BG',1,'CAUSEWAY','the cottage','rural cottage, suitable for small family',
600,4,2,2,1,2,5,'Y','Y','N','N', 'A');

INSERT INTO Properties
Values('V92AAAA','SD',1,'TRALEE','12 meadows','Close to town, suitable for small family',
800,4,1,2,1,1,3,'N','N','N','N', 'R');

INSERT INTO Properties
Values('V92BBBB','SD',1,'TRALEE','12 meadows','Close to town, suitable for small family',
800,4,2,2,1,1,3,'N','N','N','N', 'A');
INSERT INTO Properties
Values('V92HHHH','SD',1,'TRALEE','14 meadows','Close to town, suitable for small family',
800,5,2,3,1,1,3,'N','N','N','N', 'A');

INSERT INTO Properties
Values('V92DDDD','SD',1,'TRALEE','16 meadows','Close to town, suitable for small family',
800,5,1,3,1,1,3,'N','N','N','N', 'A');

INSERT INTO Properties
Values('V92EEEE','TH',1,'TRALEE','16 meadows','Close to town, suitable for small family',
800,5,2,2,1,1,3,'N','N','N','N', 'A');

INSERT INTO Properties
Values('V92FFFF','CH',1,'TRALEE','The meadows','Close to town, suitable for Large family',
800,7,2,5,1,1,3,'N','N','N','N', 'A');

INSERT INTO Properties
Values('V92GGGG','TH',1,'TRALEE','16 meadows','Close to town, suitable for small family',
800,5,1,4,1,1,3,'N','N','N','N', 'A');



PROMPT Adding Tenants...

INSERT INTO tenants
Values (1,'Barry','SMITH',0870606066,'barry@tenant.com',
'IE64IRCE92050112345678','I');

INSERT INTO tenants
Values (2,'Eric','HAL',0875555555,'eric@tenant.com',
'IE64IRCE92050112345678','A');

INSERT INTO tenants
Values (3,'James','CLIFF',0870606066,'james@tenant.com',
'IE64IRCE92050112345678','A');

PROMPT Adding Rentals...

INSERT INTO Rentals Values(1,1,'V92CCCC','10-JAN-2020','10-MAY-2020','I');
INSERT INTO Rentals Values(2,1,'V92CCCC','25-MAY-2020','25-JUL-2020','I');
INSERT INTO Rentals Values(3,2,'V92AAAA','10-FEB-2020','5-AUG-2020','I');
INSERT INTO Rentals Values(4,1,'V92CCCC','10-MAY-2020','10-SEP-2021','I');
INSERT INTO Rentals Values(5,3,'V92CCCC','25-MAR-2020','25-NOV-2020','I');
INSERT INTO Rentals Values(6,2,'V92AAAA','10-APR-2020','10-AUG-2021','I');
INSERT INTO Rentals Values(7,1,'V92CCCC','10-JUN-2020','10-MAY-2021','I');
INSERT INTO Rentals Values(8,3,'V92CCCC','25-MAY-2020','25-DEC-2020','I');
INSERT INTO Rentals Values(9,2,'V92AAAA','10-SEP-2020','10-AUG-2021','I');
INSERT INTO Rentals Values(10,1,'V92CCCC','10-JUL-2020','10-DEC-2021','I');
INSERT INTO Rentals Values(11,3,'V92CCCC','25-AUG-2020','25-JUL-2020','I');
INSERT INTO Rentals Values(12,2,'V92AAAA','10-AUG-2020','10-SEP-2021','I');
INSERT INTO Rentals Values(13,1,'V92CCCC','10-MAY-2020','10-APR-2021','I');
INSERT INTO Rentals Values(14,3,'V92CCCC','25-MAY-2020','25-JUN-2020','I');
INSERT INTO Rentals Values(15,2,'V92AAAA','10-AUG-2020','10-NOV-2021','I');
INSERT INTO Rentals Values(16,1,'V92CCCC','10-MAY-2020','10-OCT-2021','I');
INSERT INTO Rentals Values(17,3,'V92CCCC','25-MAR-2020','25-JUN-2020','I');
INSERT INTO Rentals Values(18,2,'V92AAAA','10-APR-2020','10-AUG-2021','I');
INSERT INTO Rentals Values(19,1,'V92CCCC','10-JUN-2020','10-MAR-2021','I');
INSERT INTO Rentals Values(20,3,'V92CCCC','25-MAY-2020','25-JAN-2021','I');
INSERT INTO Rentals Values(21,2,'V92AAAA','10-SEP-2020','10-AUG-2021','I');
INSERT INTO Rentals Values(22,1,'V92CCCC','10-JUL-2020','10-APR-2021','I');
INSERT INTO Rentals Values(23,3,'V92CCCC','25-AUG-2020','25-JUN-2020','I');
INSERT INTO Rentals Values(24,2,'V92AAAA','10-APR-2020','10-AUG-2021','I');
INSERT INTO Rentals Values(25,1,'V92CCCC','10-JAN-2021','10-MAY-2022','I');
INSERT INTO Rentals Values(26,1,'V92CCCC','25-MAY-2021','25-JUN-2021','I');
INSERT INTO Rentals Values(27,2,'V92AAAA','10-FEB-2021','5-SEP-2022','I');
INSERT INTO Rentals Values(28,1,'V92CCCC','10-MAY-2021','10-JUL-2021','I');
INSERT INTO Rentals Values(29,3,'V92CCCC','25-MAR-2021','25-APR-2022','I');
INSERT INTO Rentals Values(30,2,'V92AAAA','10-APR-2021','10-OCT-2022','I');
INSERT INTO Rentals Values(31,1,'V92CCCC','10-JUN-2021','10-MAY-2021','I');
INSERT INTO Rentals Values(32,3,'V92CCCC','25-OCT-2021','25-JUN-2022','I');
INSERT INTO Rentals Values(33,2,'V92AAAA','10-SEP-2021','10-AUG-2022','I');
INSERT INTO Rentals Values(34,1,'V92CCCC','10-JUL-2021','10-MAY-2021','I');
INSERT INTO Rentals Values(35,3,'V92CCCC','25-AUG-2021','25-JUN-2022','I');
INSERT INTO Rentals Values(36,2,'V92AAAA','10-AUG-2021','10-AUG-2022','I');
INSERT INTO Rentals Values(37,1,'V92CCCC','10-MAY-2021','10-JAN-2021','I');
INSERT INTO Rentals Values(38,3,'V92CCCC','25-MAY-2021','25-DEC-2021','I');
INSERT INTO Rentals Values(39,2,'V92AAAA','10-AUG-2021','10-SEP-2022','I');
INSERT INTO Rentals Values(40,1,'V92CCCC','10-MAY-2021','10-MAY-2021','I');
INSERT INTO Rentals Values(41,3,'V92CCCC','25-MAR-2021','25-JUL-2022','I');
INSERT INTO Rentals Values(42,2,'V92AAAA','10-APR-2021','10-SEP-2021','I');
INSERT INTO Rentals Values(43,1,'V92CCCC','10-JUN-2021','10-OCT-2021','I');
INSERT INTO Rentals Values(44,3,'V92CCCC','25-MAY-2021','25-NOV-2022','I');
INSERT INTO Rentals Values(45,2,'V92AAAA','10-SEP-2021','10-SEP-2021','I');
INSERT INTO Rentals Values(46,1,'V92CCCC','10-JUL-2021','10-MAY-2021','I');
INSERT INTO Rentals Values(47,3,'V92CCCC','25-AUG-2021','25-JAN-2023','I');
INSERT INTO Rentals Values(48,2,'V92AAAA','10-AUG-2021','10-SEP-2021','I');
INSERT INTO Rentals Values(49,2,'V92AAAA','10-APR-2022','10-AUG-2022','I');
INSERT INTO Rentals Values(50,1,'V92CCCC','10-JUN-2022','10-MAY-2023','I');
INSERT INTO Rentals Values(51,3,'V92CCCC','25-MAY-2022','25-JUN-2022','I');
INSERT INTO Rentals Values(52,2,'V92AAAA','10-SEP-2022','10-AUG-2022','I');
INSERT INTO Rentals Values(53,1,'V92CCCC','10-JUL-2022','10-MAY-2022','I');
INSERT INTO Rentals Values(54,3,'V92CCCC','25-AUG-2022','25-DEC-2022','I');
INSERT INTO Rentals Values(55,2,'V92AAAA','10-AUG-2022','10-AUG-2022','I');
INSERT INTO Rentals Values(56,1,'V92CCCC','10-MAY-2022','10-JAN-2023','I');
INSERT INTO Rentals Values(57,3,'V92CCCC','25-MAY-2022','25-JUN-2023','I');
INSERT INTO Rentals Values(58,2,'V92AAAA','10-AUG-2022','10-AUG-2022','I');
INSERT INTO Rentals Values(59,1,'V92CCCC','10-MAY-2022','10-MAR-2022','I');
INSERT INTO Rentals Values(60,3,'V92CCCC','25-MAR-2022','25-JUN-2023','I');
INSERT INTO Rentals Values(61,2,'V92AAAA','10-APR-2022','10-AUG-2023','I');
INSERT INTO Rentals Values(62,1,'V92CCCC','10-JUN-2022','10-MAY-2023','I');
INSERT INTO Rentals Values(63,3,'V92CCCC','25-MAY-2022','25-OCT-2022','I');
INSERT INTO Rentals Values(64,2,'V92AAAA','10-SEP-2022','10-DEC-2022','I');
INSERT INTO Rentals Values(65,1,'V92CCCC','10-JUL-2022','10-NOV-2022','I');
INSERT INTO Rentals Values(66,3,'V92CCCC','25-AUG-2022','25-JUN-2022','I');
INSERT INTO Rentals Values(67,2,'V92AAAA','10-AUG-2022','10-AUG-2023','I');
INSERT INTO Rentals Values(68,2,'V92AAAA','10-JUN-2022','10-JUN-2023','A');


PROMPT Adding Tenant Rentals...
INSERT INTO tenant_rentals
Values(1,1,'I');

INSERT INTO tenant_rentals
Values(1,2,'I');

INSERT INTO tenant_rentals
Values(2,3,'I');

INSERT INTO tenant_rentals
Values(68,2,'A');

INSERT INTO tenant_rentals
Values(68,1,'A');


PROMPT Adding Payments....
INSERT INTO Payments Values(1,1,500,'10-MAY-2020');
INSERT INTO Payments Values(2,3,900,'10-MAY-2020');
INSERT INTO Payments Values(3,1,600,'10-JUN-2020');
INSERT INTO Payments Values(4,3,1000,'10-JUN-2020');
INSERT INTO Payments Values(5,1,600,'10-JUL-2020');
INSERT INTO Payments Values(6,3,500,'10-JUL-2020');
INSERT INTO Payments Values(7,1,600,'10-AUG-2020');
INSERT INTO Payments Values(8,3,800,'10-AUG-2020');
INSERT INTO Payments Values(9,1,600,'10-SEP-2020');
INSERT INTO Payments Values(10,3,1000,'10-SEP-2020');
INSERT INTO Payments Values(11,1,300,'10-OCT-2020');
INSERT INTO Payments Values(12,3,400,'10-OCT-2020');
INSERT INTO Payments Values(13,1,250,'10-NOV-2020');
INSERT INTO Payments Values(14,3,1000,'10-NOV-2020');
INSERT INTO Payments Values(15,1,375,'10-DEC-2020');
INSERT INTO Payments Values(16,3,950,'10-DEC-2020');
INSERT INTO Payments Values(17,1,450,'10-JAN-2020');
INSERT INTO Payments Values(18,3,1750,'10-JAN-2020');
INSERT INTO Payments Values(19,1,1240,'10-FEB-2020');
INSERT INTO Payments Values(20,2,700,'10-FEB-2020');
INSERT INTO Payments Values(21,1,400,'10-MAR-2020');
INSERT INTO Payments Values(22,2,100,'10-MAR-2020');
INSERT INTO Payments Values(23,1,2000,'10-APR-2020');
INSERT INTO Payments Values(24,2,545,'10-APR-2020');
INSERT INTO Payments Values(25,1,250,'10-MAY-2021');
INSERT INTO Payments Values(26,3,1000,'10-MAY-2021');
INSERT INTO Payments Values(27,1,375,'10-JUN-2021');
INSERT INTO Payments Values(28,3,950,'10-JUN-2021');
INSERT INTO Payments Values(29,1,450,'10-JUN-2021');
INSERT INTO Payments Values(30,3,1750,'10-JUL-2021');
INSERT INTO Payments Values(31,1,1240,'10-AUG-2021');
INSERT INTO Payments Values(32,3,700,'10-AUG-2021');
INSERT INTO Payments Values(33,1,400,'10-SEP-2021');
INSERT INTO Payments Values(34,3,100,'10-SEP-2021');
INSERT INTO Payments Values(35,1,2000,'10-OCT-2021');
INSERT INTO Payments Values(36,3,545,'10-OCT-2021');
INSERT INTO Payments Values(37,1,500,'10-NOV-2021');
INSERT INTO Payments Values(38,3,900,'10-NOV-2021');
INSERT INTO Payments Values(39,1,600,'10-DEC-2021');
INSERT INTO Payments Values(40,3,1000,'10-DEC-2021');
INSERT INTO Payments Values(41,1,600,'10-JAN-2021');
INSERT INTO Payments Values(42,3,500,'10-JAN-2021');
INSERT INTO Payments Values(43,1,600,'10-FEB-2021');
INSERT INTO Payments Values(44,2,800,'10-FEB-2021');
INSERT INTO Payments Values(45,1,600,'10-MAR-2021');
INSERT INTO Payments Values(46,2,1000,'10-MAR-2021');
INSERT INTO Payments Values(47,1,300,'10-APR-2021');
INSERT INTO Payments Values(48,2,400,'10-APR-2021');
INSERT INTO Payments Values(49,1,250,'10-MAY-2022');
INSERT INTO Payments Values(50,3,1000,'10-MAY-2022');
INSERT INTO Payments Values(51,1,375,'10-JUN-2022');
INSERT INTO Payments Values(52,3,950,'10-JUN-2022');
INSERT INTO Payments Values(53,1,450,'10-JUN-2022');
INSERT INTO Payments Values(54,3,1750,'10-JUL-2022');
INSERT INTO Payments Values(55,1,1240,'10-AUG-2022');
INSERT INTO Payments Values(56,3,700,'10-AUG-2022');
INSERT INTO Payments Values(57,1,250,'10-SEP-2022');
INSERT INTO Payments Values(58,3,1000,'10-SEP-2022');
INSERT INTO Payments Values(59,1,375,'10-OCT-2022');
INSERT INTO Payments Values(60,3,950,'10-OCT-2022');
INSERT INTO Payments Values(61,1,450,'10-NOV-2022');
INSERT INTO Payments Values(62,3,900,'10-NOV-2022');
INSERT INTO Payments Values(63,1,600,'10-DEC-2022');
INSERT INTO Payments Values(64,3,250,'10-DEC-2022');
INSERT INTO Payments Values(65,1,1000,'10-JAN-2022');
INSERT INTO Payments Values(66,3,375,'10-JAN-2022');
INSERT INTO Payments Values(67,1,950,'10-FEB-2022');
INSERT INTO Payments Values(68,2,450,'10-FEB-2022');
INSERT INTO Payments Values(69,1,600,'10-MAR-2022');
INSERT INTO Payments Values(70,2,1000,'10-MAR-2022');
INSERT INTO Payments Values(71,1,300,'10-APR-2022');
INSERT INTO Payments Values(72,2,400,'10-APR-2022');


PROMPT Adding Years Opened....
INSERT INTO Years_Opened Values(2022);
INSERT INTO Years_Opened Values(2021);
INSERT INTO Years_Opened Values(2020);


COMMIT;
