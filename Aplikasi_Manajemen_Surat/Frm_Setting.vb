'Kebutuhan untuk akses file
Imports System.IO
'Modul Koneksi Database
Imports System.Data.SqlClient
Public Class Frm_Setting

    Sub Check()
    'Tempat lokasi file connection    
    Dim filePath As String = "App\....\config.ini"

    ' Mengecek apakah file connection.txt ada
    If Not File.Exists(filePath) Then
        ' Jika file tidak ada, maka buat file baru
        File.WriteAllText(filePath, "DefaultServer" & Environment.NewLine & "DefaultUser" & Environment.NewLine & "DefaultPassword")
    Else
    ' Membaca isi file connection.txt
    Dim fileContents As String = File.ReadAllText(filePath)

    ' Memisahkan baris-baris teks
    Dim lines() As String = fileContents.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

    If lines.Length >= 3 Then
        ' Mengisikan nilai dari file ke TextBox
        txt_server.Text = lines(0)
        txt_user.Text = lines(1)
        txt_password.Text = lines(2)

    End If
             
    End If
    
    Btn_TestConnect.Enabled = false
    
    End Sub


    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close
    End Sub

    Private Sub Frm_Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Check()
    End Sub

    Private Sub Btn_Apply_Click(sender As Object, e As EventArgs) Handles Btn_Apply.Click
    If Txt_server.Text = "" Then
    MessageBox.Show("Server Tidak boleh kosong: ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Txt_server.Focus()
    ElseIf Txt_User.Text = "" then
    MessageBox.Show("Username Tidak boleh kosong: ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Txt_User.Focus()
    ElseIf Txt_Password.Text = "" then
    MessageBox.Show("Password Tidak boleh kosong: ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Txt_Password.Focus()
    Else
      Btn_TestConnect.Enabled = True
    ' Mengambil isi file connection.txt
    Dim fileContents As String = File.ReadAllText("App\....\config.ini")

    ' Memisahkan baris-baris teks
    Dim lines() As String = fileContents.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

    ' Memastikan bahwa ada cukup baris dalam file (minimal 3 baris)
    If lines.Length >= 3 Then
        ' Menyimpan nilai dari TextBox ke dalam array lines
        lines(0) = txt_server.Text
        lines(1) = txt_user.Text
        lines(2) = txt_password.Text

        ' Menggabungkan kembali baris-baris teks
        fileContents = String.Join(Environment.NewLine, lines)

        ' Menyimpan teks yang telah diperbarui kembali ke dalam file
        File.WriteAllText("App\....\config.ini", fileContents)

        MessageBox.Show("Data tersimpan dalam config.ini", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
        ' Kasus jika file tidak memiliki minimal 3 baris
        MessageBox.Show("Format file config.ini tidak valid", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    End If


    
    End Sub

    Private Sub Btn_TestConnect_Click(sender As Object, e As EventArgs) Handles Btn_TestConnect.Click

         Dim filePath As String = "App\....\config.ini"
         Dim fileContents_check As String = File.ReadAllText(filePath)

        ' Memisahkan baris-baris teks
        Dim lines() As String = fileContents_check.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        
        If String.IsNullOrEmpty(fileContents_check) Then
         MessageBox.Show("Data Config Belum Terisi: ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
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

            Conn = New SqlConnection("Data Source=" & server & ";     " &
                                    "Initial Catalog=" & db & ";      " &
                                    "Persist Security Info = True;    " &
                                    "Trusted_Connection = False;      " &
                                    "Connection Timeout = 0;          " &
                                    "User ID=" & user & ";            " &
                                    "Password=" & pass)
            Conn.Open()
       
        MessageBox.Show("Koneksi database " & db & " Sukses", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        MessageBox.Show("Koneksi database error: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try 
        End If
       
    End Sub

    Private Sub Txt_server_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_server.KeyPress
         If e.KeyChar = Chr(13) Then
            Txt_User.Focus()
        End If
    End Sub

    Private Sub Txt_User_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_User.KeyPress
          If e.KeyChar = Chr(13) Then
            Txt_Password.Focus()
        End If
    End Sub

    Private Sub Txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Password.KeyPress
          If e.KeyChar = Chr(13) Then
            Btn_Apply.PerformClick()
        End If
    End Sub
End Class
