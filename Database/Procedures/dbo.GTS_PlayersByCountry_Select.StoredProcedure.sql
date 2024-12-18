CREATE PROCEDURE [dbo].[GTS_PlayersByCountry_Select]
AS
	SELECT		[Rank],
				[ImagePath],
				FORMAT([Total],'N0') AS [Total],
				FORMAT([TotalPercent], 'N4') + '%' AS [TotalPercent]

	FROM		[dbo].[GTS_PlayersByCountry]		pc

	JOIN		[dbo].[GTS_Countries]				c
		ON		pc.[Country]				=		c.[CountryName]

	ORDER BY	[Rank]


GO
