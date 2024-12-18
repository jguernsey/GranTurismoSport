
CREATE PROCEDURE [dbo].[GTS_RegisteredUsersLastUpdate_SelectAll]
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

	SELECT		rui.[ProfileId], [ProfileNumber], COALESCE(lu.[UpdateDate],CONVERT(DATETIME,'1753-01-01')) AS [LastUpdate]

	FROM		[dbo].[vw_GTS_RegisteredUserInfo]			rui

	LEFT JOIN	[dbo].[GTS_LastUpdate]						lu
		ON		rui.[ProfileId]					=			lu.[ProfileId]

	WHERE		[EntryNumber] > (@SplitNumber * (@PageNumber - 1)) AND [EntryNumber] <= @EndNumber


GO
