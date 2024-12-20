
 CREATE FUNCTION [dbo].[ConvertTimeToHHMMSS]
(
    @Time DECIMAL(28,3),
    @Unit VARCHAR(20)
)
RETURNS VARCHAR(20)
AS
BEGIN

    DECLARE @Seconds DECIMAL(18,3)
	DECLARE @Minutes INT
	DECLARE @Hours INT;
	DECLARE @Days INT;

    IF(@Unit = 'Hour' OR @Unit = 'HH' )
        SET @Seconds = @Time * 60 * 60;
    ELSE IF(@Unit = 'Minute' OR @Unit = 'MI' OR @Unit = 'N')
        SET @Seconds = @Time * 60;
    ELSE IF(@Unit = 'Second' OR @Unit = 'SS' OR @Unit = 'S')
        SET @Seconds = @Time;
    ELSE SET @Seconds = 0; -- UNKNOWN TIME UNITS

	SET @Days = CONVERT(INT, @Seconds / 60 / 60 / 24)
    SET @Hours = (CONVERT(INT, @Seconds /60 / 60) - (@Days * 24));
    SET @Minutes = CONVERT(INT, (@Seconds / 60) - (@Hours * 60 ) - (@Days * 24 * 60));
    SET @Seconds = CONVERT(INT, (@Seconds % 60));


    RETURN CONVERT(VARCHAR(32), CONVERT(VARCHAR(4), CONVERT(INT, @Days)) + ':' + RIGHT('00' + CONVERT(VARCHAR(2), CONVERT(INT, @Hours)), 2) + ':' + RIGHT('00' + CONVERT(VARCHAR(2), CONVERT(INT, @Minutes)), 2) + ':' + RIGHT('00' + CONVERT(VARCHAR(6), @Seconds), 2))

END

GO
