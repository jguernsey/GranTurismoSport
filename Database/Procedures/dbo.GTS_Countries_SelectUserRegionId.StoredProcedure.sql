
CREATE PROCEDURE [dbo].[GTS_Countries_SelectUserRegionId]
	@Id			NVARCHAR(32)
AS
	SELECT		[RegionId]
	FROM		[dbo].[GTS_Countries]				c

	JOIN		[dbo].[GTS_Profiles]				p
		ON		c.[CountryId]				=		p.[CountryId]

	WHERE		[Id]						=		@Id


GO
