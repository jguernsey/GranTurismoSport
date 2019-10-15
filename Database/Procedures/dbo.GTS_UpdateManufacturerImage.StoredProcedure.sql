CREATE PROCEDURE [dbo].[GTS_UpdateManufacturerImage]
	@PDCode		BIGINT,
	@Image		VARBINARY(MAX)
AS
	UPDATE [dbo].[GTS_Manufacturers] SET Image = @Image WHERE [PDCode] = @PDCode

GO
