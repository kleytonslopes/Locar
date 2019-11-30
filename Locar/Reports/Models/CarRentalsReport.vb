Public Class CarRentalsReport
    Private _make As String
    Private _model As String
    Private _color As String
    Private _year As Integer
    Private _licensePlate As String
    Private _startDate As DateTime
    Private _dueDate As DateTime

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
            Return _startDate.ToString("dd/MM/yyyy")
        End Get
        Set(value As String)
            _startDate = CDate(value)
        End Set
    End Property
    Public Property DueDate As String
        Get
            Return _dueDate.ToString("dd/MM/yyyy")
        End Get
        Set(value As String)
            _dueDate = CDate(value)
        End Set
    End Property
End Class
