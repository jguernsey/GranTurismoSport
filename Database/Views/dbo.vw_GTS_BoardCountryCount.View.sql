CREATE VIEW [dbo].[vw_GTS_BoardCountryCount]
AS
	SELECT		[BoardId],
				[CountryId],
				COUNT([UserId]) AS [CountryCount]

	FROM		[dbo].[GTS_RaceRankings]

	GROUP BY	[BoardId], [CountryId]

GO
