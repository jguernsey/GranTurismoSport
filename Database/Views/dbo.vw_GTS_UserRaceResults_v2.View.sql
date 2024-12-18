CREATE VIEW	[dbo].[vw_GTS_UserRaceResults_v2]
AS
	SELECT		[StartTime]					AS		[RaceTime],
				t.[Title]					AS		[Type],
				trk.[Name]					AS		[Track],
				tt.[Time]					AS		[TrackTime], 
				tod.[TimeOfDay]				AS		[TimeOfDay],
				st.[SkyType]				AS		[Weather],
				cc.[CategoryName]			AS		[Category],
				[EntryMax]					AS		[MaxEntries],
				[QualifyRank]				AS		[Qualifying],
				[FinishedLaps]				=		CASE
														WHEN		[Rank]		=		0
															THEN		0
														ELSE		[Lap]
													END,
				[LeadLaps]					=		CASE
														WHEN		[Rank]		=		0
															THEN		0
														ELSE		[LeadLap]
													END,
				[MannerPoint]				AS		[SR],  
				[Rank]						AS		[FinishPosition],
				[Change]					=		CASE
														WHEN		[Rank]		=		0
															THEN		0
														ELSE
																		[QualifyRank] - [Rank]
													END,
				p.[Id]						AS		[UserId],
				rtd.[DriverRating]

	FROM		[dbo].[GTS_EventResults]			er

	JOIN		[dbo].[GTS_EventHeader]				eh
		ON		er.[EventCalendarId]		=		eh.[EventCalendarId]

	JOIN		[dbo].[GTS_EventDetail]				ed
		ON		eh.[EventId]				=		ed.[EventId]

	JOIN		[dbo].[GTS_Titles]					t
		ON		ed.[TitleId]				=		t.[Id]

	JOIN		[dbo].[GTS_CarCategories]			cc
		ON		ed.[CarCategoryId]			=		cc.[CategoryId]

	JOIN		[dbo].[GTS_Tracks]					trk
		ON		ed.[CourseId]				=		trk.[Id]

	JOIN		[dbo].[GTS_TrackWeather]			tw
		ON		ed.[WeatherId]				=		tw.[Id]

	JOIN		[dbo].[GTS_TrackTimes]				tt
		ON		tw.[TimeId]					=		tt.[Id]

	JOIN		[dbo].[GTS_WeatherTypes]			wt
		ON		tw.[TypeId]					=		wt.[Id]

	JOIN		[dbo].[GTS_SkyTypes]				st
		ON		wt.[SkyTypeId]				=		st.[Id]

	JOIN		[dbo].[GTS_TimeOfDay]				tod
		ON		wt.[TimeOfDayId]			=		tod.[Id]

	JOIN		[dbo].[GTS_Profiles]				p
		ON		er.[UserNumber]				=		p.[ProfileNumber]

	LEFT JOIN	[dbo].[GTS_RealTimeDriverRating]	rtd
		ON		([DateUpdated] > DATEADD(MINUTE,-1,eh.[StartTime])
		AND		[DateUpdated] < DATEADD(MINUTE,1,eh.[EndTime]))
		AND		rtd.[Status]				=		'C'
		AND		p.[ProfileId]				=		rtd.[ProfileId]

GO
