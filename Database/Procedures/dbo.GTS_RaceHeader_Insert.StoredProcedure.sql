
CREATE PROCEDURE [dbo].[GTS_RaceHeader_Insert]
	@ChannelId			BIGINT,
	@RegionId			BIGINT,
	@EventId			BIGINT
AS
	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_RaceHeader] WHERE [ChannelId] = @ChannelId AND [RegionId] = @RegionId AND [EventId] = @EventId)
		BEGIN
			INSERT INTO [dbo].[GTS_RaceHeader] ([ChannelId], [RegionId], [EventId], [BoardId], [StartDate], [EndDate])
			VALUES (@ChannelId, @RegionId, @EventId, 0, '1753-01-01', '1753-01-01')
		END

	SELECT [RaceHeaderId] FROM [dbo].[GTS_RaceHeader] WHERE [ChannelId] = @ChannelId AND [RegionId] = @RegionId AND [EventId] = @EventId

GO
