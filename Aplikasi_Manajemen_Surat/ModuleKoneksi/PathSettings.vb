Imports System.Data.SqlClient
Module PathSettings
    Public DefaultPath As String = "App\....\Upload"
    Public CustomPath As String

    Public Sub SetCustomPath(path As String)
        CustomPath = path
    End Sub

     Public Function GetSettingPathFromDatabase() As String
        
        Dim sql As String = "SELECT setting_path FROM Setting" 

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using cmd As New SqlCommand(sql, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return result.ToString()
                Else
                    Return DefaultPath 
                End If
            End Using
        End Using
    End Function


End Module
