CREATE PROCEDURE [dbo].[GTS_MaxProfileNumber_Select]
AS
	SELECT MAX([ProfileNumber]) + 1 AS [MaxNumber] FROM [dbo].[GTS_Profiles]


GO
