Imports Locar

Public Class CarBusiness
    Public Function CreateCar(ByVal make As String,
                              ByVal model As String,
                              ByVal color As String,
                              ByVal year As Integer,
                              ByVal licensePlate As String,
                              ByVal price As Decimal)

        Dim car As New Car

        car.Make = make
        car.Model = model
        car.Color = color
        car.Year = year
        car.LicensePlate = licensePlate
        car.Price = price

        CreateCar = car
    End Function

    Public Sub RegisterCar(ByVal make As String,
                           ByVal model As String,
                           ByVal color As String,
                           ByVal year As String,
                           ByVal licensePlate As String,
                           ByVal price As String)

        Dim intYear As Integer
        Dim decPrice As Decimal
        Dim isValidYear As Boolean
        Dim isValidPrice As Boolean
        Dim car As Car
        Dim carDao As CarDAO
        Dim carExists As Boolean

        isValidYear = Integer.TryParse(year, intYear)
        isValidPrice = Decimal.TryParse(price, decPrice)
        carExists = CheckCarHasRegistered(licensePlate)

        HasInvalidField(isValidYear, isValidPrice, carExists)

        car = CreateCar(make, model, color, intYear, licensePlate, decPrice)

        carDao = New CarDAO
        carDao.InsertCar(car)

    End Sub

    Private Sub HasInvalidField(isValidYear As Boolean, isValidPrice As Boolean, carExists As Boolean)
        If carExists Then
            Throw New ArgumentException("Placa do veículo já Cadastrada!")
        End If

        If Not isValidPrice Then
            Throw New ArgumentException("Formato do preço do veículo esta inválido!")
        End If

        If Not isValidYear Then
            Throw New ArgumentException("Formato do ano do veículo esta inválido!")
        End If

    End Sub

    Public Function SelectAllCarsAvailable() As IEnumerable(Of Car)
        Dim result As IEnumerable(Of Car)
        Dim carDao As New CarDAO

        result = carDao.SelectAllCarsAvailable()

        SelectAllCarsAvailable = result
    End Function

    Public Function SelectCountCarsAvailable() As Integer
        Dim result As Integer
        Dim totalCarsAvailable As IEnumerable(Of Car)

        Dim carDao As New CarDAO

        totalCarsAvailable = carDao.SelectAllCarsAvailable()
        If totalCarsAvailable Is Nothing Then
            result = 0
        Else
            result = totalCarsAvailable.Count
        End If
        SelectCountCarsAvailable = result
    End Function

    Public Function SelectByLicensePlate(licensePlate As String) As Car
        Dim car As Car
        Dim carDao As CarDAO

        If String.IsNullOrWhiteSpace(licensePlate) Then
            Throw New ArgumentException("Informa a placa do veículo!")
        End If

        carDao = New CarDAO
        car = carDao.SelectCarByLicensePlate(licensePlate)

        SelectByLicensePlate = car
    End Function

    Public Function SelectAllCarsRented() As IEnumerable(Of Car)
        Dim result As IEnumerable(Of Car)
        Dim carDao As New CarDAO

        result = carDao.SelectAllCarsRented()

        SelectAllCarsRented = result
    End Function

    Public Function SelectCountCarsRented() As Integer
        Dim result As Integer
        Dim totalCarsRented As IEnumerable(Of Car)

        Dim carDao As New CarDAO

        totalCarsRented = carDao.SelectAllCarsRented()
        If totalCarsRented Is Nothing Then
            result = 0
        Else
            result = totalCarsRented.Count
        End If
        SelectCountCarsRented = result
    End Function

    Private Function CheckCarHasRegistered(licensePlate As String) As Boolean
        Dim car As Car
        Dim carExists As Boolean
        car = GetCarByLicensePlate(licensePlate)

        If car Is Nothing Then
            carExists = False
        Else
            carExists = True
        End If

        CheckCarHasRegistered = carExists
    End Function

    Public Function GetCarByLicensePlate(ByVal licensePlate As String) As Car
        Dim car As Car
        Dim carDao As CarDAO

        carDao = New CarDAO
        car = carDao.SelectCarByLicensePlate(licensePlate)

        GetCarByLicensePlate = car
    End Function

    Public Function SelectAllCars() As IEnumerable(Of Car)
        Dim result As IEnumerable(Of Car)
        Dim carDao As New CarDAO

        result = carDao.SelectAllCars()

        SelectAllCars = result
    End Function
End Class
