
CREATE PROCEDURE [dbo].[GTS_Cars_SelectByManufacturerId]
	@ManufacturerId		BIGINT
AS
	SELECT		[CarId], [CarName]
	FROM		[dbo].[GTS_Cars]
	WHERE		[ManufacturerId]		=		@ManufacturerId
	ORDER BY	[CarName]


GO
