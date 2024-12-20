
CREATE PROCEDURE [dbo].[GTS_RacesFinished_Insert]
AS
	INSERT INTO [dbo].[GTS_RacesFinished] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [RacesFinished] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [RacesFinished] DESC, [EntryDate] ASC) AS [RegionRank],
	[RacesFinished],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [RacesFinished] > 0
	ORDER BY [RacesFinished] DESC, [EntryDate] ASC

GO
