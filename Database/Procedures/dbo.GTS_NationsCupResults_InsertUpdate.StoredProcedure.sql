
CREATE PROCEDURE [dbo].[GTS_NationsCupResults_InsertUpdate]
	@SeasonId		BIGINT,
	@ProfileId		BIGINT,
	@DriverClass	BIGINT,
	@MannerPoint	BIGINT,
	@WorldRank		BIGINT,
	@CountryRank	BIGINT,
	@TotalPoints	BIGINT
AS
	BEGIN
		UPDATE	[dbo].[GTS_NationsCupResults]
		
		SET		[DriverClass]			=		@DriverClass,
				[MannerPoint]			=		@MannerPoint,
				[WorldRank]				=		@WorldRank,
				[CountryRank]			=		@CountryRank,
				[TotalPoints]			=		@TotalPoints

		WHERE	[SeasonId]				=		@SeasonId
			AND	[ProfileId]				=		@ProfileId


		IF @@ROWCOUNT = 0
			BEGIN
				INSERT INTO [dbo].[GTS_NationsCupResults] ([SeasonId], [ProfileId], [DriverClass], [MannerPoint], [WorldRank], [CountryRank], [TotalPoints])
				VALUES (@SeasonId, @ProfileId, @DriverClass, @MannerPoint, @WorldRank, @CountryRank, @TotalPoints)
			END

		SELECT [ResultId] FROM [dbo].[GTS_NationsCupResults] WHERE [SeasonId] = @SeasonId AND [ProfileId] = @ProfileId
	END

GO
