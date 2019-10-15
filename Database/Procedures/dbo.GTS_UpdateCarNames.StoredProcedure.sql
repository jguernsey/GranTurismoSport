CREATE PROCEDURE [dbo].[GTS_UpdateCarNames]
	@TagId		BIGINT,
	@CarName	NVARCHAR(32)
AS
	UPDATE [dbo].[GTS_Cars] SET [TagId] = @TagId
	WHERE [CarName] = @CarName

GO
