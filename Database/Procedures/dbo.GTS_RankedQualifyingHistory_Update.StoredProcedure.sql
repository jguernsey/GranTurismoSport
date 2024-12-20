



CREATE PROCEDURE [dbo].[GTS_RankedQualifyingHistory_Update]
as
truncate table [GTS_RankedQualifyingHistory]
insert into [GTS_RankedQualifyingHistory]
select	p.ProfileId,
		row_number() over (partition by m.RaceBoardId order by r.score, r.CreateTime) as GlobalRank,
		row_number() over (partition by r.boardid order by r.score, r.CreateTime) as RegionalRank,
		row_number() over (partition by r.boardid, r.countryid order by r.score, r.CreateTime) as CountryRank,
		r.score,
		r.countryid,
		r.BoardId,
		m.raceboardid,
		r.RankingId
from gts_racerankings r
join gts_raceboardmapping m on m.boardid = r.boardid
join GTS_Profiles p on p.Id = r.UserId

GO
