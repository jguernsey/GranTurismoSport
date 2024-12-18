CREATE PROCEDURE [dbo].[GTS_TopUserNames_Insert]
AS
	TRUNCATE TABLE [dbo].[GTS_TopUserNames];

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_ProfileStats]				ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[CarCount]								DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber] 
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_ProfileStats]				ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[PurchasedCars]							DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber] 
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_ProfileStats]				ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[CreditEarned]							DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_ProfileStats]				ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[DriverPoint]							DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_ProfileStats]				ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[Experience]
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_AchievementHistory]			ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[FastestLaps]							DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_AchievementHistory]			ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[PolePositions]							DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_ProfileStats]				ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[RaceCount]								DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_AchievementHistory]			ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[RacesFinished]							DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_AchievementHistory]			ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[PlayTime]								DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		[ProfileId], [ProfileNumber]
	FROM
	(
		SELECT		TOP(5000) p.[ProfileId], [ProfileNumber]
		FROM		[dbo].[GTS_Profiles]					p
		JOIN		[dbo].[GTS_AchievementHistory]			ps
			ON		p.[ProfileId]				=			ps.[ProfileId]
		ORDER BY	[Wins]									DESC
	) T1
	EXCEPT
	SELECT		[ProfileId], [ProfileNumber]
	FROM		[dbo].[GTS_TopUserNames]

	INSERT INTO [dbo].[GTS_TopUserNames] ([ProfileId], [ProfileNumber])
	SELECT		p.[ProfileId], [ProfileNumber]
	FROM		[dbo].[UserProfile]						up
	JOIN		[dbo].[GTS_Profiles]					p
		ON		up.[PropertyDefinitionID]	=			45
		AND		up.[PropertyValue]			=			p.[Id]


GO
