
CREATE PROCEDURE [dbo].[GTS_RequestTypes_Select]
AS
	BEGIN
		SELECT		[Id], 
					[RequestType]

		FROM		[dbo].[GTS_RequestTypes]

		ORDER BY	[Id]
	END

GO
