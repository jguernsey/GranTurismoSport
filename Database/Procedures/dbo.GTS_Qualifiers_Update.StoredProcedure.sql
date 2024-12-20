




CREATE PROCEDURE [dbo].[GTS_Qualifiers_Update]
as

	truncate table [dbo].[GTS_QualifiersGlobal]
	insert into [dbo].[GTS_QualifiersGlobal]
	select raceboardid, max(globalrank) as drivers
	from GTS_RankedQualifyingHistory
	group by raceboardid

	truncate table [dbo].[GTS_QualifiersRegional]
	insert into [dbo].[GTS_QualifiersRegional]
	select boardid, max(regionalrank) as drivers
	from GTS_RankedQualifyingHistory
	group by boardid

	truncate table [dbo].[GTS_QualifiersCountry]
	insert into [dbo].[GTS_QualifiersCountry]
	select boardid, countryid, max(countryrank) as drivers
	from GTS_RankedQualifyingHistory
	group by boardid, countryid


GO
