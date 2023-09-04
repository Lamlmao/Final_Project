CREATE TABLE dbo.Department(
DepartmentID int identity(1,1),
DepartmentName varchar(500)
)

SELECT * FROM dbo.Department

insert into dbo.Department VALUES
('Support')