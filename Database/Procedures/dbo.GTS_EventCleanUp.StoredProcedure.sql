
CREATE PROCEDURE [dbo].[GTS_EventCleanUp]
AS
	SELECT	DISTINCT 
			[RegionId],
			[Region]	=	CASE	[RegionId]
							WHEN	1
								THEN 'jp'
							WHEN	2
								THEN 'de'
							WHEN	3
								THEN 'us'
						END,
			[EventId]
	FROM	[dbo].[GTS_EventHeader]
	ORDER BY	[Region], [EventId] 

GO
