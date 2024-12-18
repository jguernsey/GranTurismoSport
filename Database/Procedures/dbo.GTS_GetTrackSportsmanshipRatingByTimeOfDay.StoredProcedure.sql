CREATE PROCEDURE [dbo].[GTS_GetTrackSportsmanshipRatingByTimeOfDay]
AS
	SELECT		t.[Name]						AS			[Track],
				c.[CategoryName]				AS			[Category],
				DATEPART(HOUR,eh.[StartTime])/4	AS			[Time],
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

	GROUP BY	t.[Name], c.[CategoryName], DATEPART(HOUR,eh.[StartTime])/4
	ORDER BY	[Track], [Category], [Time]

GO
