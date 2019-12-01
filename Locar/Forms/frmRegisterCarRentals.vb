Imports Locar

Public Class frmRegisterCarRentals
    Private Cars As List(Of Car)
    Private selectedCar As Car

    Private Sub frmRegisterCarRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim carBusiness As New CarBusiness
        Dim currentCar As Car

        Cars = carBusiness.SelectAllCarsAvailable()

        If Cars IsNot Nothing AndAlso Cars.Any() Then
            lstCars.Items.Clear()

            For Each car As Car In Cars
                lstCars.Items.Add(CreateItem(car))
            Next
        End If
    End Sub

    Private Function CreateItem(car As Car) As ListViewItem
        Dim item = New ListViewItem

        item.Tag = car
        item.Text = car.LicensePlate & " - " & car.Make & " - " & car.Model
        item.Name = car.Make
        CreateItem = item
    End Function

    Private Sub lstCars_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstCars.ItemSelectionChanged
        Dim item = New ListViewItem
        item = e.Item

        If item IsNot Nothing Then
            selectedCar = CType(item.Tag, Car)
            If selectedCar IsNot Nothing Then
                FillFields(selectedCar)
            End If
        End If
    End Sub

    Private Sub FillFields(selectedCar As Car)
        txtColor.Text = selectedCar.Color
        txtLicensePlate.Text = selectedCar.LicensePlate
        txtMake.Text = selectedCar.Make
        txtModel.Text = selectedCar.Model
        txtYear.Text = selectedCar.Year.ToString()
    End Sub

    Private Sub ClearFields()
        lstCars.SelectedItems.Clear()
        selectedCar = Nothing

        txtColor.Text = String.Empty
        txtLicensePlate.Text = String.Empty
        txtMake.Text = String.Empty
        txtModel.Text = String.Empty
        txtYear.Text = String.Empty

        dtpStart.Value = DateTime.Now.Date
        dtpDue.Value = DateTime.Now.Date

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim carRentalsBusiness As CarRentalsBusiness
            Dim StartDate = dtpStart.Value.Date
            Dim DueDate = dtpDue.Value.Date

            If DueDate <= StartDate Then
                MessageBox.Show("A data de entrega não pode ser menor ou igual a data de Retirada!", "Locar - Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If selectedCar Is Nothing Then
                MessageBox.Show("Selecione um veículo para a Locação!", "Locar - Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            carRentalsBusiness = New CarRentalsBusiness()
            carRentalsBusiness.RegisterCarRentals(selectedCar.LicensePlate, StartDate, DueDate)

            MessageBox.Show("Locação cadastrada com Sucesso!", "Locar - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Locar - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class