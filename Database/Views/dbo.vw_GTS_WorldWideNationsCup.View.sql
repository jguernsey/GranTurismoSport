CREATE VIEW [dbo].[vw_GTS_WorldWideNationsCup]
AS
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
	
		WHERE		t.[Title]					=		'FIA GT Nations Cup'
			AND		ed.[DateEntered]			=		DATEADD(HH,1,CONVERT(DATETIME,CONVERT(VARCHAR(10),GETDATE(),101)))
	)

GO
