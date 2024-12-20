
CREATE PROCEDURE [dbo].[GTS_PhotosTaken_Insert]
AS
	TRUNCATE TABLE [dbo].[GTS_PhotosTaken]

	INSERT INTO [dbo].[GTS_PhotosTaken] ([ProfileId], [CountryId], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	p.[ProfileId],
	p.[CountryId],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [PhotosTaken] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [PhotosTaken] DESC, [EntryDate] ASC) AS [RegionRank],
	[PhotosTaken],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [PhotosTaken] > 0
	ORDER BY [PhotosTaken] DESC, [EntryDate] ASC

GO
