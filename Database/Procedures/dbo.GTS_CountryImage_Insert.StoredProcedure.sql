CREATE PROCEDURE [dbo].[GTS_CountryImage_Insert]
	@CountryId		BIGINT,
	@ImageData		VARBINARY(MAX)
AS
	UPDATE [dbo].[GTS_Countries] SET [FlagImage] = @ImageData WHERE [CountryId] = @CountryId


GO
