
 CREATE FUNCTION [dbo].[fn_GTS_WorldWideRaceRanking]
(
	@Title			NVARCHAR(32)
)
RETURNS TABLE
AS
	RETURN
	SELECT	[BoardId], [UserId], [CreateTime], [Score], [CountryName]
	FROM	[dbo].[GTS_RaceRankings]			rr

	JOIN	[dbo].[GTS_Countries]			c
		ON	rr.[CountryId]			=		c.[CountryId]
	WHERE	[BoardId] IN 
	(
		SELECT		[BoardId] 
		FROM		[dbo].[GTS_EventDetail]				ed 
	
		JOIN		[dbo].[GTS_Titles]					t 
			ON		ed.[TitleId]				=		t.[Id] 
	
		WHERE		t.[Title]					=		@Title
				AND		([ActiveStart]				<=		GETDATE()
		AND		[ActiveEnd]					>		GETDATE())
	)

GO
