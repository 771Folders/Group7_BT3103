CREATE PROCEDURE [dbo].[GetAvailableBedNumbers]
	@RoomType VARCHAR(50),
	@RoomNumber INT
AS
	SELECT BedNumber
	FROM RoomAssignments
	JOIN Rooms ON Rooms.RoomID = RoomAssignments.RoomID
	WHERE Rooms.RoomType = @RoomType AND Rooms.RoomNumber = @RoomNumber