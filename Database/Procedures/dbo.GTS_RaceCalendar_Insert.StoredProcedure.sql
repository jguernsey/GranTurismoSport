CREATE PROCEDURE [dbo].[GTS_RaceCalendar_Insert]
	@EventCalendarId		BIGINT,
	@RegionId				BIGINT,
	@ChannelId				BIGINT,
	@StartTime				DATETIME,
	@EndTime				DATETIME,
	@EventId				BIGINT
AS
	DECLARE @RaceHeaderId BIGINT
	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_RaceHeader] WHERE [ChannelId] = (SELECT [Id] FROM [dbo].[GTS_Channels] WHERE [Code] = @ChannelId) AND [RegionId] = @RegionId AND [EventId] = @EventId)
		BEGIN
			INSERT INTO [dbo].[GTS_RaceHeader] ([ChannelId], [RegionId], [EventId], [BoardId], [StartDate], [EndDate])
			VALUES ((SELECT [Id] FROM [dbo].[GTS_Channels] WHERE [Code] = @ChannelId), @RegionId, @EventId, 0, '1753-01-01', '1753-01-01')
		END
	
	SET @RaceHeaderId = (SELECT [RaceHeaderId] FROM [dbo].[GTS_RaceHeader] WHERE [ChannelId] = (SELECT [Id] FROM [dbo].[GTS_Channels] WHERE [Code] = @ChannelId) AND [RegionId] = @RegionId AND [EventId] = @EventId)

	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_RaceCalendar] WHERE [RaceHeaderId] = @RaceHeaderId AND [EventCalendarId] = @EventCalendarId)
		BEGIN
			INSERT INTO [dbo].[GTS_RaceCalendar] ([RaceHeaderId], [EventCalendarId], [StartTime], [EndTime])
			VALUES (@RaceHeaderId, @EventCalendarId, @StartTime, @EndTime)
		END

GO
