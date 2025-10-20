CREATE PROCEDURE [dbo].[GetRoomNumbers]
	@RoomType VARCHAR(50)
AS
	SELECT 
		RoomNumber
	FROM
		Rooms
	WHERE
		RoomType = @RoomType