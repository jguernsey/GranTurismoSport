CREATE PROCEDURE [dbo].[GTS_UpdatePlayersByCountry]
AS
	TRUNCATE TABLE [dbo].[GTS_PlayersByCountry]

	INSERT INTO	[dbo].[GTS_PlayersByCountry] ([Country], [Total], [TotalPercent])
	SELECT		[CountryName]	AS [Country],
				[Total],
				CONVERT(NUMERIC(8,4),(CONVERT(FLOAT(53),[Total])/CONVERT(FLOAT(53),(SELECT COUNT([ProfileId]) FROM [dbo].[GTS_Profiles])) * 100))	AS [TotalPercent]
	FROM
	(
		SELECT		COUNT([ProfileId]) AS [Total], 
					[CountryId]
		FROM		[dbo].[GTS_Profiles]
		GROUP BY	[CountryId]
	)	co
	JOIN	[dbo].[GTS_Countries]			c
		ON	co.[CountryId]		=		c.[CountryId]
	WHERE			c.[CountryName]	!= 'Unknown'
	ORDER BY		[Total]		DESC


GO
