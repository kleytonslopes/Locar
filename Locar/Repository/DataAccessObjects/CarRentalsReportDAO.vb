Imports Locar

Public Class CarRentalsReportDAO
    Public Function SelectCarRentalsReportByDateRange(ByVal startDate As DateTime, ByVal dueDate As DateTime) As IEnumerable(Of CarRentalsReport)
        Dim result As List(Of CarRentalsReport)
        Dim sql As String = CarRentalsReportScripts.QuerySelectByDateRange
        Dim parameters As New With {Key _
            .CARRENT_START_DATE = startDate,
            .CARRENT_DUE_DATE = dueDate
        }

        Using conFactory As New ConnectionFactory()
            result = conFactory.SelectList(Of CarRentalsReport)(sql, parameters)
        End Using

        SelectCarRentalsReportByDateRange = result
    End Function

    Friend Function SelectCarRentalsReport() As List(Of CarRentalsReport)
        Dim result As List(Of CarRentalsReport)
        Dim sql As String = CarRentalsReportScripts.QuerySelectAll

        Using conFactory As New ConnectionFactory()
            result = conFactory.SelectList(Of CarRentalsReport)(sql, Nothing)
        End Using

        SelectCarRentalsReport = result
    End Function
End Class
