CREATE TABLE [dbo].[GTS_DamageTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DamageType] [nvarchar](32) NOT NULL CONSTRAINT [DF_DAMAGETYPE_DAMAGETYPE]  DEFAULT (''),
 CONSTRAINT [PK_GTSDAMAGETYPES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
