CREATE TABLE Products (
	Id INT PRIMARY KEY,
	[Name] TEXT
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	[Name] TEXT
);

CREATE TABLE ProductsCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);
GO

INSERT INTO Products
VALUES
	(1, 'Product 1'),
	(2, 'Product 2'),
	(3, 'Product 3'),
	(4, 'Product 4');

INSERT INTO Categories
VALUES
	(1, 'Category 1'),
	(2, 'Category 2');

INSERT INTO ProductsCategories
VALUES
	(1, 1),
	(2, 2),
	(3, 1),
	(3, 2);
GO

SELECT P.[Name], C.[Name]
FROM Products P
LEFT JOIN ProductsCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
GO