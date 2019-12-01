NotInheritable Class CarRentalsScripts

    Public Shared QueryInsert As String =
    "INSERT INTO T_CAR_RENTALS (
          CARRENT_CAR_ID
        , CARRENT_START_DATE
        , CARRENT_DUE_DATE
    ) VALUES ( 
          @CARRENT_CAR_ID
        , @CARRENT_START_DATE
        , @CARRENT_DUE_DATE
    )"

    Public Shared QuerySelectAll As String =
    "SELECT
          CARRENT_ID AS Id
        , CARRENT_CAR_ID AS CarId
        , CARRENT_START_DATE AS StartDate
        , CARRENT_DUE_DATE AS DueDate
     FROM 
        T_CAR_RENTALS"
End Class
