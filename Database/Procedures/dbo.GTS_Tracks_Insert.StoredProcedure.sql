
CREATE PROCEDURE [dbo].[GTS_Tracks_Insert]
	@TrackName		NVARCHAR(128)
AS
	INSERT INTO [dbo].[GTS_Tracks] ([Name]) VALUES (@TrackName)


GO
