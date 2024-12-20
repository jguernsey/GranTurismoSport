CREATE PROCEDURE [dbo].[GTS_RaceRankings_SelectWorldWideTopTwentyFive]
	@Title				NVARCHAR(128)
AS
	SELECT [Rank], [UserId], [CountryName], [Score]
	FROM
	(
		SELECT  ROW_NUMBER() OVER(ORDER BY [Score] ASC, [CreateTime] ASC) AS [Rank],
				(SELECT COUNT([RankingId]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] IN (SELECT [BoardId] FROM [dbo].[fn_GTS_GetBoardIdsByTitle](@Title))) AS [TotalEntries],
				[UserId],
				[CountryName],
				[Score]

		FROM	[dbo].[GTS_RaceRankings]			rr
		
		JOIN	[dbo].[GTS_Countries]			c
			ON	rr.[CountryId]			=		c.[CountryId]
		
		WHERE	[BoardId]				IN		(SELECT [BoardId] FROM [dbo].[fn_GTS_GetBoardIdsByTitle](@Title))
	) T1
	WHERE	[Rank]						<=		50
GO
