CREATE TABLE Patients (
    [PatientID] INT IDENTITY(1001,1) PRIMARY KEY,
    [FirstName] VARCHAR(50) NOT NULL,
    [LastName] VARCHAR(50) NOT NULL,
    [MiddleName] VARCHAR(50) NULL,
    [DateOfBirth] DATETIME NOT NULL,
    [Age] INT NOT NULL,
    [Gender] VARCHAR(50) NOT NULL,
    [Phone] VARCHAR(20) NOT NULL,
    [Address] VARCHAR(100) NULL,
    [Email] VARCHAR(50) NULL,
    [EmergencyContact] VARCHAR(50) NULL,
    [EmergencyContactPhone] VARCHAR(15) NULL,
    [Status] VARCHAR(50) DEFAULT 'Admitted' NOT NULL
);
