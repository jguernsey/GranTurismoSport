CREATE PROCEDURE [dbo].[GTS_RaceTypes_Select]
AS
	SELECT		[RaceTypeId], [RaceType]
	FROM		[dbo].[GTS_RaceTypes]
	ORDER BY	[RaceType]


GO
