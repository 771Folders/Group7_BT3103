CREATE PROCEDURE [dbo].[DischargePatient]
	@PatientID INT,
	@AdmissionID INT
AS
	UPDATE Patients 
	SET Status = 'Discharged'
	WHERE PatientID = @PatientID

	UPDATE AdmissionHistory
	SET DischargeDate = GETDATE()
	WHERE AdmissionID = @AdmissionID