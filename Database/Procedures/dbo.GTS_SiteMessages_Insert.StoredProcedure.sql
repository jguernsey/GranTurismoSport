CREATE PROCEDURE [dbo].[GTS_SiteMessages_Insert]
	@UserId			BIGINT,
	@MessageText	NVARCHAR(4000)
AS
	BEGIN
		INSERT INTO [dbo].[GTS_SiteMessages] ([UserId], [MessageText], [DateSent])
		VALUES (@UserId, @MessageText, GETDATE())
	END

GO
