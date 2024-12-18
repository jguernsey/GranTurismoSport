
CREATE PROCEDURE	[dbo].[GTS_GetRealTimeDriverRatingV3]
	@UserName				NVARCHAR(32),
	@StartDate				DATETIME,
	@EndDate				DATETIME
AS
	SELECT		[DateUpdated], [DriverRating], [DRChange], ROW_NUMBER() OVER (ORDER BY [DateUpdated]) AS [EntryNumber]
	FROM
	(
		SELECT		[DateUpdated],
					[DriverRating],
					COALESCE([DriverRating] - LAG([DriverRating],1) OVER (ORDER BY p.[Id]),0) AS [DRChange]					

		FROM		[dbo].[GTS_RealTimeDriverRating]		dr
	
		JOIN		[dbo].[GTS_Profiles]					p
			ON		dr.[ProfileId]					=		p.[ProfileId]
	
		WHERE		p.[Id]							=		@UserName
		AND			([DateUpdated]					>=		@StartDate
		AND			[DateUpdated]					<=		@EndDate)
	) t1
	WHERE		[DRChange]							!=		0
	ORDER BY	[DateUpdated]


GO
