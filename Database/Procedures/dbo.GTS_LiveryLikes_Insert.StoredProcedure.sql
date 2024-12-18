
CREATE PROCEDURE [dbo].[GTS_LiveryLikes_Insert]
AS
	TRUNCATE TABLE [dbo].[GTS_LiveryLikes]

	INSERT INTO [dbo].[GTS_LiveryLikes] ([ProfileId], [CountryId], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	p.[ProfileId],
	p.[CountryId],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [LiveryLikes] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [LiveryLikes] DESC, [EntryDate] ASC) AS [RegionRank],
	[LiveryLikes],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [LiveryLikes] > 0
	ORDER BY [LiveryLikes] DESC, [EntryDate] ASC

GO
