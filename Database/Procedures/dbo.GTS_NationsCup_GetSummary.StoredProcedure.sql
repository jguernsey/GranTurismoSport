CREATE PROCEDURE [dbo].[GTS_NationsCup_GetSummary]
	@EventTarget			NVARCHAR(32),
	@RegionId				BIGINT
AS
	SELECT	[WorldRank], 
			[CountryRank], 
			p.[Id]				AS		[Driver], 
			[ImagePath],
			[DR]		=		CASE	[DriverClass]
									WHEN		6
										THEN	'S'
									WHEN		5
										THEN	'A'
									WHEN		4
										THEN	'B'
									WHEN		3
										THEN	'C'
									WHEN		2
										THEN	'D'
									WHEN		1
										THEN	'E'
									ELSE		'-'
								END,
			[SR]		=		CASE	
									WHEN		[MannerPoint] >= 80 AND [MannerPoint] <= 99
										THEN	'S'
									WHEN		[MannerPoint] >= 65 AND [MannerPoint] <= 79
										THEN	'A'
									WHEN		[MannerPoint] >= 40 AND [MannerPoint] <= 64
										THEN	'B'
									WHEN		[MannerPoint] >= 20 AND [MannerPoint] <= 39
										THEN	'C'
									WHEN		[MannerPoint] >= 10 AND [MannerPoint] <= 19
										THEN	'D'
									WHEN		[MannerPoint] >= 1 AND [MannerPoint] <= 9
										THEN	'E'
									ELSE		'-'
								END,
			FORMAT([TotalPoints],'N0') AS [TotalPoints],
			[TotalPoints] AS [NTotalPoints]
	FROM	[dbo].[GTS_NationsCupResults]			ncr
	
	JOIN	[dbo].[GTS_Profiles]					p
		ON	ncr.[ProfileId]					=		p.[ProfileId]
	
	JOIN	[dbo].[GTS_SeasonDetail]				sd
		ON	ncr.[SeasonId]					=		sd.[SeasonId]
	
	JOIN	[dbo].[GTS_Countries]					c
		ON	p.[CountryId]					=		c.[CountryId]
	
	JOIN	[dbo].[GTS_EventTargets]				et
		ON	sd.[EventTargetId]				=		et.[Id]
	
	WHERE	et.[EventTarget]				=		@EventTarget
		AND	sd.[RegionId]					=		@RegionId
		AND	[WorldRank]						<=		50
	ORDER BY	[NTotalPoints]	DESC
GO
