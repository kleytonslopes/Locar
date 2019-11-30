Public Class CarRentals
    Private _id As Integer
    Private _carId As Integer
    Private _startDate As DateTime
    Private _dueDate As DateTime

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property CarId As Integer
        Get
            Return _carId
        End Get
        Set(value As Integer)
            _carId = value
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property DueDate As Date
        Get
            Return _dueDate
        End Get
        Set(value As Date)
            _dueDate = value
        End Set
    End Property
End Class
