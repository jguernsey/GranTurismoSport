
CREATE PROCEDURE [dbo].[GTS_RaceDetails_Update]
	@RaceDetailId BIGINT,
	@StartDR BIGINT,
	@EndDR BIGINT,
	@StartPosition BIGINT,
	@EndPosition BIGINT
AS
	UPDATE [dbo].[GTS_RaceDetails] 
	SET 
			[StartDR]			=	@StartDR,
			[EndDR]				=	@EndDR,
			[StartPosition]		=	@StartPosition,
			[EndPosition]		=	@EndPosition

	WHERE	[RaceDetailsId]		=	@RaceDetailId


GO
