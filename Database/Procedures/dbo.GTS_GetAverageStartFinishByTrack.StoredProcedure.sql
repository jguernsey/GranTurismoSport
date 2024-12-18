
CREATE PROCEDURE [dbo].[GTS_GetAverageStartFinishByTrack]
	@Id			NVARCHAR(32)
AS
	SELECT	t.[Name]																AS		[Track],
			CONVERT(NUMERIC(8,1),(AVG(CONVERT(FLOAT(53),[QualifyRank]))))			AS		[AverageStart],
			CONVERT(NUMERIC(8,1),(AVG(CONVERT(FLOAT(53),[Rank]))))					AS		[AverageFinish]
			
	FROM	[dbo].[GTS_EventResults]			er

	JOIN	[dbo].[GTS_EventHeader]				eh
		ON	er.[EventCalendarId]		=		eh.[EventCalendarId]

	JOIN	[dbo].[GTS_EventDetail]				ed
		ON	eh.[EventId]				=		ed.[EventId]

	JOIN	[dbo].[GTS_Tracks]					t
		ON	ed.[CourseId]				=		t.[Id]

	WHERE	er.[UserNumber]				=		(
													SELECT		[ProfileNumber] 
													FROM		[dbo].[GTS_Profiles]
													WHERE		[Id]	=	@Id
												)
	GROUP BY	t.[Name]

	ORDER BY	[Track]

GO
