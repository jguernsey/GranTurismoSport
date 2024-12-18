
CREATE PROCEDURE [dbo].[GTS_RegisteredUserUpdateSingle]
	@UserName		NVARCHAR(32)
AS
	DELETE FROM [dbo].[GTS_RegisteredUserRankings] WHERE [Id] = @UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Car Count', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_CarCount]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Cars Purchased', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_CarsPurchased]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Credit Earned', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_CreditEarned]
	WHERE	[Id] = @UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Driver Rating', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_DriverRating]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Experience', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_Experience]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Fastest Laps', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_FastestLaps]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Pole Positions', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_PolePositions]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Race Count', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_RaceCount]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Races Finished', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_RacesFinished]
	WHERE	[Id] = @UserName
		
	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Time Played', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_TimePlayed]
	WHERE	[Id] = @UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Total Distance', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_TotalDistance]
	WHERE	[Id] = @UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Wins', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_Wins]
	WHERE	[Id] = @UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Wins Per Entry', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM [dbo].[GTS_WinsPerEntry]
	WHERE	[Id] = @UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Photos Taken', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM	[dbo].[GTS_PhotosTaken]			pt
	JOIN	[dbo].[GTS_Profiles]			p
	ON		pt.[ProfileId]				=	p.[ProfileId]
	WHERE	p.[Id]						=	@UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Livery Created', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM	[dbo].[GTS_LiveryCreated]		lc
	JOIN	[dbo].[GTS_Profiles]			p
	ON		lc.[ProfileId]				=	p.[ProfileId]
	WHERE	p.[Id]						=	@UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Photo Likes', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM	[dbo].[GTS_PhotoLikes]			pl
	JOIN	[dbo].[GTS_Profiles]			p
	ON		pl.[ProfileId]				=	p.[ProfileId]
	WHERE	p.[Id]						=	@UserName

	INSERT INTO [dbo].[GTS_RegisteredUserRankings] ([Id], [Category], [WorldRank], [CountryRank], [Value], [EntryDate], [RegionRank])
	SELECT @UserName, 'Livery Likes', COALESCE([Rank], '-'), COALESCE([CountryRank], '-'), COALESCE([Value], '-'), COALESCE([EntryDate], '-'), COALESCE([RegionRank], '-')
	FROM	[dbo].[GTS_LiveryLikes]			ll
	JOIN	[dbo].[GTS_Profiles]			p
	ON		ll.[ProfileId]				=	p.[ProfileId]
	WHERE	p.[Id]						=	@UserName

GO
