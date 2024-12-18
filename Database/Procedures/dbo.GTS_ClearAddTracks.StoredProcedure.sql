
CREATE PROCEDURE [dbo].[GTS_ClearAddTracks]
	@Name			NVARCHAR(128),
	@Code			NVARCHAR(32),
	@CountryCode	NVARCHAR(2),
	@CountryTag		BIGINT,
	@Tag			BIGINT,
	@Length			BIGINT
AS
	UPDATE [dbo].[GTS_Tracks]
			SET		[Name]		=		@Name,
					[CountryCode]		=		@CountryCode,
					[CountryTag]		=		@CountryTag,
					[Tag]				=		@Tag,
					[Length]			=		@Length
			WHERE	[Code]				=		@Code

	IF @@ROWCOUNT = 0
		BEGIN
			INSERT INTO [dbo].[GTS_Tracks] ([Name], [Code], [CountryCode], [CountryTag], [Tag], [Length])
			VALUES	(@Name, @Code, @CountryCode, @CountryTag, @Tag, @Length)
		END

GO
