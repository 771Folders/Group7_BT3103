CREATE PROCEDURE [dbo].[GetCurrentRoom]
    @PatientID INT
AS
SELECT TOP 1
    r.RoomID,
    ra.AdmissionID,
    r.RoomType,
    r.RoomNumber,
    ra.BedNumber,
    ra.StartDate,
    ra.EndDate
FROM 
    RoomAssignments ra
INNER JOIN 
    Rooms r ON ra.RoomID = r.RoomID
WHERE 
    ra.PatientID = @PatientID
ORDER BY 
    CASE 
        WHEN ra.EndDate IS NULL OR ra.EndDate > GETDATE() THEN 0
        ELSE 1
    END,
    ra.StartDate DESC;