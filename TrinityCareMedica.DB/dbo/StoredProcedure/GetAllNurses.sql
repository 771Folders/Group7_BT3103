CREATE PROCEDURE [dbo].[GetAllNurses]
AS
	SELECT 
	s.StaffID,
	s.FirstName,
	s.LastName,
	d.DepartmentName,
	s.Phone,
	s.Email,
	s.HireDate
	FROM Staff s
	JOIN Departments d ON s.DepartmentID = d.DepartmentID
	WHERE s.Role = 'Nurse'