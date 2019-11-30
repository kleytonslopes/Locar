NotInheritable Class CarRentalsReportScripts
    Private Shared Table As String = "vw_CarRentalsReport"
    Private Shared CarRentalsId As String = "CARRENT_ID"
    Private Shared CarId As String = "CAR_ID"
    Private Shared StartDate As String = "CARRENT_START_DATE"
    Private Shared DueDate As String = "CARRENT_DUE_DATE"
    Private Shared Make As String = "CAR_MAKE"
    Private Shared Model As String = "CAR_MODEL"
    Private Shared Color As String = "CAR_COLOR"
    Private Shared Year As String = "CAR_YEAR"
    Private Shared LicensePlate As String = "CAR_LICENSE_PLATE"

    Public Shared QuerySelectAll As String =
    "SELECT " &
    "  " & CarRentalsId & " AS CarRentalsId" &
    ", " & CarId & " AS CarId" &
    ", " & StartDate & " AS StartDate" &
    ", " & DueDate & " AS DueDate" &
    ", " & Make & " AS Make" &
    ", " & Model & " AS Model" &
    ", " & Color & " AS Color" &
    ", " & Year & " AS Year" &
    ", " & LicensePlate & " AS LicensePlate" &
    " FROM " & Table

    Public Shared QuerySelectByDateRange As String =
    "SELECT " &
    "  " & CarRentalsId & " AS CarRentalsId" &
    ", " & CarId & " AS CarId" &
    ", " & StartDate & " AS StartDate" &
    ", " & DueDate & " AS DueDate" &
    ", " & Make & " AS Make" &
    ", " & Model & " AS Model" &
    ", " & Color & " AS Color" &
    ", " & Year & " AS Year" &
    ", " & LicensePlate & " AS LicensePlate" &
    " FROM " & Table &
    " WHERE " & StartDate & " >= @" & StartDate &
    " AND " & DueDate & " <= @" & DueDate
End Class
