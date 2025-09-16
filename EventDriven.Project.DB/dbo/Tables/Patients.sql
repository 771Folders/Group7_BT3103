CREATE TABLE [dbo].[Patients] (
    [PatientID] INT IDENTITY(1,1) PRIMARY KEY,
    [FirstName] VARCHAR(50) NULL,
    [LastName] VARCHAR(50) NULL,
    [DateOfBirth] DATE NULL,
    [Gender] VARCHAR(50) NULL,
    [Phone] VARCHAR(15),
    [Address] VARCHAR(100),
    [Email] VARCHAR(50),
    [EmergencyContact] VARCHAR(50),
    [DateRegistered] DATETIME NOT NULL DEFAULT GETDATE()
);
