'Modul Koneksi Database
Imports System.Data.SqlClient
'Modul untuk berhubungan untuk file dan folder
Imports System.IO
Public Class Frm_SuratKeluar
    Dim userRole As String = CheckUserRole(IDlogin)


 Sub bersih()
    Panel_pilihklasifikasi.Visible = false
    Txt_tujuan.Text = ""
    Txt_Perihal.Text = ""
    Nup_Jumlah.Value = 1
    DTP_Tanggal.Value = Now
    lbl_keterangan.Text = ""
    lbl_kode.Text = ""
    Cmb_Tim.Text = "PILIH TYPE"
    DTP_Tanggal.Enabled = True
    Cmb_Tim.Enabled = True
    Call Tim()
End Sub

  Sub Tim()
        If userRole = "Umum" Then
        Try
            Cmd = New SqlCommand("Select Nama_Tim, ID From Master_Tim     " &
                                 "Order By ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            Cmb_Tim.Items.Clear()          
            While Reader.Read
                Cmb_Tim.Items.Add(New KeyValuePair(Of String, Integer)(Reader(0), Reader(1)))
            End While
            Cmb_Tim.DisplayMember = "Key"
            Reader.Close()
        Catch ex As Exception
            MsgBox("Description String = " + Err.Description)
        End Try
        Reader.Close()


        ElseIf userRole="Biasa" Then
         Try
            Cmd = New SqlCommand("Select A.Nama_Tim, A.ID From Master_Tim A Join Master_User B ON A.ID = B.Type_Tim  Where  B.ID=  " & IDlogin &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            Cmb_Tim.Items.Clear()
            Cmb_Tim.Enabled = false
            DTP_Tanggal.Enabled = False
            While Reader.Read
                Cmb_Tim.Items.Add(New KeyValuePair(Of String, Integer)(Reader(0), Reader(1)))
            End While
            Cmb_Tim.DisplayMember = "Key"
            
            Reader.Close()
             If Cmb_Tim.Items.Count > 0 Then
                Cmb_Tim.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Description String = " + Err.Description)
        End Try
        Reader.Close()
        End If
    End Sub


    Private Sub Btn_Batal_Click(sender As Object, e As EventArgs) Handles Btn_Batal.Click
        Call bersih()
        rch1.Visible = False
        rch1.Clear()
    End Sub

    Private Sub Frm_SuratKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database()
        Call bersih()
        rch1.Visible = False
        rch1.Clear()
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close()
    End Sub

    #Region "Event Keypress"
    Private Sub Cmb_klasifikasi_KeyPress(sender As Object, e As KeyPressEventArgs) 
    If e.KeyChar = Chr(13) Then
       Txt_tujuan.Focus()
    End If
    End Sub
    Private Sub Txt_tujuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_tujuan.KeyPress
     If e.KeyChar = Chr(13) Then
       Txt_Perihal.Focus()
    End If
    End Sub

    Private Sub Txt_Perihal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Perihal.KeyPress
     If e.KeyChar = Chr(13) Then
       Nup_Jumlah.Focus()
    End If
    End Sub

    Private Sub Nup_Jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nup_Jumlah.KeyPress
    If e.KeyChar = Chr(13) Then
       Cmb_Tim.Focus()
    End If
    End Sub

    Private Sub Cmb_Tim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_Tim.KeyPress
     If e.KeyChar = Chr(13) Then
       DTP_Tanggal.Focus()
    End If
    End Sub

    Private Sub DTP_Tanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTP_Tanggal.KeyPress
     If e.KeyChar = Chr(13) Then
       Btn_Generate.PerformClick()
    End If
    End Sub
#End Region
    Private Sub Btn_Generate_Click(sender As Object, e As EventArgs) Handles Btn_Generate.Click
         If MessageBox.Show("Apakah Anda Yakin Generate Surat Dengan Jumlah " & Nup_Jumlah.Value & "  ini..?", "Informasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
           
            'Generate Nomor Surat
         If lbl_kode.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

         ElseIf lbl_keterangan.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
         ElseIf Txt_tujuan.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

         ElseIf Txt_Perihal.Text = "" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
         ElseIf Nup_Jumlah.Value= 0 Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

         ElseIf Cmb_Tim.Text = "PILIH TYPE" Then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                 
                'insert to database
                rch1.Clear()
                Dim ValueIDTim As Integer
                ValueIDTim = (Cmb_Tim.SelectedItem).Value
                
                DateTimeHelper.UpdateDateTimeVariables()
                Dim tanggal As String = DTP_Tanggal.Value.ToString("yyyy-MM-dd")

                Dim sqlCommand As New SqlCommand("exec spGenerate_mail_number "& ValueIDTim &",'"& lbl_kode.Text &"','"&  Txt_tujuan.Text &"','"& Txt_Perihal.Text &"','"& tanggal  &"',"& Nup_Jumlah.Value &","& IDlogin,Conn)
               
                Dim dtx As New DataTable

                    dtx = ExecuteQuery("exec spGenerate_mail_number "& ValueIDTim &",'"& lbl_kode.Text &"','"&  Txt_tujuan.Text &"','"& Txt_Perihal.Text &"','"& tanggal  &"',"& Nup_Jumlah.Value &","& IDlogin)


                    If dtx.Rows.Count > 0 Then
                    Dim message As String = dtx.Rows(0)(1).ToString()
                    MsgBox(message, MsgBoxStyle.Information, "Informasi")
                    End If

                Dim dt As New DataTable
                    
                dt = ExecuteQuery("select nomor,addtime from tran_out where id_tim="& ValueIDTim &" and id_klasifikasi='"& lbl_kode.Text & "' and isUpload=0 order by addtime asc") 
                
                rch1.Visible = True

                Dim item As String
                item = ""
                Dim str() as string
                If dt.Rows.Count > 0 Then

                        If Nup_Jumlah.Value > 1 Then
                             str = split(dt.Rows(0)(0),"/")         
                             item += "B-{no}/"&str(1)&"/"&str(2)&"/"&str(3)&"/"&str(4)&vbCrLf
                        End If                      

                        For i As Integer = 0 To dt.Rows.Count - 1
                          
                            item += dt.Rows(i)(0).ToString() &     vbcrlf  
                        Next
                End If

                rch1.Text = item
               
             Catch ex As Exception
                MessageBox.Show("Buat Nomor Surat Keluar " + Err.Description, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Call Bersih()

        End If
      End If
    End Sub

    #Region "Search Data Klasifikasi"


    Private Sub Btnpilihsupir_Click(sender As Object, e As EventArgs) Handles Btnpilih_klasifikasi.Click
        Panel_pilihklasifikasi.Visible = True
        lbl_kode.Text = ""
        lbl_keterangan.Text = ""
        Txt_search.Text = ""
       
        With dgv_pilihklasifikasi
            .ColumnCount = 2
            .Columns(0).Name = "Kode"
            .Columns(0).Width = 100
            .Columns(1).Name = "Keterangan"
            .Columns(1).Width = 800
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .ReadOnly = True
            .MultiSelect = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToDeleteRows = False
        End With
        
        Call Tampilkan_Dataklasifikasi()
        Txt_search.Focus()
    End Sub

   Sub Tampilkan_Dataklasifikasi()
        Try
             Dim dt As New DataTable
             dt = ExecuteQuery("Select Kode, Keterangan From Master_Klasifikasi " &
                                 "Order By Kode Asc") 
            dgv_pilihklasifikasi.Rows.Clear()
           If dt.Rows.Count > 0 Then
             For Each row As DataRow In dt.Rows
                    dgv_pilihklasifikasi.Rows.Add(row("Kode"), row("Keterangan"))
                  Next
          End If
          
        Catch ex As Exception
            MessageBox.Show("Tampilkan Data Klasifikasi Error = " + Err.Description, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
   End Sub

    
    Private Sub btnbatalpilihheader_Click(sender As Object, e As EventArgs) Handles btnbatalpilihheader.Click
          Panel_pilihklasifikasi.Visible = False
    End Sub

    Sub Search_Data_Klasifikasi()
          Try
            Dim sqlQuery As String
            sqlQuery = "Select Kode, Keterangan From Master_Klasifikasi WHERE "

           If Not String.IsNullOrEmpty(Txt_search.Text) Then
                sqlQuery += "  (Kode LIKE '%" & Txt_search.Text & "%' OR Keterangan LIKE '%" & Txt_search.Text & "%')"
            End If

            sqlQuery += " Order By Kode Asc"            
            
            Cmd = New SqlCommand(sqlQuery, Conn)
            Reader = Cmd.ExecuteReader
            dgv_pilihklasifikasi.Rows.Clear()
            While Reader.Read
                dgv_pilihklasifikasi.Rows.Add(Reader(0), Reader(1))
            End While
        Catch ex As Exception
             MessageBox.Show("Tampilkan Data Search Klasifikasi Error = " + Err.Description, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Reader.Close()
    End Sub


    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
      Call Search_Data_Klasifikasi()
    End Sub

    Private Sub Txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search.KeyPress
     If e.KeyChar = Chr(13) Then
       Call Search_Data_Klasifikasi()
    End If
    End Sub

    Private Sub btnpilih2header_Click(sender As Object, e As EventArgs) Handles btnpilih2header.Click
    On Error Resume Next
    lbl_kode.Text = dgv_pilihklasifikasi.CurrentRow.Cells(0).Value.ToString
    lbl_keterangan.Text = dgv_pilihklasifikasi.CurrentRow.Cells(1).Value.ToString
    Panel_pilihklasifikasi.Visible = False
    Txt_tujuan.Focus()
    End Sub



#End Region
End Class