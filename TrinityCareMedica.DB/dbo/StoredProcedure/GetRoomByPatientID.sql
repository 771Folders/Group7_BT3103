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
		Rooms R
	INNER JOIN 
		RoomAssignments RA ON R.RoomID = RA.RoomID
	WHERE 
		RA.PatientID = @PatientID;
END;	
