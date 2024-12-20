
CREATE PROCEDURE [dbo].[GTS_GetRaceRankings_ByRegionTitle]
	@RegionId			BIGINT,
	@Title				NVARCHAR(128)
AS
			SELECT		[Rank], [UserId], [Score], [CountryName]
			FROM
			(
				SELECT		ROW_NUMBER() OVER(ORDER BY rr.[Score] ASC, [CreateTime] ASC) AS [Rank],
							[UserId],
							[Score],
							[CountryName]

				FROM		[dbo].[GTS_RaceRankings]			rr

				JOIN		[dbo].[GTS_EventDetail]				ed
					ON		rr.[BoardId]				=		ed.[BoardId]

				JOIN		[dbo].[GTS_Titles]					t
					on		ed.[TitleId]				=		t.[Id]

				JOIN		[dbo].[GTS_Countries]				c
					ON		rr.[CountryId]				=		c.[CountryId]

				WHERE		ed.[RegionId]				=		@RegionId
					AND		([ActiveStart]				<=		GETDATE()
					AND		[ActiveEnd]					>		GETDATE())
					AND		t.[Title]					=		@Title
			) ranks
			WHERE			[Rank]						<=		50
	
			ORDER BY		[Rank]
GO
