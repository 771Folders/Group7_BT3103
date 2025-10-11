CREATE TABLE Patients (
    [PatientID] INT IDENTITY(1001,1) PRIMARY KEY,
    [FirstName] VARCHAR(50),
    [LastName] VARCHAR(50),
    [MiddleName] VARCHAR(50),
    [DateOfBirth] DATETIME,
    [Gender] VARCHAR(50),
    [Phone] VARCHAR(15),
    [Address] VARCHAR(100),
    [Email] VARCHAR(50),
    [EmergencyContact] VARCHAR(50),
    [EmergencyContactPhone] VARCHAR(15),
    [DateRegistered] DATETIME NOT NULL DEFAULT GETDATE()
);
