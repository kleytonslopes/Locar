Public Class CarRentalsReport
    Private _make As String
    Private _model As String
    Private _color As String
    Private _year As Integer
    Private _licensePlate As String
    Private _startDate As DateTime
    Private _dueDate As DateTime
    Private _price As Decimal

    Public Property Make As String
        Get
            Return _make
        End Get
        Set(value As String)
            _make = value
        End Set
    End Property
    Public Property Model As String
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
        End Set
    End Property
    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property
    Public Property Year As String
        Get
            Return _year.ToString()
        End Get
        Set(value As String)
            _year = CInt(value)
        End Set
    End Property
    Public Property LicensePlate As String
        Get
            Return _licensePlate
        End Get
        Set(value As String)
            _licensePlate = value.ToUpper()
        End Set
    End Property
    Public Property StartDate As String
        Get
            If _startDate = New DateTime(1900, 1, 1) Then
                Return ""
            End If
            Return _startDate.ToString("dd/MM/yyyy")
        End Get
        Set(value As String)
            _startDate = CDate(value)
        End Set
    End Property
    Public Property DueDate As String
        Get
            If _dueDate = New DateTime(1900, 1, 1) Then
                Return ""
            End If
            Return _dueDate.ToString("dd/MM/yyyy")
        End Get
        Set(value As String)
            _dueDate = CDate(value)
        End Set
    End Property
    Public Property Price As String
        Get
            Return _price.ToString("0.00")
        End Get
        Set(value As String)
            _price = CDec(value)
        End Set
    End Property
    Public Property TotalPrice As String
        Get
            Return (_price * GetTotalDays()).ToString("0.00")
        End Get
        Private Set(value As String)

        End Set
    End Property

    Public Property RentalsStatus() As String
        Get
            Dim startDate As DateTime = _startDate
            Dim dueDate As DateTime = _dueDate
            Dim dateNow As DateTime
            Dim result As String
            dateNow = DateTime.Now.Date

            If startDate < dateNow AndAlso dueDate < dateNow Then
                result = "Disponível"
            Else
                result = "Indisponível"
            End If

            Return result
        End Get
        Private Set(value As String)

        End Set
    End Property

    Public Function GetTotalDays() As Integer
        Dim startDate As DateTime = _startDate
        Dim dueDate As DateTime = _dueDate

        Dim days As Integer
        days = (dueDate - startDate).Days
        GetTotalDays = days
    End Function
End Class

