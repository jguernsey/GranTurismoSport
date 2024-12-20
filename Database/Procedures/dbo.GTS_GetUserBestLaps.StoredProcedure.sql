CREATE PROCEDURE [dbo].[GTS_GetUserBestLaps]
	@UserId				NVARCHAR(32)
AS
	SELECT	DISTINCT t.[Name], 
			cc.[CategoryName], 
			[Score], 
			CONCAT(FORMAT([WorldRank],'N0'),' / ',FORMAT([WorldCount],'N0'),' - ',(SELECT [dbo].[fn_GTS_GetPercentageValue]([WorldRank], [WorldCount])))		AS	[World],
			CONCAT(FORMAT([RegionRank],'N0'),' / ',FORMAT([RegionCount],'N0'),' - ',(SELECT [dbo].[fn_GTS_GetPercentageValue]([RegionRank], [RegionCount])))		AS	[Region], 
			CONCAT(FORMAT([CountryRank],'N0'),' / ',FORMAT([CountryCount],'N0'),' - ',(SELECT [dbo].[fn_GTS_GetPercentageValue]([CountryRank], [CountryCount])))		AS	[Country],
			[CreateTime]

	FROM	[dbo].[GTS_RankedRaceTimes]		rt

	JOIN	[dbo].[GTS_Tracks]				t
		ON	rt.[TrackId]			=		t.[Id]
		
	JOIN	[dbo].[GTS_CarCategories]		cc
		ON	rt.[CategoryId]			=		cc.[CategoryId]
		
	JOIN	[dbo].[GTS_Profiles]			p
		ON	rt.[ProfileId]			=		p.[ProfileId]
	
	WHERE	p.[Id]					=		@UserId 
	ORDER BY [Name], [CategoryName]




GO
