
 CREATE FUNCTION [dbo].[fn_GTS_GetPercentageValue]
(
	@Numerator				BIGINT,
	@Denominator			BIGINT
)
RETURNS NVARCHAR(32)
AS
	BEGIN
		DECLARE @ResultFloat	FLOAT(53)
		DECLARE @PercentNum		NUMERIC(8,4)
		DECLARE @RetVal			NVARCHAR(32)

		SET @ResultFloat = (CONVERT(FLOAT(53),@Numerator)/CONVERT(FLOAT(53),@Denominator))
		SET @PercentNum = (@ResultFloat * 100)
		SET @RetVal = CONVERT(NVARCHAR(32),CONCAT(CAST(@PercentNum AS NVARCHAR(12)),'%'))

		RETURN (@RetVal);
	END

GO
