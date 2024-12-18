
CREATE PROCEDURE [dbo].[GTS_RaceCount_Insert]
AS
	INSERT INTO [dbo].[GTS_RaceCount] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [RaceCount] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [RaceCount] DESC, [EntryDate] ASC) AS [RegionRank],
	[RaceCount],
	[EntryDate]
	FROM		[dbo].[GTS_ProfileStats]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [RaceCount] > 0
	ORDER BY [RaceCount] DESC, [EntryDate] ASC

GO
