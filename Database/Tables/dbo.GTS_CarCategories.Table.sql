CREATE TABLE [dbo].[GTS_CarCategories](
	[CategoryId] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSCARCATEGORIES_CATEGORYNAME]  DEFAULT (''),
 CONSTRAINT [PK_GTSCARCATEGORIES] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
