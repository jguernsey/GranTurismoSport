CREATE VIEW [dbo].[vw_GTS_RaceRankDetails]
AS
	SELECT		rr.[UserId], co.[CountryName], re.[Region], trk.[Name],  tt.[Time], tod.[TimeOfDay], st.[SkyType], cc.[CategoryName], rr.[Score],
				[CarType] = CASE [CarsCount]
								WHEN 0
									THEN 'Garage Car'
								WHEN 1
									THEN 'One Make'
								ELSE
									''
							END,
				rr.[CreateTime]
	FROM		[dbo].[GTS_RaceRankings]			rr

	JOIN		[dbo].[GTS_EventDetail]				ed
		ON		rr.[BoardId]				=		ed.[BoardId]

	JOIN		[dbo].[GTS_CarCategories]			cc
		ON		ed.[CarCategoryId]			=		cc.[CategoryId]

	JOIN		[dbo].[GTS_Tracks]					trk
		ON		ed.[CourseId]				=		trk.[Id]

	JOIN		[dbo].[GTS_TrackWeather]			tw
		ON		ed.[WeatherId]				=		tw.[Id]
		AND		ed.[CourseId]				=		tw.[TrackId]

	JOIN		[dbo].[GTS_TrackTimes]				tt
		ON		tt.[Id]						=		tw.[TimeId]

	JOIN		[dbo].[GTS_WeatherTypes]			wt
		ON		tw.[TypeId]					=		wt.Id

	JOIN		[dbo].[GTS_TimeOfDay]				tod
		ON		wt.[TimeOfDayId]			=		tod.[Id]

	JOIN		[dbo].[GTS_SkyTypes]				st
		ON		wt.[SkyTypeId]				=		st.[Id]

	JOIN		[dbo].[GTS_Countries]				co
		ON		rr.[CountryId]				=		co.[CountryId]

	JOIN		[dbo].[GTS_Regions]					re
		ON		co.RegionId					=		re.[Id]

GO
