CREATE PROCEDURE [dbo].[GetStaffIDByName]
	@Name VARCHAR(50)
AS
	SELECT
	StaffID
	FROM Staff
	WHERE CONCAT(FirstName, ' ', LastName) = @Name;