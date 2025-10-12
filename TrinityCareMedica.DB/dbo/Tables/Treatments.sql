CREATE TABLE [dbo].[Treatments]
(
	[TreatmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[RecordID] INT NOT NULL,
	[TreatmentType] VARCHAR(100) NOT NULL,
	[Description] VARCHAR(MAX) NULL,
	[TreatmentDate] DATETIME NOT NULL DEFAULT GETDATE()
	FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID)
)
