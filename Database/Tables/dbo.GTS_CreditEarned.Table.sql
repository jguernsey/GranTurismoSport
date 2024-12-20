CREATE TABLE [dbo].[GTS_CreditEarned](
	[Rank] [bigint] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSCREDITEARNED_ID]  DEFAULT (''),
	[Country] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSCREDITEARNED_COUNTRY]  DEFAULT (''),
	[CountryRank] [bigint] NOT NULL CONSTRAINT [DF_GTSCREDITEARNED_COUNTRYRANK]  DEFAULT ((0)),
	[Value] [bigint] NOT NULL CONSTRAINT [DF_GTSCREDITEARNED_VALUE]  DEFAULT ((0)),
	[EntryDate] [datetime] NOT NULL CONSTRAINT [DF_GTSCREDITEARNED_ENTRYDATE]  DEFAULT ('1753-01-01'),
	[RegionRank] [bigint] NOT NULL CONSTRAINT [DF_GTSCREDITEARNED_REGIONRANK]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSCREDITEARNED] PRIMARY KEY CLUSTERED 
(
	[Rank] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_CreditEarned_Country_CountryRank_098EA] ON [dbo].[GTS_CreditEarned]
(
	[Country] ASC,
	[CountryRank] ASC
)
INCLUDE ( 	[Id],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_CreditEarned_Id_98B2E] ON [dbo].[GTS_CreditEarned]
(
	[Id] ASC
)
INCLUDE ( 	[Rank],
	[CountryRank],
	[Value],
	[EntryDate],
	[RegionRank]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_CreditEarned_Id_9FC66] ON [dbo].[GTS_CreditEarned]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_CreditEarned_RegionRank_A6A50] ON [dbo].[GTS_CreditEarned]
(
	[RegionRank] ASC
)
INCLUDE ( 	[Id],
	[Country],
	[Value],
	[EntryDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
