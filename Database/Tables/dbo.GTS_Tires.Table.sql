CREATE TABLE [dbo].[GTS_Tires](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSTIRES_NAME]  DEFAULT (''),
	[Code] [nvarchar](8) NOT NULL CONSTRAINT [DF_GTSTIRES_CODE]  DEFAULT (''),
 CONSTRAINT [PK_GTSTIRES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
