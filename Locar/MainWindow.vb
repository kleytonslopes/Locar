Public Class MainWindow
    Private Sub mnuRegisterCars_Click(sender As Object, e As EventArgs) Handles mnuRegisterCars.Click
        frmRegisterCars.MdiParent = Me
        frmRegisterCars.Show()
    End Sub

    Private Sub mnuRegisterCarRentals_Click(sender As Object, e As EventArgs) Handles mnuRegisterCarRentals.Click
        frmRegisterCarRentals.MdiParent = Me
        frmRegisterCarRentals.Show()
    End Sub

    Private Sub mnuReportRentalsPrint_Click(sender As Object, e As EventArgs) Handles mnuReportRentalsPrint.Click
        frmCarRentalsReport.MdiParent = Me
        frmCarRentalsReport.Show()
    End Sub
End Class
