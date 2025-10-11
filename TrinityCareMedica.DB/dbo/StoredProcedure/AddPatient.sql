CREATE PROCEDURE AddPatient
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@DateOfBirth DATETIME,
	@Gender VARCHAR(50),
	@Phone VARCHAR(15),
	@Address VARCHAR(100),
	@Email VARCHAR(50),
	@EmergencyContact VARCHAR(50),
	@EmergencyContactPhone VARCHAR(15) = NULL,
	@DateRegistered DATETIME = NULL
AS
	INSERT INTO Patients(FirstName, LastName, MiddleName, DateOfBirth, Gender, Phone, Address, Email, EmergencyContact, EmergencyContactPhone, DateRegistered)
	VALUES (@FirstName, @LastName, @MiddleName, @DateOfBirth, @Gender, @Phone, @Address, @Email, @EmergencyContact, @EmergencyContactPhone, ISNULL(@DateRegistered, GETDATE()))