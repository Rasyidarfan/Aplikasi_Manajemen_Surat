
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Public Class Frm_Pengaturan
    Dim PassLama, PassBaru As String
    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Call Nonaktif()
        Me.Close()
    End Sub

    Sub bersih()
        Txt_passlama.Text = ""
        Txt_Passbaru.Text = ""
        Txt_Konfirpassbaru.Text = ""
    End Sub

    Sub Nonaktif
         PbOke.Hide()
        PbNotOke.Hide()
        PbOke1.Hide()
        PbNotOke1.Hide()
        Txt_Passbaru.Enabled = False
        Txt_Passbaru.Enabled = False
        BtnSimpan.Enabled = false
    End Sub

    '//Class Pada Enkripsi Password Lama//==========================
#Region "md5"
    Sub EnkripsiLama()
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Txt_passlama.Text))
        DES.Mode = CipherMode.ECB
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(Txt_passlama.Text)
        PassLama = Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Sub

   
#End Region
    '//End //=======================================================

    '//Class Pada Enkripsi Password Baru//==========================
#Region "md5"
    Sub EnkripsiBaru()
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(Txt_Passbaru.Text))
        DES.Mode = CipherMode.ECB
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(Txt_Passbaru.Text)
        PassBaru = Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Sub

  
#End Region
    '//End //=======================================================

    Private Sub Txt_Konfirpassbaru_TextChanged(sender As Object, e As EventArgs) Handles Txt_Konfirpassbaru.TextChanged
         If Txt_Konfirpassbaru.Text = Txt_Passbaru.Text Then
            PbOke1.Show()
            PbNotOke1.Hide()
            BtnSimpan.Enabled = True
        ElseIf Txt_Konfirpassbaru.Text <> Txt_Passbaru.Text Then
            PbOke1.Hide()
            PbNotOke1.Show()
           BtnSimpan.Enabled = false
        ElseIf Txt_Konfirpassbaru.Text = "" Then
            PbOke1.Hide()
            PbNotOke1.Hide()
            BtnSimpan.Enabled = false
        End If
    End Sub

    Private Sub Txt_passlama_TextChanged(sender As Object, e As EventArgs) Handles Txt_passlama.TextChanged
         If txt_passlama.Text = "" Then
            PbOke.Hide()
            PbNotOke.Hide()
            PbOke1.Hide()
            PbNotOke1.Hide()
            Txt_Passbaru.Clear()
            Txt_Konfirpassbaru.Clear()
            Txt_Passbaru.Enabled = False
            Txt_Konfirpassbaru.Enabled = False

        ElseIf txt_passlama.Text <> "" Then
            Call EnkripsiLama()
            Cmd = New SqlCommand("Select [Password] From Master_User      " &
                                 "Where [Password] = '" & PassLama & "'   " &
                                 "And ID =" & IDlogin & "", Conn)
            Reader = Cmd.ExecuteReader
            
            If Reader.Read = True Then
                If Reader(0) = PassLama Then
                    PbOke.Show()
                    PbNotOke.Hide()
                    Txt_Passbaru.Enabled = True
                    Txt_Konfirpassbaru.Enabled = True
                End If
            ElseIf Reader.Read = Nothing Then
                PbOke.Hide()
                PbNotOke.Show()
                Txt_Passbaru.Clear()
                Txt_Konfirpassbaru.Clear()
                Txt_Passbaru.Enabled = False
                Txt_Konfirpassbaru.Enabled = False
            End If
            'End While
        End If
        Reader.Close()
    End Sub

    Private Sub Txt_passlama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_passlama.KeyPress
         If e.KeyChar = Chr(13) Then
            txt_passbaru.Focus()
        End If
    End Sub

    Private Sub Txt_Passbaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Passbaru.KeyPress
         If e.KeyChar = Chr(13) Then
            Txt_Passbaru.Focus()
        End If
    End Sub

  

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Txt_passlama.Text = "" Then
              MessageBox.Show("Mohon dilengkapi data anda", "Informasi",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Txt_Konfirpassbaru.Text ="" then
             MessageBox.Show("Mohon dilengkapi data anda", "Informasi",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Txt_Passbaru.Text = "" then
             MessageBox.Show("Mohon dilengkapi data anda", "Informasi",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            
      Call EnkripsiBaru()
      DateTimeHelper.UpdateDateTimeVariables()


        Cmd = New SqlCommand("Update Master_User Set [Password] ='" & PassBaru & "'" & ",addid =  " & IDlogin &
                             ", ADDTIME = '" & DateTimeHelper.DateAndTime & "'" &
                             " Where ID =" & IDlogin & "", Conn)
        Query = Cmd.ExecuteNonQuery
       
        MessageBox.Show("Password Anda Berhasil Diubah " & "Sukses", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
        Call Nonaktif()
        Txt_passlama.Focus()
        End If

    End Sub

    Private Sub Frm_Pengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      call SelectRadioButtonBasedOnIsPath()
    End Sub

 

#Region "Setting Path"

    Sub Pilih_default()
         group_default.Enabled = True
         Group_Custom.Enabled = False 
         lbl_path_default.Text = PathSettings.DefaultPath
    End Sub
    Private Sub rdb_default_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_default.CheckedChanged
      If rdb_default.Checked = True Then
          Call Pilih_default()
        ElseIf rdb_default.Checked = False then
            group_default.Enabled = False
            Group_Custom.Enabled = True
      End If
    End Sub

    Private Sub Btn_Simpan_Path_Click(sender As Object, e As EventArgs) Handles Btn_Simpan_Path.Click
        Try
          If Group_Custom.Enabled = True And Txt_pathfile.Text = "" then
                MessageBox.Show("Mohon Pilih Folder nya terlebih dahulu ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
          elseif MessageBox.Show("Yakin akan Simpan path ini..?", "Peringatan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'check Validasi
                Dim userRole As String = CheckUserRole(IDlogin)
                
                If userRole = "Umum" Then
                     Dim is_path As Integer
                Dim path_choice As String = ""
                If rdb_default.Checked = True Then
                    is_path = 0
                    path_choice = PathSettings.DefaultPath
                ElseIf rdb_default.Checked = False then
                    is_path = 1
                    path_choice = PathSettings.CustomPath
                End If


                DateTimeHelper.UpdateDateTimeVariables()
                Dim sql As String = "UPDATE Setting SET setting_path=@setting_path, is_path=@is_path, addid=@addid, addtime=@addtime WHERE ID=1 " 
                                                                      
                Using cmd As New SqlCommand(sql, Conn)

                    cmd.Parameters.AddWithValue("@setting_path", path_choice)
                    cmd.Parameters.AddWithValue("@is_path", is_path)
                    cmd.Parameters.AddWithValue("@addid",IDlogin ) 
                    cmd.Parameters.AddWithValue("@addtime", DateTimeHelper.DateAndTime)   
                    cmd.ExecuteNonQuery()
                End Using
       
                MessageBox.Show("Direktori Path PDF Surat Berhasil Disimpan", "Pesan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf userRole="Biasa" Then

                MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If           
        End If
            
        Catch ex As Exception
            MessageBox.Show("Pengaturan Path error: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
       If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
        Dim selectedPath As String = FolderBrowserDialog1.SelectedPath
        Txt_pathfile.Text = selectedPath 
        PathSettings.SetCustomPath(selectedPath)
    End If
    End Sub

    Sub SelectRadioButtonBasedOnIsPath() '
    Dim isPathValue As Integer = 0 
    
     Dim dt As New DataTable
                    
     dt = ExecuteQuery("select is_path from Setting") 
   

    If dt.Rows.Count > 0 Then
     
        Dim row As DataRow = dt.Rows(0) '

        If dt.Columns.Contains("is_path") Then
            isPathValue = Convert.ToInt32(row("is_path"))
        End If
    End If

    
    If isPathValue = 0 Then
        rdb_default.Checked = True
    ElseIf isPathValue = 1 Then
        rdp_custom.Checked = True
       Txt_pathfile.Text = PathSettings.GetSettingPathFromDatabase()
    End If
    End Sub


   #End Region


End Class