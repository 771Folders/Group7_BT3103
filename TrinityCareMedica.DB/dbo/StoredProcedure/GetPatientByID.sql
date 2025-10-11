CREATE PROCEDURE GetPatientByID
	@PatientID INT
AS
	SELECT * FROM Patients WHERE PatientID = @PatientID