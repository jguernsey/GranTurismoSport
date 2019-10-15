CREATE PROCEDURE [dbo].[GTS_Car_Update]
	@CarId BIGINT,
	@CarName NVARCHAR (32),
	@ManufacturerId BIGINT,
	@CategoryId BIGINT
AS
	UPDATE [dbo].[GTS_Cars] 
	SET 
		[CarName] = @CarName,
		[ManufacturerId] = @ManufacturerId,
		[CategoryId] = @CategoryId
	WHERE [CarId] = @CarId


GO
