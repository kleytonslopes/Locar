Public Class frmRegisterCars

    Private make As String
    Private model As String
    Private color As String
    Private year As String
    Private licensePlate As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim carBusiness As New CarBusiness

            FillInputs()

            If IsValidInputs() Then
                carBusiness.RegisterCar(make, model, color, year, licensePlate, "0")
                MessageBox.Show("Veiculo cadastrado com Sucesso!", "Locar - Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Else
                MessageBox.Show("Preencha os Campos Obrigatórios*", "Locar - Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Locar - Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Locar - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FillInputs()
        make = cboMake.Text
        model = txtModel.Text
        color = txtColor.Text
        year = txtYear.Text
        licensePlate = txtLicensePlate.Text
    End Sub

    Private Function IsValidInputs() As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(make) Then
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(model) Then
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(color) Then
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(year) Then
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(licensePlate) Then
            isValid = False
        End If

        IsValidInputs = isValid
    End Function

    Private Sub ClearFields()

        cboMake.SelectedIndex = -1
        make = String.Empty

        model = String.Empty
        txtModel.Text = String.Empty

        color = String.Empty
        txtColor.Text = String.Empty

        year = String.Empty
        txtYear.Text = String.Empty

        licensePlate = String.Empty
        txtLicensePlate.Text = String.Empty

    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class