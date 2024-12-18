CREATE PROCEDURE [dbo].[GTS_RaceDetail_Insert]
	@RaceHeaderId				BIGINT,
	@DamageType					NVARCHAR(32),			
	@SlipstreamType				NVARCHAR(32),				
	@BoostLevel					NVARCHAR(4000),	
	@LowMuType					NVARCHAR(32),	
	@EntryMax					BIGINT,	
	@StartType					NVARCHAR(32),	
	@ConsumeFuel				BIGINT,		
	@ConsumeTire				BIGINT,		
	@RaceLimit					BIGINT,		
	@RaceLimitTypeId			BIGINT,			
	@PitConstraint				BIGINT,		
	@NeedCompoundUse			NVARCHAR(4000),			
	@LimitFuelCapacity			BIGINT,			
	@LimitTireF					BIGINT,	
	@NeedTireF					BIGINT,	
	@UseBOP						BIGINT,
	@Tuning						BIGINT,
	@NeedDriverClass			NVARCHAR(4000),			
	@Cars						NVARCHAR(4000),
	@CarsCount					BIGINT,	
	@RefuelingSpeed				BIGINT,		
	@CourseCode					NVARCHAR(32),	
	@WeatherId					BIGINT,
	@BoardId					BIGINT
AS
	UPDATE [dbo].[GTS_RaceHeader] SET [BoardId] = @BoardId WHERE [RaceHeaderId] = @RaceHeaderId

	EXEC [dbo].[GTS_RaceDetail_Initialize] @DamageType, @SlipstreamType, @LowMuType, @StartType, @CourseCode, @WeatherId

	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_RaceDetail] WHERE [RaceHeaderId] = @RaceHeaderId)
		BEGIN
			INSERT INTO [dbo].[GTS_RaceDetail] ([RaceHeaderId], [DamageTypeId], [SlipstreamTypeId], [BoostLevel], [LowMuTypeId], [EntryMax], [StartTypeId], [ConsumeFuel], [ConsumeTire], [RaceLimit], [RaceLimitTypeId], [PitConstraint], [NeedCompoundUse], [LimitFuelCapacity], [LimitTireF], [NeedTireF], [UseBOP], [Tuning], [NeedDriverClass], [Cars], [CarsCount], [RefuelingSpeed], [TrackId], [WeatherId])
			VALUES (@RaceHeaderId,
			(SELECT [Id] FROM [dbo].[GTS_DamageTypes] WHERE [DamageType] = @DamageType),
			(SELECT [Id] FROM [dbo].[GTS_SlipStreamTypes] WHERE [SlipStreamType] = @SlipstreamType),
			@BoostLevel,
			(SELECT [Id] FROM [dbo].[GTS_LowMuTypes] WHERE [LowMuType] = @LowMuType),
			@EntryMax,
			(SELECT [Id] FROM [dbo].[GTS_StartTypes] WHERE [StartType] = @StartType),
			@ConsumeFuel, 
			@ConsumeTire, 
			@RaceLimit, 
			@RaceLimitTypeId, 
			@PitConstraint, 
			@NeedCompoundUse, 
			@LimitFuelCapacity, 
			@LimitTireF, 
			@NeedTireF, 
			@UseBOP, 
			@Tuning, 
			@NeedDriverClass, 
			@Cars,
			@CarsCount, 
			@RefuelingSpeed, 
			(SELECT [Id] FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode),
			(SELECT [Id] FROM [dbo].[GTS_TrackWeather] WHERE [Code] = @WeatherId))
		END

	SELECT [RaceDetailId] FROM [dbo].[GTS_RaceDetail] WHERE [RaceHeaderId] = @RaceHeaderId

GO
