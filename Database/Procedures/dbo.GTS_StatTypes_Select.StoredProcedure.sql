CREATE PROCEDURE [dbo].[GTS_StatTypes_Select]
AS
	SELECT		[StatTypeId], 
				[StatType]
	FROM		[dbo].[GTS_StatTypes]
	WHERE		[Available] = 'Y'
	ORDER BY	[StatType]


GO
