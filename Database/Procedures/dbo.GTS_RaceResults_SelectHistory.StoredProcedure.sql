CREATE PROCEDURE [dbo].[GTS_RaceResults_SelectHistory]
	@UserId				NVARCHAR(32)
AS
	SELECT		DISTINCT [RaceTime], [Type], [Track], [TrackTime], [TimeOfDay], [Weather], [Category], [MaxEntries], [Qualifying], [FinishedLaps], [LeadLaps], [SR], [FinishPosition], [Change]
	
	FROM		[dbo].[vw_GTS_UserRaceResults]

	WHERE		[UserId]		=		@UserId

	ORDER BY	[RaceTime] DESC

GO
