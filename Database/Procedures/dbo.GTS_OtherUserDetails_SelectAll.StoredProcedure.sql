CREATE PROCEDURE [dbo].[GTS_OtherUserDetails_SelectAll]
	@PageNumber				BIGINT,
	@CountryId				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT

	SET @RecordCount = (SELECT COUNT([ProfileId]) FROM [dbo].[vw_GTS_OtherUserInfo] WHERE [CountryId] = @CountryId)

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

	FROM		[dbo].[vw_GTS_OtherUserInfo]

	WHERE		[CountryId]		=		@CountryId
		AND		([EntryNumber] > (@SplitNumber * (@PageNumber - 1)) AND [EntryNumber] <= @EndNumber)

GO
