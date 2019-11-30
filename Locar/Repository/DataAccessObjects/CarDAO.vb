Option Strict Off
Imports Locar

Public Class CarDAO
    Public Sub InsertCar(ByVal Car As Car)
        Dim sql As String = CarScripts.QueryInsert

        Dim parameters As New With {Key _
            .CAR_MAKE = Car.Make,
            .CAR_MODEL = Car.Model,
            .CAR_COLOR = Car.Color,
            .CAR_YEAR = Car.Year,
            .CAR_LICENSE_PLATE = Car.LicensePlate
        }

        Using conFactory As New ConnectionFactory()

            conFactory.Save(sql, parameters)

        End Using

    End Sub

    Friend Function SelectCarByLicensePlate(licensePlate As String) As Car
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
End Class
