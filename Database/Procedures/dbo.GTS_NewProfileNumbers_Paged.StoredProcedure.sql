CREATE PROCEDURE [dbo].[GTS_NewProfileNumbers_Paged]
	@PageNumber	 BIGINT
AS
	DECLARE @TotalCount BIGINT
	SET @TotalCount = (SELECT	COUNT([NewProfileNumber]) AS [TotalCount]	FROM	[dbo].[GTS_NewProfileNumbers_Ranked])

	IF(@TotalCount >= 10)
		BEGIN
			DECLARE @SplitNumber BIGINT
			SET @SplitNumber = (@TotalCount / 10);

			DECLARE @EndNumber BIGINT
			IF(@PageNumber = 10)
				BEGIN
					SET @EndNumber = @TotalCount
				END
			ELSE
				BEGIN
					SET @EndNumber = @SplitNumber * @PageNumber
				END

			SELECT		[NewProfileNumber]
			
			FROM		[dbo].[GTS_NewProfileNumbers_Ranked]
			
			WHERE		(
									[NumberOrder]		>		(@SplitNumber * (@PageNumber - 1))
							AND		[NumberOrder]		<=		@EndNumber
						)

			ORDER BY	[NumberOrder]
		END
	ELSE
		BEGIN
			IF(@PageNumber = 1)
				BEGIN
					SELECT		[NewProfileNumber]

					FROM		[dbo].[GTS_NewProfileNumbers_Ranked]

					ORDER BY	[NumberOrder]
				END
			ELSE
				BEGIN
					SELECT 0, 0;
				END
		END
GO
