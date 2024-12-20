
CREATE PROCEDURE [dbo].[GTS_DriverRating_Insert]
AS
	INSERT INTO [dbo].[GTS_DriverRating] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [DriverPoint] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [DriverPoint] DESC, [EntryDate] ASC) AS [RegionRank],
	[DriverPoint],
	[EntryDate]
	FROM		[dbo].[GTS_ProfileStats]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [DriverPoint] > 0
	ORDER BY [DriverPoint] DESC, [EntryDate] ASC

GO
