
CREATE PROCEDURE [dbo].[GTS_GetTrackSportsmanshipRatingByWeekday]
AS
	SELECT		t.[Name]						AS			[Track],
				c.[CategoryName]				AS			[Category],
				[Weekday]						=			CASE DATEPART(WEEKDAY,eh.[StartTime])
																WHEN 1
																	THEN 'Sun.'
																WHEN 2
																	THEN 'Mon.'
																WHEN 3
																	THEN 'Tues.'
																WHEN 4
																	THEN 'Wed.'
																WHEN 5
																	THEN 'Thurs.'
																WHEN 6
																	THEN 'Fri.'
																WHEN	7
																	THEN 'Sat.'
															END,
				COUNT([UserNumber])				AS			[Entries],
				MAX([MannerPoint])				AS			[MostGained], 
				MIN([MannerPoint])				AS			[MostLost],
				CONVERT(DECIMAL(18,3),AVG(CONVERT(FLOAT(53),[MannerPoint])))				AS			[Average],
				SUM([MannerPoint])				AS			[Total]

	FROM		[dbo].[GTS_EventResults]					er

	JOIN		[dbo].[GTS_EventHeader]						eh
		ON		er.[EventCalendarId]			=			eh.[EventCalendarId]

	JOIN		[dbo].[GTS_EventDetail]						ed
		ON		eh.[EventId]					=			ed.[EventId]

	JOIN		[dbo].[GTS_Tracks]							t
		ON		ed.[CourseId]					=			t.[Id]

	JOIN		[dbo].[GTS_CarCategories]					c
		ON		ed.[CarCategoryId]				=			c.[CategoryId]

	GROUP BY	t.[Name], c.[CategoryName], DATEPART(WEEKDAY,eh.[StartTime])
	ORDER BY	[Track], [Category], [Weekday]


GO
