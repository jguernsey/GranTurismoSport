CREATE PROCEDURE [dbo].[GTS_RaceRankings_SeletcTopTenUsers]
	@BoardId				BIGINT
AS
	SELECT [Rank], [TotalEntries], [UserId], [ImagePath], [Score]
	FROM
	(
		SELECT  ROW_NUMBER() OVER(ORDER BY [Score]) AS [Rank],
				(SELECT COUNT([RankingId]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId) AS [TotalEntries],
				[UserId],
				[ImagePath],
				[Score]
		FROM [dbo].[GTS_RaceRankings]			rr
		JOIN	[dbo].[GTS_Countries]			c
			ON	rr.[CountryId]			=		c.[CountryId]
		WHERE	[BoardId]				=		@BoardId
	) T1
	WHERE	[Rank]						<=		10
GO
