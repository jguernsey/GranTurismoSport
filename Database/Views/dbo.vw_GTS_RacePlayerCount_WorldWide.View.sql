CREATE VIEW	[dbo].[vw_GTS_RacePlayerCount_WorldWide]
AS
	SELECT		ed.[DateEntered], t.[Title], trk.[Name], COUNT([UserId]) AS [PlayerCount]
	FROM		[dbo].[GTS_RaceRankings]			rr

	JOIN		[dbo].[GTS_EventDetail]				ed
		ON		rr.[BoardId]				=		ed.[BoardId]

	JOIN		[dbo].[GTS_Titles]					t
		ON		ed.[TitleId]				=		t.[Id]

	JOIN		[dbo].[GTS_Tracks]					trk
		ON		ed.[CourseId]				=		trk.[Id]

	JOIN		[dbo].[GTS_Countries]				c
		ON		rr.[CountryId]				=		c.[CountryId]

	GROUP BY	ed.[DateEntered], t.[Title], trk.[Name]

GO
