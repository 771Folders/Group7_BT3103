CREATE TABLE [dbo].[Medications]
(
	[MedicationID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[RecordID] INT NOT NULL,
	[MedicationName] VARCHAR(100) NOT NULL,
	[FrequencyCount] INT NOT NULL,
	[FrequencyInterval] INT NOT NULL,
	[Duration] INT NOT NULL,
	[Price] DECIMAL(10,2) NOT NULL,
	FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID) ON DELETE CASCADE
)
