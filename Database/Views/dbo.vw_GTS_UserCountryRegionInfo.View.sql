CREATE VIEW [dbo].[vw_GTS_UserCountryRegionInfo]
AS
	SELECT		p.[Id], p.[ProfileId], p.[ProfileNumber], c.[CountryName], c.[CountryCode], c.[RegionId]
	FROM		[dbo].[GTS_Profiles]			p

	JOIN		[dbo].[GTS_Countries]			c
		ON		p.[CountryId]			=		c.[CountryId]

GO
