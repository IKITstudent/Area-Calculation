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