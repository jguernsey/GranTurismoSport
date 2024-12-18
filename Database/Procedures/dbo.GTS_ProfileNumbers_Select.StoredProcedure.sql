CREATE PROCEDURE [dbo].[GTS_ProfileNumbers_Select]
	@CountryId		BIGINT,
	@PageNumber		BIGINT
AS
	DECLARE @RecordCount BIGINT

	SET @RecordCount = (SELECT COUNT([ProfileId]) FROM [dbo].[GTS_Profiles] WHERE [CountryId] = @CountryId AND [ProfileStatus] = 1)
	
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
				END

			SELECT	[ProfileId],
					[ProfileNumber]
			FROM 
				(
					SELECT	ROW_NUMBER() OVER(ORDER BY [ProfileNumber] ASC)	AS	[ProfileCount],
							[ProfileId], 
							[ProfileNumber]

					FROM	[GTS_Profiles]
					WHERE	[CountryId]				=		@CountryId
						AND	[ProfileStatus]			=		1
				) psd
			WHERE	([ProfileCount] > (@SplitNumber * (@PageNumber - 1)) AND [ProfileCount] <= @EndNumber)
			ORDER BY [ProfileNumber]
		END
	ELSE
		BEGIN
			IF(@PageNumber = 1)
				BEGIN
					SELECT	[ProfileId],
							[ProfileNumber]
					FROM 
					(
						SELECT	ROW_NUMBER() OVER(ORDER BY [ProfileNumber] ASC)	AS	[ProfileCount],
								[ProfileId], 
								[ProfileNumber]

						FROM	[GTS_Profiles]
	
						WHERE	[CountryId]			=		@CountryId
						AND		[ProfileStatus]		=		1
					) psd
					ORDER BY [ProfileNumber]
				END
			ELSE
				BEGIN
					SELECT 0, 0;
				END
		END



GO
