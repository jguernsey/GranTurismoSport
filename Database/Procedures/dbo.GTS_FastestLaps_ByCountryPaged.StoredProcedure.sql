CREATE PROCEDURE [dbo].[GTS_FastestLaps_ByCountryPaged]
	@PerPage			BIGINT,
	@Country			NVARCHAR(32) = NULL,
	@PageNumber			BIGINT,
	@RegionId			BIGINT	= -99
AS
	IF @Country IS NULL
		BEGIN
			IF @RegionId = -99
			BEGIN
			SELECT	[Rank],
					[Id]		AS		[Player],
					[ImagePath],
					[Value],
					0			AS		[Wins],
					0			AS		[Races],
					[EntryDate]
			FROM	[dbo].[GTS_FastestLaps]			w
					
					JOIN	[dbo].[GTS_Countries]				c
						ON	w.[Country]					=		c.[CountryName]
			WHERE	([Rank] > (@PerPage * (@PageNumber - 1)) AND [Rank] <= (@PerPage * @PageNumber))
			ORDER BY	[Rank]
		END
		ELSE
BEGIN
			SELECT		[RegionRank]		AS	[Rank],
						[Id]				AS	[Player],
						[ImagePath],
						[Value],
						0					AS	[Wins],
						0					AS	[Races],
						[EntryDate]
			FROM		[dbo].[GTS_FastestLaps]		cc
					JOIN		[dbo].[GTS_Countries]			c
						ON		cc.[Country]			=		c.[CountryName]
					WHERE		[RegionId]				=		@RegionId
						AND		([RegionRank] > (@PerPage * (@PageNumber - 1)) AND [RegionRank] <= (@PerPage * @PageNumber))
			ORDER BY	[Rank]
END
		END
	ELSE
		BEGIN
			SELECT		[CountryRank]		AS	[Rank],
						[Id]				AS	[Player],
						[ImagePath],
						[Value],
						0					AS	[Wins],
						0					AS	[Races],
						[EntryDate]
			FROM		[dbo].[GTS_FastestLaps]			w
					
					JOIN	[dbo].[GTS_Countries]				c
						ON	w.[Country]					=		c.[CountryName]
			WHERE		[Country]			=	@Country
				AND		([CountryRank] > (@PerPage * (@PageNumber - 1)) AND [CountryRank] <= (@PerPage * @PageNumber))
			ORDER BY	[Rank]
		END
GO
