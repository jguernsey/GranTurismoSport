
CREATE PROCEDURE [dbo].[GTS_ProfileNumber_SelectById]
	@Id		NVARCHAR(32)
AS
	SELECT	[ProfileNumber]
	FROM	[dbo].[GTS_Profiles]
	WHERE	[Id]		=		@Id


GO
