Imports Locar

Public Class frmCarRentalsReport
    Private Sub frmCarRentalsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDue.Value = DateTime.Now.Date.AddDays(1)
    End Sub

    Private Sub btnCreateReport_Click(sender As Object, e As EventArgs) Handles btnCreateReport.Click
        If chkReportFull.Checked Then
            CreateFullReport()
        Else
            CreateFilteredReport()
        End If
    End Sub

    Private Sub CreateFilteredReport()
        Try
            Dim carBusiness As New CarBusiness
            Dim StartDate = dtpStart.Value.Date
            Dim DueDate = dtpDue.Value.Date
            Dim result As List(Of CarRentalsReport)
            Dim carRentalsReportBusiness As New CarRentalsReportBusiness()
            Dim rptCarRentals As New rptCarRentals

            result = carRentalsReportBusiness.CreateReportByFilters(StartDate, DueDate)
            frmReportViewer.SetReport(rptCarRentals)
            frmReportViewer.SetDataSource(Of IEnumerable(Of CarRentalsReport))(result)

            frmReportViewer.SetParameterValue("totalAvailable", carBusiness.SelectCountCarsAvailable().ToString())
            frmReportViewer.SetParameterValue("totalRented", carBusiness.SelectCountCarsRented().ToString())
            frmReportViewer.SetParameterValue("dtPeriod", StartDate.ToString("dd/MM/yyyy") & " a " & DueDate.ToString("dd/MM/yyyy"))

            frmReportViewer.MdiParent = Me.MdiParent
            frmReportViewer.Show()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Locar - Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Locar - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateFullReport()
        Try
            Dim carBusiness As New CarBusiness
            Dim result As List(Of CarRentalsReport)
            Dim carRentalsReportBusiness As New CarRentalsReportBusiness()
            Dim rptCarRentals As New rptCarRentals

            result = carRentalsReportBusiness.CreateReportFull()
            frmReportViewer.SetReport(rptCarRentals)
            frmReportViewer.SetDataSource(Of IEnumerable(Of CarRentalsReport))(result)

            frmReportViewer.SetParameterValue("totalAvailable", carBusiness.SelectCountCarsAvailable().ToString())
            frmReportViewer.SetParameterValue("totalRented", carBusiness.SelectCountCarsRented().ToString())
            frmReportViewer.SetParameterValue("dtPeriod", "- -")

            frmReportViewer.MdiParent = Me.MdiParent
            frmReportViewer.Show()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Locar - Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Locar - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkReportFull_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportFull.CheckedChanged
        dtpDue.Enabled = Not chkReportFull.Checked
        dtpStart.Enabled = Not chkReportFull.Checked
    End Sub
End Class