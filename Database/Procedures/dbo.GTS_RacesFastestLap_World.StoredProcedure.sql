CREATE PROCEDURE [dbo].[GTS_RacesFastestLap_World]
AS
	SELECT			DISTINCT 
					t.[Name]			AS	[Track],
					cc.[CategoryName]	AS	[CarCategory],
					p.[Id]				AS	[Driver],
					c.[ImagePath]		AS	[ImagePath],
					[Score]				AS	[LapTime],
					[CreateTime]		AS	[LapTimeStamp]

	FROM			[dbo].[GTS_RankedRaceTimes]			rt

	JOIN			[dbo].[GTS_Tracks]					t
		ON			rt.[TrackId]				=		t.[Id]

	JOIN			[dbo].[GTS_CarCategories]			cc
		ON			rt.[CategoryId]				=		cc.[CategoryId]

	JOIN			[dbo].[GTS_Profiles]				p
		ON			rt.[ProfileId]				=		p.[ProfileId]

	JOIN			[dbo].[GTS_Countries]				c
		ON			p.[CountryId]				=		c.[CountryId]

	WHERE			[WorldRank]					=		1

	ORDER BY		[Track], [CarCategory]
GO
