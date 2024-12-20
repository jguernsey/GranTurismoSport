
CREATE PROCEDURE [dbo].[GTS_CarsPurchased_Insert]
AS
	INSERT INTO [dbo].[GTS_CarsPurchased] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [PurchasedCars] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [PurchasedCars] DESC, [EntryDate] ASC) AS [RegionRank],
	[PurchasedCars],
	[EntryDate]
	FROM		[dbo].[GTS_ProfileStats]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [PurchasedCars] > 0
	ORDER BY [PurchasedCars] DESC, [EntryDate] ASC

GO
