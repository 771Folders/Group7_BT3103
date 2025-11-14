CREATE PROCEDURE [dbo].[AssignRoom]
	@PatientID INT,
	@RoomType VARCHAR (50),
	@RoomNumber INT,
	@BedNumber INT,
	@StartDate DATETIME,
	@EndDate DATETIME = NULL
AS
	INSERT INTO RoomAssignments (AdmissionID, RoomID, PatientID, BedNumber, StartDate, EndDate)
	VALUES ((SELECT TOP 1 AdmissionID FROM AdmissionHistory WHERE AdmissionHistory.PatientID = @PatientID ORDER BY AdmissionID DESC),
	(SELECT RoomID FROM Rooms WHERE RoomType = @RoomType AND RoomNumber = @RoomNumber), 
	@PatientID, @BedNumber, @StartDate, @EndDate)