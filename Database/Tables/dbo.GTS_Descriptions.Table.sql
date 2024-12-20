CREATE TABLE [dbo].[GTS_Descriptions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](300) NOT NULL CONSTRAINT [DF_DESCRIPTIONS_DESCRIPTION]  DEFAULT (''),
 CONSTRAINT [PK_GTSDESCRIPTIONS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
