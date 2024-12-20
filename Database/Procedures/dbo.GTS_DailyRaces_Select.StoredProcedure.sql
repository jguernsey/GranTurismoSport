
CREATE PROCEDURE [dbo].[GTS_DailyRaces_Select]
	@RegionId			BIGINT
AS
	SELECT		[Title],
				[CategoryName]																					AS	[CarCategory],
				t.[Name]																						AS	[Track],
				[RaceLimitLaps]																					AS	[Laps],
				[EntryMax]																						AS	[NoOfCars],
				[BalanceOfPower]	=	CASE	[UseBOP]
											WHEN	0
												THEN	'None'
											WHEN	1
												THEN	'Fixed'
											ELSE
												''
										END,
				[CarSettings]		=	CASE	[Tuning]
											WHEN	0
												THEN	'None'
											WHEN	1
												THEN	'Fixed'
											ELSE
												''
										END,
				[FuelConsumption]	=	CASE	[ConsumeFuel]
											WHEN 0
												THEN 'None'
											ELSE
												CONCAT(CONVERT(NVARCHAR(32),[ConsumeFuel]),'x')
										END,
				[TireWear]			=	CASE	[ConsumeTire]
											WHEN 0
												THEN 'None'
											ELSE
												CONCAT(CONVERT(NVARCHAR(32),[ConsumeTire]),'x')
										END,
				CONVERT(DECIMAL(28,4),CONVERT(FLOAT(53),t.[Length]) / 1000)										AS	[LapDistanceKm],
				CONVERT(DECIMAL(28,4),[RaceLimitLaps] * (CONVERT(FLOAT(53),t.[Length]) / 1000))					AS	[TotalDistanceKm],
				lt.[Name]																						AS	[LimitTire],
				[EventDetailId],
				[EventId],
				[BoardId]

	FROM		[dbo].[GTS_EventDetail]				ed

	JOIN		[dbo].[GTS_CarCategories]			cc
		ON		ed.[CarCategoryId]			=		cc.[CategoryId]
	
	JOIN		[dbo].[GTS_Titles]					tt
		ON		ed.[TitleId]				=		tt.[Id]

	JOIN		[dbo].[GTS_Tracks]					t
		ON		ed.[CourseId]				=		t.[Id]

	JOIN		[dbo].[GTS_Tires]					lt
		ON		ed.[LimitTireF] + 1			=		lt.[Id]

	WHERE		([ActiveStart]				<=		GETDATE()
		AND		[ActiveEnd]					>		GETDATE())

		AND		[RegionId]					=		@RegionId
						
	ORDER BY	[EventDetailId]
GO
