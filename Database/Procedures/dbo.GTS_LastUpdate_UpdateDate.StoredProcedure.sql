CREATE PROCEDURE [dbo].[GTS_LastUpdate_UpdateDate]
	@ProfileId			BIGINT
AS
	BEGIN
		UPDATE	[dbo].[GTS_LastUpdate]
		SET		[UpdateDate]			=		GETDATE()
		WHERE	[ProfileId]				=		@ProfileId
	END

GO
