CREATE PROCEDURE [dbo].[GTS_RankedRaceTimes_Update]
AS
	TRUNCATE TABLE [dbo].[GTS_RankedRaceTimes]

	INSERT INTO [dbo].[GTS_RankedRaceTimes] ([TrackId], [CategoryId], [Score], [ProfileId], [WorldCount], [WorldRank], [RegionCount], [RegionRank], [CountryCount], [CountryRank], [CreateTime])
	SELECT		t.[Id], 
				cc.[CategoryId], 
				rr.[Score]																												AS	[Score],
				p.[ProfileId],
				COUNT(rr.[UserId]) OVER (PARTITION BY t.[Name], cc.[CategoryName])														AS	[TotalCount],
				RANK() OVER (PARTITION BY t.[Name], cc.[CategoryName] ORDER BY rr.[Score] ASC, rr.[CreateTime] ASC)						AS	[WorldRank],
				COUNT(rr.[UserId]) OVER (PARTITION BY t.[Name], cc.[CategoryName], c.[RegionId])										AS	[RegionCount],
				RANK() OVER (PARTITION BY t.[Name], cc.[CategoryName], c.[RegionId] ORDER BY rr.[Score] ASC, rr.[CreateTime] ASC)		AS	[RegionRank],
				COUNT(rr.[UserId]) OVER (PARTITION BY t.[Name], cc.[CategoryName], rr.[CountryId])										AS	[CountryCount],
				RANK() OVER (PARTITION BY t.[Name], cc.[CategoryName], rr.[CountryId] ORDER BY rr.[Score] ASC, rr.[CreateTime] ASC)		AS	[CountryRank],

				rr.[CreateTime]

	FROM		[dbo].[GTS_RaceRankings]			rr
	
	JOIN		[dbo].[GTS_EventDetail]				ed
		ON		rr.[BoardId]				=		ed.[BoardId]
	
	JOIN		[dbo].[GTS_Tracks]					t
		ON		ed.[CourseId]				=		t.[Id]
	
	JOIN		[dbo].[GTS_CarCategories]			cc
		ON		ed.[CarCategoryId]			=		cc.[CategoryId]
	
	JOIN		[dbo].[GTS_Countries]				c
		ON		rr.[CountryId]				=		c.[CountryId]

	JOIN		[dbo].[GTS_Profiles]				p
		ON		rr.[UserId]					=		p.[Id]

	JOIN
	(
		SELECT		t.[Name], cc.[CategoryName], rr.[UserId], MIN([Score]) AS [Score]
		FROM		[dbo].[GTS_RaceRankings]			rr
	
		JOIN		[dbo].[GTS_EventDetail]				ed
			ON		rr.[BoardId]				=		ed.[BoardId]
	
		JOIN		[dbo].[GTS_Tracks]					t
			ON		ed.[CourseId]				=		t.[Id]
	
		JOIN		[dbo].[GTS_CarCategories]			cc
			ON		ed.[CarCategoryId]			=		cc.[CategoryId]

		GROUP BY	t.[Name], cc.[CategoryName], rr.[UserId]
	) t1
		ON		t.[Name]						=		t1.[Name]
		AND		cc.[CategoryName]				=		t1.[CategoryName]
		AND		rr.[UserId]						=		t1.[UserId]
		AND		rr.[Score]						=		t1.[Score]

	ORDER BY	t.[Name], cc.[CategoryName], rr.Score ASC

GO
