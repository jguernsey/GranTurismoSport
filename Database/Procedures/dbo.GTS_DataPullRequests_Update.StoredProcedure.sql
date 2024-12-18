
CREATE PROCEDURE [dbo].[GTS_DataPullRequests_Update]
	@ServiceName		NVARCHAR(32),
	@RequestBytes		BIGINT
AS
	UPDATE			[dbo].[GTS_DataPullRequests]

	SET				[RequestCount]		=		([RequestCount] + 1),
					[RequestBytes]		=		([RequestBytes]	+	@RequestBytes),
					[LastRequest]		=		GETDATE()

	WHERE			[ServiceName]		=		@ServiceName

	IF @@ROWCOUNT = 0
		BEGIN
			INSERT INTO [dbo].[GTS_DataPullRequests] ([ServiceName], [RequestCount], [RequestBytes], [LastRequest])
			VALUES (@ServiceName, 1, @RequestBytes, GETDATE())
		END

GO
