
CREATE PROCEDURE [dbo].[GTS_ActualStart_Select]
AS
	SELECT			[EventDateTime],
					[EventMessage]

	FROM			[dbo].[GTS_EventLog]
	
	WHERE			[EventSource]			=		'Stats Service'
		AND			[EventMessage]			LIKE	'%Start %'
	
	ORDER BY		[EventId]


GO
