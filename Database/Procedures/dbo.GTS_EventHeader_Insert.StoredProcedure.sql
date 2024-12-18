
CREATE PROCEDURE [dbo].[GTS_EventHeader_Insert]
	@EventCalendarId	BIGINT,
	@RegionId			BIGINT,
	@ChannelId			BIGINT,
	@StartTime			DATETIME,
	@EndTime			DATETIME,
	@EventId			BIGINT
AS
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_EventHeader] WHERE [EventCalendarId] = @EventCalendarId)
			BEGIN
				INSERT INTO	[dbo].[GTS_EventHeader]	([EventCalendarId], [RegionId], [ChannelId], [StartTime], [EndTime], [EventId])
				VALUES (@EventCalendarId, @RegionId, @ChannelId, @StartTime, @EndTime, @EventId)
			END
	END

GO
