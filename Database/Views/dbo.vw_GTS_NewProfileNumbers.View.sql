CREATE VIEW [dbo].[vw_GTS_NewProfileNumbers]
AS
	SELECT		RANK() OVER(ORDER BY [ProfileNumber]) AS [Rank],
				[ProfileNumber]
	FROM
	(
		SELECT [ProfileNumber] FROM [dbo].[GTS_RunningProfileNumbers]
		EXCEPT
		SELECT [ProfileNumber] FROM [dbo].[GTS_Profiles]
	) p1

GO
