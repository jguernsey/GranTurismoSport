CREATE PROCEDURE [dbo].[GTS_UpdatePSNName]
	@UserId			 BIGINT,
	@NewName			NVARCHAR(MAX)
AS
	UPDATE	[dbo].[UserProfile]
	
	SET		[PropertyValue]			=		@NewName

	WHERE	[PropertyDefinitionID]	=		45
		AND	[UserId]				=		@UserId


GO
