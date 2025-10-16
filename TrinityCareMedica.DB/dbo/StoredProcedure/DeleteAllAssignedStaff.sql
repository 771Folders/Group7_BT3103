CREATE PROCEDURE [dbo].[DeleteAllAssignedStaff]
	@PatientID INT
AS
	DELETE FROM StaffAssignments WHERE PatientID = @PatientID;