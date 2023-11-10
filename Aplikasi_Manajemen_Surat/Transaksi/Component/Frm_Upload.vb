'Modul Koneksi Database
Imports System.Data.SqlClient
'Modul untuk berhubungan untuk file dan folder
Imports System.IO

Public Class Frm_Upload

    Dim direktori_file_from As string
    Dim direktori_file_to As string
    Dim File_save As string
    Public Nomor_Surat_upload As String
    Public Nomor_ID As Integer
    Public Form_Get As String
  
    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_file_Click(sender As Object, e As EventArgs) Handles btn_file.Click
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

          
            File_save = replace(Nomor_Surat_upload,"/","_") & ".pdf"
            'pdfFilePath = direktori dan nama file

              'save
            direktori_file_to = Path.Combine(uploadFolder, File_save)
        End If
    End Sub

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles Btn_Upload.Click
          If Txt_pathfile.Text = "" Then
              MessageBox.Show("Silahkan Lengkapi Data Anda", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
           'validasiform
            If Form_Get = "ViewMasuk" then
             Try
             'upload to folder
             'Simpan File PDF
             If String.IsNullOrEmpty(direktori_file_from) Or String.IsNullOrEmpty(direktori_file_to) Then
                    ' Tidak ada yang dilakukan jika direktori sumber atau tujuan kosong.
                Else
                    ' Memeriksa apakah file tujuan sudah ada
                    If File.Exists(direktori_file_to) Then
                        ' File tujuan sudah ada, maka hapus file tujuan sebelum menyalin yang baru.
                        File.Delete(direktori_file_to)
                    End If

                    ' Menyalin file dari direktori sumber ke direktori tujuan.
                    File.Copy(direktori_file_from, direktori_file_to)
                End If


                Dim   WordNoSurat As String 
                WordNoSurat =  replace(Nomor_Surat_upload,"/","_") & ".pdf"
                'insert to database
                
                DateTimeHelper.UpdateDateTimeVariables()
                Dim sql As String = "UPDATE Tran_in Set nama_file = @nama_file, isupload = @isupload, path=@path WHERE " &
                                     " ID = @ID "
                                   
                Using cmd As New SqlCommand(sql, Conn)

                    cmd.Parameters.AddWithValue("@ID", Nomor_ID)
                    cmd.Parameters.AddWithValue("@isupload", 1)
                    cmd.Parameters.AddWithValue("@nama_file", WordNoSurat)
                    cmd.Parameters.AddWithValue("@path", PathSettings.GetSettingPathFromDatabase())   
                    cmd.ExecuteNonQuery()
                End Using
       
                MessageBox.Show("File PDF Surat Berhasil Disimpan", "Pesan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("File PDF Surat Berhasil " + Err.Description, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Call bersihViewMasuk()
            elseif Form_Get = "ViewKeluar" then
             Try
             'upload to folder
             'Simpan File PDF
             If String.IsNullOrEmpty(direktori_file_from) Or String.IsNullOrEmpty(direktori_file_to) Then
                    ' Tidak ada yang dilakukan jika direktori sumber atau tujuan kosong.
                Else
                    ' Memeriksa apakah file tujuan sudah ada
                    If File.Exists(direktori_file_to) Then
                        ' File tujuan sudah ada, maka hapus file tujuan sebelum menyalin yang baru.
                        File.Delete(direktori_file_to)
                    End If

                    ' Menyalin file dari direktori sumber ke direktori tujuan.
                    File.Copy(direktori_file_from, direktori_file_to)
                End If


                Dim   WordNoSurat As String 
                WordNoSurat =  replace(Nomor_Surat_upload,"/","_") & ".pdf"
                'insert to database
                
                DateTimeHelper.UpdateDateTimeVariables()
                Dim sql As String = "UPDATE Tran_Out Set nama_file = @nama_file, isupload = @isupload,path=@path WHERE " &
                                     " ID = @ID "
                                   
                Using cmd As New SqlCommand(sql, Conn)

                    cmd.Parameters.AddWithValue("@ID", Nomor_ID)
                    cmd.Parameters.AddWithValue("@isupload", 1)
                    cmd.Parameters.AddWithValue("@nama_file", WordNoSurat)
                    cmd.Parameters.AddWithValue("@path", PathSettings.GetSettingPathFromDatabase())   
                    cmd.ExecuteNonQuery()
                End Using
       
                MessageBox.Show("File PDF Surat Berhasil Disimpan", "Pesan",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("File PDF Surat Berhasil " + Err.Description, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Call bersihViewKeluar()

            End If
        End If
    End Sub

    Sub bersihViewKeluar()
        Txt_pathfile.Text = ""    
        Dim frm As New Frm_ViewSuratKeluar
        With frm
            .ShowDialog()
             Me.Close()
        End With
       
    End Sub

    Sub bersihViewMasuk()
        Txt_pathfile.Text = ""    
        Dim frm As New Frm_ViewSuratMasuk
        With frm
            .ShowDialog()
             Me.Close()
        End With
       
    End Sub

    Private Sub Frm_Upload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database()
        Txt_pathfile.Text = ""
    End Sub
End Class