CREATE VIEW [dbo].[vw_GTS_RegisteredUserInfo]
AS
	SELECT			
					ROW_NUMBER() OVER (ORDER BY [ProfileId]) AS [EntryNumber],
					[ProfileId], 
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
	FROM
	(
		SELECT		[PropertyValue] 
		
		FROM		[dbo].[UserProfile]					up
		
		WHERE		[PropertyDefinitionID]		=		45
	)	pv
	
	JOIN			[dbo].[GTS_Profiles]				p
		ON			pv.[PropertyValue]			=		p.[Id]
	
	JOIN			[dbo].[GTS_Countries]				c
		ON			p.[CountryId]				=		c.[CountryId]

GO
