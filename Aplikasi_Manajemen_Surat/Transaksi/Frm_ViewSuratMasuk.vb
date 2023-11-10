'Modul Koneksi Database
Imports System.Data.SqlClient
Imports System.IO
Public Class Frm_ViewSuratMasuk
    'Validasi User
    Dim userRole As String = CheckUserRole(IDlogin)
    Sub Aktif()
        Btn_Upload.Enabled = True
        Btn_Batal.Enabled = True
        btn_export.Enabled = True
        Btn_viewpdf.Enabled = True
    End Sub


    Sub NonAktif()
       Btn_Upload.Enabled = false
       Btn_Batal.Enabled = True
       btn_export.Enabled = false
       Btn_viewpdf.Enabled = False
    End Sub


    Sub View_Datagrid()
           Try
            With DgvData
                .ColumnCount = 8
                .Columns(0).Name = "No"
                .Columns(0).Width = 20
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).Name = "Nomor Surat"
                .Columns(1).Width = 170
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).Name = "Tanggal"
                .Columns(2).Width = 100
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"
                .Columns(3).Name = "Pengirim"
                .Columns(3).Width = 100
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).Name = "Tujuan"
                .Columns(4).Width = 150
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).Name = "Perihal"
                .Columns(5).Width = 150
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).Name = "Nama File"
                .Columns(6).Width = 150
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).Name = "Status Upload"
                .Columns(7).Width = 120
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
    End Sub


  Sub TampilkanData()
        Try
            If userRole="Umum" Then
                  Cmd = New SqlCommand("Select A.ID, A.Nomor, A.Tanggal, A.Pengirim, B.Nama_Tim as Tujuan, A.Perihal, A.Nama_File,     " &
                                 "Case " &
                                 "WHEN A.isupload = 1 THEN 'Uploaded' " &
                                 "WHEN A.isupload = 0 THEN 'Need Upload' " &
                                 "END AS UploadStatus " &
                                 "From Tran_in A Join Master_Tim B ON A.id_tim=B.ID where A.recid=0  " &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4), Reader(5), Reader(6), Reader(7))
            End While

            ElseIf userRole="Biasa" then
            Cmd = New SqlCommand("Select A.ID, A.Nomor, A.Tanggal, A.Pengirim, B.Nama_Tim as Tujuan, A.Perihal, A.Nama_File,     " &
                                 "Case " &
                                 "WHEN A.isupload = 1 THEN 'Uploaded' " &
                                 "WHEN A.isupload = 0 THEN 'Need Upload' " &
                                 "END AS UploadStatus " &
                                 "From Tran_in A Join Master_Tim B ON A.id_tim=B.ID where A.recid=0  AND A.Addid =  " & IDlogin &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
              DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4), Reader(5), Reader(6), Reader(7))
            End While

            End If

         
        Catch ex As Exception
             MessageBox.Show("View Data: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()
    End Sub

    Public Sub Frm_ViewSuratMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database()
        Call View_Datagrid()
        Call TampilkanData()
        Txt_search.Text = ""
        Call NonAktif()
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
         Try
           
            Dim sqlQuery As String

            If userRole="Umum" Then
            sqlQuery = "Select A.ID, A.Nomor, A.Tanggal, A.Pengirim, B.Nama_Tim as Tujuan, A.Perihal, A.Nama_File, " &
                       "Case " &
                       "WHEN A.isupload = 1 THEN 'Uploaded' " &
                       "WHEN A.isupload = 0 THEN 'Need Upload' " &
                       "END AS UploadStatus " &
                       "From Tran_in A Join Master_Tim B ON A.id_tim=B.ID where A.recid=0"

           If Not String.IsNullOrEmpty(Txt_search.Text) Then
                sqlQuery += " AND (A.Nomor LIKE '%" & Txt_search.Text & "%' OR A.Pengirim LIKE '%" & Txt_search.Text & "%' OR A.Perihal LIKE '%" & Txt_search.Text & "%' OR A.Nama_File LIKE '%" & Txt_search.Text & "%' OR A.Tahun LIKE '%" & Txt_search.Text & "%' OR B.Nama_Tim LIKE '%" & Txt_search.Text & "%')"
            End If

            sqlQuery += " Order By A.ID Asc"            
            
            Cmd = New SqlCommand(sqlQuery, Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4), Reader(5), Reader(6), Reader(7))
            End While

            ElseIf userRole="Biasa" then
            sqlQuery="Select A.ID, A.Nomor, A.Tanggal, A.Pengirim, B.Nama_Tim as Tujuan, A.Perihal, A.Nama_File,     " &
                                             "Case " &
                                             "WHEN A.isupload = 1 THEN 'Uploaded' " &
                                             "WHEN A.isupload = 0 THEN 'Need Upload' " &
                                             "END AS UploadStatus " &
                                             "From Tran_in A Join Master_Tim B ON A.id_tim=B.ID where A.recid=0 AND A.addid=  " & IDlogin
      
           If Not String.IsNullOrEmpty(Txt_search.Text) Then
                sqlQuery += " AND (A.Nomor LIKE '%" & Txt_search.Text & "%' OR A.Pengirim LIKE '%" & Txt_search.Text & "%' OR A.Perihal LIKE '%" & Txt_search.Text & "%' OR A.Nama_File LIKE '%" & Txt_search.Text & "%' OR A.Tahun LIKE '%" & Txt_search.Text & "%' OR B.Nama_Tim LIKE '%" & Txt_search.Text & "%')"
           End If
            
            sqlQuery += " Order By A.ID Asc" 
            Cmd = New SqlCommand(sqlQuery, Conn)        
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
              DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4), Reader(5), Reader(6), Reader(7))
            End While

            End If

         
        Catch ex As Exception
           MessageBox.Show("View Search Data: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()
    End Sub

    Private Sub Txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_search.KeyPress
     If e.KeyChar = Chr(13) Then
       btn_filter.PerformClick()
    End If
    End Sub

    Private Sub DgvData_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseClick
         Try
            Call Aktif()
        Catch ex As Exception       
        End Try
    End Sub

    Private Sub Btn_Upload_Click(sender As Object, e As EventArgs) Handles Btn_Upload.Click
     
        If DgvData.RowCount = 0 Then
             MessageBox.Show("Data Not Found", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
             Return

        ElseIf MessageBox.Show("Yakin akan Upload " & DgvData.CurrentRow.Cells(1).Value.ToString & "  ini..?", "Information", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If CheckUpload(DgvData.CurrentRow.Cells(0).Value) Then 
                
                Dim frm As New Frm_Upload
                With frm
                    .Nomor_Surat_upload = DgvData.CurrentRow.Cells(1).Value.ToString
                    .Nomor_ID = DgvData.CurrentRow.Cells(0).Value
                    .Form_Get = "ViewMasuk"
                    .ShowDialog()
                End With
               Me.Close()
            else
                  MessageBox.Show("File sudah diunggah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)            
            End If
        End If
    End Sub

    Private Function CheckUpload(ID As Integer) As Boolean
    Dim isUpload As Integer = 0 ' Default is_upload value

    Try
        Using cmd As New SqlCommand("SELECT isupload FROM Tran_in WHERE ID = @DataID", Conn)
            cmd.Parameters.AddWithValue("@DataID", ID)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                isUpload = Convert.ToInt32(result)
            End If
        End Using
    Catch ex As Exception
    MessageBox.Show("Check Upload: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)   
    Finally
        
    End Try

    Return isUpload = 0
    End Function

    Private Sub Btn_Batal_Click(sender As Object, e As EventArgs) Handles Btn_Batal.Click
        Call NonAktif()
        Txt_search.Text = ""
    End Sub

    Private Sub Btn_viewpdf_Click(sender As Object, e As EventArgs) Handles Btn_viewpdf.Click
         If DgvData.RowCount = 0 Then
             MessageBox.Show("Data Not Found", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
             Return
         ElseIf MessageBox.Show("Yakin akan View " & DgvData.CurrentRow.Cells(1).Value.ToString & "  ini..?", "Information", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try

              If CheckUpload(DgvData.CurrentRow.Cells(0).Value) Then 
                
              MessageBox.Show("File Belum Diupload.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning) 
               
            else
                 
            Dim viewpdf As New Frm_ViewPDF           
            Dim dt As New DataTable
                    
             dt = ExecuteQuery("select path from tran_in where ID=" & DgvData.CurrentRow.Cells(0).Value ) 
   
            Dim path As string = ""    
            If dt.Rows.Count > 0 Then
     
                Dim row As DataRow = dt.Rows(0) '

                If dt.Columns.Contains("path") Then
                    path = Convert.ToString(row("path"))
                End If
            End If
            
            If CekFilePDFAda(path, DgvData.CurrentRow.Cells(6).Value.ToString) Then
            Dim frm_pdf As New Frm_ViewPDF
            With frm_pdf
                   .url_pdf = path & "\" &  DgvData.CurrentRow.Cells(6).Value.ToString
                   .name_file =  DgvData.CurrentRow.Cells(6).Value.ToString
                   .lbl_judul.Text = DgvData.CurrentRow.Cells(6).Value.ToString
                   .ShowDialog()
            End With
            Else
             MessageBox.Show("File PDF Tidak ada di folder", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
 
            End If

            Catch ex As Exception
               MessageBox.Show("View PDF: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)   
            End Try
            
        End If
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        

       If DgvData.RowCount = 0 Then
             MessageBox.Show("Data Not Found", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
             Return

        ElseIf MessageBox.Show("Yakin akan Export?", "Information", MessageBoxButtons.YesNo) = DialogResult.Yes Then
             Dim dt As New DataTable
           
           dt = ExecuteQuery("select path from tran_in where ID=" & DgvData.CurrentRow.Cells(0).Value ) 
   
            Dim path As string = ""    
            If dt.Rows.Count > 0 Then
     
                Dim row As DataRow = dt.Rows(0) '

                If dt.Columns.Contains("path") Then
                    path = Convert.ToString(row("path"))
                End If
            End If

           If CheckUpload(DgvData.CurrentRow.Cells(0).Value) Then 
                  MessageBox.Show("File Belum Diupload.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning) 
            Else
           'cek file pada folder
           If CekFilePDFAda(path, DgvData.CurrentRow.Cells(6).Value.ToString) Then
            Dim path_namaFile As String =  path & "\" & DgvData.CurrentRow.Cells(6).Value.ToString
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files|*.pdf"
            saveFileDialog.FileName = DgvData.CurrentRow.Cells(6).Value.ToString

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim destinationPath As String = saveFileDialog.FileName

                Try
                    File.Copy(path_namaFile, destinationPath, True) ' Menyalin file dari path ke folder tujuan
                    MessageBox.Show("PDF exported successfully to " & destinationPath & " Sukses", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Gagal menyalin file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            Else
             MessageBox.Show("File PDF Tidak ada di folder", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If  
            End If       
        End If
    End Sub

     'check file pdf
    
    Function CekFilePDFAda(ByVal folderPath As String, ByVal pdfFileName As String) As Boolean
     Dim filePath As String = Path.Combine(folderPath, pdfFileName)
     Return File.Exists(filePath)
    End Function
End Class