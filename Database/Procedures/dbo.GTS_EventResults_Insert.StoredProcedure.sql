
CREATE PROCEDURE [dbo].[GTS_EventResults_Insert]
	@EventResultId		BIGINT,
	@EventCalendarId	BIGINT,
	@Lap				BIGINT,
	@LeadLap			BIGINT,
	@MannerPoint		BIGINT,
	@ManufacturerId		BIGINT = 0,
	@QualifyRank		BIGINT,
	@Rank				BIGINT,
	@UserNumber			BIGINT
AS
	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_EventResults] WHERE [EventResultId] = @EventResultId AND EventCalendarId = @EventCalendarId AND [UserNumber] = @UserNumber)
		BEGIN
			INSERT INTO [dbo].[GTS_EventResults] ([EventResultId], [EventCalendarId], [Lap], [LeadLap], [MannerPoint], [QualifyRank], [Rank], [UserNumber], [DateEntered])
			VALUES (@EventResultId, @EventCalendarId, @Lap, @LeadLap, @MannerPoint, @QualifyRank, @Rank, @UserNumber, GETDATE())
		END

GO
