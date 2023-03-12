CREATE DATABASE ProductsDB;
GO

USE ProductsDB;

CREATE TABLE Categories (
   CategoryID INT IDENTITY(1,1) PRIMARY KEY,
   CategoryName VARCHAR(50) NOT NULL,
);

CREATE TABLE Products (
   ProductID INT IDENTITY(1,1) PRIMARY KEY,
   ProductName VARCHAR(50) NOT NULL,
);

CREATE TABLE ProductCategories (
   ProductID INT,
   CategoryID INT,
   FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
   FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Categories (CategoryName) VALUES 
('�����������'),
('�����'),
('�������');

INSERT INTO Products (ProductName) VALUES 
('�������� 1'),
('�������� 2'),
('�������� 3'),
('����� 1'),
('����� 2'),
('����� 3'),
('������� 1'),
('������� 2 '),
('������� 3'),
('�������'),
('���������');

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 2),
    (5, 2),
    (6, 2),
    (7, 3),
    (8, 3),
    (9, 3),
	(10, null),
	(11, null)