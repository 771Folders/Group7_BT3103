CREATE PROCEDURE [dbo].[GetStaffByID]
	@StaffID INT
AS
	SELECT * FROM Staff WHERE StaffID = @StaffID