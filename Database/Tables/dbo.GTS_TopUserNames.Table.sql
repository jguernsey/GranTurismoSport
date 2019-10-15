CREATE TABLE [dbo].[GTS_TopUserNames](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProfileId] [bigint] NOT NULL CONSTRAINT [DF_TOPUSERNAMES_PROFILEID]  DEFAULT ((0)),
	[ProfileNumber] [bigint] NOT NULL CONSTRAINT [DF_TOPUSERNAMES_PROFILENUMBER]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSTOPUSERNAMES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ProfileId] ASC,
	[ProfileNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
