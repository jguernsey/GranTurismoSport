CREATE TABLE [dbo].[GTS_RegisteredUserRankings](
	[RankingId] [bigint] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_ID]  DEFAULT (''),
	[Category] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_CATEGORY]  DEFAULT (''),
	[WorldRank] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_WORLDRANK]  DEFAULT (''),
	[CountryRank] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_COUNTRYRANK]  DEFAULT (''),
	[Value] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_VALUE]  DEFAULT (''),
	[EntryDate] [datetime] NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_ENTRYDATE]  DEFAULT ('1753-01-01'),
	[RegionRank] [bigint] NOT NULL CONSTRAINT [DF_GTSREGISTEREDUSERRANKINGS_REGIONRANK]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSREGISTEREDUSERRANKINGS] PRIMARY KEY CLUSTERED 
(
	[RankingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_RegisteredUserRankings_Id_412F6] ON [dbo].[GTS_RegisteredUserRankings]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
