
CREATE PROCEDURE [dbo].[GTS_RegisteredUserRankings_Insert]
AS
	DECLARE @UserName NVARCHAR(32)
	
	DECLARE userCursor CURSOR FOR 
	SELECT DISTINCT [PropertyValue] FROM [UserProfile] WHERE [PropertyDefinitionID] = 45 AND [PropertyValue] IN (SELECT [Id] FROM [dbo].[GTS_Profiles])

	OPEN userCursor
	FETCH NEXT FROM userCursor INTO @UserName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		EXEC [dbo].[GTS_RegisteredUserUpdateSingle] @UserName

		FETCH NEXT FROM userCursor INTO @UserName
	END
	
	CLOSE userCursor
	DEALLOCATE userCursor


GO
