
CREATE PROCEDURE [dbo].[GTS_CarCategory_Update]
	@CarCategoryId BIGINT,
	@CategoryName NVARCHAR (32)
AS
	UPDATE [dbo].[GTS_CarCategories] 
	SET 
			[CategoryName]		=	@CategoryName
	WHERE	[CategoryId]		=	@CarCategoryId


GO
