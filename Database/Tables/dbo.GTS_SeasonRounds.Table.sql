CREATE TABLE [dbo].[GTS_SeasonRounds](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SeasonId] [bigint] NOT NULL CONSTRAINT [DF_tmp_GTSSEASONROUNDS_SEASONID]  DEFAULT ((0)),
	[RoundId] [bigint] NOT NULL CONSTRAINT [DF_tmp_GTSSEASONROUNDS_ROUNDID]  DEFAULT ((0)),
	[EventId] [bigint] NOT NULL CONSTRAINT [DF_tmp_GTSSEASONROUNDS_EVENTID]  DEFAULT ((0)),
	[FirstRaceStart] [datetime] NOT NULL CONSTRAINT [DF_tmp_GTSSEASONROUNDS_FIRSTRACESTART]  DEFAULT ('1753-01-01'),
	[LastRaceEnd] [datetime] NOT NULL CONSTRAINT [DF_tmp_GTSSEASONROUNDS_LASTRACEEND]  DEFAULT ('1753-01-01'),
	[DateCreated] [datetime] NOT NULL CONSTRAINT [DF_tmp_GTSSEASONROUNDS_DATECREATED]  DEFAULT ('1753-01-01'),
 CONSTRAINT [PK_tmp_GTSSEASONROUNDS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
