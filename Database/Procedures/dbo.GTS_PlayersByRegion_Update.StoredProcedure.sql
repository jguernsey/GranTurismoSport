CREATE PROCEDURE [dbo].[GTS_PlayersByRegion_Update]
AS
	TRUNCATE TABLE [dbo].[GTS_PlayersByRegion]
	
	INSERT INTO [dbo].[GTS_PlayersByRegion] ([RegionName], [NPlayerCount], [PlayerCount], [Percentage])
	SELECT		[RegionName]	=	CASE	[RegionId]
										WHEN	1
											THEN	'Asia and Oceania'
										WHEN	2
											THEN	'Europe, Middle East, Africa'
										WHEN	3
											THEN	'Americas'
									END,
				[PlayerCount]				AS	[NPlayerCount],
				FORMAT([PlayerCount],'N0')	AS	[PlayerCount],
				CONCAT(CONVERT(DECIMAL(8,4),(((CONVERT(FLOAT(53),[PlayerCount]))/(CONVERT(FLOAT(53),(SELECT SUM([PlayerCount]) FROM [dbo].[vw_GTS_GetPlayersByRegion]))))* 100)),' %') AS [Percentage]
	FROM		[dbo].[vw_GTS_GetPlayersByRegion]

	ORDER BY	[NPlayerCount]	DESC


GO
