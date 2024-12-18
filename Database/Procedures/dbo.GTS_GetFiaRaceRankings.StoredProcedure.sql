
CREATE PROCEDURE [dbo].[GTS_GetFiaRaceRankings]
	@Title				NVARCHAR(32)
AS
	SELECT		[Rank], [UserId], [Score], [ImagePath]
	FROM
	(
		SELECT		ROW_NUMBER() OVER(ORDER BY rr.[Score] ASC, [CreateTime] ASC) AS [Rank],
					[UserId],
					[Score],
					[ImagePath]

		FROM		[dbo].[GTS_RaceRankings]			rr

		JOIN		[dbo].[GTS_EventDetail]				ed
			ON		rr.[BoardId]				=		ed.[BoardId]

		JOIN		[dbo].[GTS_Titles]					t
			on		ed.[TitleId]				=		t.[Id]

		JOIN		[dbo].[GTS_Countries]				c
			ON		rr.[CountryId]				=		c.[CountryId]

		WHERE		([ActiveStart]				<=		GETDATE()
		AND		[ActiveEnd]					>		GETDATE())
			AND		t.[Title]					=		@Title
	) ranks
	WHERE			[Rank]						<=		50
	
	ORDER BY		[Rank]

GO
