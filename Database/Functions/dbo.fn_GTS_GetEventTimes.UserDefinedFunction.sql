
 CREATE FUNCTION [dbo].[fn_GTS_GetEventTimes]
(
	@ChannelId		BIGINT,
	@EventId		BIGINT,
	@RegionId		BIGINT
)
RETURNS @EventTimes TABLE
(
	[StartTime]	DATETIME	NOT NULL,
	[EndTime]	DATETIME	NOT NULL
)
AS
	BEGIN
		IF @ChannelId <= 3
			BEGIN
				INSERT INTO @EventTimes ([StartTime], [EndTime])
				SELECT COALESCE(MIN([StartTime]),'1753-01-01'), COALESCE(MAX([EndTime]),'1753-01-01') 
				FROM [dbo].[GTS_EventHeader] WHERE [EventId] = @EventId
			END
		ELSE
			BEGIN
				DECLARE @CurrentStart	DATETIME
				DECLARE @CurrentEnd		DATETIME
				DECLARE @LastEnd		DATETIME
				
				SET @CurrentStart	=	(SELECT MIN([StartTime]) FROM [dbo].[GTS_EventHeader] WHERE [EventId] = @EventId)
				SET @CurrentEnd		=	(SELECT [EndTime] FROM [dbo].[GTS_EventHeader] WHERE [EventId] = @EventId AND [RegionId] = @RegionId AND [StartTime] = @CurrentStart)
				SET @LastEnd		=	(SELECT TOP(1) COALESCE([EndTime],'1753-01-01') FROM [dbo].[GTS_EventHeader] WHERE [EndTime] < @CurrentEnd AND [EventId] != @EventId AND [ChannelId] = @ChannelId AND [RegionId] = @RegionId ORDER BY [EndTime] DESC)
				INSERT INTO @EventTimes ([StartTime], [EndTime])
				VALUES (DATEADD(SECOND,1,@LastEnd), (SELECT COALESCE(MAX([EndTime]),'1753-01-01') FROM [dbo].[GTS_EventHeader] WHERE [EventId] = @EventId))
			END
	RETURN
	END

GO
