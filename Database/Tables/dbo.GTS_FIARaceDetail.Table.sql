CREATE TABLE [dbo].[GTS_FIARaceDetail](
	[EventDetailId] [bigint] IDENTITY(1,1) NOT NULL,
	[RegionId] [bigint] NOT NULL,
	[EventId] [bigint] NOT NULL,
	[ChampionshipId] [bigint] NOT NULL,
	[SeasonId] [bigint] NOT NULL,
	[RoundId] [bigint] NOT NULL,
	[ChampionshipColorId] [nvarchar](8) NOT NULL,
	[GameModeId] [bigint] NOT NULL,
	[EventTypeId] [bigint] NOT NULL,
	[SportsModeId] [bigint] NOT NULL,
	[TitleId] [bigint] NOT NULL,
	[OneLineTitle] [bigint] NOT NULL,
	[DescriptionId] [bigint] NOT NULL,
	[RegistrationNotice] [nvarchar](400) NOT NULL,
	[EventTargetId] [bigint] NOT NULL,
	[EventRestrict] [nvarchar](400) NOT NULL,
	[LogoImagePathId] [bigint] NOT NULL,
	[FlyerImagePathId] [bigint] NOT NULL,
	[BehaviorDamageTypeId] [bigint] NOT NULL,
	[BehaviorSlipStreamTypeId] [bigint] NOT NULL,
	[BoostLevel] [nvarchar](400) NOT NULL,
	[LowMuTypeId] [bigint] NOT NULL,
	[EntryMax] [bigint] NOT NULL,
	[StartTypeId] [bigint] NOT NULL,
	[ConsumeFuel] [bigint] NOT NULL,
	[ConsumeTire] [bigint] NOT NULL,
	[RaceLimitLaps] [bigint] NOT NULL,
	[RaceLimitMinutes] [bigint] NOT NULL,
	[PitConstraint] [bigint] NOT NULL,
	[NeedCompoundUse] [nvarchar](400) NOT NULL,
	[LimitFuelCapacity] [bigint] NOT NULL,
	[BoardId] [bigint] NOT NULL,
	[LimitTireF] [bigint] NOT NULL,
	[NeedTireF] [bigint] NOT NULL,
	[UseBOP] [bigint] NOT NULL,
	[Tuning] [bigint] NOT NULL,
	[NeedDriverClass] [nvarchar](400) NOT NULL,
	[CarCategoryId] [bigint] NOT NULL,
	[Cars] [nvarchar](400) NOT NULL,
	[CarsCount] [bigint] NOT NULL,
	[RefuelingSpeed] [bigint] NOT NULL,
	[CourseId] [bigint] NOT NULL,
	[WeatherId] [bigint] NOT NULL,
	[DateEntered] [datetime] NOT NULL,
	[ActiveStart] [datetime] NOT NULL,
	[ActiveEnd] [datetime] NOT NULL,
 CONSTRAINT [PK_GTSFIARACEDETAIL] PRIMARY KEY CLUSTERED 
(
	[EventDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_REGIONID]  DEFAULT ((0)) FOR [RegionId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_EVENTID]  DEFAULT ((0)) FOR [EventId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CHAMPIONSHIPID]  DEFAULT ((0)) FOR [ChampionshipId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_SEASONID]  DEFAULT ((0)) FOR [SeasonId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_ROUNDID]  DEFAULT ((0)) FOR [RoundId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CHAMPIONSHIPCOLORID]  DEFAULT ('') FOR [ChampionshipColorId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_GAMEMODEID]  DEFAULT ((0)) FOR [GameModeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_EVENTTYPEID]  DEFAULT ((0)) FOR [EventTypeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_SPORTSMODEID]  DEFAULT ((0)) FOR [SportsModeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_TITLEID]  DEFAULT ((0)) FOR [TitleId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_ONELINETITLEID]  DEFAULT ((0)) FOR [OneLineTitle]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_DESCRIPTIONID]  DEFAULT ((0)) FOR [DescriptionId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_REGISTRATIONNOTICE]  DEFAULT ('') FOR [RegistrationNotice]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_EVENTTARGETID]  DEFAULT ((0)) FOR [EventTargetId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_EVENTRESTRICT]  DEFAULT ('') FOR [EventRestrict]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_LOGOIMAGEPATHID]  DEFAULT ((0)) FOR [LogoImagePathId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_FLYERIMAGEPATHID]  DEFAULT ((0)) FOR [FlyerImagePathId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_BEHAVIORDAMAGETYPEID]  DEFAULT ((0)) FOR [BehaviorDamageTypeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_BEHAVIORSLIPSTREAMTYPEID]  DEFAULT ((0)) FOR [BehaviorSlipStreamTypeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_BOOSTLEVEL]  DEFAULT ('') FOR [BoostLevel]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_LOWMUTYPEID]  DEFAULT ((0)) FOR [LowMuTypeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_ENTRYMAX]  DEFAULT ((0)) FOR [EntryMax]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_STARTTYPEID]  DEFAULT ((0)) FOR [StartTypeId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CONSUMEFUEL]  DEFAULT ((0)) FOR [ConsumeFuel]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CONSUMETIRE]  DEFAULT ((0)) FOR [ConsumeTire]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_RACELIMITLAPS]  DEFAULT ((0)) FOR [RaceLimitLaps]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_RACELIMITMINUTES]  DEFAULT ((0)) FOR [RaceLimitMinutes]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_PITCONSTRAINT]  DEFAULT ((0)) FOR [PitConstraint]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_NEEDCOMPOUNDUSE]  DEFAULT ('') FOR [NeedCompoundUse]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_LIMITFUELCAPACITY]  DEFAULT ((0)) FOR [LimitFuelCapacity]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_BOARDID]  DEFAULT ((0)) FOR [BoardId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_LIMITTIREF]  DEFAULT ((0)) FOR [LimitTireF]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_NEEDTIREF]  DEFAULT ((0)) FOR [NeedTireF]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_USEBOP]  DEFAULT ((0)) FOR [UseBOP]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_TUNING]  DEFAULT ((0)) FOR [Tuning]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_NEEDDRIVERCLASS]  DEFAULT ('') FOR [NeedDriverClass]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CARCATEGORYID]  DEFAULT ((0)) FOR [CarCategoryId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CARS]  DEFAULT ('') FOR [Cars]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_CARSCOUNT]  DEFAULT ((0)) FOR [CarsCount]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_REFUELINGSPEED]  DEFAULT ((0)) FOR [RefuelingSpeed]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_COURSEID]  DEFAULT ((0)) FOR [CourseId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_WEATHERID]  DEFAULT ((0)) FOR [WeatherId]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [DF_GTSFIARACEDETAIL_DATEENTERED]  DEFAULT ('1753-01-01') FOR [DateEntered]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [FK_GTSFIARACEDETAIL_BEHAVIORDAMAGETYPEID] FOREIGN KEY([BehaviorDamageTypeId])
REFERENCES [dbo].[GTS_DamageTypes] ([Id])
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] CHECK CONSTRAINT [FK_GTSFIARACEDETAIL_BEHAVIORDAMAGETYPEID]
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] ADD  CONSTRAINT [FK_GTSFIARACEDETAIL_BEHAVIORSLIPSTREAMTYPEID] FOREIGN KEY([BehaviorSlipStreamTypeId])
REFERENCES [dbo].[GTS_SlipStreamTypes] ([Id])
GO
ALTER TABLE [dbo].[GTS_FIARaceDetail] CHECK CONSTRAINT [FK_GTSFIARACEDETAIL_BEHAVIORSLIPSTREAMTYPEID]
GO
