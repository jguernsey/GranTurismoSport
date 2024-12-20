CREATE PROCEDURE [dbo].[GTS_SeasonRounds_Insert]
	@SeasonId			BIGINT,
	@RoundId			BIGINT,
	@StartDate			DATETIME,
	@EndDate			DATETIME,
	@EventId			BIGINT
AS
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_SeasonRounds] WHERE [SeasonId] = @SeasonId AND [RoundId] =  @RoundId AND [EventId] = @EventId AND [FirstRaceStart] = @StartDate AND [LastRaceEnd] = @EndDate)
			BEGIN
				INSERT INTO [dbo].[GTS_SeasonRounds] ([SeasonId], [RoundId], [FirstRaceStart], [LastRaceEnd], [EventId], [DateCreated])
				VALUES (@SeasonId, @RoundId, @StartDate, @EndDate, @EventId, GETDATE())
			END
	END

GO
