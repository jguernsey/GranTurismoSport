
CREATE PROCEDURE [dbo].[GTS_ManufacturerPoints_InsertUpdate]
	@ResultId		BIGINT,
	@Points			BIGINT,
	@EventResultId	BIGINT
AS
	BEGIN
		UPDATE	[dbo].[GTS_ManufacturerPoints]
		
		SET		[Points]			=		@Points
		
		WHERE	[EventResultId]		=		@EventResultId
			AND	[ResultId]			=		@ResultId

		IF @@ROWCOUNT = 0
			BEGIN
				INSERT INTO [dbo].[GTS_ManufacturerPoints] ([ResultId], [Points], [EventResultId])
				VALUES (@ResultId, @Points, @EventResultId)
			END
	END

GO
