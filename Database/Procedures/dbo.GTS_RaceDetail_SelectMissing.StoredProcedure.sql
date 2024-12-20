CREATE PROCEDURE [dbo].[GTS_RaceDetail_SelectMissing]
AS
	SELECT			[RegionCode], [Id] AS [RegionId], [EventId]
	FROM
	(
		SELECT			DISTINCT r.[RegionCode], r.[Id], eh.[EventId], ed.[EventId] AS [MissingEvents]
	
		FROM			[dbo].[GTS_EventHeader]				eh
	
		LEFT JOIN		[dbo].[GTS_Regions]					r
			ON			eh.[RegionId]				=		r.[Id]
	
		LEFT JOIN		[dbo].[GTS_Channels]				c
			ON			eh.[ChannelId]				=		c.[Id]
	
		LEFT JOIN		[dbo].[GTS_EventDetail]				ed
			ON			eh.[EventId]				=		ed.[EventId]

		WHERE			[EndTime]					>=		DATEADD(DAY, -7,GETDATE())
	)
	T1
	WHERE				[MissingEvents]				IS		NULL
	ORDER BY			[EventId]					DESC

GO
