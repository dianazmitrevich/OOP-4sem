use master
CREATE DATABASE Airport

CREATE TABLE MANUFACTURER(
	[ID] [int] NOT NULL PRIMARY KEY,
	[Name] [nvarchar](80) NOT NULL,
	[Country] [nvarchar](80) NOT NULL,
	[Year] [int] NULL);

CREATE TABLE PLANE(
	[ID] [int] NOT NULL PRIMARY KEY,
	[Type] [nvarchar](80) NULL,
	[Model] [nvarchar](80) NULL,
	[Capacity] [int] NULL,
	[Year] [int] NULL,
	[Load_Capacity] [nvarchar](80) NULL,
	[Maintenance_Date] [date] NULL,
	[Manufacturer_ID] [int] NOT NULL FOREIGN KEY REFERENCES MANUFACTURER(ID));

CREATE TABLE CREW_MEMBERS(
	[ID] [int] NOT NULL PRIMARY KEY,
	[Name_Surname] [nvarchar](80) NOT NULL,
	[Position] [nvarchar](80) NOT NULL,
	[Age] [int] NOT NULL,
	[Experience] [int] NOT NULL,
	[Plane_ID] [int] NULL FOREIGN KEY REFERENCES PLANE(ID))