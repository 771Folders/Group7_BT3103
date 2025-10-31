CREATE PROCEDURE [dbo].[GetAssignedStaff]
	@PatientID INT
AS
	SELECT StaffID FROM StaffAssignments WHERE PatientID = @PatientID