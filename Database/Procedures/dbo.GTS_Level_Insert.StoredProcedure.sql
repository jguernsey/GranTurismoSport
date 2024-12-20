
CREATE PROCEDURE [dbo].[GTS_Level_Insert]
AS
	INSERT INTO [dbo].[GTS_Level] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [Level] DESC, [Experience] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [Level] DESC, [Experience] DESC, [EntryDate] ASC) AS [RegionRank],
	[Level],
	[EntryDate]
	FROM		[dbo].[GTS_ProfileStats]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [Level]					>		0
	ORDER BY [Level] DESC, [Experience]	DESC, [EntryDate] ASC

GO
