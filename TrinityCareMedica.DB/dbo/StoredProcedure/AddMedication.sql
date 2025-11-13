CREATE PROCEDURE [dbo].[AddMedication]
	@RecordID INT,
	@MedicationName VARCHAR(100),
	@FrequencyCount INT,
	@FrequencyInterval INT,
	@Duration INT,
	@Price DECIMAL(10,2)
AS
	INSERT INTO Medications (RecordID, MedicationName, FrequencyCount, FrequencyInterval, Duration, Price)
	VALUES (@RecordID, @MedicationName, @FrequencyCount, @FrequencyInterval, @Duration, @Price);