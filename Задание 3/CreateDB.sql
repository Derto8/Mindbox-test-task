CREATE DATABASE ProductsDB;
GO

USE ProductsDB;
GO

CREATE TABLE Categories (
   CategoryID INT IDENTITY(1,1) PRIMARY KEY,
   CategoryName VARCHAR(50) NOT NULL,
);

CREATE TABLE Products (
   ProductID INT IDENTITY(1,1) PRIMARY KEY,
   ProductName VARCHAR(50) NOT NULL,
   Price DECIMAL(10,2) NOT NULL
);

CREATE TABLE ProductCategories (
   ProductID INT,
   CategoryID INT,
   PRIMARY KEY (ProductID, CategoryID),
   FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
   FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Categories (CategoryName) VALUES 
('�����������'),
('�����'),
('�������');

INSERT INTO Products (ProductName, Price) VALUES 
('�������� 1', 15000.00),
('�������� 2', 30000.00),
('�������� 3', 14000.00),
('����� 1', 1400.00),
('����� 2', 2000.00),
('����� 3', 900.00),
('������� 1', 400.00),
('������� 2 ', 1200.00),
('������� 3', 4000.00);

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 2),
    (5, 2),
    (6, 2),
    (7, 3),
    (8, 3),
    (9, 3)
