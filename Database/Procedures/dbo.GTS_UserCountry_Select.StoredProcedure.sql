CREATE PROCEDURE [dbo].[GTS_UserCountry_Select]
	@Id			NVARCHAR(32)
AS
	SELECT	[CountryName]
	
	FROM	[dbo].[GTS_Profiles]			p
	
	JOIN	[dbo].[GTS_Countries]			c
		ON	p.[CountryId]			=		c.[CountryId]

	WHERE	p.[Id]					=		@Id


GO
