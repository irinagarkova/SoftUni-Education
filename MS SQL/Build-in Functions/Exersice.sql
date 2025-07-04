USE [SoftUni]
GO


--problem 1
--First way - Use Left func
--Second way - Wild cars
SELECT [FirstName],[LastName]
FROM Employees
WHERE [FirstName] LIKE 'Sa%' -- първото име за започва с Са // % -> 0 символа или повече

--problem 2
SELECT [FirstName],[LastName]
FROM Employees
WHERE [LastName] LIKE '%ei%'

--problem 3
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3, 10)
  AND YEAR(HireDate) BETWEEN 1995 AND 2005

--problem 4
SELECT [FirstName],
       [LastName]
FROM [Employees]
WHERE CHARINDEX('engineer', [JobTitle]) = 0

--problem 5
SELECT [NAME]
FROM [Towns]
WHERE LEN([Name]) IN (5,6) -- връща дължината на името и филтрира само тези на който дължината е 5 и 6 символа
ORDER BY [Name] 

--problem 6
SELECT *
FROM [Towns]
WHERE LEFT([Name],1) IN ('M','K','B','E')
ORDER BY[Name]

--problem 7
--problem 8
--problem 9

--problem 10 RANK FUNCTION
SELECT [EmployeeID],
[FirstName],
[LastName],
[Salary],
DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID])
AS [RANK]
FROM [Employees]
WHERE [Salary] BETWEEN 10000 AND 50000
ORDER BY [Salary] DESC

--problem 11
SELECT *
FROM (
SELECT [EmployeeID],
          [FirstName],
          [LastName],
		  [Salary],
          DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID])
          AS [RANK]
    FROM [Employees]
   WHERE [Salary] BETWEEN 10000 AND 50000
   )
   AS[e]
WHERE [RANK] = 2
ORDER BY [Salary]DESC


--problem 12
--problem 13
SELECT [p].[PeakName],
       [r].[RiverName],
	   LOWER(CONCAT(SUBSTRING([p].[PeakName], 1, LEN([p].[PeakName])-1), [r].[RiverName]))
     AS[Mix]
  FROM [Peaks] AS [p],
       [Rivers] AS [r]
 WHERE RIGHT([p].[PeakName], 1) = LEFT([r].[RiverName], 1)
 ORDER BY[Mix]

--problem 14
--problem 15
GO
USE [Diablo]
GO

SELECT [Username],
	   SUBSTRING([Email], CHARINDEX('@',[Email]) + 1, LEN([Email]) - CHARINDEX('@',[Email]))
	   AS[Email Provider]
FROM [Users]
ORDER BY [Email Provider], [Username] 

--problem 16


--problem 17
SELECT [g].[Name],
  CASE
	   WHEN DATEPART(HOUR,[g].[Start]) BETWEEN 0 AND 11 THEN 'Morning'
	   WHEN DATEPART(HOUR,[g].[Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
	   ELSE 'Evening'
   END
      AS[Part of the Day],
   CASE
	   WHEN [g].[Duration] <= 3 THEN 'Extra Short'
	   WHEN [g].[Duration] BETWEEN 4 AND 6 THEN 'Short'
	   WHEN [g].[Duration] > 6 THEN 'Long'
	   ELSE 'Extra Long'
  END
	  AS[Duration]
FROM [Games]
AS [g]
ORDER BY [g].[Name], [Duration], [Part of the Day]

--problem 18
SELECT 
    ProductName,
    OrderDate,
    DATEADD(DAY, 3, OrderDate) AS PayDueDate,
    DATEADD(MONTH, 1, OrderDate) AS DeliverDueDate
FROM 
    Orders

