CREATE VIEW [dbo].[GTS_MissingStatsPercentageByCountry]
AS
	SELECT t1.[CountryId], [TotalCount], [ImportCount], [TotalCount]-[ImportCount] AS [MissingCount], CONVERT(DECIMAL(7,4),(CONVERT(FLOAT(53),[TotalCount]-[ImportCount])/CONVERT(FLOAT(53),[TotalCount]) * 100)) AS [PercentMissing]
	FROM
	(
		SELECT		COALESCE(COUNT([ProfileId]),0) AS [TotalCount], [CountryId]
		FROM		[GTS_Profiles]
		GROUP BY	[CountryId]
	) t1
	JOIN
	(
		SELECT	c.[CountryId], COALESCE(COUNT(DISTINCT ps.[ProfileId]),0) AS [ImportCount]
	
		FROM	[GTS_ProfileStats]			ps

		JOIN	[GTS_Profiles]				p 
			ON	ps.[ProfileId]		=		p.[ProfileId]

		JOIN	[GTS_Countries]				c
			ON	p.[CountryId]		=		c.[CountryId]

		GROUP BY c.[CountryId]
	) t2
	ON t1.[CountryId] = t2.[CountryId]

GO
