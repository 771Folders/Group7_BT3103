CREATE PROCEDURE [dbo].[DeleteAssignedRoom]
	@RoomID INT
AS
	DELETE FROM RoomAssignments WHERE RoomID = @RoomID