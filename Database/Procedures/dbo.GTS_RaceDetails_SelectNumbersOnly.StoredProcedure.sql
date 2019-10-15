CREATE PROCEDURE [dbo].[GTS_RaceDetails_SelectNumbersOnly]
	@RaceHeaderId		BIGINT
AS
	SET NOCOUNT ON
	UPDATE	[dbo].[RaceHeader] SET [RaceStatus] = 'true' WHERE [RaceHeaderId] = @RaceHeaderId

	SELECT	[ProfileId]
	FROM	[dbo].[RaceDetails]			rd
	WHERE	[RaceHeaderId]		=		@RaceHeaderId


GO
