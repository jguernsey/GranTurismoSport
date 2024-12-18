CREATE PROCEDURE [dbo].[GTS_GetProfilesMissingStats_Paged]
	@PageNumber				BIGINT
AS
BEGIN
		DECLARE @NumberCount BIGINT
		SET @NumberCount = (SELECT COUNT([ProfileNumber]) FROM [dbo].[vw_GTS_ProfilesMissingStats])
	
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
					END

				SELECT		[ProfileId], [ProfileNumber]
				FROM		[dbo].[vw_GTS_ProfilesMissingStats]
				WHERE		([RowId] > (@SplitNumber * (@PageNumber - 1)) AND [RowId] <= @EndNumber)
			END
		ELSE
			BEGIN
				IF(@PageNumber = 1)
					BEGIN
						SELECT		[ProfileId], [ProfileNumber]
						FROM		[dbo].[vw_GTS_ProfilesMissingStats]
					END
				ELSE
					BEGIN
						SELECT 0;
					END
			END
	END
GO
