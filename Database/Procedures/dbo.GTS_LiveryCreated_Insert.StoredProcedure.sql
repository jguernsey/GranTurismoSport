
CREATE PROCEDURE [dbo].[GTS_LiveryCreated_Insert]
AS
	TRUNCATE TABLE [dbo].[GTS_LiveryCreated]

	INSERT INTO [dbo].[GTS_LiveryCreated] ([ProfileId], [CountryId], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	p.[ProfileId],
	p.[CountryId],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [LiveryCreated] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [LiveryCreated] DESC, [EntryDate] ASC) AS [RegionRank],
	[LiveryCreated],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [LiveryCreated] > 0
	ORDER BY [LiveryCreated] DESC, [EntryDate] ASC

GO
