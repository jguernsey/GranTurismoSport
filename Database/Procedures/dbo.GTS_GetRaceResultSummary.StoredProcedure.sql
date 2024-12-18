
CREATE PROCEDURE [dbo].[GTS_GetRaceResultSummary]
	@Id				NVARCHAR(32)
AS

SELECT	
		SUM([Total])	AS	[Total],
		SUM([First])	AS [First],
		SUM([Second])	AS	[Second],
		SUM([Third])	AS	[Third],
		SUM([TopFive]) AS	[TopFive],
		SUM([TopTen])	AS	[TopTen],
		SUM([Outside])	AS	[Other]
FROM
(
SELECT	
		[Total] = CASE 
						WHEN [Rank] > 0
							THEN 1
						ELSE 0
					END,
		[First] = CASE [Rank]
					WHEN 1
						THEN 1
					ELSE 0
				END,
		[Second] = CASE [Rank]
					WHEn 2
						THEN 1
					ELSE 0
				END,
		[Third] = CASE [Rank]
					WHEN 3
						THEN 1
					ELSE 0
				END,
		[TopFive] = CASE 
						WHEN [Rank] >= 1 AND [Rank] <= 5
							THEN 1
						ELSE 0
					END,
		[TopTen] = CASE
						WHEN [Rank] >= 1 AND [Rank] <= 10
							THEN 1
						ELSE 0
					END,
		[Outside] = CASE
						WHEN [Rank] > 10
							THEN 1
						ELSE 0
					END
FROM	[dbo].[GTS_EventResults]

WHERE	[UserNumber] = (SELECT [ProfileNumber] FROM [dbo].[GTS_Profiles] WHERE [Id] = @Id)

) T1

GO
