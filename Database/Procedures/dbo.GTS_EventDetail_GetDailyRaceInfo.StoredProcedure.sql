
CREATE PROCEDURE [dbo].[GTS_EventDetail_GetDailyRaceInfo]
AS
	SELECT		[Region]	=	CASE [RegionId]
								WHEN	1
									THEN	'jp'
								WHEN	2
									THEN	'gb'
								WHEN	3
									THEN	'us'
								WHEN	4
									THEN	'jp'
								WHEN	5
									THEN	'au'
								WHEN	6
									THEN	'us'
								WHEN	7
									THEN	'mx'
							END,
				ed.[BoardId],
				COUNT([RankingId])			AS		[Entries]

	FROM		[dbo].[GTS_EventDetail]				ed

	LEFT JOIN	[dbo].[GTS_RaceRankings]			rr
		ON		ed.[BoardId]				=		rr.[BoardId]

	WHERE		[ActiveStart]				>=		DATEADD(DAY,-7,GETDATE())
		AND		[ActiveEnd]					<=		DATEADD(DAY,7,GETDATE())
		
	GROUP BY	[RegionId], ed.[BoardId]

	ORDER BY	[BoardId] DESC
GO
