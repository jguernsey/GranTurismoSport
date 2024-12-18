CREATE PROCEDURE [dbo].[GTS_GetNationsCupResultDetail]
	@Season				NVARCHAR(64),
	@Driver				NVARCHAR(32)
AS
	SELECT		[Round], [Track], [Category], [Laps], [LapsLed], [RaceSR], [Qualified], [Finished], [RacePoints], [ImagePath]
	FROM		[dbo].[vw_GTS_NationsCupResultDetail]		mrd

	JOIN		[dbo].[GTS_SeasonDetail]					sd
		ON		mrd.[Season]					=			sd.[SeasonId]

	JOIN		[dbo].[GTS_EventTargets]					et
		ON		sd.[EventTargetId]				=			et.[Id]
	
	JOIN		[dbo].[GTS_Countries]						c
		ON		mrd.[CountryName]				=			c.[CountryName]

	WHERE		[EventTarget]					=			@Season
		AND		[Driver]						=			@Driver

	ORDER BY	[Round]
GO
