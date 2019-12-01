NotInheritable Class CarRentalsReportScripts
    Public Shared QuerySelectAll As String =
    "SELECT 
           CARRENT_ID         AS CarRentalsId
         , CAR_ID             AS CarId
         , CARRENT_START_DATE AS StartDate
         , CARRENT_DUE_DATE   AS DueDate
         , CAR_MAKE           AS Make
         , CAR_MODEL          AS Model
         , CAR_COLOR          AS Color
         , CAR_YEAR           AS Year
         , CAR_LICENSE_PLATE  AS LicensePlate
         , CAR_PRICE          AS Price
     FROM 
         vw_CarRentalsReportField
    "

    Public Shared QuerySelectByDateRange As String =
    "SELECT 
           CARRENT_ID         AS CarRentalsId
         , CAR_ID             AS CarId
         , CARRENT_START_DATE AS StartDate
         , CARRENT_DUE_DATE   AS DueDate
         , CAR_MAKE           AS Make
         , CAR_MODEL          AS Model
         , CAR_COLOR          AS Color
         , CAR_YEAR           AS Year
         , CAR_LICENSE_PLATE  AS LicensePlate
         , CAR_PRICE          AS Price
     FROM 
         vw_CarRentalsReportField
     WHERE 
         CARRENT_START_DATE >= @CARRENT_START_DATE
     AND CARRENT_DUE_DATE <= @CARRENT_DUE_DATE"
End Class
