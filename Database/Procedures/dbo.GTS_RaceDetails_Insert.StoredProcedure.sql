
CREATE PROCEDURE [dbo].[GTS_RaceDetails_Insert]
	@RaceHeaderId	BIGINT,
	@StartPosition BIGINT
AS
	INSERT INTO [dbo].[GTS_RaceDetails] ([RaceHeaderId], [StartDR], [EndDR], [StartPosition], [EndPosition])
	VALUES (@RaceHeaderId, 0, 0, @StartPosition, 0)


GO
