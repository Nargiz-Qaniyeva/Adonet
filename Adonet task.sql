CREATE DATABASE ADONET

USE ADONET

CREATE TABLE Employee (
Id int identity primary key,
Fullname nvarchar (50)
)
--SELECT Fullname FROM Employee WHERE Id=1
--SELECT Fullname FROM Employee
--DELETE FROM Employee WHERE Id=2;
INSERT INTO Employee VALUES ('Ilkin Ibrahimov')
--DROP TABLE Employee 

SELECT Fullname FROM Employee
WHERE Fullname LIKE '%n%'