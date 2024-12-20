CREATE PROCEDURE [dbo].[GTS_ProfileStats_Insert]
	@ProfileId				BIGINT,
	@ManufacturerId			BIGINT,
	@PurchasedCars			BIGINT,
	@CarCount				BIGINT,
	@CreditEarned			BIGINT,
	@Level					BIGINT,
	@LevelProgress			BIGINT,
	@LoginCount				BIGINT,
	@MileageEarned			BIGINT,
	@TotalRunningMeter		BIGINT,
	@Experience				BIGINT,
	@DriverClass			BIGINT,
	@DriverPoint			BIGINT,
	@MannerPoint			BIGINT,
	@RaceCount				BIGINT,
	@DriverPointUpRate		BIGINT
AS
	BEGIN
		UPDATE		[dbo].[GTS_ProfileStats]
		SET			[ManufacturerId]		=	@ManufacturerId,
					[PurchasedCars]			=	@PurchasedCars,
					[CarCount]				=	@CarCount,
					[CreditEarned]			=	@CreditEarned,
					[Level]					=	@Level,
					[LevelProgress]			=	@LevelProgress,
					[LoginCount]			=	@LoginCount,
					[MileageEarned]			=	@MileageEarned,
					[TotalRunningMeter]		=	@TotalRunningMeter,
					[Experience]			=	(@Experience + COALESCE((SELECT [TotalPoints] FROM [dbo].[GTS_ExperiencePoints] ep WHERE ep.[Level] = @Level), 0)),
					[DriverClass]			=	@DriverClass,
					[DriverPoint]			=	@DriverPoint,
					[MannerPoint]			=	@MannerPoint,
					[RaceCount]				=	@RaceCount,
					[DriverPointUpRate]		=	@DriverPointUpRate,
					[EntryDate]				=	GETDATE()
		WHERE		[ProfileId]				=	@ProfileId

		IF @@ROWCOUNT = 0
			BEGIN
				INSERT INTO [dbo].[GTS_ProfileStats] ([ProfileId], [ManufacturerId], [PurchasedCars], [CarCount], [CreditEarned], [Level], [LevelProgress], [LoginCount], [MileageEarned], [TotalRunningMeter], [Experience], [DriverClass], [DriverPoint], [MannerPoint], [RaceCount], [DriverPointUpRate], [EntryDate])
				VALUES (@ProfileId, @ManufacturerId, @PurchasedCars, @CarCount, @CreditEarned, @Level, @LevelProgress, @LoginCount, @MileageEarned, @TotalRunningMeter, (@Experience + COALESCE((SELECT [TotalPoints] FROM [dbo].[GTS_ExperiencePoints] ep WHERE ep.[Level] = @Level), 0)), @DriverClass, @DriverPoint, @MannerPoint, @RaceCount, @DriverPointUpRate, GETDATE())
			END
	END

GO
