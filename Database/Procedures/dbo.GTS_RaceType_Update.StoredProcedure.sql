CREATE PROCEDURE [dbo].[GTS_RaceType_Update]
	@RaceTypeId BIGINT,
	@RaceType NVARCHAR (64)
AS
	UPDATE	[dbo].[GTS_RaceTypes] 
	SET		[RaceType]		=	@RaceType
	WHERE	[RaceTypeId]	=	@RaceTypeId


GO
