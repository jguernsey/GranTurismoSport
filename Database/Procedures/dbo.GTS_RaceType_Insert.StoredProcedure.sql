CREATE PROCEDURE [dbo].[GTS_RaceType_Insert]
	@RaceType NVARCHAR (64)
AS
	INSERT INTO [dbo].[GTS_RaceTypes] ([RaceType])
	VALUES (@RaceType)


GO
