CREATE PROCEDURE [dbo].[GetAssignedStaff]
	@PatientID int
AS
	SELECT 
		S.FirstName,
		S.LastName,
		S.Role
	FROM Staff S
	INNER JOIN MedicalRecordStaff MRS ON S.StaffID = MRS.StaffID
	INNER JOIN MedicalRecords MR ON MRS.RecordID = MR.RecordID
	WHERE MR.PatientID = @PatientID;