
CREATE PROCEDURE [dbo].[GTS_Wins_Insert]
AS
	INSERT INTO [dbo].[GTS_Wins] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName], 
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [Wins] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [Wins] DESC, [EntryDate] ASC) AS [RegionRank],
	[Wins],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [Wins] > 0
	ORDER BY [Wins] DESC, [EntryDate] ASC

GO
