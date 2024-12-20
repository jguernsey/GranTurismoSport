
CREATE PROCEDURE [dbo].[GTS_DriversByClass_Update]
AS
	INSERT INTO [GTS_DriversByClass] ([ClassId], [PlayerCount], [Percentage])
	SELECT	[DriverClass], 
			[ClassCount], 
			CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),[ClassCount])/(CONVERT(FLOAT(53),(SELECT COUNT([ProfileId])	FROM [dbo].[GTS_ProfileStats] WHERE [RaceCount] > 0)))) * 100) AS [Percentage]
	FROM
	(
		SELECT		[DriverClass],
					COUNT([ProfileId])	AS	[ClassCount]

		FROM		[dbo].[GTS_ProfileStats]

		WHERE		[RaceCount]			>		0

		GROUP BY	[DriverClass]
	) T1


GO
