CREATE PROCEDURE [dbo].[GTS_Manufacturer_Insert]
	@ManufacturerName NVARCHAR (64)
AS
	INSERT INTO [dbo].[GTS_Manufacturers] ([Name], [Code], [Image])
	VALUES (@ManufacturerName, 0, 0x)


GO
