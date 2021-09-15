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
	ProductID SMALLINT NOT NULL IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Price MONEY NOT NULL,
	StoreID TINYINT NOT NULL
);

CREATE TABLE OrderProduct
(
	OrderProductID SMALLINT NOT NULL IDENTITY PRIMARY KEY,
	OrderID SMALLINT NOT NULL,
	ProductID SMALLINT NOT NULL,
	CONSTRAINT PK_Order FOREIGN KEY (OrderID)
	REFERENCES [Order].[Order] (OrderID),
	CONSTRAINT PK_Order_Product FOREIGN KEY (ProductID)
	REFERENCES dbo.Product (ProductID),
);

ALTER TABLE [Order].[Order]
	add constraint FK_Order_Customer foreign key (CustomerID) references Customer(CustomerID);

ALTER TABLE [Order].[Order]
	add constraint FK_Order_Store foreign key (StoreID) references Store(StoreID);

ALTER TABLE Product
	add constraint FK_Product_Store foreign key (StoreID) references Store(StoreID);
