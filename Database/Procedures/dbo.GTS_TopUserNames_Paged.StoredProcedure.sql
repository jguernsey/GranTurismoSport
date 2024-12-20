
CREATE PROCEDURE [dbo].[GTS_TopUserNames_Paged]
	@PageNumber		BIGINT
AS
	BEGIN
		DECLARE @RecordCount BIGINT
		SET @RecordCount = (SELECT COUNT([Id]) FROM [GTS_TopUserNames])

		IF(@RecordCount >= 10)
			BEGIN
				DECLARE @SplitNumber BIGINT
				SET @SplitNumber = (@RecordCount / 10);

				DECLARE @EndNumber BIGINT
				IF(@PageNumber = 10)
					BEGIN
						SET @EndNumber = @RecordCount
					END
				ELSE
					BEGIN
						SET @EndNumber = @SplitNumber * @PageNumber
					END;

				SELECT		[ProfileId],
							[ProfileNumber]
				FROM		[dbo].[GTS_TopUserNames]
				WHERE		[Id] > (@SplitNumber * (@PageNumber - 1)) AND [Id] <= @EndNumber
			END
		ELSE
			BEGIN
				IF(@PageNumber = 1)
					BEGIN
						SELECT		[ProfileId], [ProfileNumber]
						FROM		[dbo].[GTS_TopUserNames]
						ORDER BY	[ProfileNumber]
					END
				ELSE
					BEGIN
						SELECT 0, 0;
					END
			END
		END


GO
