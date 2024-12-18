
CREATE FUNCTION [dbo].[fn_GTS_GetBoardIdsByTitle_GD]
(
	@Title		NVARCHAR(32)
)
RETURNS @T TABLE(BoardId bigint)
AS
begin

declare @Now datetime
set @Now = GETDATE()

if @Title like 'Daily%' --for daily races
	INSERT INTO @T
	SELECT		[BoardId]
	FROM		[dbo].[GTS_EventDetail]				ed
	
	JOIN		[dbo].[GTS_Titles]					t
		ON		ed.[TitleId]				=		t.[Id]
	
	WHERE		t.[Title]					=		@Title
			AND		[ActiveStart]				<=		@Now
		AND		[ActiveEnd]					>		@Now;
else --for FIA races
	INSERT INTO @T
	SELECT b.[BoardId]
	FROM GTS_EventDetail a
	join GTS_EventDetail b	on b.roundid = a.roundid --get the same round for FIA
							and b.ChampionshipId = a.ChampionshipId --match Nations/Manufacturers
							and DATEPART(year, b.activestart) = DATEPART(year, a.activestart)
							and DATEPART(week, b.activestart) = DATEPART(week, a.activestart) --match week and year
	JOIN GTS_Titles t ON a.TitleId = t.Id
	WHERE t.Title = @Title
	AND a.ActiveStart <= @Now
	AND a.ActiveEnd > @Now
	AND a.regionid = (select top 1 regionid from GTS_EventDetail where roundid > 0 and ActiveStart <= @Now and ActiveEnd > @Now order by RoundId); --get the event with the mallest roundid as "master"
RETURN
end

GO
