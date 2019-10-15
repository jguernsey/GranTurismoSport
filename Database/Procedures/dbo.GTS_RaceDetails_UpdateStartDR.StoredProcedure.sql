
CREATE PROCEDURE [dbo].[GTS_RaceDetails_UpdateStartDR]
	@RaceHeaderId		BIGINT,
	@StartDR			BIGINT
AS
	UPDATE		[dbo].[GTS_RaceDetails]

	SET			[StartDR]				=		@StartDR
	
	WHERE		[RaceHeaderId]			=		@RaceHeaderId


GO
