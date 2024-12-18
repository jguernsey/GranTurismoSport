
CREATE PROCEDURE [dbo].[GTS_CountryDetail_Select]
AS
	SELECT		c.[CountryId], [CountryName], [TotalCount], [ImportCount], [MissingCount], [PercentMissing]
	
	FROM		[dbo].[GTS_Countries]										c
	
	JOIN		[dbo].[GTS_MissingStatsPercentageByCountry]					mp
		ON		c.[CountryId]								=			mp.[CountryId]
	
	ORDER BY	mp.[TotalCount]


GO
