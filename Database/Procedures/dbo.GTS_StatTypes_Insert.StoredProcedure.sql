
CREATE PROCEDURE [dbo].[GTS_StatTypes_Insert]
	@StatType	NVARCHAR(32),
	@WorldProc	NVARCHAR(128),
	@CountryProc	NVARCHAR(128),
	@WorldPages		NVARCHAR(128),
	@CountryPages	NVARCHAR(128),
	@TableCaption	NVARCHAR(128),
	@Available		NVARCHAR(1)
AS
	INSERT INTO [dbo].[GTS_StatTypes] ([StatType], [WorldProc], [CountryProc], [WorldPages], [CountryPages], [TableCaption], [Available])
	VALUES (@StatType, @WorldProc, @CountryProc, @WorldPages, @CountryPages, @TableCaption, @Available)


GO
