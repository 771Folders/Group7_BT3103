CREATE PROCEDURE [dbo].[GetPatientByMiddleName]
	@MiddleName VARCHAR(50)
AS
	SELECT * FROM [dbo].[Patients] 
	WHERE MiddleName LIKE '%' + @MiddleName + '%'
