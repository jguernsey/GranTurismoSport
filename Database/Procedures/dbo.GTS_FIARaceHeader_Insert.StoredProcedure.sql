
CREATE PROCEDURE [dbo].[GTS_FIARaceHeader_Insert]
	@CalendarId		BIGINT,
	@RegionId		BIGINT,
	@ChannelId		BIGINT,
	@StartTime		DATETIME,
	@EndTime		DATETIME,
	@EventId		BIGINT
AS
	BEGIN
		UPDATE		[dbo].[GTS_FIARaceHeader]
		SET			[StartTime]				=		@StartTime,
					[EndTime]				=		@EndTime
		WHERE		[CalendarId]			=		@CalendarId
			AND		[RegionId]				=		@RegionId
			AND		[ChannelId]				=		@ChannelId
			AND		[EventId]				=		@EventId

		IF @@ROWCOUNT = 0
			BEGIN
				INSERT INTO [dbo].[GTS_FIARaceHeader] ([CalendarId], [RegionId], [ChannelId], [StartTime], [EndTime], [EventId], [CreateDate])
				VALUES (@CalendarId, @RegionId, @ChannelId, @StartTime, @EndTime, @EventId, GETDATE())
			END
	END
GO
