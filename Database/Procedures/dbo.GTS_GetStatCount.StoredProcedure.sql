CREATE PROCEDURE [dbo].[GTS_GetStatCount]
	@StatId	 BIGINT,
	@StatYear BIGINT,
	@StatMonth BIGINT,
	@StatDay BIGINT
AS
	SELECT COUNT([StatsId]) FROM [dbo].[GTS_Stats] WHERE [StatId] = @StatId AND [StatYear] = @StatYear AND [StatMonth] = @StatMonth AND [StatDay] = @StatDay AND [StatValue] = 0


GO
