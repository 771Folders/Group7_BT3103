CREATE PROCEDURE [dbo].[GetRoomCapacity]
	@RoomType VARCHAR(50)
AS
	SELECT 
		Capacity
	FROM
		Rooms
	WHERE
		RoomType = @RoomType