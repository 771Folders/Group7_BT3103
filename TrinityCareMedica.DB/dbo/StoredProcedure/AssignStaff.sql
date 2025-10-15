CREATE PROCEDURE [dbo].[AssignStaff]
	@PatientID INT,
	@StaffID INT
AS
	INSERT INTO StaffAssignments (PatientID, StaffID, Role)
	VALUES (@PatientID, @StaffID, (SELECT Role FROM Staff WHERE StaffID = @StaffID));