
CREATE PROCEDURE [dbo].[GTS_Experience_PageCount]
	@Country NVARCHAR(32) = NULL,
	@RegionId BIGINT = -99
AS
	SELECT COUNT([Id]) AS [TotalItems] FROM [dbo].[GTS_Experience] cc
		JOIN		[dbo].[GTS_Countries]			co
		ON		cc.[Country]			=		co.[CountryName]
	WHERE		(@Country				IS		NULL
		OR		([Country]				=		@Country
		AND		@RegionId				=		-99))
		AND		(@RegionId				=		-99
		OR		co.RegionId				=		@RegionId)
GO
