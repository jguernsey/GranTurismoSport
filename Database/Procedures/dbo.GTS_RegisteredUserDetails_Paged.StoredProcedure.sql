CREATE PROCEDURE [dbo].[GTS_RegisteredUserDetails_Paged]
	@PageNumber				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT
	DECLARE @MinDate		DATETIME

	SET @MinDate = (SELECT DATEADD(HOUR,-2,GETDATE()))

	SET @RecordCount = (SELECT COUNT(DISTINCT ru.[ProfileId]) FROM [dbo].[GTS_RegisteredUserDetails] ru JOIN		[dbo].[GTS_LastUpdate]					lu
		ON		ru.[ProfileId]				=			lu.ProfileId WHERE [UpdateDate] < @MinDate)

	SET @SplitNumber = (@RecordCount / 10)
	
	IF(@PageNumber = 10)
		BEGIN
			SET @EndNumber = @RecordCount
		END
	ELSE
		BEGIN
			SET @EndNumber = @SplitNumber * @PageNumber
		END

	SELECT		rud.[ProfileId],
				rud.[ProfileNumber],
				lu.[UpdateDate]

	FROM		[dbo].[GTS_RegisteredUserDetails]		rud

	JOIN		[dbo].[GTS_LastUpdate]					lu
		ON		rud.[ProfileId]				=			lu.ProfileId

	WHERE		lu.[UpdateDate]				<			@MinDate
		AND		(rud.[Id] > (@SplitNumber * (@PageNumber - 1)) 
		AND		rud.[Id] <= @EndNumber)
	
GO
