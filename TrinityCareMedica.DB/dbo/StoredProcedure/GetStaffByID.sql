CREATE PROCEDURE [dbo].[GetStaffByID]
	@StaffID INT
AS
	SELECT 
	s.StaffID,
	s.FirstName,
	s.LastName,
	d.DepartmentName,
	s.Role,
	s.Phone,
	s.Email,
	s.HireDate
	FROM Staff s
	JOIN Departments d ON s.DepartmentID = d.DepartmentID 
	WHERE s.StaffID = @StaffID