Imports Locar

Public Class CarBusiness
    Public Function CreateCar(ByVal make As String,
                              ByVal model As String,
                              ByVal color As String,
                              ByVal year As Integer,
                              ByVal licensePlate As String)

        Dim car As New Car

        car.Make = make
        car.Model = model
        car.Color = color
        car.Year = year
        car.LicensePlate = licensePlate

        CreateCar = car
    End Function

    Public Sub RegisterCar(ByVal make As String,
                           ByVal model As String,
                           ByVal color As String,
                           ByVal year As String,
                           ByVal licensePlate As String)

        Dim intYear As Integer
        Dim isValidYear As Boolean
        Dim car As Car
        Dim carDao As CarDAO
        Dim carExists As Boolean

        isValidYear = Integer.TryParse(year, intYear)
        carExists = CheckCarHasRegistered(licensePlate)

        If carExists Then
            Throw New ArgumentException("Placa do veículo já Cadastrada!")
        End If

        If isValidYear Then
            car = CreateCar(make, model, color, intYear, licensePlate)

            carDao = New CarDAO
            carDao.InsertCar(car)
        Else
            Throw New ArgumentException("Formato do ano do veículo esta inválido!")
        End If

    End Sub

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
End Class
