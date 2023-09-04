CREATE TABLE dbo.Employee(
EmployeeID int IDENTITY(1,1),
EmployeeName VARCHAR(500),
Department VARCHAR(500),
DateOfJoining DATE,
PhotoFileName VARCHAR(500)
)

INSERT into dbo.Employee VALUES
('Sam', 'IT', '2020-06-01', 'anonymous.png')

SELECT * FROM dbo.Employee