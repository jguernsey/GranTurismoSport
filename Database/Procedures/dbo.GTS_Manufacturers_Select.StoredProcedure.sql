CREATE PROCEDURE [dbo].[GTS_Manufacturers_Select]
AS
	SELECT		[Id], [Name]
	FROM		[dbo].[GTS_Manufacturers]
	ORDER BY	[Name]


GO
