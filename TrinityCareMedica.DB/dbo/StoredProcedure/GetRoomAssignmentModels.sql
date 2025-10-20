CREATE PROCEDURE [dbo].[GetRoomAssignmentModels]
AS
	SELECT 
		R.RoomType,
		R.RoomNumber
	FROM Rooms R
	JOIN RoomAssignments RA ON R.RoomID = RA.RoomID