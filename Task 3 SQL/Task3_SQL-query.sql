USE master;

GO
IF exists (SELECT name FROM sys.databases WHERE name like 'Task3DB')
BEGIN
	ALTER DATABASE Task3DB SET single_user with rollback immediate
	DROP DATABASE Task3DB
	CREATE DATABASE Task3DB
END;

GO
USE Task3DB;

CREATE TABLE Product
(
	id INT not null IDENTITY(1,1),
	product_title VARCHAR(30) not null,
	PRIMARY KEY (id)
)

CREATE TABLE Category
(
	id INT not null IDENTITY(1,1),
	category_title VARCHAR(20) not null,
	PRIMARY KEY (id)
)

CREATE TABLE Showcase
(
	product_ID INT FOREIGN KEY REFERENCES Product(id) not null,
	category_ID INT FOREIGN key REFERENCES Category(id) not null,
	PRIMARY KEY (product_ID, category_ID)
)

INSERT INTO Product VALUES
('Saint spring'),
('Coca-cola'),
('Alpen Gold'),
('Arkhyz'),
('Peanut')

INSERT INTO Category VALUES
('Drink'),
('Highly carbonated'),
('Water'),
('Non-carbonated'),
('Chocolate'),
('Juice')

INSERT INTO Showcase VALUES
(1,1),
(1,3),
(1,4),
(2,1),
(2,2),
(3,5),
(4,1),
(4,2),
(4,3)

SELECT Product.product_title AS 'Имя продукта', Category.category_title AS ' Имя категория'
FROM Showcase
right join Product ON Showcase.product_ID = Product.ID
left join Category ON Showcase.category_ID = Category.ID