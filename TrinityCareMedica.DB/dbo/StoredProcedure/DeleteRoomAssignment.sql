CREATE PROCEDURE [dbo].[DeleteRoomAssignment]
	@PatientID INT
AS
	DELETE FROM RoomAssignments WHERE PatientID = @PatientID