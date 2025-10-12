CREATE TABLE [dbo].[Departments]
(
	[DepartmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[DepartmentName] VARCHAR(100) NOT NULL,
	[Description] VARCHAR(MAX) NULL
)
