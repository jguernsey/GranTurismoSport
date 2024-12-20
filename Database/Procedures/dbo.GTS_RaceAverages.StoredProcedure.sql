CREATE PROCEDURE [dbo].[GTS_RaceAverages]
	@UserId			NVARCHAR(32)
AS
	SELECT [Name], [CategoryName], [CarType] = CASE WHEN [CarsCount] = 0 THEN 'Garage Car' WHEN [CarsCount] = 1 THEN 'One Make' END, 
	[Races], 
	COALESCE([AvgLapsLed],0) AS [AverageLapsLed], 
	COALESCE([MostLapsLed],0) AS [MostLapsLead], 
	[AvgSR], 
	[MostGainedSR]	AS [MaxSRChange],  
	[MostLostSR]	AS	[MinSRChange],
	COALESCE([AvgQualify],0) AS [AverageQualifyPosition],
	COALESCE([BestQualify],0) AS [HighestQualifyPosition],
	COALESCE([WorstQualify],0) AS [LowestQualifyPosition],
	COALESCE([AvgFinish],0) AS [AverageFinish],
	COALESCE([BestFinish],0) AS [HighestFinish],
	COALESCE([WorstFinish],0) AS [LowestFinish]
	FROM [dbo].[vw_GTS_RaceAverages]
	WHERE [Id] = @UserId
	ORDER BY [Name]

GO
