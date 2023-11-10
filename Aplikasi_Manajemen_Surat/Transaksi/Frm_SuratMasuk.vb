'Modul Koneksi Database
Imports System.Data.SqlClient
'Modul untuk berhubungan untuk file dan folder
Imports System.IO
'Modul untuk view pdf
Imports DevExpress.XtraPdfViewer


Public Class Frm_SuratMasuk
    Dim userRole As String = CheckUserRole(IDlogin)
    Dim pdfViewer As New PdfViewer()


    Dim direktori_file_from As string
    Dim direktori_file_to As string
    Dim File_save As string


    Sub bersih()
        Txt_Nomor_surat.Text = ""
        DTP_Tanggal.Value = Now
        Txt_Pengirim.Text = ""
        Txt_Perihal.Text = ""
        Txt_pathfile.Text = ""
        DTP_Tanggal.Enabled = True
        pdfViewer.CloseDocument()
        Call Tim()
    End Sub

    Sub NonAktif()
        Group_Input.Enabled = false
        BtnSimpan.Enabled = False
        BtnUserBaru.Enabled =True   
    End Sub

     Sub Aktif()
        Group_Input.Enabled = True
        BtnSimpan.Enabled = True
        BtnUserBaru.Enabled =False   
    End Sub

      Sub Tim()
        If userRole = "Umum" Then
        Try
            Cmd = New SqlCommand("Select Nama_Tim, ID From Master_Tim     " &
                                 "Order By ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            Cmbtype.Items.Clear()
            Cmbtype.Enabled = True
            While Reader.Read
                Cmbtype.Items.Add(New KeyValuePair(Of String, Integer)(Reader(0), Reader(1)))
            End While
            Cmbtype.DisplayMember = "Key"
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
            Cmbtype.Items.Clear()
            Cmbtype.Enabled = false
            DTP_Tanggal.Enabled = False
            While Reader.Read
                Cmbtype.Items.Add(New KeyValuePair(Of String, Integer)(Reader(0), Reader(1)))
            End While
            Cmbtype.DisplayMember = "Key"
            
            Reader.Close()
             If Cmbtype.Items.Count > 0 Then
                Cmbtype.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Description String = " + Err.Description)
        End Try
        Reader.Close()
        End If
    End Sub

    Private Sub Frm_SuratMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database()
        'Call Data_grid()
        'Call TampilkanData()
        Call Bersih()
        Call NonAktif()
    End Sub

   

    Private Sub Txt_Nomor_surat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nomor_surat.KeyPress
        If  e.KeyChar = Chr(13) Then
        ' Ambil nomor surat dari teks kotak
        Dim nomorSurat As String = Txt_Nomor_surat.Text.Trim()

        Try
            ' Membuat perintah SQL untuk memeriksa nomor surat
            Dim query As String = "SELECT COUNT(*) FROM Tran_in WHERE Nomor = @NomorSurat"
            Dim command As New SqlCommand(query, Conn)
            command.Parameters.AddWithValue("@NomorSurat", nomorSurat)

            ' Mengeksekusi perintah SQL
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            ' Memeriksa apakah nomor surat sudah ada
            If count > 0 Then
                MessageBox.Show("Nomor surat sudah ada di database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Txt_Nomor_surat.Text  = ""
            Else
                  DTP_Tanggal.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
         
        End Try
    End If

    End Sub

    Private Sub DTP_Tanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTP_Tanggal.KeyPress
          If e.KeyChar = Chr(13) Then
            Txt_Pengirim.Focus()
        End If
    End Sub

    Private Sub Txt_Pengirim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Pengirim.KeyPress
          If e.KeyChar = Chr(13) Then
            Cmbtype.Focus()
        End If
    End Sub

    Private Sub Cmbtype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbtype.KeyPress
         If e.KeyChar = Chr(13) Then
         Txt_Perihal.Focus()
        End If
    End Sub

    Private Sub Txt_Perihal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Perihal.KeyPress
        If e.KeyChar = Chr(13) Then
         btn_file.PerformClick()
        End If
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close()    
    End Sub

    Private Sub BtnUserBaru_Click(sender As Object, e As EventArgs) Handles BtnUserBaru.Click
        Call Bersih()
        Call Aktif()
        Txt_Nomor_surat.Focus() 
    End Sub

    Private Function Check_Nomor_Surat(Nomorsurat As String) As boolean       
        Try
         
            Dim query As String = "SELECT COUNT(*) FROM Tran_in WHERE Nomor = @NomorSurat"
            Dim command As New SqlCommand(query, Conn)
            command.Parameters.AddWithValue("@NomorSurat", nomorSurat)

          
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

        
            If count > 0 Then      
                Txt_Nomor_surat.Text  = ""
                Return True
            Else
                  DTP_Tanggal.Focus()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
             Return False
        Finally
         
        End Try
    End Function

    Private Sub btn_file_Click(sender As Object, e As EventArgs) Handles btn_file.Click
        Try
        pdfViewer.CloseDocument()
       
        Dim openFileDialog1 As New OpenFileDialog()

        ' Atur filter file untuk menampilkan hanya file PDF.
        openFileDialog1.Filter = "File PDF (*.pdf)|*.pdf"
        openFileDialog1.Title = "Pilih file PDF untuk diunggah"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Ambil path lengkap file PDF yang dipilih.
            Dim pdfFilePath As String = openFileDialog1.FileName

            ' Buat direktori 'Upload' jika belum ada.
            Dim uploadFolder As String = PathSettings.GetSettingPathFromDatabase()

            
            If Not Directory.Exists(uploadFolder) Then
                Directory.CreateDirectory(uploadFolder)
            End If

            ' Ambil nama file PDF.
            Dim pdfFileName As String = pdfFilePath

            Txt_pathfile.Text = pdfFilePath

            ' Buat path baru untuk menyimpan file PDF dalam folder 'Upload'.
            Dim savePath As String = Path.Combine(uploadFolder, pdfFileName)

          
            'Buat keterangan untuk simpan pada upload 
            'Path.GetFileName(pdfFilePath) nama file
            direktori_file_from = pdfFilePath
            File_save = Path.GetFileName(pdfFilePath)
            File_save = Txt_Nomor_surat.Text.Replace("/", "_") & ".pdf"
            'pdfFilePath = direktori dan nama file

             'save
            direktori_file_to = Path.Combine(uploadFolder, File_save)
            
            
            pdfViewer.Dock = DockStyle.fill
            Panel_pdf.Controls.Add(pdfViewer)
            pdfViewer.LoadDocument(savePath)
       
         End If 

         Catch ex As Exception
         MessageBox.Show("view PDF " + Err.Description, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Txt_Nomor_surat.Text = "" Then
              MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Txt_Pengirim.Text = "" then
            MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Cmbtype.Text = "PILIH TYPE" then
             MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Check_Nomor_Surat( Txt_Nomor_surat.Text.Trim()) = True then
              MessageBox.Show("Nomor surat sudah ada di database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
           Try
                'upload to folder
                 'Simpan File PDF
                'Jika path kosong
                If String.IsNullOrEmpty(direktori_file_from) And String.IsNullOrEmpty(direktori_file_to)  Then
                    'tindakan tidak ada yang dilakukan
                Else
                      
                Dim uploadFolder As String = PathSettings.GetSettingPathFromDatabase()
                Dim pdfFilePath As String = openFileDialog1.FileName
                Dim pdfFileName As String = pdfFilePath
                Txt_pathfile.Text = pdfFilePath
               
                File_save = Path.GetFileName(pdfFilePath)
                File_save = Txt_Nomor_surat.Text.Replace("/", "_") & ".pdf"

                 'save
                direktori_file_to = Path.Combine(uploadFolder, File_save)
                      File.Copy(direktori_file_from, direktori_file_to)
                End If  

                'insert to database
                Dim ValueIDTim As Integer
                Dim WordNoSurat As String
                Dim isupload As Integer           
                
                if Txt_pathfile.Text = "" Then
                    isupload=0
                    WordNoSurat = ""
                Else
                    isupload=1
                    WordNoSurat =  replace(Txt_Nomor_surat.Text,"/","_") & ".pdf"
                End If

                
                DateTimeHelper.UpdateDateTimeVariables()
                ValueIDTim = (Cmbtype.SelectedItem).Value
                Dim tanggal As String = DTP_Tanggal.Value.ToString("yyyy-MM-dd")
                Dim sql As String = "Insert Into tran_in (nomor, tanggal, pengirim, tahun, id_tim, isupload, perihal, nama_file, addid, addtime,  " &
                                     " recid, path) Values (@nomor, @tanggal, @pengirim, @tahun, @id_tim, @isupload, @perihal, @nama_file,   " &
                                     " @addid, @addtime, @recid, @path)" 

                Using cmd As New SqlCommand(sql, Conn)

                    cmd.Parameters.AddWithValue("@nomor", Txt_Nomor_surat.Text)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@pengirim", Txt_Pengirim.Text)
                    cmd.Parameters.AddWithValue("@tahun", DateTimeHelper.Tahun)
                    cmd.Parameters.AddWithValue("@id_tim", ValueIDTim)
                    cmd.Parameters.AddWithValue("@isupload", isupload)
                    cmd.Parameters.AddWithValue("@perihal", Txt_Perihal.Text)
                    cmd.Parameters.AddWithValue("@nama_file", WordNoSurat)  
                    cmd.Parameters.AddWithValue("@addid", IDlogin)      
                    cmd.Parameters.AddWithValue("@addtime", DateTimeHelper.DateAndTime)     
                    cmd.Parameters.AddWithValue("@recid", 0)
                    cmd.Parameters.AddWithValue("@path", PathSettings.GetSettingPathFromDatabase())             
                    cmd.ExecuteNonQuery()
                End Using


                    
                MessageBox.Show("Data Surat Masuk Berhasil Disimpan", "Pesan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Data Surat Masuk Gagal " + Err.Description, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
         
            Call Bersih()
            Call NonAktif()
        End If
    End Sub

  
End Class