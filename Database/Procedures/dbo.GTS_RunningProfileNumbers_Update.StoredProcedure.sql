CREATE PROCEDURE [dbo].[GTS_RunningProfileNumbers_Update]
	@LastNumber		BIGINT,
	@NewMax			BIGINT
AS
	DECLARE @NewNumber	BIGINT
	SET @NewNumber = @LastNumber

	WHILE @NewNumber <= @NewMax
		BEGIN
			INSERT INTO [dbo].[GTS_RunningProfileNumbers] ([ProfileNumber]) VALUES (@NewNumber)

			SET @NewNumber = @NewNumber + 1
		END

GO
