
CREATE VIEW	[dbo].[vw_GTS_TrackLapTimes]
AS
SELECT			RANK() OVER (PARTITION BY t.[Name], [CategoryName] ORDER BY [Score] ASC, [CreateTime] ASC) [EntryId],
				t.[Name]					AS		[Track],
				[CategoryName]				AS		[CarCategory],
				[UserId]					AS		[Driver],
				co.[CountryName]			AS		[Country],
				[Score]						AS		[LapTime],
				[CreateTime]				AS		[LapTimestamp]	
				
FROM			[dbo].[GTS_RaceRankings]			rr

JOIN			[dbo].[GTS_EventDetail]				ed
	ON			rr.[BoardId]				=		ed.[BoardId]

JOIN			[dbo].[GTS_Tracks]					t
	ON			ed.[CourseId]				=		t.[Id]

JOIN			[dbo].[GTS_CarCategories]			cc
	ON			ed.[CarCategoryId]			=		cc.[CategoryId]

JOIN			[dbo].[GTS_Countries]				co
	ON			rr.[CountryId]				=		co.[CountryId]


GO
