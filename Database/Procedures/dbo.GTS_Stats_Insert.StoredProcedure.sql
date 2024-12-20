CREATE PROCEDURE [dbo].[GTS_Stats_Insert]
	@ProfileId		BIGINT,
	@StatId			BIGINT,
	@StatYear		BIGINT,
	@StatMonth		BIGINT,
	@StatDay		BIGINT,
	@StatValue		BIGINT
AS
	UPDATE		[dbo].[GTS_Stats] 

	SET			[StatValue]			=		@StatValue,
				[EntryDate]			=		GETDATE()

	WHERE		[ProfileId]			=		@ProfileId
		AND		[StatId]			=		@StatId
		AND		[StatYear]			=		@StatYear
		AND		[StatMonth]			=		@StatMonth 
		AND		[StatDay]			=		@StatDay

	IF @@ROWCOUNT = 0
		BEGIN
			INSERT INTO [dbo].[GTS_Stats] ([ProfileId], [StatId], [StatYear], [StatMonth], [StatDay], [StatValue], [EntryDate])
			VALUES (@ProfileId, @StatId, @StatYear, @StatMonth, @StatDay, @StatValue, GETDATE())
		END
GO
