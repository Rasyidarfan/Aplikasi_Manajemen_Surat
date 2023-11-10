'Modul Koneksi Database
Imports System.Data.SqlClient
Module Module_Koneksi
    'Kebutuhan-Kebutuhan Parameter Yang Dibutuhkan
    Public Conn As SqlConnection
    Public Cmd As SqlCommand
    Public Reader As SqlDataReader
    Public Query, Digit As Integer
    Public IDlogin As Integer
    Public connectionString As string

  
    'Koneksi Server
    Sub Database()
        Try
            Dim server, user, db, pass As String
            Dim fileContents As String = System.IO.File.ReadAllText("App\....\config.ini")
            Dim line() As String
            fileContents = fileContents.Replace(ControlChars.CrLf, ControlChars.Lf)
            line = fileContents.Split(New Char() {ControlChars.Lf, ControlChars.Cr})
            server = line(0)
            db = "Database_Surat"
            user = line(1)
            pass = line(2)

            connectionString = "Data Source=" & server & ";     " &
                                    "Initial Catalog=" & db & ";      " &
                                    "Persist Security Info = True;    " &
                                    "Trusted_Connection = False;      " &
                                    "Connection Timeout = 0;          " &
                                    "User ID=" & user & ";            " &
                                    "Password=" & pass

            Conn = New SqlConnection("Data Source=" & server & ";     " &
                                    "Initial Catalog=" & db & ";      " &
                                    "Persist Security Info = True;    " &
                                    "Trusted_Connection = False;      " &
                                    "Connection Timeout = 0;          " &
                                    "User ID=" & user & ";            " &
                                    "Password=" & pass)
            Conn.Open()
            

        Catch ex As Exception
        MessageBox.Show("Koneksi database error: " & ex.Message, "Silahkan Setting Database Dahulu", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'executequery
    Public Function ExecuteQuery(query As String) As DataTable
        Using connection As New SqlConnection(connectionString)
            Dim dataTable As New DataTable()
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                dataTable.Load(reader)
                reader.Close()
            Catch ex As Exception
                Throw ex
            End Try

            Return dataTable
        End Using
    End Function

    'executenonquery

    Public Sub ExecuteNonQuery(query As String)
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub

    'sqltable
  
    Public Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim Adp As New SqlDataAdapter(Source, Conn)
            Dim DT As New DataTable

            Adp.Fill(DT)
            SQLTable = DT
        Catch ex As Exception
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function


    'check user
Public Function CheckUserRole(user As Integer) As String
    Dim role As String = "Biasa" ' Default role jika tidak ditemukan

    Try
       
        Using cmd As New SqlCommand("SELECT A.Role FROM Master_Tim A " &
			                         "Join Master_User  B on A.ID = B.Type_Tim WHERE B.ID = @USERID", Conn)
            cmd.Parameters.AddWithValue("@USERID", user)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                role = result.ToString()
            End If
        End Using
    Catch ex As Exception
       MessageBox.Show("CheckUserRole: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
     
    End Try

    Return role

    
End Function

 

End Module
