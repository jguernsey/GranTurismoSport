
CREATE PROCEDURE [dbo].[GTS_EventDetail_Initialize]
	@ChampionshipColor			NVARCHAR(8),
	@GameMode					NVARCHAR(4000),
	@EventType					NVARCHAR(4000),
	@SportsMode					NVARCHAR(4000),
	@Title						NVARCHAR(4000),
	@OneLineTitle				NVARCHAR(4000),
	@Description				NVARCHAR(4000),
	@EventTarget				NVARCHAR(4000),
	@LogoImagePath				NVARCHAR(4000),
	@FlyerImagePath				NVARCHAR(4000),
	@BehaviorDamageType			NVARCHAR(4000),
	@BehaviorSlipStreamType		NVARCHAR(4000),
	@LowMuType					NVARCHAR(4000),
	@StartType					NVARCHAR(4000),
	@CarCategoryTypes			NVARCHAR(4000),
	@CourseCode					NVARCHAR(4000),
	@WeatherId					BIGINT
AS
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_ChampionshipColors] WHERE [ChampionshipColor] = @ChampionshipColor)
		BEGIN
			INSERT INTO [dbo].[GTS_ChampionshipColors] ([ChampionshipColor]) VALUES (@ChampionshipColor)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_GameModes] WHERE [GameMode] = @GameMode)
		BEGIN
			INSERT INTO [dbo].[GTS_GameModes] ([GameMode]) VALUES (@GameMode)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_EventTypes] WHERE [EventType] = @EventType)
		BEGIN
			INSERT INTO [dbo].[GTS_EventTypes] ([EventType]) VALUES (@EventType)
		END 
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_SportsModes] WHERE [SportsMode] = @SportsMode)
		BEGIN
			INSERT INTO [dbo].[GTS_SportsModes] ([SportsMode]) VALUES (@SportsMode)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_Titles] WHERE [Title] = @Title)
		BEGIN
			INSERT INTO [dbo].[GTS_Titles] ([Title]) VALUES (@Title)
		END 
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_OneLineTitles] WHERE [OneLineTitle] = @OneLineTitle)
		BEGIN
			INSERT INTO [dbo].[GTS_OneLineTitles] ([OneLineTitle]) VALUES (@OneLineTitle)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_Descriptions] WHERE [Description] = @Description)
		BEGIN
			INSERT INTO [dbo].[GTS_Descriptions] ([Description]) VALUES (@Description)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_EventTargets] WHERE [EventTarget] = @EventTarget)
		BEGIN
			INSERT INTO [dbo].[GTS_EventTargets] ([EventTarget]) VALUES (@EventTarget)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @LogoImagePath)
		BEGIN
			INSERT INTO [dbo].[GTS_ImagePaths] ([Path]) VALUES (@LogoImagePath)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_ImagePaths] WHERE [Path] = @FlyerImagePath)
		BEGIN
			INSERT INTO [dbo].[GTS_ImagePaths] ([Path]) VALUES (@FlyerImagePath)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_DamageTypes] WHERE [DamageType] = @BehaviorDamageType)
		BEGIN
			INSERT INTO [dbo].[GTS_DamageTypes] ([DamageType]) VALUES (@BehaviorDamageType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_SlipStreamTypes] WHERE [SlipStreamType] = @BehaviorSlipStreamType)
		BEGIN
			INSERT INTO [dbo].[GTS_SlipStreamTypes] ([SlipStreamType]) VALUES (@BehaviorSlipStreamType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_LowMuTypes] WHERE [LowMuType] = @LowMuType)
		BEGIN
			INSERT INTO [dbo].[GTS_LowMuTypes] ([LowMuType]) VALUES (@LowMuType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_StartTypes] WHERE [StartType] = @StartType)
		BEGIN
			INSERT INTO [dbo].[GTS_StartTypes] ([StartType]) VALUES (@StartType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_CarCategories] WHERE [CategoryName] = @CarCategoryTypes)
		BEGIN
			INSERT INTO [dbo].[GTS_CarCategories] ([CategoryName]) VALUES (@CarCategoryTypes)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode)
		BEGIN
			INSERT INTO [dbo].[GTS_Tracks] ([Name], [Code], [CountryCode], [CountryTag], [Tag], [Length]) VALUES ('', @CourseCode, '', 0, 0, 0)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_TrackWeather] WHERE [Code] = @WeatherId)
		BEGIN
			INSERT INTO [dbo].[GTS_TrackWeather] ([TrackId], [Code], [TimeId], [TypeId], [IsDefault]) VALUES (1, @WeatherId, 1, 1, 'false')
		END


GO
