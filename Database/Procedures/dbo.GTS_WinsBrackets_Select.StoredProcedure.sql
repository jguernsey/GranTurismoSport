CREATE PROCEDURE [dbo].[GTS_WinsBrackets_Select]
AS
	SELECT	[Order],
			[Wins],
			FORMAT([Players],'N0') AS [Players],
			CAST(CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),[Players])/CONVERT(FLOAT(53),(SELECT	COUNT(DISTINCT [Id]) FROM [dbo].[GTS_RaceCount]))) * 100) AS NVARCHAR(32)) + '%' AS [Percentage]
	FROM (
	SELECT	0 AS [Order],
			'0' AS [Wins],
			(SELECT	COUNT(DISTINCT [Id]) FROM [dbo].[GTS_RaceCount]) - (SELECT COUNT(DISTINCT [Id]) FROM [dbo].[GTS_Wins]) AS [Players]
	UNION
	SELECT	[Value]						AS [Order],
			CAST([Value] AS NVARCHAR(8))	AS [Wins],
			COUNT([Id])					AS [Players]
	FROM	[dbo].[GTS_Wins]
	WHERE [Value] < 10
	GROUP BY [Value]
	UNION
	SELECT  [StartRange] AS [Order],
			CAST([StartRange] AS NVARCHAR(8)) + ' - ' + CAST([EndRange] AS NVARCHAR(8)) AS [Wins],
			[Players]
	FROM (
	SELECT	5 * ([Value] / 5)			AS [StartRange],
			5 * ([Value] / 5) + 4	AS [EndRange],
			COUNT(*)					AS [Players]
	FROM	[dbo].[GTS_Wins]
	WHERE [Value] >= 10 AND [Value] <= 24
	GROUP BY	[Value] / 5
	UNION
	SELECT	25 * ([Value] / 25)			AS [StartRange],
			25 * ([Value] / 25) + 24	AS [EndRange],
			COUNT(*)					AS [Players]
	FROM	[dbo].[GTS_Wins]
	WHERE [Value] >= 25
	GROUP BY	[Value] / 25
	) t
	) t2
	ORDER BY	[Order]


GO
