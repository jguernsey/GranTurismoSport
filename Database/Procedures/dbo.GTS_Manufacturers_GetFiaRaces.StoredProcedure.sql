CREATE PROCEDURE [dbo].[GTS_Manufacturers_GetFiaRaces]
AS
	SELECT		[PDCode] AS [Id], 
				[Name]
	
	FROM		[dbo].[GTS_Manufacturers]
	
	WHERE		[FiaRaces]				=		'Y'
	
	ORDER BY	[Name]

GO
