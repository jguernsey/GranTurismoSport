
CREATE PROCEDURE [dbo].[GTS_ExperiencePoints_Insert]
	@Level		 BIGINT,
	@Points		 BIGINT,
	@TotalPoints BIGINT
AS
	INSERT INTO [dbo].[GTS_ExperiencePoints] ([Level], [Points], [TotalPoints])
	VALUES (@Level, @Points, @TotalPoints)


GO
