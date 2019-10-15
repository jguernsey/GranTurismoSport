CREATE TABLE [dbo].[GTS_RaceRankings](
	[RankingId] [bigint] IDENTITY(1,1) NOT NULL,
	[BoardId] [bigint] NOT NULL CONSTRAINT [DF_GTSRACERANKINGS_BOARDID]  DEFAULT ((0)),
	[UserId] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSRACERANKINGS_USERID]  DEFAULT (''),
	[CreateTime] [datetime] NOT NULL CONSTRAINT [DF_GTSRACERANKINGS_CREATETIME]  DEFAULT ('1753-01-01'),
	[Score] [bigint] NOT NULL CONSTRAINT [DF_GTSRACERANKINGS_SCORE]  DEFAULT ((0)),
	[CountryId] [bigint] NOT NULL CONSTRAINT [DF_GTSRACERANKINGS_COUNTRYID]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSRACERANKINGS] PRIMARY KEY CLUSTERED 
(
	[RankingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_15E1B] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC
)
INCLUDE ( 	[RankingId],
	[UserId],
	[CreateTime],
	[Score],
	[CountryId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_552B4] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_84274] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC
)
INCLUDE ( 	[Score],
	[CountryId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_96A7B] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC
)
INCLUDE ( 	[UserId],
	[Score],
	[CountryId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_ABEB3] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC
)
INCLUDE ( 	[UserId],
	[CreateTime],
	[Score]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_B9046] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC
)
INCLUDE ( 	[Score]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_CountryId_3DEE0] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC,
	[CountryId] ASC
)
INCLUDE ( 	[UserId],
	[Score]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_UserId_48918] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_BoardId_UserId_Score_BAEAC] ON [dbo].[GTS_RaceRankings]
(
	[BoardId] ASC,
	[UserId] ASC,
	[Score] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_CountryId_433B3] ON [dbo].[GTS_RaceRankings]
(
	[CountryId] ASC
)
INCLUDE ( 	[CreateTime]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_CountryId_6D8E5] ON [dbo].[GTS_RaceRankings]
(
	[CountryId] ASC
)
INCLUDE ( 	[BoardId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_CountryId_8DDE3] ON [dbo].[GTS_RaceRankings]
(
	[CountryId] ASC
)
INCLUDE ( 	[BoardId],
	[UserId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_RaceRankings_UserId_D75B3] ON [dbo].[GTS_RaceRankings]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
