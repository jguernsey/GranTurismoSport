
CREATE PROCEDURE [dbo].[GTS_GetAllRegisteredUserDetails_Paged]
	@PageNumber				BIGINT
AS
	DECLARE @RecordCount	BIGINT
	DECLARE @EndNumber		BIGINT
	DECLARE @SplitNumber	BIGINT
	DECLARE @MinDate		DATETIME

	SET @MinDate = (SELECT DATEADD(HOUR,-2,GETDATE()))

	SET @RecordCount = (SELECT COUNT(DISTINCT [ProfileId]) FROM [dbo].[GTS_RegisteredUserDetails])

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
				[Region]	=	CASE	[RegionId]
						WHEN	1
							THEN 'jp'
						WHEN	2
							THEN 'de'
						WHEN	3
							THEN 'us'
					END

	FROM		[dbo].[GTS_RegisteredUserDetails]		rud

	JOIN		[dbo].[GTS_Profiles]					p
		ON		rud.[ProfileId]				=			p.[ProfileId]

	JOIN		[dbo].[GTS_Countries]					c
		ON		p.[CountryId]				=			c.[CountryId]

	WHERE		(rud.[Id] > (@SplitNumber * (@PageNumber - 1)) AND rud.[Id] <= @EndNumber)
GO
