
CREATE PROCEDURE [dbo].[GTS_ActiveUserLastUpdate_SelectAll]
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

			SELECT			[ProfileId], [ProfileNumber], [LastUpdate]
			FROM
			(
				SELECT		ROW_NUMBER() OVER (ORDER BY rui.[ProfileId]) AS [EntryNumber],
							rui.[ProfileId], [ProfileNumber], COALESCE(lu.[UpdateDate],CONVERT(DATETIME,'1753-01-01')) AS [LastUpdate]
				
				FROM		[dbo].[vw_GTS_ActiveUserInfo]				rui

				LEFT JOIN	[dbo].[GTS_LastUpdate]						lu
					ON		rui.[ProfileId]					=			lu.[ProfileId]

				WHERE		[CountryId]		=		@CountryId
			) t1
			WHERE		([EntryNumber] > (@SplitNumber * (@PageNumber - 1)) AND [EntryNumber] <= @EndNumber)
		END
	ELSE
		BEGIN
			IF @PageNumber = 1
				BEGIN
					SELECT		rui.[ProfileId], [ProfileNumber], COALESCE(lu.[UpdateDate],CONVERT(DATETIME,'1753-01-01')) AS [LastUpdate]
				
					FROM		[dbo].[vw_GTS_ActiveUserInfo]				rui

					LEFT JOIN	[dbo].[GTS_LastUpdate]						lu
						ON		rui.[ProfileId]					=			lu.[ProfileId]

					WHERE		[CountryId]		=		@CountryId
				END
			ELSE
				BEGIN
					SELECT 0, 0, CONVERT(DATETIME,'1753-01-01')
				END
		END


GO
