
CREATE PROCEDURE [dbo].[GTS_EventTimes_GetNextTime]
AS
	SELECT		TOP(1) [TimeType], [UpdateTime]
	FROM		[dbo].[vw_GTS_DailyEventTimes]
	WHERE		[UpdateTime] > GETDATE()
	ORDER BY	[UpdateTime]
GO
