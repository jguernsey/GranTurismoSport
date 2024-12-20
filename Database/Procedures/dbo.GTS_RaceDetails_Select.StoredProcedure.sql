
CREATE PROCEDURE [dbo].[GTS_RaceDetails_Select]
	@RaceHeaderId		BIGINT
AS
	SELECT	[RaceHeaderId],
			[RaceDetailsId]								AS	[RaceDetailsId],
			[StartDR],
			[EndDR],
			[EndDR] - [StartDR]							AS	[DRChange],
			[StartPosition],
			[EndPosition],
			[EndPosition] - [StartPosition]				AS	[PositionChange]

	FROM	[dbo].[GTS_RaceDetails]								rd
	WHERE	[RaceHeaderId]								=	@RaceHeaderId


GO
