CREATE PROCEDURE [dbo].[GetPatientByLastName]
	@LastName VARCHAR(50)
AS
	SELECT * FROM [dbo].[Patients] 
	WHERE LastName LIKE '%' + @LastName + '%'