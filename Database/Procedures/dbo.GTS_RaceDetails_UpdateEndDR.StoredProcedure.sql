
CREATE PROCEDURE [dbo].[GTS_RaceDetails_UpdateEndDR]
	@RaceHeaderId		BIGINT,
	@EndDR				BIGINT
AS
	UPDATE		[dbo].[GTS_RaceDetails] 
	
	SET			[EndDR]					=		@EndDR

	WHERE		[RaceHeaderId]			=		@RaceHeaderId


GO
