CREATE PROCEDURE SearchPatient
	@searchTerm NVARCHAR(50)
AS
	SELECT * FROM Patients
	WHERE FirstName LIKE '%' + @searchTerm + '%'
	   OR LastName LIKE '%' + @searchTerm + '%'
	   OR MiddleName LIKE '%' + @searchTerm + '%'
	   OR CAST(PatientID AS NVARCHAR(50)) LIKE '%' + @searchTerm + '%'
	   OR (FirstName + ' ' + MiddleName + ' ' + LastName) LIKE '%' + @searchTerm + '%'
	   OR (FirstName + ' ' + MiddleName) LIKE '%' + @searchTerm + '%'
	   OR (FirstName + ' ' + LastName) LIKE '%' + @searchTerm + '%'
	   OR (MiddleName + ' ' + LastName) LIKE '%' + @searchTerm + '%'
