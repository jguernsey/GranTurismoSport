
CREATE PROCEDURE [dbo].[GTS_RequestBoard_Insert]
	@UserId				BIGINT,
	@RequestType		NVARCHAR(32),
	@Title				NVARCHAR(64),
	@Description		NVARCHAR(500)
AS
	BEGIN
		INSERT INTO [dbo].[GTS_RequestBoard] ([UserId], [TypeId], [Title], [Description], [StatusId], [DateCreated])
		VALUES (@UserId, (SELECT [Id] FROM [dbo].[GTS_RequestTypes] WHERE [RequestType] = @RequestType), @Title, @Description, 2, GETDATE())
	END

GO
