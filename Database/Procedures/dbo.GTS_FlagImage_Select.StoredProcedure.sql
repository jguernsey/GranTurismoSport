
CREATE PROCEDURE [dbo].[GTS_FlagImage_Select]
	@CountryName		NVARCHAR(32)
AS
	SELECT	[FlagImage]
	FROM	[dbo].[GTS_Countries]
	WHERE	[CountryName] = @CountryName



GO
