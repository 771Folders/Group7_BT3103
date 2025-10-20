CREATE PROCEDURE [dbo].[GetRoomByPatientID]
	@PatientID int
AS
BEGIN
	SELECT 
		R.RoomType,
		R.RoomNumber,
		RA.BedNumber,
		RA.StartDate,
		RA.EndDate
	FROM 
		RoomAssignments RA
	INNER JOIN 
		Rooms R ON R.RoomID = RA.RoomID
	WHERE 
		RA.PatientID = @PatientID;
END;	
