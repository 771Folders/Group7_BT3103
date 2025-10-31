CREATE PROCEDURE [dbo].[DeleteStaffAssignments]
	@PatientID INT
AS
	DELETE FROM StaffAssignments WHERE PatientID = @PatientID