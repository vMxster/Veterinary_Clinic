-- Database Section
-- ________________
DROP DATABASE if EXISTS VeterinaryDB;
CREATE DATABASE VeterinaryDB;
USE
    VeterinaryDB;
    
-- Tables Section
CREATE TABLE PET
(
  ID INT NOT NULL AUTO_INCREMENT,
  Name VARCHAR(50) NOT NULL,
  Type VARCHAR(50) NOT NULL,
  Colour VARCHAR(50) NOT NULL,
  CONSTRAINT IDPET PRIMARY KEY (ID)
);