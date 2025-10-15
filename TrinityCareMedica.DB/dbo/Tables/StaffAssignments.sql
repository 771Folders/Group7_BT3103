CREATE TABLE [dbo].[StaffAssignments]
(
	[StaffAssignmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[PatientID] INT NOT NULL,
	[StaffID] INT NOT NULL,
	[Role] VARCHAR(50) NOT NULL,
	FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
	FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
)
