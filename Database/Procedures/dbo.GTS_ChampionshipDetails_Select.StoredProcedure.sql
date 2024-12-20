
CREATE PROCEDURE [dbo].[GTS_ChampionshipDetails_Select]
	@ChampionshipId		BIGINT
AS
	BEGIN
		SELECT	[Region], [SeasonId]
		FROM
		(
		SELECT	DISTINCT 
				[Region]	=	CASE s.[RegionId]
									WHEN		1
										THEN	'jp'
									WHEN		2
										THEN	'de'
									WHEN	3
										THEN	'us'
									WHEN	4
										THEN 'jp'
									WHEN	5
										THEN 'au'
									WHEN	6
										THEN 'us'
									WHEN	7
										THEN 'mx'
								END, 
				s.[SeasonId],
				[Channel]	=	CASE ed.[SportsModeId]
									WHEN		2
										THEN	12
									WHEN	3
										THEN	11
								END
		FROM	[dbo].[GTS_Seasons]			s
		JOIN	[dbo].[GTS_SeasonRounds]		sr
		ON		s.Id = sr.[SeasonId]
		JOIN	[dbo].[GTS_EventDetail]				ed
			ON	sr.[EventId]				=		ed.[EventId]
		WHERE	s.[Processed]				=		'N'
		) T1
		WHERE [Channel] = @ChampionshipId
		ORDER BY [Region] DESC, [SeasonId] DESC
	END
GO
