CREATE PROCEDURE [dbo].[GTS_RegisteredUserDetails_Update]
AS
	TRUNCATE TABLE [dbo].[GTS_RegisteredUserDetails]

	INSERT INTO		[dbo].[GTS_RegisteredUserDetails] ([ProfileId], [ProfileNumber])
	SELECT			DISTINCT
					gp.[ProfileId], 
					gp.[ProfileNumber]
					
	FROM			[dbo].[UserProfile]								p

	JOIN			[dbo].[GTS_Profiles]							gp
		ON			p.[PropertyDefinitionID]				=		45
		AND			p.[PropertyValue]						=		gp.[Id]

	ORDER BY		gp.[ProfileId]


GO
