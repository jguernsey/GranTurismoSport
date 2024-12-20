
CREATE PROCEDURE [dbo].[GTS_Experience_Insert]
AS
	INSERT INTO [dbo].[GTS_Experience] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [Experience] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [Experience] DESC, [EntryDate] ASC) AS [RegionRank],
	[Experience],
	[EntryDate]
	FROM		[dbo].[GTS_ProfileStats]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [Experience] > 0
	ORDER BY [Experience] DESC, [EntryDate] ASC

GO
