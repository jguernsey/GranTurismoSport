CREATE PROCEDURE [dbo].[GTS_RaceRankings_SelectWorldWideUser]
	@BoardId					BIGINT,
	@UserId						NVARCHAR(32)
AS
	IF EXISTS (SELECT 1 FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId AND [UserId] = @UserId)
		BEGIN
			DECLARE @Title NVARCHAR(32)
			SET @Title = 
			(
				SELECT		t.[Title]
				FROM		[dbo].[GTS_EventDetail]			ed
				JOIN		[dbo].[GTS_Titles]				t
					ON		ed.[TitleId]			=		t.[Id]
				WHERE		ed.BoardId				=		@BoardId
			)
	
			DECLARE @TotalEntries BIGINT
			SET @TotalEntries = (SELECT COUNT([RankingId]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] IN (SELECT [BoardId] FROM [dbo].[fn_GTS_GetBoardIdsByTitle](@Title)))
	
			DECLARE @UserRank BIGINT
			SET @UserRank = (SELECT [Rank] FROM (SELECT ROW_NUMBER() OVER(ORDER BY [Score]) AS [Rank], [UserId] FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] IN (SELECT [BoardId] FROM [dbo].[fn_GTS_GetBoardIdsByTitle](@Title))) T1 WHERE [UserId] = @UserId)

			DECLARE @UserScore BIGINT
			SET @UserScore = (SELECT [Score] FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId AND [UserId] = @UserId)

			DECLARE @NextScore BIGINT
			IF @UserRank = 1
				BEGIN
					SET @NextScore = 0
				END
			ELSE
				BEGIN
					SET @NextScore = (SELECT TOP(1) [Score] FROM (SELECT ROW_NUMBER() OVER(ORDER BY [Score]) AS [Rank], [Score] FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] IN (SELECT [BoardId] FROM [dbo].[fn_GTS_GetBoardIdsByTitle](@Title))) T1 WHERE [Rank] < @UserRank AND [Score] < @UserScore ORDER BY [Score] DESC)
				END

			DECLARE @LowestScore BIGINT
			SET @LowestScore = (SELECT MIN([Score]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] IN (SELECT [BoardId] FROM [dbo].[fn_GTS_GetBoardIdsByTitle](@Title)))

			SELECT  @UserRank						AS	[Rank],
					@TotalEntries					AS	[TotalEntries],
					@UserId							AS	[UserId],
					''								AS	[CountryName],
					@UserScore						AS	[Score],
					@UserScore - @LowestScore		AS	[Gap],
					@UserScore - @NextScore			AS	[WorldNext]
		END
	ELSE
		BEGIN
			SELECT 0, 0, '', '', 0, 0, 0, 0
		END


GO
