CREATE PROCEDURE	[dbo].[GTS_SeasonNames_Select]
	@TypeId			BIGINT,
	@RegionId		BIGINT
AS
	IF @TypeId = 11
		BEGIN
			SELECT		[EventTarget]
			FROM
			(
				SELECT		DISTINCT et.[EventTarget], COUNT([ProfileId]) AS [EntryCount], sd.[SeasonId]
	
				FROM		[dbo].[GTS_SeasonDetail]			sd
	
				JOIN		[dbo].[GTS_EventTargets]			et
					ON		sd.[EventTargetId]			=		et.[Id]
			
				LEFT JOIN	[dbo].[GTS_NationsCupResults]		n
					ON		sd.[SeasonId]				=		n.[SeasonId]

				WHERE		sd.[TypeId]					=		11
					AND		sd.[RegionId]				=		@RegionId

				GROUP BY	et.[EventTarget], sd.[SeasonId]
			) T1
			WHERE		[EntryCount] > 0
			ORDER BY	[SeasonId] DESC
		END
	ELSE
		BEGIN
			SELECT		[EventTarget]
			FROM
			(
				SELECT		DISTINCT et.[EventTarget], COUNT([ProfileId]) AS [EntryCount], sd.[SeasonId]
	
				FROM		[dbo].[GTS_SeasonDetail]			sd
	
				JOIN		[dbo].[GTS_EventTargets]			et
					ON		sd.[EventTargetId]			=		et.[Id]
			
				LEFT JOIN	[dbo].[GTS_ManufacturerResults]		n
					ON		sd.[SeasonId]				=		n.[SeasonId]

				WHERE		sd.[TypeId]					=		12
					AND		sd.[RegionId]				=		@RegionId

				GROUP BY	et.[EventTarget], sd.[SeasonId]
			) T1
			WHERE		[EntryCount] > 0
			ORDER BY	[SeasonId] DESC
		END

GO
