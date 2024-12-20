CREATE PROCEDURE [dbo].[GTS_RaceCalendarUpdates_Update]
	@RegionId				BIGINT,
	@ChannelId				BIGINT,
	@LastUpdate				DATETIME
AS
	UPDATE		[dbo].[GTS_RaceCalendarUpdates]

	SET			[LastUpdate]				=			@LastUpdate

	WHERE		[RegionId]					=			@RegionId
		AND		[ChannelId]					=			@ChannelId

	IF @@ROWCOUNT = 0
		BEGIN
			INSERT INTO [dbo].[GTS_RaceCalendarUpdates] ([RegionId], [ChannelId], [LastUpdate])
			VALUES (@RegionId, @ChannelId, @LastUpdate)
		END

GO
