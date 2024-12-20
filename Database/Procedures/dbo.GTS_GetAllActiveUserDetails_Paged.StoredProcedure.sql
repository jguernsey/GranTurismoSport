
CREATE PROCEDURE [dbo].[GTS_GetAllActiveUserDetails_Paged]
	@PageNumber				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT

	SET @RecordCount = (SELECT COUNT([ProfileId]) FROM [dbo].[GTS_Profiles] WHERE [ProfileStatus] = 1)

	SET @SplitNumber = (@RecordCount / 10)
	
	IF(@PageNumber = 10)
		BEGIN
			SET @EndNumber = @RecordCount
		END
	ELSE
		BEGIN
			SET @EndNumber = @SplitNumber * @PageNumber
		END

	SELECT		[ProfileId], [ProfileNumber], [Region]
	FROM
	(
		SELECT		ROW_NUMBER() OVER(ORDER BY [ProfileId]) AS [RowNumber],
					p.[ProfileId],
					p.[ProfileNumber],
					[Region]	=	CASE	[RegionId]
							WHEN	1
								THEN 'jp'
							WHEN	2
								THEN 'de'
							WHEN	3
								THEN 'us'
						END

		FROM		[dbo].[GTS_Profiles]					p

		JOIN		[dbo].[GTS_Countries]					c
			ON		p.[CountryId]				=			c.[CountryId]

		WHERE		[ProfileStatus]				=			1
	) T1
	WHERE		([RowNumber] > (@SplitNumber * (@PageNumber - 1)) AND [RowNumber] <= @EndNumber)


GO
