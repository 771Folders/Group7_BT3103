CREATE PROCEDURE [dbo].[AssignStaff]
	@PatientID INT,
	@StaffID int
AS
	INSERT INTO StaffAssignments (PatientID, StaffID) 
	VALUES (@PatientID, @StaffID)
