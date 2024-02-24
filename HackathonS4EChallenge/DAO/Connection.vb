Imports System.Data.SqlClient

Public Class Connection
    Public Sub ExecuteReader(sql As String)
        Dim connectionString = ConfigurationManager.ConnectionStrings("HackathonS4E").ConnectionString
        Dim connection = New SqlConnection(connectionString)
        Dim command = New SqlCommand(sql, connection)
        Try
            connection.Open()
            command.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function Execute(sql As String) As DataView
        Dim connectionString = ConfigurationManager.ConnectionStrings("HackathonS4E").ConnectionString
        Dim connection = New SqlConnection(connectionString)
        Dim command = New SqlCommand(sql, connection)
        Dim dataAdapter = New SqlDataAdapter(command)
        Dim dataSet = New DataSet
        Try
            connection.Open()
            dataAdapter.Fill(dataSet)
            Return dataSet.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function
End Class
