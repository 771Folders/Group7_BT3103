CREATE PROCEDURE [dbo].[GetAssignedStaff]
	@PatientID int
AS
	SELECT 
		S.FirstName,
		S.LastName,
		S.Role
	FROM Staff S
	INNER JOIN StaffAssignments SA ON S.StaffID = SA.StaffID
	INNER JOIN Patients P ON SA.PatientID = P.PatientID
	WHERE P.PatientID = @PatientID;