CREATE TABLE [dbo].[GTS_PhotosTaken](
	[Rank] [bigint] IDENTITY(1,1) NOT NULL,
	[ProfileId] [bigint] NOT NULL CONSTRAINT [DF_GTSPHOTOSTAKEN_PROFILEID]  DEFAULT ((0)),
	[CountryId] [bigint] NOT NULL CONSTRAINT [DF_GTSPHOTOSTAKEN_COUNTRYID]  DEFAULT ((0)),
	[CountryRank] [bigint] NOT NULL CONSTRAINT [DF_GTSPHOTOSTAKEN_COUNTRYRANK]  DEFAULT ((0)),
	[Value] [bigint] NOT NULL CONSTRAINT [DF_GTSPHOTOSTAKEN_VALUE]  DEFAULT ((0)),
	[EntryDate] [datetime] NOT NULL CONSTRAINT [DF_GTSPHOTOSTAKEN_ENTRYDATE]  DEFAULT ('1753-01-01'),
	[RegionRank] [bigint] NOT NULL CONSTRAINT [DF_GTSPHOTOSTAKEN_REGIONRANK]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSPHOTOSTAKEN] PRIMARY KEY CLUSTERED 
(
	[Rank] ASC,
	[ProfileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_PhotosTaken_ProfileId_5BC12] ON [dbo].[GTS_PhotosTaken]
(
	[ProfileId] ASC
)
INCLUDE ( 	[Rank],
	[CountryRank],
	[Value],
	[EntryDate],
	[RegionRank]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
