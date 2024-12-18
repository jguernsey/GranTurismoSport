CREATE VIEW [dbo].[vw_GTS_GroupedRaceCounts_T]
AS
	SELECT	[Order],
			[Races],
			[Players],
			CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),[Players])/CONVERT(FLOAT(53),(SELECT	COUNT([Id]) FROM [dbo].[GTS_Profiles]))) * 100) AS [PercentageOfTotal],
			[Racers] AS [Percentage],
			[PercentileRank]
	FROM (
	SELECT	0 AS [Order],
			'0' AS [Races],
			(SELECT	COUNT([Id]) FROM [dbo].[GTS_Profiles]) - (SELECT COUNT([Id]) FROM [dbo].[GTS_RaceCount]) AS [Players],
			0 AS [Racers],
			0 AS [PercentileRank]
	UNION
	SELECT	[Value]						AS [Order],
			CAST([Value] AS NVARCHAR(8))	AS [Races],
			COUNT([Id])					AS [Players],
			CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),COUNT([Id]))/CONVERT(FLOAT(53),(SELECT	COUNT([Id]) FROM [dbo].[GTS_RaceCount]))) * 100) AS [Racers],
			(rank() over (order by [Value]) - 1.0) / (select count(*) from [GTS_RaceCount]) * 100 as PercentileRank
	FROM	[dbo].[GTS_RaceCount]
	WHERE [Value] < 10
	GROUP BY [Value]
	UNION
	SELECT  [StartRange] AS [Order],
			CAST([StartRange] AS NVARCHAR(8)) + ' - ' + CAST([EndRange] AS NVARCHAR(8)) AS [Races],
			[Players],
			[Racers],
			[PercentileRank]
	FROM (
	SELECT	5 * ([Value] / 5)			AS [StartRange],
			5 * ([Value] / 5) + 4		AS [EndRange],
			COUNT([Id])					AS [Players],
			CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),COUNT([Id]))/CONVERT(FLOAT(53),(SELECT	COUNT([Id]) FROM [dbo].[GTS_RaceCount]))) * 100) AS [Racers],
			(rank() over (order by [Value]) - 1.0) / (select count(*) from [GTS_RaceCount]) * 100 as PercentileRank
	FROM	[dbo].[GTS_RaceCount]
	WHERE [Value] >= 10 AND [Value] <= 24
	GROUP BY	[Value] / 5, [Value]
	UNION
	SELECT	25 * ([Value] / 25)			AS [StartRange],
			25 * ([Value] / 25) + 24	AS [EndRange],
			COUNT([ID])					AS [Players],
			CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),COUNT([Id]))/CONVERT(FLOAT(53),(SELECT	COUNT([Id]) FROM [dbo].[GTS_RaceCount]))) * 100) AS [Racers],
			(rank() over (order by [Value]) - 1.0) / (select count(*) from [GTS_RaceCount]) * 100 as PercentileRank
	FROM	[dbo].[GTS_RaceCount]
	WHERE [Value] >= 25
	GROUP BY	[Value] / 25, [Value]
	) t
	) t2

GO
