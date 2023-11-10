Imports System.Data.SqlClient
Public Class Frm_Klasifikasi

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.close()
    End Sub

    Sub bersih()
        txt_kode.Text = ""
        Txt_Keterangan.Text=""
    End Sub

    Sub Aktif()
       Group_Input.Enabled = True
       BtnSimpan.Enabled = True  
    End Sub

    Sub NonAktif()
       Group_Input.Enabled = False   
       BtnSimpan.Enabled = False   
    End Sub

      Sub TampilkanData()
        Try
            Cmd = New SqlCommand("Select Kode,  Keterangan   " &
                                 "From Master_Klasifikasi      " &
                                 "Order By Kode Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1))
            End While

        Catch ex As Exception
            MessageBox.Show("Desctiption Error = " + Err.Description, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()
    End Sub

    Private Sub Frm_Klasifikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Call Database()
        Try
            With DgvData
                .ColumnCount = 2
                .Columns(0).Name = "Kode"
                .Columns(0).Width = 40
                .Columns(1).Name = "Keterangan"
                .Columns(1).Width = 400
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter          
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

    Private Sub txt_kode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kode.KeyPress
         If e.KeyChar = Chr(13) Then
            Txt_Keterangan.Focus()
        End If
    End Sub

    Private Sub Txt_Keterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Keterangan.KeyPress
         If e.KeyChar = Chr(13) Then
            BtnSimpan.PerformClick()
        End If
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
           Dim userRole As String = CheckUserRole(IDlogin)
          If txt_kode.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Txt_Keterangan.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf userRole ="Biasa" Then
         MessageBox.Show("Anda Tidak Memiliki Hak Otorisasi Untuk Melakukan Tindakan Ini ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Elseif  userRole ="Umum" Then
           
                     Try 
                    'Update to database 
                     DateTimeHelper.UpdateDateTimeVariables()
                    Dim sql As String = "Update Master_Klasifikasi Set Keterangan= @Keterangan,        " &
                                        "Modifiedby=@Modifiedby , ModifiedDate=@ModifiedDate Where Kode=@kode " 
                    Using cmd As New SqlCommand(sql, Conn)

                        cmd.Parameters.AddWithValue("@Kode", txt_kode.Text)
                        cmd.Parameters.AddWithValue("@Keterangan", Txt_Keterangan.Text)
                        cmd.Parameters.AddWithValue("@Modifiedby", IDlogin)
                        cmd.Parameters.AddWithValue("@ModifiedDate",DateTimeHelper.DateAndTime )          
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data Klasifikasi Berhasil Dirubah", "Information",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call TampilkanData()
                    Call Bersih()
                    Call NonAktif()
                    Catch ex As Exception
                       MessageBox.Show("Data Klasifikasi Gagal Dirubah: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    
        End If
    End Sub

       

    Private Sub DgvData_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseClick
           Try
            Call Aktif()
            txt_kode.Text = DgvData.CurrentRow.Cells(0).Value.ToString
            Txt_Keterangan.Text = DgvData.CurrentRow.Cells(1).Value.ToString
       
        Catch ex As Exception
          
        End Try
    End Sub
End Class