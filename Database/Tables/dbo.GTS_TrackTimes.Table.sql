CREATE TABLE [dbo].[GTS_TrackTimes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Time] [time](7) NOT NULL CONSTRAINT [DF_GTSTRACKTIMES_TIME]  DEFAULT ('00:00:00'),
 CONSTRAINT [PK_TRACKTIMES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
