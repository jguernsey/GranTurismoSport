CREATE PROCEDURE [dbo].[GTS_RaceResults_SelectHistoryV2]
	@UserId				NVARCHAR(32)
AS
	SELECT		DISTINCT [RaceTime], [Type], [Track], [TrackTime], [TimeOfDay], [Weather], [Category], [MaxEntries], [Qualifying], [FinishedLaps], [LeadLaps], [SR], [FinishPosition], [Change], [DriverRating]
	
	FROM		[dbo].[vw_GTS_UserRaceResults_v2]

	WHERE		[UserId]		=		@UserId

	ORDER BY	[RaceTime] DESC

GO
