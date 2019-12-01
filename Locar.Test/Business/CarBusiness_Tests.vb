<TestClass()> Public Class CarBusiness_Tests

    <TestMethod()> Public Sub CreateCar_Test()
        Dim car As New Car

        car = New CarBusiness().CreateCar("mMake", "nModel", "cColor", 99, "tst-test", 125.29)

        Assert.IsNotNull(car)
        Assert.IsTrue(car.Make = "mMake")
        Assert.IsTrue(car.Model = "nModel")
        Assert.IsTrue(car.Color = "cColor")
        Assert.IsTrue(car.Year = 99)
        Assert.IsTrue(car.LicensePlate = "TST-TEST")
        Assert.IsTrue(car.Price = 125.29)
    End Sub

    <TestMethod()> Public Sub RegisterCar_Test()

        Dim car As New Car
        Dim carBusiness As New CarBusiness
        Dim licensePlate As String = DateTime.Now.ToString("MMddhhssff")

        carBusiness.RegisterCar("mMake", "nModel", "cColor", "99", licensePlate, "52")
    End Sub

    <TestMethod()> Public Sub SelectCarByLicensePlate_Test()
        Dim car As New Car
        Dim carBusiness As New CarBusiness
        Dim licensePlate As String = DateTime.Now.ToString("MMddHHmmss")

        carBusiness.RegisterCar("mMake", "nModel", "cColor", "99", licensePlate, "52")
        car = carBusiness.SelectByLicensePlate(licensePlate)

        Assert.IsNotNull(car)
        Assert.IsTrue(car.Make = "mMake")
        Assert.IsTrue(car.Model = "nModel")
        Assert.IsTrue(car.Color = "cColor")
        Assert.IsTrue(car.Year = 99)
        Assert.IsTrue(car.LicensePlate = licensePlate.ToUpper())
        Assert.IsTrue(car.Price = 52)

    End Sub

    <TestMethod()> Public Sub SelectAllCar_Test()
        Dim carBusiness As New CarBusiness
        Dim result As IEnumerable(Of Car)

        result = carBusiness.SelectAllCars()

        Assert.IsNotNull(result)
        Assert.IsTrue(result.Count > 1)
    End Sub

    <TestMethod()> Public Sub SelectAllCarAvailable_Test()
        Dim carBusiness As New CarBusiness
        Dim totalCars As IEnumerable(Of Car)
        Dim totalAvailable As IEnumerable(Of Car)

        totalCars = carBusiness.SelectAllCars()
        totalAvailable = carBusiness.SelectAllCarsAvailable()

        Assert.IsNotNull(totalCars)
        Assert.IsNotNull(totalAvailable)

        Assert.IsTrue(totalCars.Count > 1)
        Assert.IsTrue(totalAvailable.Count > 1)
        Assert.IsTrue(totalAvailable.Count < totalCars.Count)
    End Sub

    <TestMethod()> Public Sub SelectCountCarAvailable_Test()
        Dim carBusiness As New CarBusiness
        Dim totalAvailable As Integer

        totalAvailable = carBusiness.SelectCountCarsAvailable()
        Assert.IsTrue(totalAvailable > 0)

    End Sub

    <TestMethod()> Public Sub SelectAllCarRented_Test()
        Dim carBusiness As New CarBusiness
        Dim totalCars As IEnumerable(Of Car)
        Dim totalAvailable As IEnumerable(Of Car)

        totalCars = carBusiness.SelectAllCars()
        totalAvailable = carBusiness.SelectAllCarsRented()

        Assert.IsNotNull(totalCars)
        Assert.IsNotNull(totalAvailable)

        Assert.IsTrue(totalCars.Count > 1)
        Assert.IsTrue(totalAvailable.Count > 1)
        Assert.IsTrue(totalAvailable.Count < totalCars.Count)
    End Sub

    <TestMethod()> Public Sub SelectCountCarRented_Test()
        Dim carBusiness As New CarBusiness
        Dim totalRented As Integer

        totalRented = carBusiness.SelectCountCarsRented()
        Assert.IsTrue(totalRented > 0)

    End Sub
End Class
