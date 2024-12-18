
CREATE PROCEDURE [dbo].[GTS_PlayerLevels_Insert]
AS
	INSERT INTO		[dbo].[GTS_PlayerLevels] ([PlayerCount], [PercentageOfTotal])
	SELECT			COUNT([ProfileId])																																	AS	[PlayerCount],
					CONVERT(DECIMAL(14,4),COUNT([ProfileId])) / CONVERT(DECIMAL(14,4),(SELECT COUNT([ProfileId]) FROM [dbo].[GTS_ProfileStats] WHERE [Level] > 0))		AS	[PercentageOfTotal]
	FROM			[dbo].[GTS_ProfileStats]

	WHERE			[Level]			>		0

	GROUP BY		[Level]
	
	ORDER BY		[Level]


GO
