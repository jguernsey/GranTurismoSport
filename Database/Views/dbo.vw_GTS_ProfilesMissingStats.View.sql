CREATE VIEW	[dbo].[vw_GTS_ProfilesMissingStats]
AS
	SELECT		ROW_NUMBER() OVER (ORDER BY [ProfileNumber]) AS [RowId],
				[ProfileId],
				[ProfileNumber]
	FROM
	(
		SELECT		p.[ProfileId], [ProfileNumber]
			
		FROM		[dbo].[GTS_Profiles]						p
		
		LEFT JOIN	[dbo].[GTS_AchievementHistory]				ah
			ON		p.[ProfileId]					=			ah.[ProfileId]

		LEFT JOIN	[dbo].[GTS_ProfileStats]					ps
			ON		p.[ProfileId]					=			ps.[ProfileId]

		WHERE		[ProfileStatus]					=			1
			AND		(ah.[ProfileId]					IS			NULL
			OR		ps.[ProfileId]					IS			NULL)
	) tw

GO
