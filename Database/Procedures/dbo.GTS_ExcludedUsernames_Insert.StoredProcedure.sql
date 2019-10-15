
CREATE PROCEDURE [dbo].[GTS_ExcludedUsernames_Insert]
	@Username			NVARCHAR(32)
AS
	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_ExcludedUsernames] WHERE [Username] = @Username)
		BEGIN
			INSERT INTO [dbo].[GTS_ExcludedUsernames] ([Username])
			VALUES (@Username)
		END

GO
