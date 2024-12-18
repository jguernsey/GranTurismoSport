
CREATE VIEW [dbo].[GTS_NewProfileNumbers_Ranked]
AS
	SELECT		ROW_NUMBER() OVER(ORDER BY [Number] ASC)	AS	[NumberOrder],
				[Number]									AS	[NewProfileNumber]
	FROM
	(
		SELECT		nm.[Number],
					pro.[ProfileNumber]
	
		FROM		[dbo].[GTS_Nums]				nm

		LEFT JOIN	[dbo].[GTS_Profiles]			pro
			ON		nm.[Number]				=		pro.[ProfileNumber]
	) np
	WHERE		np.[ProfileNumber]			IS		NULL

GO
