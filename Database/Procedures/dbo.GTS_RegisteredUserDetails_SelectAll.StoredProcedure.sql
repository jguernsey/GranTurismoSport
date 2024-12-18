CREATE PROCEDURE [dbo].[GTS_RegisteredUserDetails_SelectAll]
	@PageNumber				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT

	SET @RecordCount = (SELECT COUNT([ProfileId]) FROM [dbo].[vw_GTS_RegisteredUserInfo])

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

	FROM		[dbo].[vw_GTS_RegisteredUserInfo]

	WHERE		[EntryNumber] > (@SplitNumber * (@PageNumber - 1)) AND [EntryNumber] <= @EndNumber

GO
