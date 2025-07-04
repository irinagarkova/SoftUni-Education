--problem 1
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000  
AS  
BEGIN  
    SELECT  
        FirstName,  
        LastName  
    FROM Employees  
    WHERE Salary > 35000;  
END

--problem 2

CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber 
@salary DECIMAL (18,4)
AS
BEGIN
SELECT FirstName, LastName
FROM Employees
 WHERE Salary >= @salary
 END

--problem 3
--problem 4
--problem 5
CREATE FUNCTION
ufn_GetSalaryLevel(@Salary MONEY)
RETURNS NVARCHAR(10)
AS
BEGIN
DECLARE @salaryLevel VARCHAR(10)
IF (@Salary < 30000)
SET @salaryLevel = 'Low'
ELSE IF(@Salary <= 50000)
SET @salaryLevel = 'Average'
ELSE
SET @salaryLevel = 'High'
RETURN @salaryLevel
END
--problem 6
--problem 7