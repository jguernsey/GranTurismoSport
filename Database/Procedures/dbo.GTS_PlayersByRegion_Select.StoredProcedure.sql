CREATE PROCEDURE	[dbo].[GTS_PlayersByRegion_Select]
AS
	SELECT			[Id],
					[RegionName],
					[PlayerCount],
					[Percentage]

	FROM			[dbo].[GTS_PlayersByRegion]

	ORDER BY		[NPlayerCount]	DESC


GO
