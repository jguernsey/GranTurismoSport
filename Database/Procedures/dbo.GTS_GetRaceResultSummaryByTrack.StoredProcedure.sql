CREATE PROCEDURE [dbo].[GTS_GetRaceResultSummaryByTrack]
	@Id				NVARCHAR(32)
AS

SELECT	[Track],
		SUM([Total])	AS	[Total],
		SUM([First])	AS [First],
		SUM([Second])	AS	[Second],
		SUM([Third])	AS	[Third],
		SUM([TopFive]) AS	[TopFive],
		SUM([TopTen])	AS	[TopTen],
		SUM([Outside])	AS	[Other],
		0				AS	[Sorting]
FROM
(
SELECT	t.[Name]	AS	[Track],
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
FROM	[dbo].[GTS_EventResults]				er

JOIN	[dbo].[GTS_EventHeader]					eh
	ON	er.[EventCalendarId]			=		eh.[EventCalendarId]

JOIN	[dbo].[GTS_EventDetail]					ed
	ON	eh.[EventId]					=		ed.[EventId]

JOIN	[dbo].[GTS_Tracks]						t
	ON	ed.[CourseId]					=		t.[Id]

WHERE	[UserNumber] = (SELECT [ProfileNumber] FROM [dbo].[GTS_Profiles] WHERE [Id] = @Id)
) T1
GROUP BY [Track]
UNION
SELECT 'Total' AS [Track],
		SUM([Total])	AS	[Total],
		SUM([First])	AS [First],
		SUM([Second])	AS	[Second],
		SUM([Third])	AS	[Third],
		SUM([TopFive]) AS	[TopFive],
		SUM([TopTen])	AS	[TopTen],
		SUM([Other])	AS	[Other],
		99				AS	[Sorting]
FROM
(
	SELECT	[Track],
			SUM([Total])	AS	[Total],
			SUM([First])	AS [First],
			SUM([Second])	AS	[Second],
			SUM([Third])	AS	[Third],
			SUM([TopFive]) AS	[TopFive],
			SUM([TopTen])	AS	[TopTen],
			SUM([Outside])	AS	[Other]
	FROM
	(
		SELECT	t.[Name]	AS	[Track],
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
		FROM	[dbo].[GTS_EventResults]				er

		JOIN	[dbo].[GTS_EventHeader]					eh
			ON	er.[EventCalendarId]			=		eh.[EventCalendarId]

		JOIN	[dbo].[GTS_EventDetail]					ed
			ON	eh.[EventId]					=		ed.[EventId]

		JOIN	[dbo].[GTS_Tracks]						t
			ON	ed.[CourseId]					=		t.[Id]

		WHERE	[UserNumber] = (SELECT [ProfileNumber] FROM [dbo].[GTS_Profiles] WHERE [Id] = @Id)

	) T1
	GROUP BY [Track]
) T2
ORDER BY [Sorting], [Track]
GO
