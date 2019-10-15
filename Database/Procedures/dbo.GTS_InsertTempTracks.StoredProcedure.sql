CREATE PROCEDURE [dbo].[GTS_InsertTempTracks]
	@Index INT,
	@Code VARCHAR(64),
	@Country_Code VARCHAR(2),
	@country_tag INT,
	@tag INT,
	@length INT
AS
	INSERT INTO GTS_TempTracks ([Index],[Code],[CountryCode],[CountryTag],[Tag],[Length])
	VALUES (@index,@code,@country_code,@country_tag,@tag,@length)

GO
