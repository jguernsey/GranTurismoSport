CREATE PROCEDURE [dbo].[GTS_RaceCars_Insert]
	@RaceDetailId		BIGINT,
	@CarCategory		NVARCHAR(32)
AS
	DECLARE @CategoryId BIGINT
	SET @CategoryId = (SELECT [CategoryId] FROM [dbo].[GTS_CarCategories] WHERE [CategoryName] = @CarCategory)

	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_RaceCars] WHERE [RaceDetailId] = @RaceDetailId AND [CategoryId] = @CategoryId)
		BEGIN
			INSERT INTO [dbo].[GTS_RaceCars] ([RaceDetailId], [CategoryId])
			VALUES (@RaceDetailId, @CategoryId)
		END

GO
