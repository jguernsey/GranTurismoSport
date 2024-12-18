
CREATE PROCEDURE [dbo].[GTS_RequestBoard_Vote]
	@UserId				BIGINT,
	@RequestId			BIGINT
AS
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_RequestVotes] WHERE [UserId] = @UserId AND [RequestId] = @RequestId)
			BEGIN
				INSERT INTO [dbo].[GTS_RequestVotes] ([UserId], [RequestId])
				VALUES (@UserId, @RequestId)
			END
	END

GO
