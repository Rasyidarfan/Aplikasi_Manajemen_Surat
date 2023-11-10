Imports DevExpress.XtraPdfViewer

Public Class Frm_ViewPDF 
    Public url_pdf As string
    Public name_file As string 
    Dim pdfViewer As New PdfViewer()

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
    pdfViewer.CloseDocument()
    Me.Close()
    End Sub

    Private Sub Frm_ViewPDF_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
    pdfViewer.Dock = DockStyle.fill
    Me.Panel_tengah.Controls.Add(pdfViewer)
    pdfViewer.LoadDocument(url_pdf)

    ' Membuat tombol "Export PDF" dan menambahkan event handler
    Dim btnExportPDF As New Button()
    btnExportPDF.Text = "Export PDF"
    btnExportPDF.Location = New Point(10, 10)
    btnExportPDF.Dock = DockStyle.Right

    AddHandler btnExportPDF.Click, AddressOf ExportPDFButton_Click

    Me.Panel_tengah.Controls.Add(btnExportPDF)
    Catch ex As Exception
    MessageBox.Show("View PDF Gagal: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
    
  
   
    End Sub

    Private Sub ExportPDFButton_Click(sender As Object, e As EventArgs)
    Dim pdfViewer As PdfViewer = Me.Panel_tengah.Controls.OfType(Of PdfViewer).FirstOrDefault()

    If pdfViewer IsNot Nothing Then
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        saveFileDialog.FileName = name_file

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            pdfViewer.SaveDocument(saveFileDialog.FileName)
            MessageBox.Show("PDF exported successfully to " & saveFileDialog.FileName & " Sukses", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    Else
        MessageBox.Show("PdfViewer control not found on the form.")
    End If
End Sub

  
End Class