
CREATE PROCEDURE [dbo].[GTS_LocalizedText_Insert]
	@RoundId		BIGINT,
	@TextType		BIGINT,
	@CountryCode	NVARCHAR(2),
	@LocalText		NVARCHAR(4000)
AS
	BEGIN
		DECLARE @CountryId BIGINT
		SET @CountryId = (SELECT [CountryId] FROM [dbo].[GTS_Countries] WHERE [CountryCode] = @CountryCode)

		IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_LocalizedText] WHERE [RoundId] = @RoundId AND [TextType] = @TextType AND [CountryId] = @CountryId)
			BEGIN
				INSERT INTO [dbo].[GTS_LocalizedText] ([RoundId], [TextType], [CountryId], [LocalText])
				VALUES (@RoundId, @TextType, @CountryId, @LocalText)
			END
	END

GO
