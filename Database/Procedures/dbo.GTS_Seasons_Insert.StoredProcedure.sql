CREATE PROCEDURE [dbo].[GTS_Seasons_Insert]
	@SeasonId				BIGINT,
	@ChampionshipId			BIGINT,
	@RegionId				BIGINT,
	@RaceCount				BIGINT,
	@Logo					NVARCHAR(32),
	@Flyer					NVARCHAR(32),
	@Color					NVARCHAR(8)
AS
	BEGIN
		EXEC [dbo].[GTS_InitializeSeasons] @Logo, @Flyer, @Color
		
		UPDATE		[dbo].[GTS_Seasons]

		SET			[ChampionshipId]		=		@ChampionshipId,
					[RegionId]				=		@RegionId,
					[RaceCount]				=		@RaceCount,
					[LogoId]				=		(SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @Logo),
					[FlyerId]				=		(SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @Flyer),
					[ColorId]				=		(SELECT [Id] FROM [dbo].[GTS_ChampionshipColors] WHERE [ChampionshipColor] = @Color),
					[DateUpdated]			=		GETDATE()
		WHERE		[SeasonId]				=		@SeasonId

		IF @@ROWCOUNT = 0
			BEGIN
				DECLARE @LogoId BIGINT
				DECLARE @FlyerId BIGINT
				DECLARE @ColorId BIGINT

				SET @LogoId				=		(SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @Logo)
				SET @FlyerId			=		(SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @Flyer)
				SET @ColorId			=		(SELECT [Id] FROM [dbo].[GTS_ChampionshipColors] WHERE [ChampionshipColor] = @Color)

				INSERT INTO [dbo].[GTS_Seasons] ([SeasonId], [ChampionshipId], [RegionId], [RaceCount], [LogoId], [FlyerId], [ColorId], [Processed], [DateCreated], [DateUpdated])
				VALUES (@SeasonId, @ChampionshipId, @RegionId, @RaceCount, @LogoId, @FlyerId, @ColorId, 'N', GETDATE(), '1753-01-01')
			END

		SELECT [Id] FROM [dbo].[GTS_Seasons] WHERE [SeasonId] = @SeasonId AND [RegionId] = @RegionId
	END

GO
