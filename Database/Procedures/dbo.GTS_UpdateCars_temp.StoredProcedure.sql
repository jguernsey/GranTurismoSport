CREATE PROCEDURE [dbo].[GTS_UpdateCars_temp]
	@CarTagId		BIGINT,
	@CarName		NVARCHAR(64)
	
AS
	UPDATE		[dbo].[GTS_Cars]
	SET			[ShortName]	=		@CarName
	WHERE		[TagId]		=		@CarTagId

GO
