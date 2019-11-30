<TestClass()> Public Class CarRentalsBusiness_Tests
    <TestMethod()> Public Sub CreateCarRentals_Test()
        Dim carRentals As CarRentals
        Dim startDate As DateTime = DateTime.Now.Date
        Dim dueDate As DateTime = DateTime.Now.Date.AddDays(5).Date

        carRentals = New CarRentalsBusiness().CreateCarRentals(1, DateTime.Now.Date, DateTime.Now.AddDays(5).Date)

        Assert.IsNotNull(carRentals)
        Assert.IsTrue(carRentals.CarId = 1)
        Assert.IsTrue(carRentals.StartDate = startDate)
        Assert.IsTrue(carRentals.DueDate = dueDate)
    End Sub

    <TestMethod()> Public Sub RegisterCarRentals_Test()
        Dim carRentalsBusiness As New CarRentalsBusiness
        Dim carBusiness As New CarBusiness
        Dim licensePlate As String = DateTime.Now.ToString("yyddhhssff")

        carBusiness.RegisterCar("mMake", "nModel", "cColor", "99", licensePlate)

        carRentalsBusiness.RegisterCarRentals(licensePlate, DateTime.Now.Date, DateTime.Now.AddDays(5).Date)
    End Sub

    <TestMethod()> Public Sub SelectAllCarRentals_Test()
        Dim carRentalsBusiness As New CarRentalsBusiness
        Dim carBusiness As New CarBusiness
        Dim licensePlate As String = DateTime.Now.ToString("yyddhhssff")
        Dim result As IEnumerable(Of CarRentals)

        carBusiness.RegisterCar("mMake", "nModel", "cColor", "99", licensePlate)

        carRentalsBusiness.RegisterCarRentals(licensePlate, DateTime.Now.Date, DateTime.Now.AddDays(5).Date)
        carRentalsBusiness.RegisterCarRentals(licensePlate, DateTime.Now.Date.AddDays(10), DateTime.Now.AddDays(15).Date)

        result = carRentalsBusiness.SelectAllCarRentals()

        Assert.IsNotNull(result)
        Assert.IsTrue(result.Count > 1)
    End Sub
End Class
