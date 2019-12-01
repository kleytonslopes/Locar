Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports Dapper

Public Class ConnectionFactory
    Implements IDisposable

    Private connection As SqlConnection

    Public Sub Dispose() Implements IDisposable.Dispose

        If connection IsNot Nothing Then
            connection.Dispose()
            connection = Nothing
        End If

        GC.SuppressFinalize(Me)
    End Sub

    Public Sub New()
        Dim localPath As String
        localPath = Directory.GetCurrentDirectory()
        connection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & localPath & "\database.mdf;Integrated Security=True")
        connection.Open()
    End Sub

    Public Sub Save(ByVal query As String, Optional ByVal parameters As Object = Nothing)
        connection.Execute(query, parameters)
    End Sub

    Public Function SelectFirst(Of T)(sql As String, parameters As Object) As T
        Dim result As T

        result = connection.QueryFirstOrDefault(Of T)(sql, parameters)

        SelectFirst = result
    End Function

    Public Function SelectList(Of T)(sql As String, parameters As Object) As IEnumerable(Of T)
        Dim result As IEnumerable(Of T)

        result = connection.Query(Of T)(sql, parameters)

        SelectList = result
    End Function
End Class
