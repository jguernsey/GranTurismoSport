CREATE PROCEDURE [dbo].[GTS_ManufacturerSeries_GetSummaryByManufacturer]
	@EventTarget			NVARCHAR(32),
	@RegionId				BIGINT,
	@ManufacturerId			BIGINT,
	@PageNumber				BIGINT
AS
	SELECT [WorldRank], [ManufacturerRank], [ManufacturerId], [Driver], [ImagePath], [DR], [SR], [TotalPoints]
	FROM
	(
		SELECT	ROW_NUMBER() OVER (ORDER BY [TotalPoints] DESC) AS [EntryNumber],
				[WorldRank], 
				[ManufacturerRank], 
				[ManufacturerId],
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
		FROM	[dbo].[GTS_ManufacturerResults]			ncr
	
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
			AND [ManufacturerId]				=		@ManufacturerId
	) t1
	WHERE		
	(
					([EntryNumber]				>		((@PageNumber - 1) * 100))
		AND			([EntryNumber]				<=		(@PageNumber * 100))
	)
	ORDER BY	[NTotalPoints]	DESC
GO
