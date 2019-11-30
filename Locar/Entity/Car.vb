Imports Locar

Public Class Car
    Private _id As Integer
    Private _make As String
    Private _model As String
    Private _color As String
    Private _year As Integer
    Private _licensePlate As String

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
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
    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
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

End Class
