CREATE PROCEDURE [dbo].[GTS_Manufacturer_Update]
	@ManufacturerId BIGINT,
	@ManufacturerName NVARCHAR (64),
	@ManufacturerCode BIGINT,
	@ManufacturerImage	VARBINARY(MAX)
AS
	UPDATE	[dbo].[GTS_Manufacturers] 
	SET 
			[Name]	=	@ManufacturerName,
			[Code]	=	@ManufacturerCode,
			[Image] =	@ManufacturerImage
	WHERE	[Id]	=	@ManufacturerId


GO
