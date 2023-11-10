
'//Form Login Pengguna
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Frm_UserBaru
    Dim userrole As String  = CheckUserRole(IDlogin)
       
    Dim Pass As String

    Sub Bersih()
        TxtNamaDapan.Clear()
        TxtNamaBelakang.Clear()
        TxtUsername.Clear()
        TxtPassword.Clear()
        TxtPassword.PasswordChar =""
        cmb_status.SelectedIndex = 0
    End Sub

    Sub NonAktif()
        Btn_ubah.Enabled = false
        Group_Input.Enabled = False
        TxtPassword.ReadOnly = false
        BtnSimpan.Enabled = False
        Btn_Delete.Enabled = False
        BtnUserBaru.Enabled =True
    End Sub

    Sub Aktif()
        TxtPassword.ReadOnly = false
        Btn_ubah.Enabled = false
        BtnSimpan.Enabled = True
        Btn_Delete.Enabled = False
        BtnUserBaru.Enabled =False   
        Group_Input.Enabled = True
    End Sub

    Sub Aktif_While_Click_DGV()
        Btn_ubah.Enabled = True
        BtnSimpan.Enabled = false
        Btn_Delete.Enabled = True
        BtnUserBaru.Enabled =True   
        Group_Input.Enabled = True
    End Sub

    'Menampilkan Tim
    Sub Tim()
        Try
            Cmd = New SqlCommand("Select Nama_Tim, ID From Master_Tim     " &
                                 "Order By ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            Cmbtype.Items.Clear()
            While Reader.Read
                Cmbtype.Items.Add(New KeyValuePair(Of String, Integer)(Reader(0), Reader(1)))
            End While
            Cmbtype.DisplayMember = "Key"
            Reader.Close()
        Catch ex As Exception
            MsgBox("Description String = " + Err.Description)
        End Try
        Reader.Close()

    End Sub


    Sub TampilkanData()
     
        If  cmb_status.SelectedIndex = 0 Then
             Try
            Cmd = New SqlCommand("Select A.ID, A.First_Name, A.Last_Name, A.Username, B.Nama_Tim    " &
                                 "From Master_User A Join Master_Tim B ON A.Type_Tim=B.ID where A.Aktif=0  " &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4))
            End While
            
            Btn_Delete.Text = "NonAktif"
            Btn_Delete.BackColor = Color.Red
        Catch ex As Exception
            MessageBox.Show("Desctiption Error = " + Err.Description, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()

        ElseIf cmb_status.SelectedIndex = 1 Then
             Try
            Cmd = New SqlCommand("Select A.ID, A.First_Name, A.Last_Name, A.Username, B.Nama_Tim    " &
                                 "From Master_User A Join Master_Tim B ON A.Type_Tim=B.ID where A.Aktif=1  " &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4))
            End While
           Btn_Delete.Text = "Aktif"
           Btn_Delete.BackColor = Color.FromArgb(23, 89,74)
        Catch ex As Exception
            MessageBox.Show("Desctiption Error = " + Err.Description, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()
        End If
       
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

    Private Sub FrmUserBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database()
        Try
            With DgvData
                .ColumnCount = 5
                .Columns(0).Name = "No"
                .Columns(0).Width = 40
                .Columns(1).Name = "First Name"
                .Columns(1).Width = 170
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).Name = "Last Name"
                .Columns(2).Width = 170
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).Name = "Username"
                .Columns(3).Width = 150
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).Name = "Type Tim"
                .Columns(4).Width = 120
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ReadOnly = True
                .MultiSelect = False
                .RowHeadersVisible = False
                .AutoSizeColumnsMode = DatagridviewAutoSizeColumnsMode.fill
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .AllowUserToDeleteRows = False
            End With

        Catch ex As Exception
           MessageBox.Show("Tampilkan Data database error: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Call Tim()
        Call TampilkanData()
        Call Bersih()
        Call NonAktif()
    End Sub



    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged
        If TxtUsername.Text <> "" And TxtPassword.ReadOnly = false Then
            TxtPassword.Text = TxtUsername.Text + "123"
        Else
            TxtPassword.Text = ""
        End If
    End Sub


    Private Sub TxtNamaDapan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaDapan.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNamaBelakang.Focus()
        End If
    End Sub

    Private Sub TxtNamaBelakang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaBelakang.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnSimpan.PerformClick()
        End If
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub BtnUserBaru_Click_1(sender As Object, e As EventArgs) Handles BtnUserBaru.Click
         'check Validasi
        Dim userRole As String = CheckUserRole(IDlogin)

        If userRole = "Umum" Then
        Call Bersih()
        Call Aktif()
        TxtNamaDapan.Focus() 
        ElseIf userRole ="Biasa" Then
         MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call Enkripsi()
        If TxtNamaDapan.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf TxtUsername.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Cmbtype.Text = "PILIH TYPE" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                  
                'insert to database
                DateTimeHelper.UpdateDateTimeVariables()
                Dim ValueIDTim As Integer
                ValueIDTim = (Cmbtype.SelectedItem).Value
                Dim sql As String = "Insert Into Master_User (Username, Password, First_Name,       " &
                                     "Last_Name, Type_Tim, Last_Status, Aktif,addid, addtime) values (@Username, @Password, @First_Name,   " &
                                     "@Last_Name, @Type_Tim, @Last_Status, @Aktif, @addid, @addtime)" 
                Using cmd As New SqlCommand(sql, Conn)
                    cmd.Parameters.AddWithValue("@Username", TxtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", Pass)
                    cmd.Parameters.AddWithValue("@First_Name", TxtNamaDapan.Text)
                    cmd.Parameters.AddWithValue("@Last_Name", TxtNamaBelakang.Text)
                    cmd.Parameters.AddWithValue("@Type_Tim", ValueIDTim)
                    cmd.Parameters.AddWithValue("@Last_Status", "OFFLINE")  
                    cmd.Parameters.AddWithValue("@Aktif", 0)
                    cmd.Parameters.AddWithValue("@addid", IDlogin)
                    cmd.Parameters.AddWithValue("@addtime", DateTimeHelper.DateAndTime )                   
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Data User Berhasil Disimpan", "Pesan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Desctiption Error = " + Err.Description, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Call TampilkanData()
            Call Bersih()
            Call NonAktif()

        End If
    End Sub

    Private Sub DgvData_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseClick
       Try
            Call Aktif_While_Click_DGV()
            TxtNamaDapan.Text = DgvData.CurrentRow.Cells(1).Value.ToString
            TxtNamaBelakang.Text = DgvData.CurrentRow.Cells(2).Value.ToString
            TxtUsername.Text = DgvData.CurrentRow.Cells(3).Value.ToString
            Cmbtype.Text     = DgvData.CurrentRow.Cells(4).Value.ToString
            TxtPassword.PasswordChar = "*"
            TxtPassword.ReadOnly = True
        Catch ex As Exception
            Call Bersih()
        End Try
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
            Dim Message As String=""

            Dim NilaiStatus As Integer = 0
               
                If cmb_status.SelectedIndex = 0 Then
                    NilaiStatus = 1
                    Message = "NonAktifkan"
                Elseif  cmb_status.SelectedIndex = 1 then
                    NilaiStatus = 0
                      Message = "Aktifkan"
                End If


        If DgvData.RowCount = 0 Then
             MessageBox.Show("Data Not Found", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
             Return


        ElseIf MessageBox.Show("Yakin akan " & Message & " User " & DgvData.CurrentRow.Cells(1).Value.ToString & "  ini..?", "Peringatan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
          

            If userrole = "Umum" Then
             Try
              
                Dim sqlhapus As String = "Update Master_User set Aktif = " & NilaiStatus & " where ID='" & DgvData.CurrentRow.Cells(0).Value.ToString & "'",
                cmd = New SqlCommand(sqlhapus, Conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show(Message & " User Berhasil", "Information",  MessageBoxButtons.OK, MessageBoxIcon.Information)    
                        
                         
            Catch ex As Exception
                MessageBox.Show(Message & " User Gagal: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
           
            Call TampilkanData()
            Call Bersih()
            Call NonAktif()
            ElseIf userrole = "Biasa" Then
             MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)     
            End If
           
        End If
    End Sub

    Private Sub Btn_ubah_Click(sender As Object, e As EventArgs) Handles Btn_ubah.Click
          If DgvData.RowCount > 1 = False Then
            MessageBox.Show("User Not Found", "Informasi",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub

        ElseIf DgvData.CurrentCell.Value Is Nothing Then
            MessageBox.Show("User Not Found", "Informasi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub

        ElseIf MessageBox.Show("Yakin akan Mengubah User " & DgvData.CurrentRow.Cells(1).Value.ToString & "  ini..?", "Peringatan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
          

            If userrole = "Umum" Then
             Try
                 If TxtNamaDapan.Text = "" Then
                        MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)

                 ElseIf TxtUsername.Text = "" Then
                        MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                 ElseIf Cmbtype.Text = "PILIH TYPE" Then
                        MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information)

                 Else
                Dim ValueIDTim As Integer
                ValueIDTim = (Cmbtype.SelectedItem).Value
                Dim sqlhapus As String = "Update Master_User set Username='" & TxtUsername.Text & "', First_Name='" & TxtNamaDapan.Text & "', " &
                                         "Last_Name='" & TxtNamaBelakang.Text & "', Type_Tim =" & ValueIDTim & " where ID= " &
                                         DgvData.CurrentRow.Cells(0).Value.ToString & "",
                cmd = New SqlCommand(sqlhapus, Conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Ubah User Berhasil", "Information",  MessageBoxButtons.OK, MessageBoxIcon.Information)     
                End If
            Catch ex As Exception
                MessageBox.Show("Ubah User Gagal: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
           
            Call TampilkanData()
            Call Bersih()
            Call NonAktif()
            ElseIf userrole = "Biasa" Then
             MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)     
            End If
           
        End If
    End Sub

    Private Sub cmb_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_status.SelectedIndexChanged
       TampilkanData()
    End Sub

    Private Sub cmb_status_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_status.MouseClick
         If userrole = "Umum" Then
          TampilkanData()
         ElseIf userrole = "Biasa" Then
            MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)    
         End If
    End Sub
End Class