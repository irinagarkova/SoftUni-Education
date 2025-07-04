--problem 1
SELECT 
COUNT(*) AS TotalRecords 
FROM WizzardDeposits

--problem 2
SELECT 
MAX(w.MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits AS w

--problem 3
SELECT w.DepositGroup,
MAX(w.MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup

--problem 11
SELECT 
    DepositGroup, 
    IsDepositExpired, 
    AVG(DepositInterest) AS AverageDepositInterest
FROM WizzardDeposits
WHERE DepositStartDate > '1985-01-01'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired ASC


--problem 12
SELECT SUM([Difference]) AS [SumDifference]
FROM (
       SELECT [FirstName] AS [Host Wizard],
       [DepositAmount] AS [Host Deposit],
	   LEAD([FirstName]) OVER(ORDER BY [Id]) AS [Guest Wizard],--ВЗИМА втория ред и го добавя към първия
	   LEAD([DepositAmount]) OVER(ORDER BY [Id]) AS [Guest Deposit],
	   [DepositAmount] - LEAD([DepositAmount]) OVER(ORDER BY [Id]) AS [Difference]
       FROM WizzardDeposits
) AS [HostGuestWizardTempTable]

--problem 13
GO
USE [SoftUni]
GO
SELECT e.DepartmentID,
SUM(e.Salary) AS TotalSalary
FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID

--problem 14
SELECT DepartmentID,
MIN(Salary) AS [MinimumSalary]
FROM Employees
WHERE HireDate > '2000-01-01' 
AND DepartmentID IN (2,5,7)
GROUP BY DepartmentID

--PROBLEM 15
SELECT *
INTO [EmployeesWithHighSalary]
FROM [Employees]
WHERE [Salary] > 30000

DELETE FROM [EmployeesWithHighSalary]
WHERE [ManagerID] = 42

UPDATE [EmployeesWithHighSalary]
SET[Salary] += 5000
WHERE [DepartmentID] = 1 

SELECT DepartmentID,
AVG([Salary]) AS [AverageSalary]
FROM [EmployeesWithHighSalary]
GROUP BY[DepartmentID]



--PROBLEM 16
SELECT DepartmentID,
MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000


--PROBLEM 17
SELECT 
COUNT(*)
FROM Employees
WHERE ManagerID IS NULL


