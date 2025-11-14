CREATE PROCEDURE [dbo].[DischargePatient]
    @PatientID INT,
    @AdmissionID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (
        SELECT 1
        FROM AdmissionHistory
        WHERE AdmissionID = @AdmissionID
        AND PatientID = @PatientID
    )
    BEGIN
        RAISERROR('Invalid AdmissionID for the specified PatientID.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1
        FROM AdmissionHistory
        WHERE AdmissionID = @AdmissionID
        AND DischargeDate IS NOT NULL
    )
    BEGIN
        RAISERROR('This admission has already been discharged.', 16, 1);
        RETURN;
    END

    UPDATE RoomAssignments
    SET EndDate = GETDATE()
    WHERE PatientID = @PatientID
    AND AdmissionID = @AdmissionID
    AND EndDate IS NULL;

    UPDATE AdmissionHistory
    SET DischargeDate = GETDATE()
    WHERE AdmissionID = @AdmissionID;

    UPDATE Patients
    SET Status = 'Discharged'
    WHERE PatientID = @PatientID;
END
