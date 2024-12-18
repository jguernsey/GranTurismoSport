CREATE PROCEDURE [dbo].[GTS_OrphanNumbers_Select]
	@PageNumber	 BIGINT
AS
	DECLARE @NumberCount BIGINT
	SET @NumberCount = (SELECT COUNT([Number]) FROM [dbo].[GTS_Nums])
	
	IF @NumberCount > 10
			BEGIN
				DECLARE @SplitNumber BIGINT
				SET @SplitNumber = (@NumberCount / 10);

				DECLARE @EndNumber BIGINT
				IF(@PageNumber = 10)
					BEGIN
						SET @EndNumber = @NumberCount
					END
				ELSE
					BEGIN
						SET @EndNumber = @SplitNumber * @PageNumber
					END;

				SELECT		[RowNumber], [Number]
				FROM
				(
					SELECT		[RowNumber] = ROW_NUMBER() OVER(ORDER BY [Number] ASC), [Number]
					FROM		[dbo].[GTS_Nums]
					WHERE		[Number] >= 1000000
				) T1
				WHERE ([RowNumber] > (@SplitNumber * (@PageNumber - 1)) AND [RowNumber] <= @EndNumber)
			END
		ELSE
			BEGIN
				IF(@PageNumber = 1)
					BEGIN
						SELECT		[RowNumber] = ROW_NUMBER() OVER(ORDER BY [Number] ASC), [Number]
						FROM		[dbo].[GTS_Nums]
						WHERE		[Number] >= 1000000
					END
				ELSE
					BEGIN
						SELECT 0, 0;
					END
			END


GO
