Public Class CarRentalsBusiness
    Public Function CreateCarRentals(ByVal carId As Integer,
                                     ByVal startDate As DateTime,
                                     ByVal dueDate As DateTime) As CarRentals
        Dim carRentals As New CarRentals

        carRentals.CarId = carId
        carRentals.StartDate = startDate
        carRentals.DueDate = dueDate

        CreateCarRentals = carRentals
    End Function

    Public Sub RegisterCarRentals(ByVal carLicensePlate As String,
                                  ByVal startDate As DateTime,
                                  ByVal dueDate As DateTime)
        Dim car As Car
        Dim carRentals As New CarRentals
        Dim carDao As CarDAO
        Dim carRentalsDAO As CarRentalsDAO

        carDao = New CarDAO
        carRentalsDAO = New CarRentalsDAO

        car = carDao.SelectCarByLicensePlate(carLicensePlate)

        If car Is Nothing Then
            Throw New ArgumentException("Carro não encontrado!")
        End If

        carRentals = CreateCarRentals(car.Id, startDate, dueDate)
        carRentalsDAO.InsertCarRentals(carRentals)

    End Sub

    Public Function SelectAllCarRentals() As IEnumerable(Of CarRentals)
        Dim carRentalsDAO As New CarRentalsDAO
        Dim result As IEnumerable(Of CarRentals)

        result = carRentalsDAO.SelectAllCarRentals()

        SelectAllCarRentals = result
    End Function
End Class
