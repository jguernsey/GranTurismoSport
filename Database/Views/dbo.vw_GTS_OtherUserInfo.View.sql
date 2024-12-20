CREATE VIEW [dbo].[vw_GTS_OtherUserInfo]
AS
	SELECT		
				ROW_NUMBER() OVER (ORDER BY p.[ProfileId]) AS [EntryNumber],
				p.[ProfileId], 
				[ProfileNumber],
				c.[CountryId],
				[CountryName],
				[RegionId],
				[Region] = CASE [RegionId]
									WHEN	1
										THEN	'jp'
									WHEN	2
										THEN	'de'
									WHEN	3
										THEN	'us'
								END

	FROM		[dbo].[GTS_Profiles]				p

	JOIN		[dbo].[GTS_ProfileStats]			ps
		ON		p.[ProfileId]				=		ps.[ProfileId]

	JOIN		[dbo].[GTS_Countries]				c
		ON		p.[CountryId]				=		c.[CountryId]

	WHERE		p.[ProfileStatus]			=		1
		AND		p.[ProfileNumber] NOT IN (SELECT [ProfileNumber] FROM [dbo].[vw_GTS_RegisteredUserInfo])
		AND		p.[ProfileNumber] NOT IN (SELECT [ProfileNumber] FROM [dbo].[vw_GTS_ActiveUserInfo])

GO
