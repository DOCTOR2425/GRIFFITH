CREATE DATABASE Notary
USE Notary

CREATE TABLE Client(
	ClientID uniqueidentifier PRIMARY KEY,
	ClientName VARCHAR(150) NOT NULL,
	Telephone VARCHAR(19) NOT NULL,
	Activity NTEXT NOT NULL
)

CREATE TABLE Discount(
	DiscountID uniqueidentifier PRIMARY KEY,
	DiscountName VARCHAR(150) NOT NULL,
	DiscountPercent FLOAT NOT NULL,
	DiscountDescription NTEXT NOT NULL,
	NewFlag INT NOT NULL
)

CREATE TABLE Employee(
	EmployeeID uniqueidentifier PRIMARY KEY,
	EmployeeName VARCHAR(150) NOT NULL,
	Salary FLOAT NOT NULL,
	HireDate DATE NOT NULL,
	DismissalDate DATE NOT NULL,
	Post VARCHAR(150) NOT NULL,
)

CREATE TABLE tService(
	ServiceID uniqueidentifier PRIMARY KEY,
	ServiceName VARCHAR(150) NOT NULL,
	Price FLOAT NOT NULL,
	ServiceDescription NTEXT NOT NULL,
	NewFlag INT NOT NULL
)

CREATE TABLE tOrder(
	OrderID uniqueidentifier NOT NULL PRIMARY KEY,
	ServiceID uniqueidentifier NOT NULL CONSTRAINT cs_servid 
	FOREIGN KEY (ServiceID) REFERENCES tService(ServiceID) ON UPDATE CASCADE,
	EmployeeID uniqueidentifier NOT NULL CONSTRAINT cs_empid 
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON UPDATE CASCADE,
	DiscountID uniqueidentifier NOT NULL CONSTRAINT cs_discid 
	FOREIGN KEY (DiscountID) REFERENCES Discount(DiscountID) ON UPDATE CASCADE,
	ClientID uniqueidentifier NOT NULL CONSTRAINT cs_clid 
	FOREIGN KEY (ClientID) REFERENCES Client(ClientID) ON UPDATE CASCADE
)
