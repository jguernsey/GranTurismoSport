CREATE PROCEDURE [dbo].[GTS_GetPlayersByCountry]
AS
	SELECT		[Rank],
				[Country],
				FORMAT([Total],'N0') AS [Total],
				FORMAT([TotalPercent], 'N4') + '%' AS [TotalPercent]

	FROM		[dbo].[GTS_PlayersByCountry]
	ORDER BY	[Rank]


GO
