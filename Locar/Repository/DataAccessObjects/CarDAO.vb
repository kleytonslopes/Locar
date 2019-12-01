Imports Locar

Public Class CarDAO
    Public Sub InsertCar(ByVal Car As Car)
        Dim sql As String = CarScripts.QueryInsert

        Dim parameters As New With {Key _
            .CAR_MAKE = Car.Make,
            .CAR_MODEL = Car.Model,
            .CAR_COLOR = Car.Color,
            .CAR_YEAR = Car.Year,
            .CAR_LICENSE_PLATE = Car.LicensePlate,
            .CAR_PRICE = Car.Price
        }

        Using conFactory As New ConnectionFactory()

            conFactory.Save(sql, parameters)

        End Using

    End Sub

    Public Function SelectCarByLicensePlate(licensePlate As String) As Car
        Dim car As Car
        Dim sql As String = CarScripts.QuerySelectByLicensePlate

        Dim parameters As New With {Key _
            .CAR_LICENSE_PLATE = licensePlate
        }

        Using conFactory As New ConnectionFactory()
            car = conFactory.SelectFirst(Of Car)(sql, parameters)
        End Using

        SelectCarByLicensePlate = car

    End Function

    Friend Function SelectAllCars() As IEnumerable(Of Car)
        Dim result As IEnumerable(Of Car)
        Dim sql As String = CarScripts.QuerySelectAllCars

        Using conFactory As New ConnectionFactory()
            result = conFactory.SelectList(Of Car)(sql, Nothing)
        End Using

        SelectAllCars = result
    End Function

    Friend Function SelectAllCarsAvailable() As IEnumerable(Of Car)
        Dim result As IEnumerable(Of Car)
        Dim sql As String = CarScripts.QuerySelectAllCarsAvailable

        Using conFactory As New ConnectionFactory()
            result = conFactory.SelectList(Of Car)(sql, Nothing)
        End Using

        SelectAllCarsAvailable = result
    End Function

    Friend Function SelectAllCarsRented() As IEnumerable(Of Car)
        Dim result As IEnumerable(Of Car)
        Dim sql As String = CarScripts.QuerySelectAllCarsRented

        Using conFactory As New ConnectionFactory()
            result = conFactory.SelectList(Of Car)(sql, Nothing)
        End Using

        SelectAllCarsRented = result
    End Function
End Class
