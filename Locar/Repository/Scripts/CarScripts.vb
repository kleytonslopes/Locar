NotInheritable Class CarScripts
    Public Shared QueryInsert As String =
    "INSERT INTO T_CARS (
          CAR_MAKE         
        , CAR_MODEL        
        , CAR_COLOR        
        , CAR_YEAR         
        , CAR_LICENSE_PLATE
        , CAR_PRICE        
    ) VALUES ( 
          @CAR_MAKE         
        , @CAR_MODEL        
        , @CAR_COLOR        
        , @CAR_YEAR         
        , @CAR_LICENSE_PLATE
        , @CAR_PRICE 
    )"

    Public Shared QuerySelectByLicensePlate As String =
    "SELECT
          CAR_ID            As Id 
        , CAR_MAKE          AS Make 
        , CAR_MODEL         AS Model 
        , CAR_COLOR         AS Color 
        , CAR_YEAR          AS Year 
        , CAR_LICENSE_PLATE AS LicensePlate 
        , CAR_PRICE         AS Price 
    FROM 
        T_CARS 
    WHERE
        CAR_LICENSE_PLATE = @CAR_LICENSE_PLATE"

    Public Shared Property QuerySelectAllCarsAvailable As String =
    "
    DECLARE @DateNow DATETIME;
    SET @DateNow = CAST(CAST(GETDATE() AS DATE) AS DATETIME);
    SELECT                                 
          CAR_ID            As Id 
        , CAR_MAKE          AS Make 
        , CAR_MODEL         AS Model 
        , CAR_COLOR         AS Color 
        , CAR_YEAR          AS Year 
        , CAR_LICENSE_PLATE AS LicensePlate 
        , CAR_PRICE         AS Price 
    FROM 
        T_CARS CA 
    WHERE 
        CA.CAR_ID NOT IN (                     
            SELECT 
                DISTINCT (CR.CARRENT_CAR_ID)   
            FROM 
                T_CAR_RENTALS CR   
            WHERE 
                (CR.CARRENT_START_DATE < @DateNow AND CR.CARRENT_DUE_DATE < @DateNow) 
             OR (CR.CARRENT_START_DATE IS NULL)
    )"

    Public Shared Property QuerySelectAllCarsRented As String =
    "
    DECLARE @DateNow DATETIME;
    SET @DateNow = CAST(CAST(GETDATE() AS DATE) AS DATETIME);
    SELECT                                 
          CAR_ID            As Id 
        , CAR_MAKE          AS Make 
        , CAR_MODEL         AS Model 
        , CAR_COLOR         AS Color 
        , CAR_YEAR          AS Year 
        , CAR_LICENSE_PLATE AS LicensePlate 
        , CAR_PRICE         AS Price 
    FROM 
        T_CARS CA 
    WHERE 
        CA.CAR_ID IN (                     
            SELECT 
                DISTINCT (CR.CARRENT_CAR_ID)   
            FROM 
                T_CAR_RENTALS CR   
            WHERE 
                (CR.CARRENT_START_DATE < @DateNow AND CR.CARRENT_DUE_DATE < @DateNow) 
             OR (CR.CARRENT_START_DATE IS NULL)
    )"

    Public Shared Property QuerySelectAllCars As String =
    "SELECT
          CAR_ID            As Id 
        , CAR_MAKE          AS Make 
        , CAR_MODEL         AS Model 
        , CAR_COLOR         AS Color 
        , CAR_YEAR          AS Year 
        , CAR_LICENSE_PLATE AS LicensePlate 
        , CAR_PRICE         AS Price 
    FROM T_CARS"

End Class

