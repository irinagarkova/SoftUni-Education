DROP TABLE [Users]

CREATE TABLE [Users](
[Id] BIGINT PRIMARY KEY IDENTITY NOT NULL, --identity is auto increment
[Username] VARCHAR(30) UNIQUE NOT NULL, --UNIQUE -УНИКАЛЕН 
[Password] VARCHAR(26) NOT NULL,
[ProfilePicture] VARBINARY(MAX), --РАЗМЕРА Е В БАЙТОВЕ!!
[LastLoginTime] DATETIME2,
[IsDeleted] BIT  --BIT Пази само 0 и 1, което може да е 1 за и 0 за
)

INSERT INTO [Users]([Username],[Password],[ProfilePicture],[LastLoginTime], [IsDeleted])
VALUES
('Pesho','12345', NULL, GETDATE(), NULL),
('Gosho','1234567', NULL, GETUTCDATE (), 0),
('Ivan','123456789', NULL, NULL, 1),
('Dragan','12333', NULL, NULL, 0),
('Maria','192222', NULL, GETDATE(), 1)

---- FROM HERE !!!!
ALTER TABLE[Users] --махаме праймъри ключа
DROP [PK__Users__77222459C3D055C7]

ALTER TABLE[Users]
ADD CONSTRAINT[PK_Composite_Id_Username] --създаваме нов, като му задаваме име и с какви параметри да работи 
PRIMARY KEY([Id],[Username])

--add check constaint - да валидираме
ALTER TABLE[Users]
ADD CONSTRAINT[CK_Passwords_MIN_5]
CHECK(LEN([Password]) >= 5) --проверяваме дали дължината на Password е по-голяма или равна на 5 / LEN e вградена функция която връща дължината 
--check constraint са правила който дефинират логически правила на който трябва да отговарят нещата в таблицата 

-- default value of a Field
ALTER TABLE[Users]
ADD CONSTRAINT [DF_LastLoginTime_Current_Time]
DEFAULT GETDATE() FOR [LastLoginTime] --ако някой не изсъртне (да няма сложена изобщо, не да бъде NULL) стойност дефолтно ще се сложи стойност  

--PROBLEM 16
CREATE DATABASE [SoftUni]

GO
USE [SoftUni]

CREATE TABLE[Towns](
[Id] INT PRIMARY KEY IDENTITY NOT NULL,
[Name] NVARCHAR(85) NOT NULL
)
CREATE TABLE[Addresses](
[Id] INT PRIMARY KEY IDENTITY NOT NULL,
[AddressText] NVARCHAR(147) NOT NULL,
[TownId] INT FOREIGN KEY REFERENCES [Towns]([Id]) 
)

CREATE TABLE[Departments](
[Id] INT PRIMARY KEY IDENTITY NOT NULL,
[Name] NVARCHAR(70) NOT NULL
)

CREATE TABLE[Employees](
[Id] INT PRIMARY KEY IDENTITY NOT NULL,
[FirstName] NVARCHAR(36) NOT NULL,
[MiddleName] NVARCHAR(36),
[LastName] NVARCHAR(36) NOT NULL,
[JobTittle] NVARCHAR(40) NOT NULL,
[DepartmentId] INT FOREIGN KEY REFERENCES [Departments]([Id]) NOT NULL,
[HireDate] DATE NOT NULL DEFAULT(GETDATE()),
[Salary] DECIMAL(18,2) NOT NULL,
[AddressId] INT FOREIGN KEY REFERENCES [Addresses]([Id])
)


--PROBLEM 18
INSERT INTO[Towns]([Name])
VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')


INSERT INTO [Departments]([Name])
VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance') 


ALTER TABLE[Employees]
ALTER COLUMN[AddressId]
INT


INSERT INTO[Employees]([FirstName],[MiddleName],[LastName],[JobTittle],[DepartmentId],[HireDate],[Salary])
VALUES
('Ivan', 'Ivanov', 'Ivanov','.NET Developer',4,'02/01/2013','3500.00'),
('Petar', 'Petrov', 'Petrov','Senior Engineer',1,'03/02/2004','4000.00'),
('Maria', 'Petrova', 'Ivanova','Intern',5,'08/28/2016','525.25'),
('Georgi', 'Teziev', 'Ivanov','CEO',2,'12/09/2007','3000.00'),
('Peter', 'Pan', 'Pan','Intern',3,'08/28/2016','599.88')
	
SELECT * FROM [Departments]

--WITH DROP [NAMEOFTABLE] WE WILL DELETE THE TABLE

-- как се прави BACK-UP ! 
--десен бутон на базата данни --> таскс --> бекъп -->



--PROBLEM 19 & 20 
--HOW TO SORT ?? по дефолд ордера е възходящ, ASC(default) - възходящ ,DESC - низходящ
SELECT * FROM [Towns]
ORDER BY[Name]
SELECT * FROM [Departments]
ORDER BY[Name]
SELECT * FROM [Employees]
ORDER BY[Salary]DESC

--PROBLEM 21
SELECT [Name]
FROM [Towns]
ORDER BY[Name]

SELECT [Name]
FROM [Departments]
ORDER BY[Name]

SELECT [FirstName],[LastName],[JobTittle],[Salary]
FROM [Employees]
ORDER BY[Salary]DESC


UPDATE [Employees]
SET [Salary] = Salary * 1.15