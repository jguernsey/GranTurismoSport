CREATE PROCEDURE [dbo].[GTS_Manufacturers_GetImage]
	@PDCode			BIGINT
AS
	SELECT		[Image]
	
	FROM		[dbo].[GTS_Manufacturers]

	WHERE		[PDCode]		=		@PDCode

GO
