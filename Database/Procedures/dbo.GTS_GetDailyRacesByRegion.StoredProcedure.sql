
CREATE PROCEDURE	[dbo].[GTS_GetDailyRacesByRegion]
	@Username				NVARCHAR(32),
	@StartDate				DATETIME,
	@EndDate				DATETIME
AS
	SELECT		eh.[RegionId], t.[Title], trk.[Name], eh.[StartTime]
	FROM		[dbo].[GTS_Profiles]				p
	
	JOIN		[dbo].[GTS_Countries]				c
		ON		p.[CountryId]				=		c.[CountryId]

	JOIN		[dbo].[GTS_EventHeader]				eh
		ON		c.[RegionId]				=		eh.[RegionId]

	JOIN		[dbo].[GTS_EventDetail]				ed
		ON		eh.[EventId]				=		ed.[EventId]

	JOIN		[dbo].[GTS_Titles]					t
		ON		ed.[TitleId]				=		t.[Id]

	JOIN		[dbo].[GTS_Tracks]					trk
		ON		ed.[CourseId]				=		trk.[Id]
	
	WHERE		p.[Id]						=		@Username
		AND		eh.[StartTime]				>=		@StartDate
		AND		eh.[EndTime]				<=		@EndDate

	ORDER BY	eh.[StartTime]

GO
