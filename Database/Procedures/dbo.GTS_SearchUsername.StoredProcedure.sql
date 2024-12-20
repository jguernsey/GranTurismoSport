CREATE PROCEDURE [dbo].[GTS_SearchUsername]
	@Username		NVARCHAR(32),
	@UserId			BIGINT
AS
	EXEC [dbo].[GTS_SearchHistory_Insert] @UserId, @Username

	IF NOT EXISTS(SELECT 1 FROM [dbo].[GTS_ExcludedUsernames] WHERE [Username] = @Username)
		BEGIN
			IF EXISTS(SELECT 1 FROM [dbo].[GTS_RegisteredUserRankings] WHERE [Id] = @Username)
				BEGIN
					SELECT [Category],
							[Value] =	CASE 
											WHEN [Category] = 'Car Count'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Cars Purchased'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Credit Earned'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Driver Rating'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Experience'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Fastest Laps'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Pole Positions'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Race Count'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Races Finished'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Time Played'
												THEN (SELECT [dbo].[ConvertTimeToHHMMSS](CONVERT(DECIMAL(28,3),[Value]), 'S'))
											WHEN [Category] = 'Total Distance'
												THEN FORMAT(CONVERT(FLOAT(53),[Value])/1000, 'N4')
											WHEN [Category] = 'Wins'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Wins Per Entry'
												THEN CAST(FORMAT((CONVERT(FLOAT(53),[Value]) * 100), 'N3') AS NVARCHAR(32)) + ' %'
										END, 
							[WorldRank],
							[CountryRank],
							[RegionRank],
							[EntryDate]
					
							FROM			[dbo].[GTS_RegisteredUserRankings]
					
							WHERE			[Id] = @Username
						END
					ELSE
						BEGIN
							SELECT	[Category],
									[Value] =	CASE 
											WHEN [Category] = 'Car Count'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Cars Purchased'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Credit Earned'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Driver Rating'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Experience'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Fastest Laps'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Pole Positions'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Race Count'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Races Finished'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Time Played'
												THEN (SELECT [dbo].[ConvertTimeToHHMMSS](CONVERT(DECIMAL(28,3),[Value]), 'S'))
											WHEN [Category] = 'Total Distance'
												THEN FORMAT(CONVERT(FLOAT(53),[Value])/1000, 'N4')
											WHEN [Category] = 'Wins'
												THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
											WHEN [Category] = 'Wins Per Entry'
												THEN CAST(FORMAT((CONVERT(FLOAT(53),[Value]) * 100), 'N3') AS NVARCHAR(32)) + ' %'
											END,
											[WorldRank],
											[CountryRank],
											[RegionRank],
											[EntryDate]
									FROM
									(
										SELECT @UserName AS [Id], 'Car Count' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_CarCount]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Cars Purchased' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_CarsPurchased]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Credit Earned' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_CreditEarned]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Driver Rating' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_DriverRating]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Experience' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_Experience]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Fastest Laps' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_FastestLaps]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Pole Positions' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_PolePositions]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Race Count' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_RaceCount]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Races Finished' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_RacesFinished]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Time Played' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_TimePlayed]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Total Distance' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_TotalDistance]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Wins' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_Wins]
										WHERE	[Id] = @UserName
										UNION
										SELECT @UserName AS [Id], 'Wins Per Entry' AS [Category], COALESCE([Rank], '-') AS [WorldRank], COALESCE([CountryRank], '-') AS [CountryRank], COALESCE([Value], '-') AS [Value], COALESCE([EntryDate], '-') AS [EntryDate], COALESCE([RegionRank], '-') AS [RegionRank]
										FROM [dbo].[GTS_WinsPerEntry]
										WHERE	[Id] = @UserName
							) T1
						END
				END

GO
