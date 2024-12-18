

--exec GTS_Get_QualifyingHistoryByUser 'FK-Austria1911'

CREATE procedure [dbo].[GTS_GetUpcomingRaces]
as
select DATENAME(WEEKDAY, case when e.titleid <= 3 then e.activestart else e.ActiveEnd end) as WeekDay,
		convert(date, case when e.titleid <= 3 then e.activestart else e.ActiveEnd end) as RaceDate,
		t.Title, c.CategoryName, tr.Name, case when e.NeedDriverClass = '5' then 'Superstar Race' else 'Regular Race' end as RaceType
from GTS_EventDetail e
join GTS_Titles t on t.id = e.TitleId
join GTS_CarCategories c on c.CategoryId = e.CarCategoryId
join GTS_Tracks tr on tr.Id = e.CourseId
where e.ActiveEnd > getdate()
and e.RegionId = 2
order by 2, e.TitleId



GO
