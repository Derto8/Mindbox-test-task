USE ProductsDB;

SELECT p.ProductName AS 'Название продукта', c.CategoryName AS 'Категория продукта'
FROM ProductCategories pc 
JOIN Products p ON p.ProductID = pc.ProductID 
JOIN Categories c ON pc.CategoryID = c.CategoryID 
ORDER BY p.ProductName, c.CategoryName;