CREATE	VIEW	[dbo].[vw_GTS_WorldRaceQualifiers]
AS
	SELECT		[Title],
				COUNT(rr.[UserId])			AS		[Total]

	FROM		[dbo].[GTS_EventDetail]			ed

	JOIN		[dbo].[GTS_RaceRankings]		rr
		ON		ed.[BoardId]		=			rr.[BoardId]

	JOIN		[dbo].[GTS_Titles]				t
		ON		ed.[TitleId]		=			t.[Id]

	WHERE		[ActiveStart]	<=	GETDATE()
		AND		[ActiveEnd]		>=	GETDATE()

	GROUP BY	[Title]

GO
