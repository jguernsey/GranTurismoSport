
CREATE PROCEDURE [dbo].[GTS_Cars_SelectByCarId]
	@CarId			BIGINT
AS
	SELECT		[ManufacturerId], [CategoryId]
	FROM		[dbo].[GTS_Cars]
	WHERE		[CarId]			=		@CarId


GO
