
CREATE PROCEDURE [dbo].[GTS_TimePlayed_Insert]
AS
	INSERT INTO [dbo].[GTS_TimePlayed] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [PlayTime] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [PlayTime] DESC, [EntryDate] ASC) AS [RegionRank],
	[PlayTime],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [PlayTime] > 0
	ORDER BY [PlayTime] DESC, [EntryDate] ASC

GO
