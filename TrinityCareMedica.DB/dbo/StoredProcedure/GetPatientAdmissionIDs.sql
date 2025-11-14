CREATE PROCEDURE [dbo].[GetPatientAdmissionIDs]
	@PatientID INT
AS
	SELECT AdmissionID FROM AdmissionHistory WHERE PatientID = @PatientID;