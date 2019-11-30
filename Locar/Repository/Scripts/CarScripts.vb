NotInheritable Class CarScripts
    Private Shared Table As String = "T_CARS"
    Private Shared Id As String = "CAR_ID"
    Private Shared Make As String = "CAR_MAKE"
    Private Shared Model As String = "CAR_MODEL"
    Private Shared Color As String = "CAR_COLOR"
    Private Shared Year As String = "CAR_YEAR"
    Private Shared LicensePlate As String = "CAR_LICENSE_PLATE"

    Public Shared QueryInsert As String =
    "INSERT INTO " & Table & " (" &
    "  " & Make &
    ", " & Model &
    ", " & Color &
    ", " & Year &
    ", " & LicensePlate &
    ") VALUES ( " &
    "  @" & Make &
    ", @" & Model &
    ", @" & Color &
    ", @" & Year &
    ", @" & LicensePlate &
    ")"

    Public Shared QuerySelectByLicensePlate As String =
    "SELECT " &
    "  " & Id & " AS Id" &
    ", " & Make & " AS Make" &
    ", " & Model & " AS Model" &
    ", " & Color & " AS Color" &
    ", " & Year & " AS Year" &
    ", " & LicensePlate & " AS LicensePlate" &
    " FROM " & Table & " WHERE " &
    "  " & LicensePlate & " = @" & LicensePlate

    Public Shared Property QuerySelectAllCars As String =
    "SELECT " &
    "  " & Id & " AS Id" &
    ", " & Make & " AS Make" &
    ", " & Model & " AS Model" &
    ", " & Color & " AS Color" &
    ", " & Year & " AS Year" &
    ", " & LicensePlate & " AS LicensePlate" &
    " FROM " & Table
End Class

