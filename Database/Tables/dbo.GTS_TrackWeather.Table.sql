CREATE TABLE [dbo].[GTS_TrackWeather](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TrackId] [bigint] NOT NULL CONSTRAINT [DF_GTSTRACKWEATHER_TRACKID]  DEFAULT ((0)),
	[Code] [bigint] NOT NULL CONSTRAINT [DF_GTSTRACKWEATHER_CODE]  DEFAULT ((0)),
	[TimeId] [bigint] NOT NULL CONSTRAINT [DF_GTSTRACKWEATHER_TIMEID]  DEFAULT ((0)),
	[TypeId] [bigint] NOT NULL CONSTRAINT [DF_GTSTRACKWEATHER_TYPEID]  DEFAULT ((1)),
	[IsDefault] [nvarchar](8) NOT NULL CONSTRAINT [DF_GTSTRACKWEATHER_ISDEFAULT]  DEFAULT ('false'),
 CONSTRAINT [PK_GTSTRACKWEATHER] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[GTS_TrackWeather] ADD  CONSTRAINT [FK_GTSTRACKWEATHER_TIMEID] FOREIGN KEY([TimeId])
REFERENCES [dbo].[GTS_TrackTimes] ([Id])
GO
ALTER TABLE [dbo].[GTS_TrackWeather] CHECK CONSTRAINT [FK_GTSTRACKWEATHER_TIMEID]
GO
ALTER TABLE [dbo].[GTS_TrackWeather] ADD  CONSTRAINT [FK_GTSTRACKWEATHER_TRACKID] FOREIGN KEY([TrackId])
REFERENCES [dbo].[GTS_Tracks] ([Id])
GO
ALTER TABLE [dbo].[GTS_TrackWeather] CHECK CONSTRAINT [FK_GTSTRACKWEATHER_TRACKID]
GO
