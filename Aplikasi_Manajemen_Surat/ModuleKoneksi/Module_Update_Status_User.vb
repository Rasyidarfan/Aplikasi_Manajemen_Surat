'Modul Koneksi Database
Imports System.Data.SqlClient

Public Class Module_Update_Status_User
   

    Public Shared sub UpdateUserStatusOnLogin(ID As Integer)

        Call database()
        DateTimeHelper.UpdateDateTimeVariables()

        Dim sql As String = "UPDATE Master_User SET last_login = @LastLogin, last_status = @LastStatus WHERE ID = @ID"

            Using cmd As New SqlCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@LastLogin", DateTimeHelper.DateAndTime) ' Update waktu terakhir login
                cmd.Parameters.AddWithValue("@LastStatus", "ONLINE")
                cmd.Parameters.AddWithValue("@ID", ID)

                cmd.ExecuteNonQuery()
            End Using
        
    End Sub

    Public Shared sub UpdateUserStatusOnLogout(ID As Integer)

        Call database()
        DateTimeHelper.UpdateDateTimeVariables()
        Dim sql As String = "UPDATE Master_User SET last_login = @LastLogin, last_status = @LastStatus WHERE ID = @ID"

            Using cmd As New SqlCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@LastLogin", DateTimeHelper.DateAndTime) ' Update waktu terakhir login
                cmd.Parameters.AddWithValue("@LastStatus", "OFFLINE")
                cmd.Parameters.AddWithValue("@ID", ID)

                cmd.ExecuteNonQuery()
            End Using
        
    End Sub
End Class


