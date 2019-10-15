CREATE TABLE [dbo].[GTS_PlayersByRegion](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RegionName] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSPLAYERSBYREGION_REGIONNAME]  DEFAULT (''),
	[NPlayerCount] [bigint] NOT NULL CONSTRAINT [DF_GTSPLAYERSBYREGION_NPLAYRECOUNT]  DEFAULT ((0)),
	[PlayerCount] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSPLAYERSBYREGION_PLAYERCOUNT]  DEFAULT (''),
	[Percentage] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSPLAYERSBYREGION_PERCENTAGE]  DEFAULT (''),
 CONSTRAINT [PK_GTSPLAYERSBYREGION] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
