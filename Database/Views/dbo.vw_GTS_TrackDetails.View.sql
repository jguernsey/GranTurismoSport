CREATE VIEW	[dbo].[vw_GTS_TrackDetails]
AS
	SELECT  t.[Name],  tt.[Time], tod.[TimeOfDay], st.[SkyType]
	FROM	[dbo].[GTS_Tracks]							t
	JOIN	[dbo].[GTS_TrackWeather]					tw
	ON		t.Id						=				tw.TrackId
	JOIN	[dbo].[GTS_TrackTimes]						tt
	ON		tw.TimeId					=				tt.Id
	JOIN	[dbo].[GTS_WeatherTypes]					wt
	ON		tw.TypeId					=				wt.Id
	JOIN	[dbo].[GTS_TimeOfDay]						tod
	ON		wt.TimeOfDayId				=				tod.Id
	JOIN	[dbo].[GTS_SkyTypes]						st
	ON		wt.SkyTypeId				=				st.Id

GO
