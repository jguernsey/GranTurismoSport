
CREATE VIEW [dbo].[vw_GTS_NationsCupResultDetail]
AS
	SELECT		ncr.[SeasonId]			AS		[Season],
				sr.[RoundId]			AS		[Round],
				t.[Name]				AS		[Track],
				cc.[CategoryName]		AS		[Category],			
				p.[Id]					AS		[Driver],
				c.[CountryName]			AS		[CountryName],
				[DR]					=		CASE ncr.[DriverClass]
													WHEN	6
														THEN	'S'
													WHEN	5
														THEN	'A'
													WHEN	4
														THEN	'B'
													WHEN	3
														THEN	'C'
													WHEN	2
														THEN	'D'
													WHEN	1
														THEN	'E'
													ELSE		'-'
				END,
				[SR]					=		CASE
													WHEN	ncr.[MannerPoint] >= 80 AND ncr.[MannerPoint] <= 99
														THEN	'S'
													WHEN	ncr.[MannerPoint] >= 65 AND ncr.[MannerPoint] <= 79
														THEN	'A'
													WHEN	ncr.[MannerPoint] >= 40 AND ncr.[MannerPoint] <= 64
														THEN	'B'
													WHEN	ncr.[MannerPoint] >= 20 AND ncr.[MannerPoint] <= 39
														THEN	'C'
													WHEN	ncr.[MannerPoint] >= 10 AND ncr.[MannerPoint] <= 19
														THEN	'D'
													WHEN	ncr.[MannerPoint] >= 1 AND ncr.[MannerPoint] <= 9
														THEN	'E'
													ELSE		'-'
												END,
				[Laps]					=		CASE	er.[Lap]
													WHEN	-1
														THEN	0
													ELSE
														er.[Lap]
												END,
				[LapsLed]				=		CASE	er.[LeadLap]
													WHEN	-1
														THEN 0
													ELSE	er.[LeadLap]
												END,
				er.[MannerPoint]		AS		[RaceSR],
				er.[ManufacturerId]		AS		[ManufacturerId],
				[Qualified]				=		CASE er.[QualifyRank]
													WHEN	-1
														THEN	'-'
													ELSE		CAST(er.[QualifyRank] AS NVARCHAR(8))
												END,
				[Finished]				=		CASE er.[Rank]
													WHEN	0
														THEN	'DNF'
													ELSE
														CAST(er.[Rank] AS NVARCHAR(8))
												END,
				ncp.[Points]			AS		[RacePoints],
				ncr.[TotalPoints]		AS		[SeasonPoints],	
				ncr.[WorldRank]			AS		[WorldRank],
				ncr.[CountryRank]		AS		[CountryRank]

	FROM		[dbo].[GTS_NationsCupPoints]				ncp

	JOIN		[dbo].[GTS_NationsCupResults]				ncr
		ON		ncp.[ResultId]						=		ncr.[ResultId]

	JOIN		[dbo].[GTS_Profiles]						p
		ON		ncr.[ProfileId]						=		p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]						c
		ON		p.[CountryId]						=		c.[CountryId]

	JOIN		[dbo].[GTS_Seasons]							s
		ON		ncr.[SeasonId]						=		s.[SeasonId]

	JOIN		[dbo].[GTS_EventResults]					er
		ON		ncp.[EventResultId]					=		er.[EventResultId]
		AND		p.[ProfileNumber]					=		er.[UserNumber]

	JOIN		[dbo].[GTS_EventHeader]						eh
		ON		er.[EventCalendarId]				=		eh.[EventCalendarId]

	JOIN		[dbo].[GTS_SeasonRounds]					sr
		ON		eh.[EventId]						=		sr.[EventId]

	JOIN		[dbo].[GTS_EventDetail]						ed
		ON		eh.[EventId]						=		ed.[EventId]

	JOIN		[dbo].[GTS_Tracks]							t
		ON		ed.[CourseId]						=		t.[Id]

	JOIN		[dbo].[GTS_CarCategories]					cc
		ON		ed.[CarCategoryId]					=		cc.[CategoryId]


GO
