
 CREATE FUNCTION [dbo].[fn_GTS_GetLowestLapTime_ByUser]
(
	@UserId					NVARCHAR(32)
)
RETURNS TABLE 
AS
	RETURN 
	SELECT	[BoardId], [UserId], [CreateTime], [Score], [CountryId]
	FROM	[dbo].[GTS_RaceRankings]		rra
	WHERE	[Score] = 
	(
		SELECT	MIN([Score])
		FROM	[dbo].[GTS_RaceRankings]	rrb
		WHERE	rrb.BoardId			=		rra.BoardId
		AND		rrb.UserId			=		rra.UserId
	)
	AND	[UserId]					=		@UserId

GO
