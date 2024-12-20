CREATE PROCEDURE [dbo].[GTS_CountryDetail_SelectList]
AS
	SELECT		c.[CountryId], [CountryName], COUNT([ProfileId]) AS [PlayerCount]
	
	FROM		[dbo].[GTS_Countries]			c
	
	JOIN		[dbo].[GTS_Profiles]			p
		ON		c.[CountryId]			=		p.[CountryId]
	
	WHERE		c.[CountryId]			!=		247
		AND		p.[ProfileStatus]		=		1

	GROUP BY	c.[CountryId], [CountryName]

	ORDER BY	[PlayerCount]
GO
