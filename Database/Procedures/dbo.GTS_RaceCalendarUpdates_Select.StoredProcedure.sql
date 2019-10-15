
CREATE PROCEDURE [dbo].[GTS_RaceCalendarUpdates_Select]
	@RegionId				BIGINT
AS
	SELECT	[ChannelId], [LastUpdate]

	FROM	[dbo].[GTS_RaceCalendarUpdates]
	
	WHERE	[RegionId]						=			@RegionId

GO
