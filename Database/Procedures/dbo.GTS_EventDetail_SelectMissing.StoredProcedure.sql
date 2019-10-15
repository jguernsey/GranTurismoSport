
CREATE PROCEDURE [dbo].[GTS_EventDetail_SelectMissing]
AS
	SELECT		DISTINCT
				[RegionId],
				[Region]	=	CASE [RegionId]
									WHEN	1
										THEN	'jp'
									WHEN		2
										THEN	'de'
									WHEN	3
										THEN	'us'
								END,
				[ChannelId], 
				[EventId]

	FROM		[dbo].[GTS_EventHeader]
GO
