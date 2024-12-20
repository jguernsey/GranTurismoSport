

CREATE PROCEDURE [dbo].[GTS_GetQualifyingGlobalRankings]
	@RaceBoardId BigInt,
	@Page int = 1,
	@EntriesByPage int = 50
as

select t.Title, dbo.[fn_GTS_GetEventRaceDate](e.EventDetailId) as RaceDate,
		tr.Name as Track, cc.CategoryName as CarClass, p.Id, c.CountryCode, q.Score,
		q.GlobalRank, qg.GlobalDrivers, cast(q.GlobalRank as float) / qg.GlobalDrivers * 100 as GlobalPercentage,
		q.RegionalRank, qr.RegionalDrivers,cast(q.RegionalRank as float) / qr.RegionalDrivers * 100 as RegionalPercentage,
		q.CountryRank, qc.CountryDrivers, cast(q.CountryRank as float) / qc.CountryDrivers * 100 as CountryPercentage
from GTS_RankedQualifyingHistory q
join GTS_QualifiersGlobal qg on qg.RaceBoardId = q.RaceBoardId
join GTS_QualifiersRegional qr on qr.BoardId = q.BoardId
join GTS_QualifiersCountry qc on qc.BoardId = q.BoardId and qc.CountryId = q.CountryId
join GTS_EventDetail e on e.BoardId = q.BoardId
join GTS_Titles t on t.Id = e.TitleId
join GTS_Tracks tr on tr.id = e.courseid
join GTS_CarCategories cc on cc.CategoryId = e.CarCategoryId
join GTS_Profiles p on p.ProfileId = q.ProfileId
join GTS_Countries c on c.CountryId = q.CountryId
where q.RaceBoardId = @RaceBoardId
and q.GlobalRank between (@Page-1)*(@EntriesByPage)+1 and @Page*@EntriesByPage
order by q.GlobalRank


GO
