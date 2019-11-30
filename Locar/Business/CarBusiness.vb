Public Class CarBusiness
    Public Function CreateCar(ByVal name As String,
                              ByVal model As String,
                              ByVal color As String,
                              ByVal year As Integer,
                              ByVal licensePlate As String)

        Dim car As New Car

        car.Name = name
        car.Model = model
        car.Color = color
        car.Year = year
        car.LicensePlate = licensePlate

        CreateCar = car
    End Function
End Class
