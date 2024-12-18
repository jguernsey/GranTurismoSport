CREATE PROCEDURE [dbo].[GTS_RaceRankings_InsertUpdate]
	@BoardId		BIGINT,
	@UserId			NVARCHAR(32),
	@CreateTime		DATETIME,
	@Score			BIGINT,
	@Country		NVARCHAR(32)
AS
	UPDATE		[dbo].[GTS_RaceRankings]
	SET			[CreateTime]		=		@CreateTime,
				[Score]				=		@Score

	WHERE		[BoardId]			=		@BoardId
		AND		[UserId]			=		@UserId

	IF @@ROWCOUNT = 0
		BEGIN
			INSERT INTO [dbo].[GTS_RaceRankings] ([BoardId], [UserId], [CreateTime], [Score], [CountryId])
			VALUES (@BoardId, @UserId, @CreateTime, @Score, (SELECT [CountryId] FROM [dbo].[GTS_Countries] WHERE [CountryCode] = @Country))
		END
GO
