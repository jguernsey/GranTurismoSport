CREATE PROCEDURE [dbo].[GTS_InitializeSeasons]
	@Logo			NVARCHAR(32),
	@Flyer			NVARCHAR(32),
	@Color			NVARCHAR(8)
AS
	BEGIN
		IF NOT EXISTS (SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @Logo)
			BEGIN
				INSERT INTO [dbo].[GTS_ImagePaths] ([Path])
				VALUES (@Logo)
			END
		IF NOT  EXISTS (SELECT [Id] FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @Flyer)
			BEGIN
				INSERT INTO [dbo].[GTS_ImagePaths] ([Path])
				VALUES (@Flyer)
			END
		IF NOT EXISTS (SELECT [Id] FROM [dbo].[GTS_ChampionshipColors] WHERE [ChampionshipColor] = @Color)
			BEGIN
				INSERT INTO [dbo].[GTS_ChampionshipColors] ([ChampionshipColor])
				VALUES (@Color)
			END
	END

GO
