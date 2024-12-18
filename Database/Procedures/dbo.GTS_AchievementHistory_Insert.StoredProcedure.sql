

CREATE PROCEDURE [dbo].[GTS_AchievementHistory_Insert]
	@ProfileId				BIGINT,
	@PlayTime				BIGINT,
	@DistanceDriven			BIGINT,
	@TimeDriven				BIGINT,
	@FuelConsumed			BIGINT,
	@DriftPoints			BIGINT,
	@PrizeCredits			BIGINT,
	@MileagePointsEarned	BIGINT,
	@MileagePointsUsed		BIGINT,
	@CarsPurchased			BIGINT,
	@ValueofCarsPurchased	BIGINT,
	@CleanRaces				BIGINT,
	@PolePositions			BIGINT,
	@FastestLaps			BIGINT,
	@RacesFinished			BIGINT,
	@Wins					BIGINT,
	@PhotosTaken			BIGINT,
	@LiveryCreated			BIGINT,
	@PhotoLikes				BIGINT,
	@LiveryLikes			BIGINT,
	@DaysLoggedIn			BIGINT
AS
	BEGIN
		UPDATE		[dbo].[GTS_AchievementHistory]
		SET			[PlayTime]					=		@PlayTime,
					[DistanceDriven]			=		@DistanceDriven,
					[TimeDriven]				=		@TimeDriven,
					[FuelConsumed]				=		@FuelConsumed,
					[DriftPoints]				=		@DriftPoints,
					[PrizeCredits]				=		@PrizeCredits,
					[MileagePointsEarned]		=		@MileagePointsEarned,
					[MileagePointsUsed]			=		@MileagePointsUsed,
					[CarsPurchased]				=		@CarsPurchased,
					[ValueofCarsPurchased]		=		@ValueofCarsPurchased,
					[CleanRaces]				=		@CleanRaces,
					[PolePositions]				=		@PolePositions,
					[FastestLaps]				=		@FastestLaps,
					[RacesFinished]				=		@RacesFinished,
					[Wins]						=		@Wins,
					[PhotosTaken]				=		@PhotosTaken,
					[LiveryCreated]				=		@LiveryCreated,
					[PhotoLikes]				=		@PhotoLikes,
					[LiveryLikes]				=		@LiveryLikes,
					[DaysLoggedIn]				=		@DaysLoggedIn,
					[EntryDate]					=		GETDATE()
		WHERE		[ProfileId]					=		@ProfileId

		IF @@ROWCOUNT = 0
			BEGIN
				INSERT INTO [dbo].[GTS_AchievementHistory] ([ProfileId], [PlayTime], [DistanceDriven], [TimeDriven], [FuelConsumed], [DriftPoints], [PrizeCredits], [MileagePointsEarned], [MileagePointsUsed], [CarsPurchased], [ValueofCarsPurchased], [CleanRaces], [PolePositions], [FastestLaps], [RacesFinished], [Wins], [DaysLoggedIn], [EntryDate], [PhotosTaken], [LiveryCreated], [PhotoLikes], [LiveryLikes])
				VALUES (@ProfileId, @PlayTime, @DistanceDriven, @TimeDriven, @FuelConsumed, @DriftPoints, @PrizeCredits, @MileagePointsEarned, @MileagePointsUsed, @CarsPurchased, @ValueofCarsPurchased, @CleanRaces, @PolePositions, @FastestLaps, @RacesFinished, @Wins, @DaysLoggedIn, GETDATE(), @PhotosTaken, @LiveryCreated, @PhotoLikes, @LiveryLikes)
			END
	END

GO
