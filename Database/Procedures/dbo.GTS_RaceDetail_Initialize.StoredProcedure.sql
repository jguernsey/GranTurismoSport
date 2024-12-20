CREATE PROCEDURE [dbo].[GTS_RaceDetail_Initialize]
	@DamageType					NVARCHAR(32),
	@SlipStreamType				NVARCHAR(32),
	@LowMuType					NVARCHAR(32),
	@StartType					NVARCHAR(32),
	@CourseCode					NVARCHAR(32),
	@WeatherId					BIGINT
AS
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_DamageTypes] WHERE [DamageType] = @DamageType)
		BEGIN
			INSERT INTO [dbo].[GTS_DamageTypes] ([DamageType]) VALUES (@DamageType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_SlipStreamTypes] WHERE [SlipStreamType] = @SlipstreamType)
		BEGIN
			INSERT INTO [dbo].[GTS_SlipStreamTypes] ([SlipStreamType]) VALUES (@SlipstreamType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_LowMuTypes] WHERE [LowMuType] = @LowMuType)
		BEGIN
			INSERT INTO [dbo].[GTS_LowMuTypes] ([LowMuType]) VALUES (@LowMuType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_StartTypes] WHERE [StartType] = @StartType)
		BEGIN
			INSERT INTO [dbo].[GTS_StartTypes] ([StartType]) VALUES (@StartType)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode)
		BEGIN
			INSERT INTO [dbo].[GTS_Tracks] ([Name], [Code], [CountryCode], [CountryTag], [Tag], [Length]) VALUES ('', @CourseCode, '', 0, 0, 0)
		END
	IF NOT EXISTS (SELECT 1 FROM [dbo].[GTS_TrackWeather] WHERE [Code] = @WeatherId AND [TrackId] = (SELECT [Id] FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode))
		BEGIN
			INSERT INTO [dbo].[GTS_TrackWeather] ([TrackId], [Code], [TimeId], [TypeId], [IsDefault]) VALUES ((SELECT [Id] FROM [dbo].[GTS_Tracks] WHERE [Code] = @CourseCode), @WeatherId, 1, 1, 'false')
		END

GO
