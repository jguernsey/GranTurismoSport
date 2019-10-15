CREATE PROCEDURE [dbo].[GTS_StatType_Details]
	@StatType		NVARCHAR(32)
AS
	SELECT	[WorldProc], [CountryProc], [WorldPages], [CountryPages], [TableCaption]
	FROM	[dbo].[GTS_StatTypes]
	WHERE	[StatType]	=		@StatType


GO
