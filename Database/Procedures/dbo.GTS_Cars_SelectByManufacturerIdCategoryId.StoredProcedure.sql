
CREATE PROCEDURE [dbo].[GTS_Cars_SelectByManufacturerIdCategoryId]
	@ManufacturerId		BIGINT,
	@CategoryId			BIGINT
AS
	SELECT		[CarId], [CarName]
	FROM		[dbo].[GTS_Cars]
	WHERE		[ManufacturerId]		=		@ManufacturerId
		AND		[CategoryId]			=		@CategoryId
	ORDER BY	[CarName]


GO
