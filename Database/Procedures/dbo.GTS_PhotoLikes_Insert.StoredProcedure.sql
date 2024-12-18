
CREATE PROCEDURE [dbo].[GTS_PhotoLikes_Insert]
AS
	TRUNCATE TABLE [dbo].[GTS_PhotoLikes]

	INSERT INTO [dbo].[GTS_PhotoLikes] ([ProfileId], [CountryId], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	p.[ProfileId],
	p.[CountryId],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [PhotoLikes] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [PhotoLikes] DESC, [EntryDate] ASC) AS [RegionRank],
	[PhotoLikes],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [PhotoLikes] > 0
	ORDER BY [PhotoLikes] DESC, [EntryDate] ASC

GO
