
CREATE PROCEDURE [dbo].[GTS_TotalDistance_Insert]
AS
	INSERT INTO [dbo].[GTS_TotalDistance] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [DistanceDriven] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [DistanceDriven] DESC, [EntryDate] ASC) AS [RegionRank],
	[DistanceDriven],
	[EntryDate]
	FROM		[dbo].[GTS_AchievementHistory]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [DistanceDriven] > 0
	ORDER BY [DistanceDriven] DESC, [EntryDate] ASC

GO
