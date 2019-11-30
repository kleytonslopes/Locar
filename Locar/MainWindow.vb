Public Class MainWindow
    Private Sub mnuRegisterCars_Click(sender As Object, e As EventArgs) Handles mnuRegisterCars.Click
        frmRegisterCars.MdiParent = Me
        ' frmRegisterCars.StartPosition = FormStartPosition.CenterParent
        frmRegisterCars.Show()
    End Sub
End Class
