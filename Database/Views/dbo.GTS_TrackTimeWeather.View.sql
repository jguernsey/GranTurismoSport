CREATE VIEW [dbo].[GTS_TrackTimeWeather]
AS
	SELECT		tw.[TrackId],
				tw.[Code],
				[Time], 
				[WeatherType]
	
	FROM		[dbo].[GTS_TrackWeather]			tw

	JOIN		[dbo].[GTS_TrackTimes]				tt
		ON		tw.[TimeId]					=		tt.[Id]

	JOIN		[dbo].[GTS_Tracks]					t
		ON		tw.TrackId					=		t.Id

	JOIN		[dbo].[GTS_WeatherTypes]			wt
		ON		tw.[TypeId]					=		wt.[Id]

GO
