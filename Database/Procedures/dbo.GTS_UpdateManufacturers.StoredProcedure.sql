CREATE PROCEDURE [dbo].[GTS_UpdateManufacturers]
	@PDCode		BIGINT,
	@Code		NVARCHAR(32),
	@TagId		BIGINT
AS
	UPDATE [dbo].[GTS_Manufacturers] 
	SET [TagId] = @TagId,
		[PDCode] = @PDCode
	WHERE [Code] = @Code

GO
