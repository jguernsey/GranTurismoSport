CREATE VIEW [dbo].[vw_GTS_BoardRegionCount]
AS
	SELECT		[BoardId],
				[RegionId],
				COUNT([UserId])	AS	[RegionCount]
	
	FROM		[dbo].[GTS_RaceRankings]			rr

	JOIN		[dbo].[GTS_Countries]				co
		ON		rr.[CountryId]				=		co.[CountryId]

	GROUP BY	[BoardId], [RegionId]

GO
