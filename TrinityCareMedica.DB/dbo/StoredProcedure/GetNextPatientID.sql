CREATE PROCEDURE GetNextPatientID
	
AS
	SELECT IDENT_CURRENT('Patients') + IDENT_INCR('Patients') AS NextPatientID;