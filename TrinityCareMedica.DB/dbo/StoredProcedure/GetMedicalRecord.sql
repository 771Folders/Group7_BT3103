CREATE PROCEDURE [dbo].[GetMedicalRecord]
	@PatientID int
AS
BEGIN
    SET NOCOUNT ON;
	SELECT
	MR.RecordID,
	MR.RecordDate,
    COALESCE(
    R.RoomType + ' - ' + CAST(R.RoomNumber AS VARCHAR(10)),
    'No Room Assigned'
    ) AS RoomName,
    COALESCE(
        STRING_AGG(CONCAT(S.FirstName, ' ', S.LastName), ', '),
        'No Assigned Doctor'
    ) AS DoctorName,
    MR.Diagnosis,
    MR.Notes,
	COALESCE(
        (SELECT STRING_AGG(CONCAT(M.MedicationName, ' - ', M.Dosage, ' - ', M.Frequency, ' - ', M.Duration), ', ')
         FROM Medications M
         WHERE M.RecordID = MR.RecordID),
        'None'
    ) AS Medications,
    COALESCE(
        (SELECT STRING_AGG(CONCAT(T.TreatmentType, ' - ', T.TreatmentDate), ', ')
         FROM Treatments T
         WHERE T.RecordID = MR.RecordID),
        'None'
    ) AS Treatments
    FROM
        MedicalRecords MR
        INNER JOIN Rooms R ON MR.RoomID = R.RoomID
        LEFT JOIN MedicalRecordStaff MRS ON MR.RecordID = MRS.RecordID
        LEFT JOIN Staff S ON MRS.StaffID = S.StaffID
    WHERE
        MR.PatientID = @PatientID
    GROUP BY
        MR.PatientID,
        MR.RecordID,
        MR.RecordDate,
        R.RoomType,
        R.RoomNumber,
        MR.Diagnosis,
        MR.Notes
    ORDER BY
        MR.RecordDate DESC;
END;