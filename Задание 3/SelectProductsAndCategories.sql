USE ProductsDB;

SELECT p.ProductName AS 'Название продукта', COALESCE(c.CategoryName, 'Нету категории') AS 'Название категории'
FROM ProductCategories pc 
LEFT JOIN Products p ON p.ProductID = pc.ProductID 
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID 
ORDER BY p.ProductName, c.CategoryName;
