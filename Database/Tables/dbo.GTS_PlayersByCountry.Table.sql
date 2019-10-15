CREATE TABLE [dbo].[GTS_PlayersByCountry](
	[Rank] [bigint] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSPLAYERSBYCOUNTRY_COUNTRY]  DEFAULT (''),
	[Total] [bigint] NOT NULL CONSTRAINT [DF_GTSPLAYERSBYCOUNTRY_TOTAL]  DEFAULT ((0)),
	[TotalPercent] [decimal](8, 4) NOT NULL CONSTRAINT [DF_GTSPLAYERSBYCOUNTRY_TOTALPERCENT]  DEFAULT ((0))
) ON [PRIMARY]

GO
