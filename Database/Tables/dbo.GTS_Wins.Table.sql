CREATE TABLE [dbo].[GTS_Wins](
	[Rank] [bigint] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSWINS_ID]  DEFAULT (''),
	[Country] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSWINS_COUNTRY]  DEFAULT (''),
	[CountryRank] [bigint] NOT NULL CONSTRAINT [DF_GTSWINS_COUNTRYRANK]  DEFAULT ((0)),
	[Value] [bigint] NOT NULL CONSTRAINT [DF_GTSWINS_VALUE]  DEFAULT ((0)),
	[EntryDate] [datetime] NOT NULL CONSTRAINT [DF_GTSWINS_ENTRYDATE]  DEFAULT ('1753-01-01'),
	[RegionRank] [bigint] NOT NULL CONSTRAINT [DF_GTSWINS_REGIONRANK]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSWINS] PRIMARY KEY CLUSTERED 
(
	[Rank] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_Wins_Country_CountryRank_F35AD] ON [dbo].[GTS_Wins]
(
	[Country] ASC,
	[CountryRank] ASC
)
INCLUDE ( 	[Id],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Wins_Country_RegionRank_7C581] ON [dbo].[GTS_Wins]
(
	[Country] ASC,
	[RegionRank] ASC
)
INCLUDE ( 	[Id],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Wins_Id_A9DE4] ON [dbo].[GTS_Wins]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Wins_RegionRank_8FD31] ON [dbo].[GTS_Wins]
(
	[RegionRank] ASC
)
INCLUDE ( 	[Id],
	[Country],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Wins_Value_35B53] ON [dbo].[GTS_Wins]
(
	[Value] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
