CREATE PROCEDURE [dbo].[AssignRoom]
	@PatientID INT,
	@RoomID INT,
	@BedNumber VARCHAR(10) = NULL,
	@StartDate DATETIME,
	@EndDate DATETIME = NULL
AS
	INSERT INTO RoomAssignments (RoomID, PatientID, BedNumber, StartDate, EndDate)
	VALUES (@RoomID, @PatientID, @BedNumber, @StartDate, @EndDate);