Create Table Customer 
(
	CustomerID tinyint not null Identity,
	Name nvarchar(100) not null

);

INSERT INTO Customer(Name)
VALUES ('Clypto'), ('Sam'), ('Jackson');

alter table Customer
	add constraint PK_Customer primary key (CustomerID);

ALTER TABLE [Order].[Order]
ADD CONSTRAINT FK_Customer_Order
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID);

CREATE TABLE Store
(
	StoreID TINYINT NOT NULL IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Product
(
	ProductID TINYINT NOT NULL IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL
);

CREATE TABLE OrderProduct
(
	OrderID SMALLINT NOT NULL,
	ProductID SMALLINT NOT NULL,
	CONSTRAINT PK_TempOrder
);