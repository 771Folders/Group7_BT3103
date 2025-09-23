CREATE PROCEDURE [dbo].[GetPatientByFirstName]
	@FirstName VARCHAR(50)
AS
	SELECT * FROM [dbo].[Patients] 
	WHERE FirstName = @FirstName