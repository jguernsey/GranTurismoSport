CREATE PROCEDURE [dbo].[GTS_ProfileDisclaimer_Select]
AS
	SELECT	COUNT([ProfileId])		AS		[ProfileCount],
			MAX([CreateDate])		AS		[LastUpdate]
	FROM [dbo].[GTS_Profiles]


GO
