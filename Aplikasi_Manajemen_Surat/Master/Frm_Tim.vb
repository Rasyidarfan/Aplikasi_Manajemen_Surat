Imports System.Data.SqlClient
Public Class Frm_Tim
    Dim ID As Integer = 0
    Dim userRole As String = CheckUserRole(IDlogin)

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close
    End Sub
    
    Sub Bersih()
        Txt_Keterangan.Text = ""
        Txt_NamaTim.Text = ""
    End Sub

    Sub Aktif()
        Group_Input.Enabled = True
        BtnSimpan.Enabled = True
        BtnUserBaru.Enabled = False
    End Sub

    Sub NonAktif()
        Group_Input.Enabled = false
        BtnSimpan.Enabled = False
        BtnUserBaru.Enabled = True
    End Sub


      Sub TampilkanData()
        Try
            Cmd = New SqlCommand("Select ID, Nama_Tim, Keterangan, Role   " &
                                 "From Master_Tim      " &
                                 "Order By ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3))
            End While

        Catch ex As Exception
            MessageBox.Show("Desctiption Error = " + Err.Description, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()
    End Sub

    Private Sub Frm_Tim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Call Database()
        Try
            With DgvData
                .ColumnCount = 4
                .Columns(0).Name = "No"
                .Columns(0).Width = 40
                .Columns(1).Name = "Nama Tim"
                .Columns(1).Width = 200
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).Name = "Keterangan"
                .Columns(2).Width = 170
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).Name = "Role"
                .Columns(3).Width = 150
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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


        Call TampilkanData()
        Call Bersih()
        Call NonAktif()
    End Sub

    Private Sub Txt_NamaTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NamaTim.KeyPress
         If e.KeyChar = Chr(13) Then
            Txt_Keterangan.Focus()
        End If
    End Sub

    Private Sub Txt_Keterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Keterangan.KeyPress
         If e.KeyChar = Chr(13) Then
            CmbRole.Focus()
        End If
    End Sub

    Private Sub CmbRole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbRole.KeyPress
         If e.KeyChar = Chr(13) Then
            BtnSimpan.PerformClick()
        End If
    End Sub

    Private Sub BtnUserBaru_Click(sender As Object, e As EventArgs) Handles BtnUserBaru.Click 
         'check Validasi
        Dim userRole As String = CheckUserRole(IDlogin)

        If userRole = "Umum" Then
        Call Bersih()
        Call Aktif()
        Txt_NamaTim.Focus() 
        ElseIf userRole ="Biasa" Then
         MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If    
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        
         If Txt_NamaTim.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Txt_Keterangan.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CmbRole.Text = "PILIH TYPE" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf userRole ="Biasa" Then
         MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf userRole ="Umum" Then
            Try
                  
                'insert to database 
                 DateTimeHelper.UpdateDateTimeVariables()
                Dim sql As String = "Update Master_Tim SET Nama_Tim=@Nama_Tim, Role=@Role, Keterangan=@Keterangan,       " &
                                     "Last_Modified=@Last_Modified WHERE ID=@ID "
                                     
                Using cmd As New SqlCommand(sql, Conn)

                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.Parameters.AddWithValue("@Nama_Tim", Txt_NamaTim.Text)
                    cmd.Parameters.AddWithValue("@Keterangan", Txt_Keterangan.Text)
                    cmd.Parameters.AddWithValue("@Role", CmbRole.Text)
                    cmd.Parameters.AddWithValue("@Last_Modified",DateTimeHelper.DateAndTime )          
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Data Tim Berhasil Dirubah", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
               MessageBox.Show("Data Tim Gagal Dirubah: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Call TampilkanData()
            Call Bersih()
            Call NonAktif()

        End If
    End Sub

    Private Sub DgvData_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseClick
           Try
            Call Aktif()
             ID = DgvData.CurrentRow.Cells(0).Value
            Txt_NamaTim.Text = DgvData.CurrentRow.Cells(1).Value.ToString
            Txt_Keterangan.Text = DgvData.CurrentRow.Cells(2).Value.ToString
            CmbRole.Text =  DgvData.CurrentRow.Cells(3).Value.ToString
        Catch ex As Exception
          
        End Try
    End Sub
End Class