
CREATE PROCEDURE [dbo].[GTS_RaceRankings_SelectUserInfo]
	@UserId			NVARCHAR(32),
	@BoardId		BIGINT
AS
	IF EXISTS(SELECT 1 FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId AND [UserId] = @UserId)
		BEGIN
			DECLARE @TotalCount BIGINT
			SET @TotalCount = (SELECT COUNT([RankingId]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId)

			DECLARE @UserRank BIGINT
			SET @UserRank = (SELECT [Rank] FROM (SELECT ROW_NUMBER() OVER(ORDER BY [Score]) AS [Rank], [UserId], [CountryName], [Score] FROM [dbo].[GTS_RaceRankings] rr JOIN [dbo].[GTS_Countries] c ON rr.[CountryId] = c.[CountryId] WHERE [BoardId] = @BoardId) T1 WHERE [UserId] = @UserId)

			DECLARE @UserScore BIGINT
			SET @UserScore = (SELECT [Score] FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId AND [UserId] = @UserId)

			DECLARE @NextScore BIGINT
			IF @UserRank = 1
				BEGIN
					SET @NextScore = 0
				END
			ELSE
				BEGIN
					SET @NextScore = (SELECT TOP(1) [Score] FROM (SELECT ROW_NUMBER() OVER(ORDER BY [Score]) AS [Rank], [Score] FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId) T1 WHERE [Rank] < @UserRank AND [Score] < @UserScore ORDER BY [Score] DESC)
				END

			DECLARE @LowestScore BIGINT
			SET @LowestScore = (SELECT MIN([Score]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] = @BoardId)

			SELECT		COALESCE(@UserRank,0)								AS		[Rank],
						COALESCE(@TotalCount,0)								AS		[TotalEntries],
						COALESCE(@UserId,'')								AS		[UserId],
						''													AS		[CountryName],
						COALESCE(@UserScore,0)								AS		[Score],
						COALESCE(@UserScore,0) - COALESCE(@LowestScore,0)	AS		[Gap],
						COALESCE(@UserScore,0) - COALESCE(@NextScore,0)		AS		[RegionNext]
		END
	ELSE
		BEGIN
			SELECT 0, 0, '', '', 0, 0, 0
		END


GO
