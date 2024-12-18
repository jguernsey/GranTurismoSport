CREATE TABLE [dbo].[GTS_RunningProfileNumbers](
	[ProfileNumber] [bigint] NOT NULL CONSTRAINT [DF_GTSRUNNINGPROFILENUMBERS_PROFILENUMBER]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSRUNNINGPROFILENUMBERS] PRIMARY KEY CLUSTERED 
(
	[ProfileNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
