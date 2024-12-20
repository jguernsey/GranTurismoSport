
CREATE PROCEDURE [dbo].[GTS_EventDetails_Insert]
	@RegionId					BIGINT,	
	@EventId					BIGINT,	
	@ChampionshipId				BIGINT,		
	@SeasonId					BIGINT,	
	@RoundId					BIGINT,	
	@ChampionshipColor			NVARCHAR(8),			
	@GameMode					NVARCHAR(4000),	
	@EventType					NVARCHAR(4000),	
	@SportsMode					NVARCHAR(4000),	
	@Title						NVARCHAR(4000),
	@OneLineTitle				NVARCHAR(4000),		
	@Description				NVARCHAR(300),		
	@RegistrationNotice			NVARCHAR(4000),			
	@EventTarget				NVARCHAR(4000),		
	@EventRestrict				NVARCHAR(4000),		
	@LogoImagePath				NVARCHAR(4000),		
	@FlyerImagePath				NVARCHAR(4000),		
	@BehaviorDamageType			NVARCHAR(4000),			
	@BehaviorSlipStreamType		NVARCHAR(4000),				
	@BoostLevel					NVARCHAR(4000),	
	@LowMuType					NVARCHAR(4000),	
	@EntryMax					BIGINT,	
	@StartType					NVARCHAR(4000),	
	@ConsumeFuel				BIGINT,		
	@ConsumeTire				BIGINT,		
	@RaceLimitLaps				BIGINT,		
	@RaceLimitMinutes			BIGINT,			
	@PitConstraint				BIGINT,		
	@NeedCompoundUse			NVARCHAR(4000),			
	@LimitFuelCapacity			BIGINT,			
	@BoardId					BIGINT,	
	@LimitTireF					BIGINT,	
	@NeedTireF					BIGINT,	
	@UseBOP						BIGINT,
	@Tuning						BIGINT,
	@NeedDriverClass			NVARCHAR(4000),			
	@CarCategoryTypes			NVARCHAR(4000),			
	@Cars						NVARCHAR(4000),
	@CarsCount					BIGINT,	
	@RefuelingSpeed				BIGINT,		
	@CourseCode					NVARCHAR(32),	
	@WeatherId					BIGINT	
AS
	DECLARE @StartDate DATETIME
	SET @StartDate = (SELECT DATEADD(HH,1,CONVERT(DATETIME,CONVERT(VARCHAR(10),GETDATE(),101))))

	DECLARE @CurrentHour INT
	SET @CurrentHour = (SELECT DATEPART(HOUR,GETDATE()))

	IF @CurrentHour = 0
		BEGIN
			SET @StartDate = (SELECT DATEADD(DAY,-1,@StartDate))
		END
	DECLARE @ChannelId BIGINT
	SET @ChannelId = (SELECT TOP(1) [ChannelId] FROM [dbo].[GTS_EventHeader] WHERE [EventId] = @EventId AND [RegionId] = @RegionId)

	DECLARE @ActiveStart DATETIME
	DECLARE @ActiveEnd DATETIME
	SELECT @ActiveStart = [StartTime], @ActiveEnd = [EndTime] FROM [dbo].[fn_GTS_GetEventTimes](@ChannelId, @EventId, @RegionId)

	EXEC [dbo].[GTS_EventDetail_Initialize] @ChampionshipColor, @GameMode, @EventType, @SportsMode, @Title, @OneLineTitle, @Description, @EventTarget, @LogoImagePath, @FlyerImagePath, @BehaviorDamageType, @BehaviorSlipStreamType, @LowMuType, @StartType, @CarCategoryTypes, @CourseCode,@WeatherId

	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_EventDetail] WHERE [EventId] = @EventId) AND NOT EXISTS(SELECT 1 FROM [dbo].[GTS_EventsBlocked] WHERE [EventId] = @EventId) --C01 GD 2018-04-01 block certain events from being inserted
		BEGIN
			INSERT INTO [dbo].[GTS_EventDetail] ([RegionId], [EventId], [ChampionshipId], [SeasonId], [RoundId], [ChampionshipColorId], [GameModeId], [EventTypeId], [SportsModeId],
			 [TitleId], [OneLineTitle], [DescriptionId], [RegistrationNotice], [EventTargetId], [EventRestrict], [LogoImagePathId], 
			 [FlyerImagePathId], [BehaviorDamageTypeId], [BehaviorSlipStreamTypeId], [BoostLevel], [LowMuTypeId], [EntryMax], [StartTypeId], 
			 [ConsumeFuel], [ConsumeTire], [RaceLimitLaps], [RaceLimitMinutes], [PitConstraint], [NeedCompoundUse], [LimitFuelCapacity], 
			 [BoardId], [LimitTireF], [NeedTireF], [UseBOP], [Tuning], [NeedDriverClass], [CarCategoryId], [Cars], [CarsCount], [RefuelingSpeed], 
			 [CourseId], [WeatherId], [DateEntered], [ActiveStart], [ActiveEnd])
			VALUES (@RegionId, @EventId, @ChampionshipId, @SeasonId, @RoundId, 
			(SELECT [Id] FROM [dbo].[GTS_ChampionshipColors] WHERE [ChampionshipColor] = @ChampionshipColor),
			(SELECT [Id] FROM [dbo].[GTS_GameModes] WHERE [GameMode] = @GameMode),
			(SELECT [Id] FROM [dbo].[GTS_EventTypes] WHERE [EventType] = @EventType), 
			(SELECT [Id] FROM [dbo].[GTS_SportsModes] WHERE [SportsMode] = @SportsMode),
			(SELECT [Id] FROM [dbo].[GTS_Titles] WHERE [Title] = @Title), 
			(SELECT [Id] FROM [dbo].[GTS_OneLineTitles] WHERE [OneLineTitle] = @OneLineTitle),
			(SELECT [Id] FROM [dbo].[GTS_Descriptions] WHERE [Description] = @Description),
			@RegistrationNotice, 
			(SELECT [Id] FROM [dbo].[GTS_EventTargets] WHERE [EventTarget] = @EventTarget),
			@EventRestrict, 
			(SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @LogoImagePath),
			(SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @FlyerImagePath),
			(SELECT [Id] FROM [dbo].[GTS_DamageTypes] WHERE [DamageType] = @BehaviorDamageType),
			(SELECT [Id] FROM [dbo].[GTS_SlipStreamTypes] WHERE [SlipStreamType] = @BehaviorSlipStreamType),
			@BoostLevel,
			(SELECT [Id] FROM [dbo].[GTS_LowMuTypes] WHERE [LowMuType] = @LowMuType),
			@EntryMax,
			(SELECT [Id] FROM [dbo].[GTS_StartTypes] WHERE [StartType] = @StartType),
			@ConsumeFuel, 
			@ConsumeTire, 
			@RaceLimitLaps, 
			@RaceLimitMinutes, 
			@PitConstraint, 
			@NeedCompoundUse, 
			@LimitFuelCapacity, 
			@BoardId, 
			@LimitTireF, 
			@NeedTireF, 
			@UseBOP, 
			@Tuning, 
			@NeedDriverClass, 
			(SELECT [CategoryId] FROM [dbo].[GTS_CarCategories] WHERE [CategoryName] = @CarCategoryTypes),
			@Cars,
			@CarsCount, 
			@RefuelingSpeed, 
			(SELECT [Id] FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode),
			COALESCE((SELECT [Id] FROM [dbo].[GTS_TrackWeather] WHERE [Code] = @WeatherId AND [TrackId] = (SELECT [Id] FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode)), 0),
			@StartDate,
			@ActiveStart,
			@ActiveEnd)
		END

GO
