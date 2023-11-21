USE master;

GO
IF exists (SELECT name FROM sys.databases WHERE name like 'Task3DB')
BEGIN
	ALTER DATABASE Task3DB SET single_user with rollback immediate
	DROP DATABASE Task3DB
	CREATE DATABASE Task3DB
END;