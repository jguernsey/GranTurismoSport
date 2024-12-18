
CREATE procedure [dbo].[GTS_Get_QualifyingHistoryByUser]
	@UserId				NVARCHAR(32)
as
declare @ProfileId bigint
set @ProfileId = (select top 1 ProfileId from GTS_Profiles where Id = @UserId)

select t.Title, dbo.[fn_GTS_GetEventRaceDate](e.EventDetailId) as RaceDate,
		tr.Name as Track, cc.CategoryName as CarClass, q.RaceBoardId, q.BoardId, q.CountryId, q.Score,
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
where q.ProfileId = @ProfileId
and e.NeedDriverClass != '5' --to filter out Superstar Races (duplicate BoardIds)
order by dbo.[fn_GTS_GetEventRaceDate](e.EventDetailId) desc, e.titleid asc

GO
