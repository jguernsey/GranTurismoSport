CREATE PROCEDURE [dbo].[GTS_CarCategory_Insert]
	@CategoryName NVARCHAR (32)
AS
	INSERT INTO [dbo].[GTS_CarCategories] ([CategoryName])
	VALUES (@CategoryName)


GO
