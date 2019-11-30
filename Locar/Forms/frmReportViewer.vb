Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportViewer
    Private reportClass As ReportClass
    Private dataSoucer As IEnumerable(Of Object)

    Public Sub SetReport(ByVal report As ReportClass)
        reportClass = report
    End Sub

    Public Sub SetDataSource(Of T)(ByVal data As T)
        dataSoucer = data
    End Sub

    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportClass.SetDataSource(dataSoucer)
        crvReport.ReportSource = reportClass
    End Sub
End Class