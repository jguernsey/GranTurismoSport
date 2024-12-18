CREATE TABLE [dbo].[GTS_RaceChannels](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Channel] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSRACECHANNELS_CHANNEL]  DEFAULT (''),
 CONSTRAINT [PK_GTSRACECHANNELS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
