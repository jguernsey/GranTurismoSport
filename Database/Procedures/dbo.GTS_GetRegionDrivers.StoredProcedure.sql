
CREATE PROCEDURE [dbo].[GTS_GetRegionDrivers]
AS
SELECT		[ProfileNumber], p.[Id]

FROM		[dbo].[GTS_Profiles]				p

JOIN		[dbo].[GTS_Countries]				c
	ON		p.[CountryId]				=		c.[CountryId]

JOIN		[dbo].[GTS_RaceCount]				rc
	ON		p.[Id]						=		rc.[Id]

WHERE		c.[RegionId]	= 3

ORDER BY	p.[Id]

GO
