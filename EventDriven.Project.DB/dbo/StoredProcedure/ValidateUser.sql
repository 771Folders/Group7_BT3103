CREATE PROCEDURE [dbo].[ValidateUser]
	@Username NVARCHAR(30),
	@Password NVARCHAR(30)

AS
	BEGIN
	SELECT
		*
	FROM
		dbo.[User]
	WHERE
		Username = @Username AND Password = @Password
	END