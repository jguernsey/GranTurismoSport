CREATE PROCEDURE [dbo].[GTS_Car_Insert]
	@CarName NVARCHAR (32),
	@ManufacturerId BIGINT,
	@CategoryId BIGINT
AS
	INSERT INTO [dbo].[GTS_Cars] ([CarName], [ManufacturerId], [CategoryId])
	VALUES (@CarName, @ManufacturerId, @CategoryId)


GO
