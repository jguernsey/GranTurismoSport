CREATE PROCEDURE [dbo].[GTS_UpdateSportsmanshipRatings]
AS
	INSERT INTO [GTS_SportsmanshipRating] ([ClassId], [PlayerCount], [Percentage])
	SELECT	[SportsmanshipRating],
			[ClassCount], 
			CONVERT(DECIMAL(8,4),(CONVERT(FLOAT(53),[ClassCount])/(CONVERT(FLOAT(53),(SELECT COUNT([ProfileId])	FROM [dbo].[GTS_ProfileStats] WHERE [RaceCount] > 0)))) * 100) AS [Percentage]
	FROM
	(
		SELECT  [SportsmanshipRating], COUNT([ProfileId]) AS [ClassCount]
		FROM
		(
			SELECT 	[SportsmanshipRating] = CASE 
											WHEN [MannerPoint] >= 80
												THEN 6 
											WHEN [MannerPoint] >= 65 AND [MannerPoint] <= 79
												THEN 5
											WHEN [MannerPoint] >= 40 AND [MannerPoint] <= 64
												THEN 4
											WHEN [MannerPoint] >= 20 AND [MannerPoint] <= 39
												THEN 3
											WHEN [MannerPoint] >= 10 AND [MannerPoint] <= 19
												THEN 2
											WHEN [MannerPoint] <= 9
												THEN 1
										END, [ProfileId]
			FROM [dbo].[GTS_ProfileStats]
			WHERE [RaceCount] > 0
		) T2
		GROUP BY [SportsmanshipRating]
	) T1





GO
