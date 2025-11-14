CREATE PROCEDURE AddPatient
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@DateOfBirth DATETIME,
	@Age INT,
	@Gender VARCHAR(50),
	@Phone VARCHAR(15),
	@Address VARCHAR(100),
	@Email VARCHAR(50),
	@EmergencyContact VARCHAR(50),
	@EmergencyContactPhone VARCHAR(15) = NULL
AS
	INSERT INTO Patients(FirstName, LastName, MiddleName, DateOfBirth, Age, Gender, Phone, Address, Email, EmergencyContact, EmergencyContactPhone)
	VALUES (@FirstName, @LastName, @MiddleName, @DateOfBirth, @Age, @Gender, @Phone, @Address, @Email, @EmergencyContact, @EmergencyContactPhone)

	INSERT INTO AdmissionHistory (PatientID, AdmissionDate)
	VALUES ((SELECT TOP 1 PatientID FROM Patients ORDER BY PatientID DESC), GETDATE())