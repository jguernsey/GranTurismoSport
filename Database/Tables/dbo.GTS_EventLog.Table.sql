CREATE TABLE [dbo].[GTS_EventLog](
	[EventId] [bigint] IDENTITY(1,1) NOT NULL,
	[EventDateTime] [datetime] NOT NULL CONSTRAINT [DF_GTS_EVENTLOG_EVENTDATETIME]  DEFAULT ('1753-01-01'),
	[EventMessage] [nvarchar](4000) NOT NULL CONSTRAINT [DF_GTS_EVENTLOG_EVENTMESSAGE]  DEFAULT (''),
	[EventSource] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTS_EVENTLOG_EVENTSOURCE]  DEFAULT (''),
 CONSTRAINT [PK_GTS_EVENTLOG] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_EventLog_EventSource_1AE01] ON [dbo].[GTS_EventLog]
(
	[EventSource] ASC
)
INCLUDE ( 	[EventId],
	[EventDateTime],
	[EventMessage]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_EventLog_EventSource_EventId_B9BFC] ON [dbo].[GTS_EventLog]
(
	[EventSource] ASC,
	[EventId] ASC
)
INCLUDE ( 	[EventDateTime],
	[EventMessage]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
