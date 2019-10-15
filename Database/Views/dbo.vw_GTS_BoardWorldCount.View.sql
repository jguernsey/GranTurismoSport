CREATE VIEW [dbo].[vw_GTS_BoardWorldCount]
AS
	SELECT		[BoardId],
				COUNT([UserId]) AS	[WorldCount]

	FROM		[dbo].[GTS_RaceRankings]	

	GROUP BY	[BoardId]

GO
