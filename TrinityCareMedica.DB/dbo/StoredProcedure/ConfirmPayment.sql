CREATE PROCEDURE [dbo].[ConfirmPayment]
	@BillingID INT,
	@AmountPaid DECIMAL(10,2)
AS
BEGIN
	UPDATE Billings
		SET 
			AmountPaid = AmountPaid + @AmountPaid,
			BillingDate = GETDATE()
		WHERE BillingID = @BillingID

	SELECT * FROM Billings WHERE BillingID = @BillingID;
END