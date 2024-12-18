CREATE PROCEDURE [dbo].[GTS_GetRegisteredUserDetails_Paged]
	@PageNumber				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT
	DECLARE @MinDate		DATETIME

	SET @MinDate = (SELECT DATEADD(HOUR,-2,GETDATE()))

	SET @RecordCount = (SELECT COUNT(DISTINCT rud.[ProfileId]) FROM [dbo].[GTS_RegisteredUserDetails] rud LEFT JOIN [dbo].[GTS_LastUpdate] lu ON rud.[ProfileId] = lu.[ProfileId] WHERE	[UpdateDate] <=	@MinDate)

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
				COALESCE([UpdateDate],CONVERT(DATETIME,'1753-01-01')) AS [UpdateDate],
				[Region]	=	CASE	[RegionId]
						WHEN	1
							THEN 'jp'
						WHEN	2
							THEN 'de'
						WHEN	3
							THEN 'us'
					END

	FROM		[dbo].[GTS_RegisteredUserDetails]		rud

	LEFT JOIN	[dbo].[GTS_LastUpdate]					lu
		ON		rud.[ProfileId]				=			lu.[ProfileId]

	JOIN		[dbo].[GTS_Profiles]					p
		ON		rud.[ProfileId]				=			p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]					c
		ON		p.[CountryId]				=			c.[CountryId]

	WHERE		[UpdateDate]				<=			@MinDate
		AND		(rud.[Id] > (@SplitNumber * (@PageNumber - 1)) AND rud.[Id] <= @EndNumber)

GO
