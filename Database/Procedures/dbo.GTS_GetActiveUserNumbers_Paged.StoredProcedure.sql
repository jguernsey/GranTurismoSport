
CREATE PROCEDURE [dbo].[GTS_GetActiveUserNumbers_Paged]
	@PageNumber				BIGINT
AS
	BEGIN
		DECLARE @TotalCount BIGINT
		DECLARE @EndNumber BIGINT
		DECLARE @SplitNumber BIGINT

		SET @TotalCount = (SELECT	COUNT([NewProfileNumber]) AS [TotalCount]	FROM	[dbo].[GTS_NewProfileNumbers_Ranked])
		SET @SplitNumber = (@TotalCount / 10);
	
		IF(@PageNumber = 10)
			BEGIN
				SET @EndNumber = @TotalCount
			END
		ELSE
			BEGIN
				SET @EndNumber = @SplitNumber * @PageNumber
			END

		SELECT		[ProfileId], [ProfileNumber], [CountryId]
		FROM
		(
			SELECT		ROW_NUMBER() OVER (ORDER BY [ProfileNumber])	AS [RowNumber],
						[ProfileId],
						[ProfileNumber],
						[CountryId]
			FROM
			(
				SELECT		p.[ProfileId], p.[ProfileNumber], p.[CountryId]

				FROM		[dbo].[GTS_RaceRankings]			rr

				JOIN		[dbo].[GTS_Profiles]				p
					ON		rr.[UserId]					=		p.[Id]
				UNION
				SELECT		p.[ProfileId], p.[ProfileNumber], p.[CountryId]

				FROM		[dbo].[GTS_EventResults]			er

				JOIN		[dbo].[GTS_Profiles]				p
					ON		er.[UserNumber]				=		p.[ProfileNumber]
			)	T1
		)	T2
		WHERE
		(
					[RowNumber]		>		(@SplitNumber * (@PageNumber - 1))
			AND		[RowNumber]		<=		@EndNumber
		)
		
		ORDER BY		[ProfileNumber]
	END

GO
