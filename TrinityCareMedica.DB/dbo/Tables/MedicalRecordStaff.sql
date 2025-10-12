CREATE TABLE [dbo].[MedicalRecordStaff]
(
	[RecordStaffID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[RecordID] INT NOT NULL,
	[StaffID] INT NOT NULL,
	[Role] VARCHAR(50) NOT NULL,
	FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID),
	FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)
