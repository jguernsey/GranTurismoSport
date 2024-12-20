
CREATE PROCEDURE	[dbo].[GTS_GetRealTimeDriverRating]
	@UserName				NVARCHAR(32),
	@StartDate				DATETIME,
	@EndDate				DATETIME
AS
	SELECT		[DriverRating], [DRChange], [DateUpdated]
	FROM
	(
		SELECT		[DriverRating],
					COALESCE([DriverRating] - LAG([DriverRating],1) OVER (ORDER BY p.[Id]),0) AS [DRChange],
					[DateUpdated]

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
