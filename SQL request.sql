CREATE TABLE Product (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

CREATE TABLE Category (
  id INT PRIMARY KEY,
  name VARCHAR(45) NOT NULL
);

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Product(Id),
	CategoryId INT FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY (ProductId, CategoryId)
);


INSERT INTO Category (name, id) VALUES ('юбка', 1);
INSERT INTO Category (name, id) VALUES ('футболка', 2);
INSERT INTO Category (name, id) VALUES ('одежда', 3);
INSERT INTO Category (name, id) VALUES ('мороженое', 4);
INSERT INTO Category (name, id) VALUES ('еда', 5);
INSERT INTO Category (name, id) VALUES ('овощи', 6);
INSERT INTO Category (name, id) VALUES ('фрукты', 7);

INSERT INTO Product (name, id) VALUES ('орехи', 1);
INSERT INTO Product (name, id) VALUES ('чистая_линия', 2);
INSERT INTO Product (name, id) VALUES ('картошка', 3);
INSERT INTO Product (name, id) VALUES ('морковка', 4);
INSERT INTO Product (name, id) VALUES ('бананы', 5);
INSERT INTO Product (name, id) VALUES ('топ1', 6);
INSERT INTO Product (name, id) VALUES ('топ2', 7);
INSERT INTO Product (name, id) VALUES ('юбка1', 8);
INSERT INTO Product (name, id) VALUES ('юбка2', 9);
INSERT INTO Product (name, id) VALUES ('мясо', 10);

INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 5);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (2, 4);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (2, 5);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (3, 5);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (3, 6);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (4, 5);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (4, 6);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (5, 7);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (5, 5);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (6, 3);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (7, 3);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (6, 2);
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (7, 2);

/* Итоговый запрос */

SELECT Product.name, Category.name
FROM Product
LEFT JOIN ProductCategories
	ON Product.id = ProductCategories.ProductId
LEFT JOIN Category
	ON ProductCategories.CategoryId = Category.id





