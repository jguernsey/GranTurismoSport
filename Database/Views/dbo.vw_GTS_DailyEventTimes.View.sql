CREATE VIEW	[dbo].[vw_GTS_DailyEventTimes]
AS
	SELECT		[Region]		=		CASE	[RegionId]
											WHEN	1
												THEN	'jp'
											WHEN		2
												THEN	'de'
											WHEN		3
												THEN	'us'
										END,
				[EventId],
				'Start'								AS		[TimeType],
				[StartTime]							AS		[UpdateTime]
	FROM		[dbo].[GTS_EventHeader]
	WHERE		([StartTime]					>=		DATEADD(DAY,DATEDIFF(DAY,0,GETDATE()),0)
		AND		[StartTime]						<=		DATEADD(DAY,DATEDIFF(DAY,0,GETDATE()),1))
	UNION
	SELECT		[Region]		=		CASE	[RegionId]
											WHEN	1
												THEN	'jp'
											WHEN		2
												THEN	'de'
											WHEN		3
												THEN	'us'
										END,
				[EventId],
				'End'							AS		[TimeType],
				[EndTime]						AS		[UpdateTime]
	FROM		[dbo].[GTS_EventHeader]
	WHERE		([StartTime]					>=		DATEADD(DAY,DATEDIFF(DAY,0,GETDATE()),0)
		AND		[StartTime]						<=		DATEADD(DAY,DATEDIFF(DAY,0,GETDATE()),1))


GO
