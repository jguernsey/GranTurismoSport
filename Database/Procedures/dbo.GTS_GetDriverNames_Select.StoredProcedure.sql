
CREATE PROCEDURE [dbo].[GTS_GetDriverNames_Select]
	@Id			NVARCHAR(32)
AS
	SELECT		[ProfileNumber], [Id]
	FROM		[dbo].[GTS_Profiles]
	WHERE		[Id]				LIKE	@Id + '%'
	ORDER BY	[Id]


GO
