CREATE PROCEDURE [dbo].[GTS_SportsmanshipBrackets_Select]
AS
	SELECT	[ClassId],
			[SR] = CASE [ClassId]
								WHEN 1
									THEN	'E'
								WHEN 2
									THEN	'D'
								WHEN 3
									THEN	'C'
								WHEN 4
									THEN	'B'
								WHEN 5
									THEN	'A'
								WHEN 6
									THEN	'S'
								ELSE
									''
							END,
			FORMAT([PlayerCount], 'N0') AS [Players],
			CAST([Percentage] AS NVARCHAR(32)) + '%' AS [Percentage]
	FROM [dbo].[GTS_SportsmanshipRating]
	WHERE	[ClassId] > 0 AND [ClassId] <= 6
	ORDER BY [ClassId]


GO
