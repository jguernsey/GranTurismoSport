
 CREATE FUNCTION [dbo].[fn_GTS_GetEventRaceDate]
(
	@EventDetailId bigint
)
returns date
as 
begin
	return (select top 1 cast(case when championshipid = 0 then activestart else activeend end as date) as racedate
	from gts_eventdetail
	where EventDetailId = @EventDetailId)
end

GO
