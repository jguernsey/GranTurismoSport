CREATE PROCEDURE [dbo].[GTS_PlayerLevels_Select]
AS
	SELECT	[PlayerLevel],
			[PlayerCount],
			[PercentageOfTotal]
	FROM	[dbo].[GTS_PlayerLevels]
	ORDER BY [PlayerLevel]


GO
