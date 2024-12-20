CREATE VIEW [dbo].[vw_GTS_GetPlayersByRegion]
AS
	SELECT		c.RegionId, 
				COUNT(p.[ProfileId])	AS		[PlayerCount]

	FROM		[dbo].[GTS_Profiles]			p

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=		c.[CountryId]

	WHERE		c.[RegionId]			!=		4

	GROUP BY	c.[RegionId]

GO
