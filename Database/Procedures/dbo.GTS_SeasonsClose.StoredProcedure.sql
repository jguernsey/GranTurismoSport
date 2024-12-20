
CREATE PROCEDURE [dbo].[GTS_SeasonsClose]
	@SeasonId		BIGINT
AS
	DECLARE @LastDate DATETIME
	SET @LastDate = (SELECT DATEADD(DAY,2,MAX([LastRaceEnd])) FROM [dbo].[GTS_SeasonRounds] sr JOIN [dbo].[GTS_Seasons] s ON sr.[SeasonId] = s.[Id] WHERE s.[SeasonId] = @SeasonId)

	IF @LastDate < GETDATE()
		BEGIN
			UPDATE [dbo].[GTS_Seasons] SET [Processed] = 'Y' WHERE [SeasonId] = @SeasonId
		END
GO
