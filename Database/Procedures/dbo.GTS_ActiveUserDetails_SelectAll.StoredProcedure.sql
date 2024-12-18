CREATE PROCEDURE [dbo].[GTS_ActiveUserDetails_SelectAll]
	@PageNumber				BIGINT,
	@CountryId				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT

	SET @RecordCount = (SELECT COUNT([ProfileId]) FROM [dbo].[vw_GTS_ActiveUserInfo] WHERE [CountryId] = @CountryId)
	IF @RecordCount > 45
		BEGIN
			SET @SplitNumber = (@RecordCount / 15)
			IF(@PageNumber = 15)
				BEGIN
					SET @EndNumber = @RecordCount
				END
			ELSE
				BEGIN
					SET @EndNumber = @SplitNumber * @PageNumber
				END

			SELECT		[ProfileId], [ProfileNumber], [CountryId], [CountryName], [RegionId], [Region]
			FROM
			(
				SELECT	ROW_NUMBER() OVER (ORDER BY [ProfileId]) AS [EntryNumber],
						[ProfileId], [ProfileNumber], [CountryId], [CountryName], [RegionId], [Region]
				
				FROM	[dbo].[vw_GTS_ActiveUserInfo]

				WHERE		[CountryId]		=		@CountryId
			) t1
			WHERE		([EntryNumber] > (@SplitNumber * (@PageNumber - 1)) AND [EntryNumber] <= @EndNumber)
		END
	ELSE
		BEGIN
			IF @PageNumber = 1
				BEGIN
					SELECT	[ProfileId], [ProfileNumber], [CountryId], [CountryName], [RegionId], [Region]
				
					FROM	[dbo].[vw_GTS_ActiveUserInfo]

					WHERE		[CountryId]		=		@CountryId
				END
			ELSE
				BEGIN
					SELECT 0, 0, 0, 0, 0, 0
				END
		END

GO
