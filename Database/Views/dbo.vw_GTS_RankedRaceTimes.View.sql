CREATE VIEW		[dbo].[vw_GTS_RankedRaceTimes]
AS
SELECT			COUNT([UserId]) OVER(PARTITION BY [Name], [Time], [TimeOfDay], [SkyType], [CategoryName], [CarType]) AS [TotalCount],
				RANK() OVER(PARTITION BY [Name], [Time], [TimeOfDay], [SkyType], [CategoryName], [CarType] ORDER BY [Score] ASC) AS [WorldRank],
				RANK() OVER(PARTITION BY [Name], [Time], [TimeOfDay], [SkyType], [CategoryName], [Region], [CarType] ORDER BY [Score] ASC) AS [RegionRank],
				RANK() OVER(PARTITION BY [Name], [Time], [TimeOfDay], [SkyType], [CategoryName], [CountryName], [CarType] ORDER BY [Score] ASC) AS [CountryRank],
				[UserId], [CountryName], [Region], [Name], [Time], [TimeofDay], [SkyType], [CategoryName], [CarType], [Score], [CreateTime]
FROM
(
	SELECT			[UserId], [CountryName], [Region], [Name], [Time], [TimeofDay], [SkyType], [CategoryName], [CarType], MIN([Score]) AS [Score], MAX([CreateTime]) AS [CreateTime]
	FROM			[dbo].[vw_GTS_RaceRankDetails]
	GROUP BY		[UserId], [CountryName], [Region], [Name], [Time], [TimeofDay], [SkyType], [CategoryName], [CarType]
) T1

GO
