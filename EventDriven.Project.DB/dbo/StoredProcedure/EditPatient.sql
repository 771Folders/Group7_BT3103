CREATE PROCEDURE [dbo].[EditPatient]
	@PatientID INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@DateOfBirth DATETIME,
	@Gender VARCHAR(50),
	@Phone VARCHAR(15),
	@Address VARCHAR(100),
	@Email VARCHAR(50),
	@EmergencyContact VARCHAR(50),
	@EmergencyContactPhone VARCHAR(15),
	@DateRegistered DATETIME = NULL
AS
	UPDATE [dbo].[Patients]
	SET
		FirstName = @FirstName,
		LastName = @LastName,
		MiddleName = @MiddleName,
		DateOfBirth = @DateOfBirth,
		Gender = @Gender,
		Phone = @Phone,
		Address = @Address,
		Email = @Email,
		EmergencyContact = @EmergencyContact,
		EmergencyContactPhone = @EmergencyContactPhone,
		DateRegistered = ISNULL(@DateRegistered, DateRegistered)
	WHERE PatientID = @PatientID