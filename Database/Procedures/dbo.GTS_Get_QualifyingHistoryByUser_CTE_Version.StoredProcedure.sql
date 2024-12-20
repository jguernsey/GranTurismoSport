
CREATE procedure [dbo].[GTS_Get_QualifyingHistoryByUser_CTE_Version]
	@UserId				NVARCHAR(32)
as
with
Rankings(UserId, CountryId, RaceBoardId, BoardID, RaceDate, GlobalRank, RegionalRank, CountryRank, Score)
as (
	select	r.userid,
			r.CountryId,
			m.RaceBoardId,
			r.BoardId,
			m.RaceDate,
			row_number() over (partition by m.RaceBoardId order by r.score),
			row_number() over (partition by r.boardid order by r.score),
			row_number() over (partition by r.boardid, r.countryid order by r.score),
			r.score
	from gts_racerankings r
	join gts_raceboardmapping m on m.boardid = r.boardid
),
GlobalCount(RaceBoardId, GlobalCount)
as (
	select	m.RaceBoardId,
			count(m.RaceBoardId)
	from gts_racerankings r
	join gts_raceboardmapping m on m.boardid = r.boardid
	group by m.RaceBoardId
),
RegionalCount(BoardId, RegionalCount)
as (
	select	r.BoardId,
			count(r.BoardId)
	from gts_racerankings r
	group by r.BoardId
),
CountryCount(BoardId, CountryId, CountryCount)
as (
	select	r.BoardId,
			r.CountryId,
			count(r.BoardId)
	from gts_racerankings r
	group by r.BoardId, r.CountryId
),
--CTE only to eliminate duplicate BoardIds from GTS_EventDetails,, not necarry if duped get removed physically from table
EventDetailsNoDupes(EventId, BoardId) 
as (
	select min(EventId), BoardId
	from GTS_EventDetail
	group by BoardId
)
select r.UserId, tl.Title, car.CategoryName as CarClass, t.Name as Track, r.RaceDate,
		r.GlobalRank, gc.GlobalCount, r.RegionalRank, rc.RegionalCount, r.CountryRank, cc.CountryCount, r.Score
from Rankings r
join GlobalCount gc on gc.RaceBoardId = r.RaceBoardId
join RegionalCount rc on rc.BoardId = r.BoardId
join CountryCount cc on cc.BoardId = r.BoardId and cc.CountryId = r.CountryId
join EventDetailsNoDupes en on en.BoardId = r.RaceBoardId
join GTS_EventDetail e on e.EventId = en.EventId
join GTS_CarCategories car on car.CategoryId = e.CarCategoryId
join GTS_Tracks t on t.id = e.courseid
join GTS_Titles tl on tl.id = e.titleid
where r.UserId = @UserId
order by r.RaceDate desc

GO
