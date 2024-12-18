CREATE PROCEDURE [dbo].[GTS_GetManufacturerResultDetail]
	@Season				NVARCHAR(64),
	@Driver				NVARCHAR(32)
AS
	SELECT		[Driver], [ImagePath], [Round], [Track], [Category], [Laps], [LapsLed], [RaceSR], [Qualified], [Finished], [RacePoints]
	FROM		[dbo].[vw_GTS_ManufacturerResultDetail]		mrd

	JOIN		[dbo].[GTS_SeasonDetail]					sd
		ON		mrd.[Season]					=			sd.[SeasonId]

	JOIN		[dbo].[GTS_EventTargets]					et
		ON		sd.[EventTargetId]				=			et.[Id]

	WHERE		[EventTarget]					=			@Season
		AND		[Driver]						=			@Driver

	ORDER BY	[Round]

GO
