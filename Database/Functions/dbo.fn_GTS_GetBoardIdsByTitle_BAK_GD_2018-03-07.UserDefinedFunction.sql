 
CREATE FUNCTION [dbo].[fn_GTS_GetBoardIdsByTitle_BAK_GD_2018-03-07]
(
	@Title		NVARCHAR(32)
)
RETURNS TABLE
AS
	RETURN
	SELECT		[BoardId]
	FROM		[dbo].[GTS_EventDetail]				ed
	
	JOIN		[dbo].[GTS_Titles]					t
		ON		ed.[TitleId]				=		t.[Id]
	
	WHERE		t.[Title]					=		@Title
			AND		([ActiveStart]				<=		GETDATE()
		AND		[ActiveEnd]					>		GETDATE())

GO
