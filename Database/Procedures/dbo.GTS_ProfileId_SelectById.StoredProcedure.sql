
CREATE PROCEDURE [dbo].[GTS_ProfileId_SelectById]
	@Id		NVARCHAR(32)
AS
	SELECT	[ProfileId]
	FROM	[dbo].[GTS_Profiles]
	WHERE	[Id]		=		@Id


GO
