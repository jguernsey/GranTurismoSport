CREATE PROCEDURE [dbo].[GTS_UpdateTempTracks]
	@Code VARCHAR(64),
	@Name VARCHAR(128)
AS
	UPDATE GTS_TempTracks SET Name = @Name WHERE Code = @Code

GO
