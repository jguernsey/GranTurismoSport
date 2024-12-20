
CREATE PROCEDURE [dbo].[GTS_Countries_SelectUserFiaRegionId]
		@Id			NVARCHAR(32)
AS
	SELECT		reg.[RegionId]
	FROM		[dbo].[GTS_Countries]				c

	JOIN		[dbo].[GTS_Profiles]				p
		ON		c.[CountryId]				=		p.[CountryId]

	JOIN		[dbo].[GTS_FiaRegions]				reg
		ON		c.[CountryId]				=		reg.[CountryId]

	WHERE		p.[Id]						=		@Id

GO
