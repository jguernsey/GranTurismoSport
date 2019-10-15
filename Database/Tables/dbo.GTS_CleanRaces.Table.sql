CREATE TABLE [dbo].[GTS_CleanRaces](
	[Rank] [bigint] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSCLEANRACES_ID]  DEFAULT (''),
	[Country] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSCLEANRACES_COUNTRY]  DEFAULT (''),
	[CountryRank] [bigint] NOT NULL CONSTRAINT [DF_GTSCLEANRACES_COUNTRYRANK]  DEFAULT ((0)),
	[Value] [bigint] NOT NULL CONSTRAINT [DF_GTSCLEANRACES_VALUE]  DEFAULT ((0)),
	[EntryDate] [datetime] NOT NULL CONSTRAINT [DF_GTSCLEANRACES_ENTRYDATE]  DEFAULT ('1753-01-01'),
	[RegionRank] [bigint] NOT NULL CONSTRAINT [DF_GTSLEANRACES_REGIONRANK]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSCLEANRACES] PRIMARY KEY CLUSTERED 
(
	[Rank] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_CleanRaces_Country_CountryRank_CF101] ON [dbo].[GTS_CleanRaces]
(
	[Country] ASC,
	[CountryRank] ASC
)
INCLUDE ( 	[Id],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_CleanRaces_Country_RegionRank_4A522] ON [dbo].[GTS_CleanRaces]
(
	[Country] ASC,
	[RegionRank] ASC
)
INCLUDE ( 	[Id],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_CleanRaces_RegionRank_A80CD] ON [dbo].[GTS_CleanRaces]
(
	[RegionRank] ASC
)
INCLUDE ( 	[Id],
	[Country],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
