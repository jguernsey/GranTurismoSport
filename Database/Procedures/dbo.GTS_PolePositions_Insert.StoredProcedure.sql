
CREATE PROCEDURE [dbo].[GTS_PolePositions_Insert]
AS
	INSERT INTO [dbo].[GTS_PolePositions] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName], 
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [PolePositions] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [PolePositions] DESC, [EntryDate] ASC) AS [RegionRank],
	[PolePositions],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [PolePositions] > 0
	ORDER BY [PolePositions] DESC, [EntryDate] ASC

GO
