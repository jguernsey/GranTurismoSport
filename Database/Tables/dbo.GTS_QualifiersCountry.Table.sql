CREATE TABLE [dbo].[GTS_QualifiersCountry](
	[BoardId] [bigint] NOT NULL,
	[CountryId] [int] NOT NULL,
	[CountryDrivers] [int] NOT NULL
) ON [PRIMARY]

GO
CREATE CLUSTERED INDEX [BoardId-CountryId] ON [dbo].[GTS_QualifiersCountry]
(
	[BoardId] ASC,
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
