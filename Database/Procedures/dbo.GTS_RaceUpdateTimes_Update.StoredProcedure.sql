CREATE PROCEDURE [dbo].[GTS_RaceUpdateTimes_Update]
	@BoardId			BIGINT
AS
	DECLARE @Entries BIGINT
	DECLARE @UpdateDate DATETIME

	SET @Entries = (SELECT COUNT([RankingId]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId)
	SET @UpdateDate = GETDATE()

	INSERT INTO [dbo].[GTS_RaceUpdateTimes] ([BoardId], [Entries], [UpdateTime])
	VALUES (@BoardId, @Entries, @UpdateDate)

GO
