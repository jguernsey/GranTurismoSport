CREATE VIEW [dbo].[vw_GTS_RegisteredUserDetails]
AS
	SELECT			RANK() OVER(ORDER BY gp.[ProfileId])	AS		[RowNumber],
					gp.[ProfileNumber], 
					gp.[ProfileId]

	FROM			[dbo].[UserProfile]								p

	JOIN			[dbo].[GTS_Profiles]							gp
		ON			p.[PropertyDefinitionID]				=		45
		AND			p.[PropertyValue]						=		gp.[Id]

GO
