
CREATE PROCEDURE [dbo].[GTS_RaceCountBrackets_Select]
AS
	DECLARE @TotalRacers FLOAT(53)
	SET @TotalRacers = (SELECT	CONVERT(FLOAT(53),COUNT([Id])) FROM [dbo].[GTS_RaceCount])
	DECLARE @NoRaces BIGINT
	SET @NoRaces = (SELECT (SELECT	COUNT([Id]) FROM [dbo].[GTS_Profiles]) - (SELECT COUNT([Id]) FROM [dbo].[GTS_RaceCount]))
	DECLARE @PlayerCount FLOAT(53)
	SET @PlayerCount = (SELECT	CONVERT(FLOAT(53),COUNT([Id])) FROM [dbo].[GTS_Profiles])

	SELECT		[Order],
				[Races],
				FORMAT([Players],'N0')																																										AS		[Players],
				FORMAT(CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),[Players])/CONVERT(FLOAT(53),(SELECT	COUNT([Id]) FROM [dbo].[GTS_Profiles]))) * 100),'N3') + '%'												AS		[PercentageOfTotal],
				FORMAT([Racers],'N3') + '%'																																									AS		[Percentage],
				FORMAT(CONVERT(DECIMAL(8,4),((CONVERT(FLOAT(53),(COALESCE(SUM([Players]) OVER (ORDER BY [Order] ROWS BETWEEN UNBOUNDED PRECEDING AND 1 PRECEDING),0)))/@PlayerCount) * 100)),'N3') + '%'	AS		[Percentile]
	FROM
	(
	SELECT		0																				AS		[Order],
				'0'																				AS		[Races],
				@NoRaces																		AS		[Players],
				0																				AS		[Racers]
	UNION
	SELECT		[Value]																			AS		[Order],
				CAST([Value] AS NVARCHAR(8))													AS		[Races],
				COUNT([Id])																		AS		[Players],
				CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),COUNT([Id]))/@TotalRacers) * 100)		AS		[Racers]
	FROM		[dbo].[GTS_RaceCount]
	WHERE		[Value]																			<		10
	GROUP BY	[Value]
	UNION
	SELECT		[StartRange]																	AS		[Order],
				CAST([StartRange] AS NVARCHAR(8)) + ' - ' + CAST([EndRange] AS NVARCHAR(8))		AS		[Races],
				[Players],
				[Racers]
	FROM 
	(
	SELECT		5 * ([Value] / 5)																AS		[StartRange],
				5 * ([Value] / 5) + 4															AS		[EndRange],
				COUNT([Id])																		AS		[Players],
				CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),COUNT([Id]))/@TotalRacers) * 100)		AS		[Racers]
	FROM		[dbo].[GTS_RaceCount]
	WHERE		[Value]																			>=		10
		AND		[Value]																			<=		24
	GROUP BY	[Value] / 5
	UNION
	SELECT		25 * ([Value] / 25)																AS		[StartRange],
				25 * ([Value] / 25) + 24														AS		[EndRange],
				COUNT([ID])																		AS		[Players],
				CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),COUNT([Id]))/@TotalRacers) * 100)		AS		[Racers]
	FROM		[dbo].[GTS_RaceCount]
	WHERE		[Value]																			>=		25
	GROUP BY	[Value] / 25
	) t
	) t2
	ORDER BY	[Order]

GO
