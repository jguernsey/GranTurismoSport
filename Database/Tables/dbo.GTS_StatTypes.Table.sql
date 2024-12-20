CREATE TABLE [dbo].[GTS_StatTypes](
	[StatTypeId] [bigint] IDENTITY(1,1) NOT NULL,
	[StatType] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_STATTYPE]  DEFAULT (''),
	[WorldProc] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_WORLDPROC]  DEFAULT (''),
	[CountryProc] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_COUNTRYPROC]  DEFAULT (''),
	[WorldPages] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_WORLDPAGES]  DEFAULT (''),
	[CountryPages] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_COUNTRYPAGES]  DEFAULT (''),
	[TableCaption] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_TABLECAPTION]  DEFAULT (''),
	[Available] [nvarchar](1) NOT NULL CONSTRAINT [DF_GTSSTATTYPES_AVAILABLE]  DEFAULT ('Y'),
 CONSTRAINT [PK_GTSSTATTYPES] PRIMARY KEY CLUSTERED 
(
	[StatTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
