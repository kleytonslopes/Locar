<TestClass()> Public Class CarBusiness_Tests

    <TestMethod()> Public Sub CreateCar_Test()
        Dim car As New Car

        car = New CarBusiness().CreateCar("nName", "nModel", "cColor", 99, "tst-test")

        Assert.IsNotNull(car)
        Assert.IsTrue(car.Name = "nName")
        Assert.IsTrue(car.Model = "nModel")
        Assert.IsTrue(car.Color = "cColor")
        Assert.IsTrue(car.Year = 99)
        Assert.IsTrue(car.LicensePlate = "TST-TEST")
    End Sub

End Class
