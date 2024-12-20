
CREATE PROCEDURE [dbo].[GTS_Chart_DailyDistance]
	@Id			NVARCHAR(32)
AS
	DECLARE		@ProfileId BIGINT
	SET @ProfileId = (SELECT [ProfileId] FROM [dbo].[GTS_Profiles] WHERE [Id] = @Id)

	SELECT		[HistoryDate], [Kilometers], SUM([Kilometers]) OVER (ORDER BY [HistoryDate]) AS [RunningTotal]
	FROM
	(
	SELECT		CAST(CAST([StatYear] AS NVARCHAR(4)) + RIGHT('0' + CAST([StatMonth] AS NVARCHAR(2)), 2) + RIGHT('0' + CAST([StatDay] AS NVARCHAR(2)), 2) AS DATETIME) AS [HistoryDate], 
				CONVERT(FLOAT(53),[StatValue])/1000 AS [Kilometers]
	FROM		[dbo].[GTS_Stats]				
	
	WHERE		[ProfileId]			=		@ProfileId
		AND		[StatId]			=		1
	) T1
	ORDER BY	[HistoryDate]


GO
