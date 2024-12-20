CREATE PROCEDURE [dbo].[GTS_RaceRankings_SelectWorldWideTopTen]
	@BoardId					BIGINT
AS
	DECLARE @Title NVARCHAR(32)
	SET @Title = (SELECT t.[Title] FROM [dbo].[GTS_EventDetail] ed JOIN [dbo].[GTS_Titles] t ON ed.[TitleId] = t.[Id] WHERE ed.BoardId = @BoardId)

	SELECT [Rank], [TotalEntries], [UserId], [ImagePath], [Score]
	FROM
	(
		SELECT  ROW_NUMBER() OVER(ORDER BY [Score]) AS [Rank],
		(
			SELECT COUNT([RankingId]) FROM [dbo].[GTS_RaceRankings] WHERE [BoardId] IN 
			(
				SELECT		[BoardId] 
				FROM		[dbo].[GTS_EventDetail]				ed
				JOIN		[dbo].[GTS_Titles]					t
					ON		ed.[TitleId]				=		t.[Id]
				WHERE		t.[Title]					=		@Title
					AND		([ActiveStart]				<=		GETDATE()
					AND		[ActiveEnd]					>		GETDATE()))) AS [TotalEntries],
				[UserId],
				[ImagePath],
				[Score]
		FROM [dbo].[GTS_RaceRankings]			rr
		JOIN	[dbo].[GTS_Countries]			c
			ON	rr.[CountryId]			=		c.[CountryId]
		WHERE	[BoardId]				IN		(
												SELECT		[BoardId] 
												FROM		[dbo].[GTS_EventDetail]				ed
												JOIN		[dbo].[GTS_Titles]					t
													ON		ed.[TitleId]				=		t.[Id]
												WHERE		t.[Title]					=		@Title
														AND		([ActiveStart]				<=		GETDATE()
		AND		[ActiveEnd]					>		GETDATE())
												)
	) T1
	WHERE	[Rank]						<=		25
GO
