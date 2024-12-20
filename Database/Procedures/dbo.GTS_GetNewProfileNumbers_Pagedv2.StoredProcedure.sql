CREATE PROCEDURE [dbo].[GTS_GetNewProfileNumbers_Pagedv2]
	@PageNumber	 BIGINT
AS
	DECLARE @TotalCount BIGINT
	SET @TotalCount = (SELECT	COUNT([ProfileNumber]) AS [TotalCount]	FROM	[dbo].[GTS_NewProfileNumbers])

	IF(@TotalCount >= 300)
		BEGIN
			DECLARE @SplitNumber BIGINT
			SET @SplitNumber = (@TotalCount / 20);

			DECLARE @EndNumber BIGINT
			IF(@PageNumber = 20)
				BEGIN
					SET @EndNumber = @TotalCount
				END
			ELSE
				BEGIN
					SET @EndNumber = @SplitNumber * @PageNumber
				END

			SELECT		[ProfileNumber]
			
			FROM		[dbo].[GTS_NewProfileNumbers]
			
			WHERE		(
									[Id]		>		(@SplitNumber * (@PageNumber - 1))
							AND		[Id]		<=		@EndNumber
						)

			ORDER BY	[Id]
		END
	ELSE
		BEGIN
			IF(@PageNumber = 1)
				BEGIN
					SELECT		[ProfileNumber]

					FROM		[dbo].[GTS_NewProfileNumbers]

					ORDER BY	[ProfileNumber]
				END
			ELSE
				BEGIN
					SELECT 0, 0;
				END
		END
GO
