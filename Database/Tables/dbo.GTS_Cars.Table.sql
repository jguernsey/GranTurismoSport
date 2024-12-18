CREATE TABLE [dbo].[GTS_Cars](
	[CarId] [bigint] IDENTITY(1,1) NOT NULL,
	[CarName] [nvarchar](64) NOT NULL CONSTRAINT [DF_GTSCARS_CARNAME]  DEFAULT (''),
	[ManufacturerId] [bigint] NOT NULL CONSTRAINT [DF_GTSCARS_MANUFACTURERID]  DEFAULT ((0)),
	[CategoryId] [bigint] NOT NULL CONSTRAINT [DF_GTSCARS_CATEGORYID]  DEFAULT ((0)),
	[TagId] [bigint] NOT NULL CONSTRAINT [DF_GTSCARS_TAGID]  DEFAULT ((0)),
	[ShortName] [nvarchar](64) NOT NULL CONSTRAINT [DF_GTSCARS_SHORTNAME]  DEFAULT (''),
	[Code] [bigint] NOT NULL CONSTRAINT [DF_GTSCARS_CODE]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSCARS] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
