CREATE PROCEDURE [dbo].[GTS_UserCars_Insert]
	@ProfileId		BIGINT,
	@CarId			BIGINT,
	@UserCarId		BIGINT OUTPUT
AS
	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_UserCars] WHERE [ProfileId] = @ProfileId AND [CarId] = @CarId)
		BEGIN
			INSERT INTO [dbo].[GTS_UserCars] ([ProfileId], [CarId])
			VALUES (@ProfileId, @CarId)
		END
	
	SET NOCOUNT ON;
	
	SELECT @UserCarId = [UserCarId] FROM [dbo].[GTS_UserCars] WHERE [ProfileId] = @ProfileId AND [CarId] = @CarId;
	
	RETURN


GO
