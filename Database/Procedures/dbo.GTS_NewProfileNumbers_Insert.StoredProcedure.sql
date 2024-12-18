CREATE PROCEDURE [dbo].[GTS_NewProfileNumbers_Insert]
AS
	TRUNCATE TABLE [dbo].[GTS_NewProfileNumbers]

	INSERT INTO		[dbo].[GTS_NewProfileNumbers]		([ProfileNumber])
	SELECT			[ProfileNumber]
	FROM			
	(
		SELECT [Number]	AS [ProfileNumber] FROM [dbo].[GTS_Nums] WHERE [Number] NOT IN (SELECT [ProfileNumber] FROM [dbo].[GTS_Profiles])
	) T1

GO
