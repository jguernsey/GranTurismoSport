CREATE TABLE [dbo].[GTS_RaceCalendarUpdates](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RegionId] [bigint] NOT NULL,
	[ChannelId] [bigint] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_GTSRACECALENDARUPATES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] ADD  CONSTRAINT [DF_GTSRACECALENDARUPDATES_REGIONID]  DEFAULT ((0)) FOR [RegionId]
GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] ADD  CONSTRAINT [DF_GTSRACECALENDARUPDATES_CHANNELID]  DEFAULT ((0)) FOR [ChannelId]
GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] ADD  CONSTRAINT [DF_GTSRACECALENDARUPDATES_LASTUPDATE]  DEFAULT ((0)) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] ADD  CONSTRAINT [FK_GTSRACECALENDARUPDATES_CHANNELID] FOREIGN KEY([ChannelId])
REFERENCES [dbo].[GTS_RaceChannels] ([Id])
GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] CHECK CONSTRAINT [FK_GTSRACECALENDARUPDATES_CHANNELID]
GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] ADD  CONSTRAINT [FK_GTSRACECALENDARUPDATES_REGIONID] FOREIGN KEY([RegionId])
REFERENCES [dbo].[GTS_Regions] ([Id])
GO
ALTER TABLE [dbo].[GTS_RaceCalendarUpdates] CHECK CONSTRAINT [FK_GTSRACECALENDARUPDATES_REGIONID]
GO
