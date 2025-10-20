CREATE PROCEDURE [dbo].[AssignRoom]
	@PatientID INT,
	@RoomType VARCHAR(50),
	@RoomNumber INT,
	@BedNumber VARCHAR(10) = NULL,
	@StartDate DATETIME,
	@EndDate DATETIME = NULL
AS
	INSERT INTO RoomAssignments (RoomID, PatientID, BedNumber, StartDate, EndDate)
	SELECT
		r.RoomID,
		@PatientID,
		@BedNumber,
		@StartDate,
		@EndDate
	FROM Rooms r
	WHERE r.RoomType = @RoomType AND r.RoomNumber = @RoomNumber;