
CREATE PROCEDURE [dbo].[GTS_CarCategories_Select]
AS
	SELECT		[CategoryId], [CategoryName]
	FROM		[dbo].[GTS_CarCategories]
	ORDER BY	[CategoryName]


GO
