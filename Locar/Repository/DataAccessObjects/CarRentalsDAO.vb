Imports Locar

Public Class CarRentalsDAO
    Friend Sub InsertCarRentals(carRentals As CarRentals)
        Dim sql As String = CarRentalsScripts.QueryInsert

        Dim parameters As New With {Key _
            .CARRENT_CAR_ID = carRentals.CarId,
            .CARRENT_START_DATE = carRentals.StartDate,
            .CARRENT_DUE_DATE = carRentals.DueDate
        }

        Using conFactory As New ConnectionFactory()
            conFactory.Save(sql, parameters)
        End Using

    End Sub

    Public Function SelectAllCarRentals() As IEnumerable(Of CarRentals)
        Dim sql As String = CarRentalsScripts.QuerySelectAll
        Dim result As IEnumerable(Of CarRentals)

        Using conFactory As New ConnectionFactory()
            result = conFactory.SelectList(Of CarRentals)(sql, Nothing)
        End Using

        SelectAllCarRentals = result
    End Function
End Class
