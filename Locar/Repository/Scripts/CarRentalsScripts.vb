NotInheritable Class CarRentalsScripts
    Private Shared Table As String = "T_CAR_RENTALS"
    Private Shared Id As String = "CARRENT_ID"
    Private Shared CarId As String = "CARRENT_CAR_ID"
    Private Shared StartDate As String = "CARRENT_START_DATE"
    Private Shared DueDate As String = "CARRENT_DUE_DATE"

    Public Shared QueryInsert As String =
    "INSERT INTO " & Table & " (" &
    "  " & CarId &
    ", " & StartDate &
    ", " & DueDate &
    ") VALUES ( " &
    "  @" & CarId &
    ", @" & StartDate &
    ", @" & DueDate &
    ")"

    Public Shared QuerySelectAll As String =
    "SELECT " &
    "  " & Id & " AS Id" &
    ", " & CarId & " AS CarId" &
    ", " & StartDate & " AS StartDate" &
    ", " & DueDate & " AS DueDate" &
    " FROM " & Table

End Class
