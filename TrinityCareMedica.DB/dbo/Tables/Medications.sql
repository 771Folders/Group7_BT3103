CREATE TABLE [dbo].[Medications]
(
	[MedicationID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[RecordID] INT NOT NULL,
	[MedicationName] VARCHAR(100) NOT NULL,
	[Dosage] VARCHAR(50) NOT NULL,
	[Frequency] VARCHAR(50) NOT NULL,
	[Duration] VARCHAR(50) NOT NULL
	FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID)
)
