CREATE PROCEDURE DeletePatient
	@PatientID INT
AS
	DELETE FROM Patients WHERE PatientID = @PatientID