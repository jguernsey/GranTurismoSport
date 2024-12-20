CREATE PROCEDURE [dbo].[GTS_GetTrackSportsmanshipRatingSummary]
AS
	SELECT		t.[Name]						AS			[Track], 
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

	GROUP BY	t.[Name]
	ORDER BY	t.[Name]

GO
