CREATE PROCEDURE [dbo].[GTS_WinsPerEntry_Insert]
AS
	INSERT INTO [dbo].[GTS_WinsPerEntry] ([Id], [Country], [CountryRank], [RegionRank], [Value], [Races], [Wins], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY CONVERT(DECIMAL(8,4),(CONVERT(DECIMAL(28,3),[Wins])) / (CONVERT(DECIMAL(28,3),[RaceCount]))) DESC, [RaceCount] DESC, [Wins] DESC, ah.[EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY CONVERT(DECIMAL(8,4),(CONVERT(DECIMAL(28,3),[Wins])) / (CONVERT(DECIMAL(28,3),[RaceCount]))) DESC, [RaceCount] DESC, [Wins] DESC, ah.[EntryDate] ASC) AS [RegionRank],
	CONVERT(DECIMAL(8,4),(CONVERT(DECIMAL(28,3),[Wins])) / (CONVERT(DECIMAL(28,3),[RaceCount]))) AS [Value],
	[RaceCount],
	[Wins],
	ah.[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ah

	JOIN		[dbo].[GTS_ProfileStats]		ps
		ON		ah.[ProfileId]			=	ps.ProfileId

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [RaceCount] >= 50 AND [Wins] > 1
	ORDER BY [Value] DESC, [RaceCount] DESC, [Wins] DESC, [EntryDate] ASC

GO
