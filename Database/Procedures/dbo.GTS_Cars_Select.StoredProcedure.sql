
CREATE PROCEDURE [dbo].[GTS_Cars_Select]
AS
	SELECT		[CarId], [CarName]
	FROM		[dbo].[GTS_Cars]
	ORDER BY	[CarName]


GO
