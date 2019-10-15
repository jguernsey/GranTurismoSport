CREATE VIEW [dbo].[GTS_v_NewProfileNumbers]
AS
	SELECT [Number] AS [ProfileNumber] FROM [dbo].[GTS_Nums]
	EXCEPT
	SELECT [ProfileNumber] FROM [dbo].[GTS_Profiles]

GO
