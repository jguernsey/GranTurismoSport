
CREATE PROCEDURE [dbo].[GTS_EventDetail_GetRegionBoard]
AS
	SELECT	[Region]	=	CASE [RegionId]
								WHEN	1
									THEN	'jp'
								WHEN	2
									THEN	'de'
								WHEN	3
									THEN	'us'
							END,
			[BoardId],
			[Title]

	FROM	[dbo].[GTS_EventDetail]			ed

	JOIN	[dbo].[gts_Titles]				t
		ON	ed.[TitleId]			=		t.[Id]

	WHERE	([ActiveStart]				<=		GETDATE()
		AND		[ActiveEnd]					>		GETDATE())
GO
