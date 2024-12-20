
CREATE PROCEDURE [dbo].[GTS_ManufacturerResults_InsertUpdate]
	@SeasonId			BIGINT,
	@ProfileId			BIGINT,
	@DriverClass		BIGINT,
	@MannerPoint		BIGINT,
	@WorldRank			BIGINT,
	@ManufacturerRank	BIGINT,
	@TotalPoints		BIGINT,
	@ManufacturerId		BIGINT
AS
	BEGIN
		UPDATE	[dbo].[GTS_ManufacturerResults]
		
		SET		[DriverClass]			=		@DriverClass,
				[MannerPoint]			=		@MannerPoint,
				[WorldRank]				=		@WorldRank,
				[ManufacturerRank]		=		@ManufacturerRank,
				[TotalPoints]			=		@TotalPoints,
				[ManufacturerId]		=		@ManufacturerId

		WHERE	[SeasonId]				=		@SeasonId
			AND	[ProfileId]				=		@ProfileId


		IF @@ROWCOUNT = 0
			BEGIN
				INSERT INTO [dbo].[GTS_ManufacturerResults] ([SeasonId], [ProfileId], [DriverClass], [MannerPoint], [WorldRank], [ManufacturerRank], [TotalPoints], [ManufacturerId])
				VALUES (@SeasonId, @ProfileId, @DriverClass, @MannerPoint, @WorldRank, @ManufacturerRank, @TotalPoints, @ManufacturerId)
			END

		SELECT [ResultId] FROM [dbo].[GTS_ManufacturerResults] WHERE [SeasonId] = @SeasonId AND [ProfileId] = @ProfileId
	END

GO
