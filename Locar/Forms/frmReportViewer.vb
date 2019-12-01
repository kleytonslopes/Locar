Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportViewer
    Private reportClass As ReportClass
    Private dataSoucer As IEnumerable(Of Object)

    Public Sub SetReport(ByVal report As ReportClass)
        reportClass = report
        crvReport.ReportSource = reportClass
    End Sub

    Public Sub SetDataSource(Of T)(ByVal data As T)
        dataSoucer = data
        reportClass.SetDataSource(dataSoucer)
    End Sub

    Public Sub SetParameterValue(ByVal name As String, ByVal value As String)
        crvReport.Refresh()
        reportClass.SetParameterValue(name, value)
        crvReport.Refresh()
    End Sub

End Class