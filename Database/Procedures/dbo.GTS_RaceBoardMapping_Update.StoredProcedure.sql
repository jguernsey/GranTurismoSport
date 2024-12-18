CREATE PROCEDURE [dbo].[GTS_RaceBoardMapping_Update]
as
truncate table [dbo].[GTS_RaceBoardMapping]

--Daily Races
insert into [GTS_RaceBoardMapping]
select distinct b.BoardId, a.BoardId, DATEADD(dd, 0, DATEDIFF(dd, 0, a.ActiveStart))
from GTS_EventDetail a
join GTS_EventDetail b	on DATEADD(dd, 0, DATEDIFF(dd, 0, b.ActiveStart)) = DATEADD(dd, 0, DATEDIFF(dd, 0, a.ActiveStart))
						and b.TitleId = a.TitleId
						and b.CourseId = a.CourseId
						and b.CarCategoryId = a.CarCategoryId
where a.regionid = 1
and a.activestart > '2017-01-01'
and a.TitleId between 1 and 3
order by b.BoardId

--FIA Races
--insert into [GTS_RaceBoardMapping]
--select distinct b.BoardId, a.BoardId, DATEADD(dd, 0, DATEDIFF(dd, 0, a.ActiveEnd))
--from GTS_EventDetail a
--join GTS_EventDetail b	on b.ChampionshipId = a.ChampionshipId
--						and b.RoundId = a.RoundId
--						and DATEPART(yy, b.ActiveStart) = DATEPART(yy, a.activestart)
--						and datepart(ww, b.ActiveStart) = DATEPART(ww, a.ActiveStart)
--where a.regionid = 1
--and a.activestart > '2017-01-01'
--and a.TitleId between 4 and 5
--and b.BoardId NOT IN (select distinct b.BoardId
--from GTS_EventDetail a
--join GTS_EventDetail b	on DATEADD(dd, 0, DATEDIFF(dd, 0, b.ActiveStart)) = DATEADD(dd, 0, DATEDIFF(dd, 0, a.ActiveStart))
--						and b.TitleId = a.TitleId
--						and b.CourseId = a.CourseId
--						and b.CarCategoryId = a.CarCategoryId
--where a.regionid = 1
--and a.activestart > '2017-01-01'
--and a.TitleId between 1 and 3)
--order by b.BoardId



GO
