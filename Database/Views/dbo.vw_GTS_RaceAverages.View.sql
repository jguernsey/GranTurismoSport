CREATE VIEW [dbo].[vw_GTS_RaceAverages]
AS
SELECT	
t.Name, 
p.[Id], 
cc.[CategoryName], 
[CarsCount],
COUNT([UserNumber]) AS [Races],
AVG(NULLIF([LeadLap],-1))	AS	[AvgLapsLed],
MAX(NULLIF([LeadLap],-1)) AS [MostLapsLed],
AVG([MannerPoint])	AS [AvgSR],
MAX([MannerPoint]) AS [MostGainedSR],
MIN([MannerPoint]) AS [MostLostSR],
AVG([QualifyRank]) AS [AvgQualify],
MIN(NULLIF([QualifyRank],0)) AS [BestQualify],
MAX(NULLIF([QualifyRank],0)) AS [WorstQualify],
AVG(NULLIF([Rank],0)) AS [AvgFinish],
MIN(NULLIF([Rank],0)) AS [BestFinish],
MAX(NULLIF([Rank],0)) AS [WorstFinish]
 
FROM	[dbo].[GTS_EventResults]	er

JOIN	[dbo].[GTS_EventHeader]	eh
	ON	er.[EventCalendarId]		=		eh.[EventCalendarId]

JOIN	[dbo].[GTS_EventDetail]				ed
	ON	eh.[EventId]				=		ed.[EventId]

JOIN	[dbo].[GTS_Tracks]					t
	ON	ed.[CourseId]				=		t.[Id]

JOIN	[dbo].[GTS_CarCategories]			cc
	ON	ed.[CarCategoryId]			=		cc.[CategoryId]

JOIN	[dbo].[GTS_Profiles]				p
	ON	[UserNumber]				=		p.[ProfileNumber]

GROUP BY t.Name, p.[Id], cc.[CategoryName], [CarsCount]

GO
