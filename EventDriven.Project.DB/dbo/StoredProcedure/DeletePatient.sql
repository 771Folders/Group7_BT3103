CREATE PROCEDURE [dbo].[DeletePatient]
	@PatientID INT
AS
	DELETE FROM [dbo].[Patients] WHERE PatientID = @PatientID