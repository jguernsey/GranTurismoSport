CREATE PROCEDURE [dbo].[GTS_Tracks_Select]
AS
	SELECT		[Id], [Name]
	FROM		[dbo].[GTS_Tracks]
	ORDER BY	[Name]


GO
