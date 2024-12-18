CREATE PROCEDURE [dbo].[GTS_LastUpdate_Update]
	@ProfileId	 BIGINT
AS
	DECLARE @LastUpdate DATETIME

	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_LastUpdate] WHERE [ProfileId] = @ProfileId)
		BEGIN
			SET @LastUpdate = (SELECT '1753-01-01')

			INSERT INTO [dbo].[GTS_LastUpdate] ([ProfileId], [UpdateDate])
			VALUES (@ProfileId, GETDATE())
		END
	ELSE
		BEGIN
			SET @LastUpdate = (SELECT [UpdateDate] FROM [dbo].[GTS_LastUpdate] WHERE [ProfileId] = @ProfileId)

			UPDATE	[dbo].[GTS_LastUpdate]
			SET		[UpdateDate] = GETDATE()
			WHERE	[ProfileId] = @ProfileId
		END

	SELECT @LastUpdate



GO
