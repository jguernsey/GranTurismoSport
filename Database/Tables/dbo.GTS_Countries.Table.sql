CREATE TABLE [dbo].[GTS_Countries](
	[CountryId] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryCode] [nvarchar](2) NOT NULL CONSTRAINT [DF_GTSCOUNTRIES_COUNTRYCODE]  DEFAULT (''),
	[CountryName] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSCOUNTRIES_COUNTRYNAME]  DEFAULT (''),
	[FlagImage] [varbinary](max) NOT NULL CONSTRAINT [DF_GTSCOUNTRIES_FLAGIMAGE]  DEFAULT (0x),
	[RegionId] [bigint] NOT NULL CONSTRAINT [DF_GTSCOUNTRIES_REGIONID]  DEFAULT ((1)),
	[ImagePath] [nvarchar](128) NOT NULL CONSTRAINT [DF_GTSCOUNTRIES_IMAGEPATH]  DEFAULT (''),
 CONSTRAINT [PK_GTSCOUNTRIES] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
