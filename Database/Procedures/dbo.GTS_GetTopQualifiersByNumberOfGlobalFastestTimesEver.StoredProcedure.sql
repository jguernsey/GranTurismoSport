










CREATE PROCEDURE [dbo].[GTS_GetTopQualifiersByNumberOfGlobalFastestTimesEver]
as
with
baselist (PSNID, NumberOfGlobalFastestTimes)
as (
	select p.id, count(q.profileid) as NumberOfGlobalFastestTimes
	from [dbo].[GTS_RankedQualifyingHistory] q
	join GTS_Profiles p on p.profileid = q.profileid
	where q.globalrank = 1
	group by p.id
)
select	rank() over (order by NumberOfGlobalFastestTimes desc) as rank,
		PSNID, NumberOfGlobalFastestTimes
from baselist




GO
