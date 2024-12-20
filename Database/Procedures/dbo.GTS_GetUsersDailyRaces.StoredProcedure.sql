CREATE PROCEDURE	[dbo].[GTS_GetUsersDailyRaces]
	@UserName			NVARCHAR(32)
AS
	DECLARE @RegionId BIGINT
	SET @RegionId = (SELECT [RegionId] FROM [dbo].[vw_GTS_UserCountryRegionInfo] WHERE [Id] = @UserName)

	SELECT		
				tt.[Title]					AS		[Title],
				t.[Name]					AS		[Track],
				cc.[CategoryName]			AS		[Category],
				ed.[RaceLimitLaps]			AS		[Laps],
				[Fuel]						=		CASE	ed.[ConsumeFuel]
															WHEN	0
																THEN	'None'
															ELSE
																CONCAT(ed.[ConsumeFuel],'x')
													END,
				[TireWear]					=		CASE	ed.[ConsumeTire]
															WHEN	0
																THEN	'None'
															ELSE
																CONCAT(ed.[ConsumeTire],'x')
													END,
				COALESCE(MAX(brc.[RegionCount]),0)		AS		[RegionCount],
				[Superstars]				=		CASE
														WHEN	[EntryMax]	=	24 AND [NeedDriverClass] = 5
															THEN 'Y'
														ELSE
															'N'
													END

	FROM		[dbo].[GTS_EventDetail]				ed

	JOIN		[dbo].[GTS_EventHeader]				eh
		ON		ed.[EventId]				=		eh.[EventId]

	JOIN		[dbo].[GTS_Titles]					tt
		ON		ed.[TitleId]				=		tt.[Id]

	JOIN		[dbo].[GTS_Tracks]					t
		ON		ed.[CourseId]				=		t.[Id]

	JOIN		[dbo].[GTS_CarCategories]			cc
		ON		ed.[CarCategoryId]			=		cc.[CategoryId]

	LEFT JOIN		[dbo].[GTS_RaceRankings]			ra
		ON		ed.BoardId					=		ra.[BoardId]

	LEFT JOIN		[dbo].[GTS_Countries]				co
		ON		ra.[CountryId]				=		co.[CountryId]

	LEFT JOIN		[dbo].[vw_GTS_BoardRegionCount]		brc
		ON		ed.[BoardId]				=		brc.[BoardId]
		AND		brc.[RegionId]				=		@RegionId

	WHERE		GETDATE()					BETWEEN [ActiveStart]	
												AND	[ActiveEnd]
		AND		ed.[RegionId]				=		@RegionId

	GROUP BY	eh.[EventId], t.[Name], tt.[Title], cc.[CategoryName], [EntryMax], [NeedDriverClass], ed.[RaceLimitLaps], ed.[ConsumeFuel], ed.[ConsumeTire]
	ORDER BY	[Title]

GO
