CREATE TABLE [dbo].[RoomAssignments]
(
	[RoomAssignmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [RoomID] INT NOT NULL, 
    [PatientID] INT NOT NULL, 
    [AdmissionID] INT NOT NULL,
    [BedNumber] INT NOT NULL,
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NULL,
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (AdmissionID) REFERENCES AdmissionHistory(AdmissionID)
)
