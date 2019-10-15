
CREATE PROCEDURE [dbo].[GTS_Cars_SelectByCategoryId]
	@CategoryId		BIGINT
AS
	SELECT		[CarId], [CarName]
	FROM		[dbo].[GTS_Cars]
	WHERE		[CategoryId]		=		@CategoryId
	ORDER BY	[CarName]


GO
