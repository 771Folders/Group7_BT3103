CREATE PROCEDURE [dbo].[AssignStaff]
	@PatientID INT,
	@StaffID INT
AS
	INSERT INTO StaffAssignments (PatientID, StaffID, Role)
	SELECT
			@PatientID,
			s.StaffID,
			s.Role
	FROM Staff s
	WHERE s.StaffID = @StaffID;
