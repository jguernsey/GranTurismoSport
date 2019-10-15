CREATE TABLE [dbo].[GTS_RealTimeDriverRating](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProfileId] [bigint] NOT NULL CONSTRAINT [DF_GTSREALTIMEDRIVERRATING_PROFILEID]  DEFAULT ((0)),
	[DriverRating] [bigint] NOT NULL CONSTRAINT [DF_GTSREALTIMEDRIVERRATING_DRIVERRATING]  DEFAULT ((0)),
	[DateUpdated] [datetime] NOT NULL CONSTRAINT [DF_GTSREALTIMEDRIVERRATING_DATEUPDATED]  DEFAULT ('1753-01-01'),
	[Status] [nvarchar](2) NULL CONSTRAINT [DF_GTSREALTIMERIVERRATING_STATUS]  DEFAULT ('NC'),
	[UpdateType] [nvarchar](8) NOT NULL CONSTRAINT [DF_GTSREALTIMEDRIVERRATING_UPDATETYPE]  DEFAULT (''),
 CONSTRAINT [PK_GTSREALTIMEDRIVERRATING] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_RealTimeDriverRating_DateUpdated_7EBB5] ON [dbo].[GTS_RealTimeDriverRating]
(
	[DateUpdated] ASC
)
INCLUDE ( 	[DriverRating]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RealTimeDriverRating_ProfileId_603BB] ON [dbo].[GTS_RealTimeDriverRating]
(
	[ProfileId] ASC
)
INCLUDE ( 	[DriverRating],
	[DateUpdated]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RealTimeDriverRating_ProfileId_DriverRating_0BCB5] ON [dbo].[GTS_RealTimeDriverRating]
(
	[ProfileId] ASC,
	[DriverRating] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RealTimeDriverRating_UpdateType_F55FC] ON [dbo].[GTS_RealTimeDriverRating]
(
	[UpdateType] ASC
)
INCLUDE ( 	[ProfileId],
	[DriverRating],
	[DateUpdated],
	[Status]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GTS_RealTimeDriverRating] ADD  CONSTRAINT [FK_GTSREALTIMEDRIVERRATING_PROFILEID] FOREIGN KEY([ProfileId])
REFERENCES [dbo].[GTS_Profiles] ([ProfileId])
GO
ALTER TABLE [dbo].[GTS_RealTimeDriverRating] CHECK CONSTRAINT [FK_GTSREALTIMEDRIVERRATING_PROFILEID]
GO
