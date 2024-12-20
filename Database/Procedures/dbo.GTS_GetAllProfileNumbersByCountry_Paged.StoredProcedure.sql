
CREATE PROCEDURE [dbo].[GTS_GetAllProfileNumbersByCountry_Paged]
	@CountryId				BIGINT,
	@PageNumber				BIGINT
AS
	DECLARE @TotalCount	BIGINT
	DECLARE @EndNumber BIGINT
	DECLARE @SplitNumber BIGINT

	SET @TotalCount = (SELECT COUNT([ProfileId]) FROM [dbo].[GTS_Profiles] WHERE [CountryId] = @CountryId AND [ProfileStatus] = 1)

	SET @SplitNumber = (@TotalCount / 10);
	
	IF(@PageNumber = 10)
		BEGIN
			SET @EndNumber = @TotalCount
		END
	ELSE
		BEGIN
			SET @EndNumber = @SplitNumber * @PageNumber
		END

	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		ROW_NUMBER() OVER (ORDER BY [ProfileNumber])	AS	[RowNumber],
					[ProfileId],
					[ProfileNumber]
			
		FROM		[dbo].[GTS_Profiles]

		WHERE		[CountryId]			=			@CountryId
			AND		[ProfileStatus]		=			1
	) T1

	WHERE		([RowNumber]		>		(@SplitNumber * (@PageNumber - 1))
		AND		([RowNumber]		<=		@EndNumber))
			
	ORDER BY		[ProfileNumber]

GO
