CREATE PROCEDURE [dbo].[GTS_IncreaseMaximumNumber]
	@NewMax		 BIGINT
AS
	TRUNCATE TABLE [dbo].[GTS_NewProfileNumbers]

	DECLARE @StartNumber BIGINT
	SET @StartNumber = 1000000
	WHILE @StartNumber <= @NewMax
		BEGIN
			IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_Profiles] WHERE [ProfileNumber] = @StartNumber)
				BEGIN
					INSERT INTO [dbo].[GTS_NewProfileNumbers] ([ProfileNumber])
					VALUES (@StartNumber)
				END
			SET @StartNumber = @StartNumber + 1
		END

GO
