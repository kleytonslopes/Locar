Public Class CarRentalsReportBusiness
    Public Function CreateReportByFilters(ByVal startDate As DateTime, ByVal dueDate As DateTime) As IEnumerable(Of CarRentalsReport)
        Dim result As List(Of CarRentalsReport)
        Dim carRentalsReportDAO As New CarRentalsReportDAO()

        If dueDate.Date <= startDate.Date Then
            Throw New ArgumentException("A data de entrega não pode ser menor ou igual a data de Retirada!")
        End If

        result = carRentalsReportDAO.SelectCarRentalsReportByDateRange(startDate, dueDate)

        CreateReportByFilters = result
    End Function
End Class
