
CREATE PROCEDURE [dbo].[GTS_EventLog_Insert]
	@EventMessage		NVARCHAR(4000),
	@EventSource		NVARCHAR(128)
AS
	BEGIN
		INSERT INTO [dbo].[GTS_EventLog] ([EventDateTime], [EventMessage], [EventSource])
		VALUES (GETDATE(), @EventMessage, @EventSource)
	END



GO
