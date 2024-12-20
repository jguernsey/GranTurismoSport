
CREATE PROCEDURE [dbo].[GTS_GetCombinedBrackets]
AS
	SELECT [DR]		=		CASE
								WHEN [DR] = 1
									THEN 'E'
								WHEN [DR] = 2
									THEN 'D'
								WHEN [DR] = 3
									THEN 'C'
								WHEN [DR] = 4
									THEN 'B'
								WHEN [DR] = 5
									THEN 'A'
								WHEN [DR] = 6
									THEN 'S'
							END,
			[SR]	=		CASE
								WHEN [SR] = 1
									THEN 'E'
								WHEN [SR] = 2
									THEN 'D'
								WHEN [SR] = 3
									THEN 'C'
								WHEN [SR] = 4
									THEN 'B'
								WHEN [SR] = 5
									THEN 'A'
								WHEN [SR] = 6
									THEN 'S'
							END,
			FORMAT([PlayerCount], 'N0') AS [Players],
			CAST([Percentage] AS NVARCHAR(32)) + '%' AS [Percentage]

		FROM [dbo].[GTS_CombinedRatings]
		ORDER BY [BracketId]
			


GO
