
CREATE PROCEDURE [dbo].[GTS_CreditEarned_Insert]
AS
	INSERT INTO [dbo].[GTS_CreditEarned] ([Id], [Country], [CountryRank], [RegionRank], [Value], [EntryDate])
	SELECT 
	[Id],
	[CountryName],
	RANK() OVER(PARTITION BY [CountryName] ORDER BY [CreditEarned] DESC, [EntryDate] ASC) AS [CountryRank],
	RANK() OVER(PARTITION BY [RegionId] ORDER BY [CreditEarned] DESC, [EntryDate] ASC) AS [RegionRank],
	[CreditEarned],
	[EntryDate]
	FROM		[dbo].[GTS_ProfileStats]	ps

	JOIN		[dbo].[GTS_Profiles]			p
		ON		ps.[ProfileId]			=	p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=	c.[CountryId]
	WHERE [CreditEarned] > 0
	ORDER BY [CreditEarned] DESC, [EntryDate] DESC

GO
