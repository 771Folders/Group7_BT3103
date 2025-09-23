CREATE PROCEDURE [dbo].[GetPatientByID]
	@PatientID INT
AS
	SELECT * FROM [dbo].[Patients] WHERE PatientID = @PatientID