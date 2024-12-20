CREATE PROCEDURE [dbo].[GTS_PlayerProfile_Insert]
	@Id				NVARCHAR(32),
	@ProfileNumber	BIGINT,
	@ProfileStatus	BIGINT,
	@CountryCode	NVARCHAR(2)
AS
	BEGIN
		INSERT INTO [dbo].[GTS_Profiles] ([Id], [ProfileNumber], [ProfileStatus], [CountryId], [CreateDate])
		VALUES (@Id, @ProfileNumber, @ProfileStatus, (SELECT [CountryId] FROM [dbo].[GTS_Countries] WHERE [CountryCode] = @CountryCode), GETDATE())
	END

GO
