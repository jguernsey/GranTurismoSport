CREATE VIEW [dbo].[GTS_v_NewProfileNumbers_Ranked]
AS
	SELECT	ROW_NUMBER() OVER(ORDER BY [ProfileNumber])	AS [RowNumber],
			[ProfileNumber]
	FROM	[dbo].[GTS_v_NewProfileNumbers]

GO
