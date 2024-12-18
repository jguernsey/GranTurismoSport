CREATE PROCEDURE [dbo].[GTS_RankedPlayerInfo_Select]
	@Id		NVARCHAR(32)
AS
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
						THEN FORMAT(CONVERT(FLOAT(53),[Value])/1000, 'N3')
					WHEN [Category] = 'Wins'
						THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
					WHEN [Category] = 'Wins Per Entry'
						THEN CAST(FORMAT((CONVERT(FLOAT(53),[Value]) * 100), 'N3') AS NVARCHAR(32)) + ' %'
					WHEN [Category] = 'Photos Taken'
						THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
					WHEN [Category] = 'Livery Created'
						THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
					WHEN [Category] = 'Photo Likes'
						THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
					WHEN [Category] = 'Livery Likes'
						THEN FORMAT(CONVERT(BIGINT,[Value]), 'N0')
				END, 
			FORMAT(CONVERT(BIGINT,[CountryRank]), 'N0')		AS	[CountryRank],
			FORMAT(CONVERT(BIGINT,[RegionRank]), 'N0')		AS	[RegionRank],
			FORMAT(CONVERT(BIGINT,[WorldRank]), 'N0')		AS	[WorldRank],
			[EntryDate]
	FROM	[dbo].[GTS_RegisteredUserRankings]
	WHERE	[Id] = @Id




GO
