CREATE PROCEDURE [dbo].[GTS_RealTimeDriverRating_Update]
	@ProfileId			BIGINT,
	@DriverRating		BIGINT,
	@UpdateType nvarchar(8) = null
AS
	DECLARE @Status NVARCHAR(2)
	SET @Status = 'C'

	IF EXISTS(SELECT 1 FROM [dbo].[GTS_RealTimeDriverRating] WHERE [ProfileId] = @ProfileId AND [DriverRating] = @DriverRating)
		BEGIN
			SET @Status = 'NC'
		END
	
	INSERT INTO [dbo].[GTS_RealTimeDriverRating] ([ProfileId], [DriverRating], [DateUpdated], [Status], [UpdateType])
	VALUES (@ProfileId, @DriverRating, GETDATE(), @Status, '')
GO
