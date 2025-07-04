SELECT *
 FROM Departments

SELECT [Name] 
  FROM Departments

SELECT FirstName,LastName,Salary
  FROM Employees

SELECT FirstName,MiddleName,LastName
  FROM Employees

SELECT[FirstName] + '.' + [LastName] + '@softuni.bg'
    AS [Full Email Address]
  FROM [Employees]

SELECT 
DISTINCT [Salary]
FROM [Employees]

SELECT *
FROM[Employees]
WHERE [JobTitle] = 'Sales Representative'

SELECT 
[FirstName],
[LastName],
[JobTitle]
FROM[Employees]
WHERE [Salary] BETWEEN 20000 AND 30000

SELECT[FirstName] + ' ' + ISNULL([MiddleName], '') + ' ' + [LastName]
AS[Full Name]
FROM[Employees]
WHERE [Salary] IN (25000,14000,12500,23600)

--PROBLEM 11
SELECT [FirstName], [LastName]
FROM [Employees]
WHERE [ManagerID] IS NULL

--PROBLEM 12
SELECT [FirstName],[LastName], [Salary]
FROM [Employees]
WHERE [Salary] > 50000
ORDER BY[Salary] DESC

--PROBLEM 13
SELECT TOP(5) 
           [FirstName], [LastName]
      FROM [Employees]
  ORDER BY [Salary] DESC

--PROBLEM 14
SELECT [FirstName],[LastName]
FROM[Employees]
WHERE [DepartmentID] NOT IN (4)

--PROBLEM 15
SELECT *
FROM [Employees]
ORDER BY [Salary] DESC,
         [FirstName] ASC,
		 [LastName] DESC,
		 [MiddleName] ASC

--PROBLEM 16
CREATE
VIEW [V_EmployeesSalaries]
AS(
     SELECT CONCAT( [FirstName],'')
                  AS[FirstName],[LastName],[Salary]
               FROM [Employees]
)


--PROBLEM 17
CREATE 
VIEW [V_EmployeeNameJobTitle]
AS( 
    SELECT CONCAT(
                 [FirstName], ' ',[MiddleName], ' ', [LastName])
              AS [Full Name], [JobTitle]
            FROM [Employees]
)

--PROBLEM 18
SELECT 
DISTINCT[JobTitle]
AS [JobTItle]
FROM [Employees]

--PROBLEM 19
SELECT TOP (10) * 
FROM[Projects]
ORDER BY [StartDate],[Name] ASC


--PROBLEM 20
SELECT TOP (7) [FirstName],[LastName],[HireDate]
FROM[Employees]
ORDER BY [HireDate] DESC
--PROBLEM 21
SELECT *
FROM [Departments]

UPDATE[Employees]
SET [Salary] += (0.12 * [Salary])
WHERE[DepartmentID] IN (1,2,4,11)

SELECT [Salary] 
FROM[Employees]


USE [Geography]
GO
--PROBLEM 22
SELECT [PeakName]
AS[PeakName]
FROM[Peaks]
ORDER BY[PeakName] ASC
--PROBLEM 23
SELECT TOP (30) [CountryName], [Population]
FROM [Countries]
WHERE [ContinentCode] = 'EU'
ORDER BY [Population] DESC, [CountryName] ASC

--PROBLEM 24
SELECT [CountryName], [CountryCode], 
CASE
WHEN [CurrencyCode] = 'EUR' THEN 'Euro'
ELSE 'Not Euro'
END
AS[Currency]
FROM [Countries]
ORDER BY [CountryName]


USE[Diablo]
GO
--PROBLEM 25
SELECT [Name]
FROM[Characters]
ORDER BY [Name] ASC



USE[SoftUni]
GO 

