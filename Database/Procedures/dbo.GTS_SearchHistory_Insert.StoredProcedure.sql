CREATE PROCEDURE [dbo].[GTS_SearchHistory_Insert]
	@UserId				BIGINT,
	@SearchName			NVARCHAR(128)
AS
	INSERT INTO [dbo].[GTS_SearchHistory] ([UserId], [SearchName], [DateEntered])
	VALUES (@UserId, @SearchName, GETDATE())


GO
