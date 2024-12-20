
CREATE PROCEDURE [dbo].[GTS_NationsCup_GetCountByCountry]
	@EventTarget			NVARCHAR(32),
	@RegionId				BIGINT,
	@CountryId				BIGINT
AS
	SELECT	COUNT(p.[Id]) AS [EntryCount]
	FROM	[dbo].[GTS_NationsCupResults]			ncr
	
	JOIN	[dbo].[GTS_Profiles]					p
		ON	ncr.[ProfileId]					=		p.[ProfileId]
	
	JOIN	[dbo].[GTS_SeasonDetail]				sd
		ON	ncr.[SeasonId]					=		sd.[SeasonId]
	
	JOIN	[dbo].[GTS_Countries]					c
		ON	p.[CountryId]					=		c.[CountryId]
	
	JOIN	[dbo].[GTS_EventTargets]				et
		ON	sd.[EventTargetId]				=		et.[Id]
	
	WHERE	et.[EventTarget]				=		@EventTarget
		AND	sd.[RegionId]					=		@RegionId
		AND	c.[CountryId]					=		@CountryId


GO
