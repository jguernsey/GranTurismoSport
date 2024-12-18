
CREATE PROCEDURE [dbo].[GTS_FastestLaps_Insert]
AS
	INSERT INTO [dbo].[GTS_FastestLaps] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName], 
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [FastestLaps] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [FastestLaps] DESC, [EntryDate] ASC) AS [RegionRank],
	[FastestLaps],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [FastestLaps] > 0
	ORDER BY [FastestLaps] DESC, [EntryDate] ASC

GO
