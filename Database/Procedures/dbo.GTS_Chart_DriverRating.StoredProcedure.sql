
CREATE PROCEDURE [dbo].[GTS_Chart_DriverRating]
	@Id			NVARCHAR(32)
AS
	DECLARE		@ProfileId BIGINT
	SET @ProfileId = (SELECT [ProfileId] FROM [dbo].[GTS_Profiles] WHERE [Id] = @Id)

	SELECT		CAST(CAST([StatYear] AS NVARCHAR(4)) + RIGHT('0' + CAST([StatMonth] AS NVARCHAR(2)), 2) + RIGHT('0' + CAST([StatDay] AS NVARCHAR(2)), 2) AS DATETIME) AS [HistoryDate], 
				[StatValue] AS [DriverPoints]
	FROM		[dbo].[GTS_Stats]				
	
	WHERE		[ProfileId]			=		@ProfileId
		AND		[StatId]			=		12

	ORDER BY	[StatYear], [StatMonth], [StatDay]


GO
