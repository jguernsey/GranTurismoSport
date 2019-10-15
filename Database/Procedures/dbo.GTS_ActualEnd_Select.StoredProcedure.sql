CREATE PROCEDURE [dbo].[GTS_ActualEnd_Select]
AS
	SELECT			[EventDateTime],
					[EventMessage]

	FROM			[dbo].[GTS_EventLog]
	
	WHERE			[EventSource]			=		'Stats Service'
		AND			[EventMessage]			LIKE	'%End %'
	
	ORDER BY		[EventId]


GO
