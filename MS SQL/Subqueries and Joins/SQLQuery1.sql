--problem 1
SELECT TOP (5) 
[e].EmployeeID,
[e].JobTitle,
[e].AddressID,
[a].AddressText
FROM [Employees]AS [e]
INNER JOIN [Addresses] AS [a]
ON [e].AddressID = [a].AddressID
ORDER BY [e].[AddressID]


--problem 2
SELECT TOP 50 
     e.FirstName,
     e.LastName,
     t.Name as Town, 
     a.AddressText
FROM [Employees] e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName

--problem 3
SELECT 
   e.EmployeeID, 
   e.FirstName,
   e.LastName,
   d.Name AS DepartmentName
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID

--problem 4
SELECT TOP(5) 
[e].[EmployeeID],
[e].[FirstName],
[e].[Salary],
[d].[Name]
FROM [Employees] AS [e]
INNER JOIN [Departments] AS [d]
ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [e].Salary > 15000
ORDER BY [e].[DepartmentID]

--problem 5
SELECT TOP(3)
[e].EmployeeID,
[e].[FirstName]
FROM [Employees] AS[e]
LEFT JOIN [EmployeesProjects] AS [ep]
ON [ep].EmployeeID = [e].[EmployeeID]
WHERE [ep].[ProjectID] IS NULL
ORDER BY [e].[EmployeeID]

--problem 6
SELECT 
e.FirstName, 
e.LastName, 
e.HireDate,
d.Name as DeptName
FROM Employees e
INNER JOIN Departments d
ON (e.DepartmentId = d.DepartmentId
AND e.HireDate > '1/1/1999'
AND d.Name IN ('Sales', 'Finance'))
ORDER BY e.HireDate ASC

--problem 7
SELECT TOP(5)
[e].EmployeeID,
[e].FirstName,
[p].[Name]
FROM[EmployeesProjects] AS [ep]
INNER JOIN [Employees] AS [e]
ON [ep].[EmployeeID] = [e].[EmployeeID]
INNER JOIN[Projects] AS [p]
ON [ep].[ProjectID] = [p].ProjectID
WHERE [p].StartDate > '08/13/2002' 
AND [p].EndDate IS NULL
ORDER BY [ep].[EmployeeID]

--problem 8
--problem 9 SELF-REFERENCE
SELECT 
[e1].EmployeeID,
[e1].FirstName,
[e1].ManagerID,
[e2].FirstName AS [ManagerName]
FROM[Employees] AS [e1]
LEFT JOIN [Employees] AS [e2]
ON [e1].[ManagerID] = [e2].EmployeeID
WHERE [e1].ManagerID IN (3,7)
ORDER BY[e1].EmployeeID

--problem 10
SELECT TOP 50
e.EmployeeID,
e.FirstName + ' ' + e.LastName AS EmployeeName,
m.FirstName + ' ' + m. LastName AS ManagerName,
d.Name AS DepartmentName
FROM Employees AS e
LEFT JOIN Employees AS m ON m.EmployeeID =
e.ManagerID
LEFT JOIN Departments AS d ON d.DepartmentID =
e.DepartmentID
ORDER BY e.EmployeeID ASC

--problem 11
SELECT
MIN(a.AverageSalary) AS MinAverageSalary
FROM
(
  SELECT e.DepartmentID,
   AVG(e.Salary) AS AverageSalary
  FROM Employees AS e
  GROUP BY e.DepartmentID
) AS a

--problem 12
--problem 13
GO 
USE [Geography]
GO

SELECT [c].CountryCode,
COUNT ([mc].[MountainId]) AS[MountainRanges]
FROM Countries AS[c]
LEFT JOIN[MountainsCountries] AS [mc]
ON[mc].CountryCode = [c].CountryCode
WHERE [c].CountryName IN('United States','Russia','Bulgaria')
GROUP BY [c].CountryCode

--problem 14
--problem 15
--problem 16