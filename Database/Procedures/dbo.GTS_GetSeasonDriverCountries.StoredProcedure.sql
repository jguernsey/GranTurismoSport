CREATE PROCEDURE	[dbo].[GTS_GetSeasonDriverCountries]
	@EventTarget			NVARCHAR(64),
	@RegionId				BIGINT
AS
	SELECT		[CountryName], [CountryId]

	FROM		[dbo].[GTS_Countries]

	WHERE		[RegionId]					=		@RegionId

	ORDER BY	[CountryName]

GO
