Public Class frmCarRentalsReport
    Private Sub frmCarRentalsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDue.Value = DateTime.Now.Date.AddDays(1)
    End Sub

    Private Sub btnCreateReport_Click(sender As Object, e As EventArgs) Handles btnCreateReport.Click
        Try
            Dim StartDate = dtpStart.Value.Date
            Dim DueDate = dtpDue.Value.Date
            Dim result As List(Of CarRentalsReport)
            Dim carRentalsReportBusiness As New CarRentalsReportBusiness()
            Dim rptCarRentals As New rptCarRentals

            result = carRentalsReportBusiness.CreateReportByFilters(StartDate, DueDate)

            frmReportViewer.SetReport(rptCarRentals)
            frmReportViewer.SetDataSource(Of IEnumerable(Of CarRentalsReport))(result)
            frmReportViewer.MdiParent = Me.MdiParent
            frmReportViewer.Show()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Locar - Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Locar - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class