<TestClass()> Public Class CarBusiness_Tests

    <TestMethod()> Public Sub CreateCar_Test()
        Dim car As New Car

        car = New CarBusiness().CreateCar("mMake", "nModel", "cColor", 99, "tst-test")

        Assert.IsNotNull(car)
        Assert.IsTrue(car.Make = "mMake")
        Assert.IsTrue(car.Model = "nModel")
        Assert.IsTrue(car.Color = "cColor")
        Assert.IsTrue(car.Year = 99)
        Assert.IsTrue(car.LicensePlate = "TST-TEST")
    End Sub

    <TestMethod()> Public Sub RegisterCar_Test()

        Dim car As New Car
        Dim carBusiness As New CarBusiness
        Dim licensePlate As String = DateTime.Now.ToString("MMddhhssff")

        carBusiness.RegisterCar("mMake", "nModel", "cColor", "99", licensePlate)
    End Sub

    <TestMethod()> Public Sub SelectCarByLicensePlate_Test()
        Dim car As New Car
        Dim carBusiness As New CarBusiness
        Dim licensePlate As String = DateTime.Now.ToString("MMddHHmmss")

        carBusiness.RegisterCar("mMake", "nModel", "cColor", "99", licensePlate)
        car = carBusiness.SelectByLicensePlate(licensePlate)

        Assert.IsNotNull(car)
        Assert.IsTrue(car.Make = "mMake")
        Assert.IsTrue(car.Model = "nModel")
        Assert.IsTrue(car.Color = "cColor")
        Assert.IsTrue(car.Year = 99)
        Assert.IsTrue(car.LicensePlate = licensePlate.ToUpper())

    End Sub

    <TestMethod()> Public Sub SelectAllCar_Test()
        Dim carBusiness As New CarBusiness
        Dim result As IEnumerable(Of Car)

        result = carBusiness.SelectAllCars()

        Assert.IsNotNull(result)
        Assert.IsTrue(result.Count > 1)
    End Sub
End Class
