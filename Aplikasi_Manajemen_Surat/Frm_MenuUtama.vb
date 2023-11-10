Imports System.Data.SqlClient
Public Class Frm_MenuUtama
    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles Btn_keluar.Click
      Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin Keluar dari Aplikasi ini?", "Konfirmasi Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    If result = DialogResult.Yes Then
       Module_Update_Status_User.UpdateUserStatusOnLogout(IDlogin)
      End
    Else
      Return
    End If
    End Sub

    'ambil data user dari database
    Sub User_Login()
    Try
    Dim dt As New DataTable
    dt = ExecuteQuery("SELECT A.Username, B.Nama_Tim FROM Master_User A JOIN Master_Tim B ON A.Type_Tim = B.ID WHERE A.ID = " & IDlogin)

    lbl_userlogin.Text = ""
    lbltim.Text = ""

    If dt.Rows.Count > 0 Then
        lbl_userlogin.Text = dt.Rows(0)("Username").ToString()
        lbltim.Text = dt.Rows(0)("Nama_Tim").ToString()
    End If

    Catch ex As Exception
        MessageBox.Show("Tampilkan Data User Login Error = " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try


    End Sub


    'Desaign Button agar melengkung
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



    Private Sub Frm_MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         RoundButton(Btn_Daftar_Surat_Keluar)
         RoundButton(Btn_Buat_Nomor_Surat_Keluar)
         RoundButton(Btn_Daftar_Surat_Masuk)
         RoundButton(Btn_Unggah_Surat_Masuk)
         Panel_Daftar_Surat_Keluar.Visible = False
         PictureBox_Dashboard.Visible = True
        Call User_Login()
        Call View_Datagrid()
        Call TampilkanData()
    End Sub

    Private Sub Btn_SignOut_Click(sender As Object, e As EventArgs) Handles Btn_SignOut.Click
    Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin sign out?", "Konfirmasi Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    If result = DialogResult.Yes Then
        Module_Update_Status_User.UpdateUserStatusOnLogout(IDlogin)
        Me.close()
        Dim frm As New Frm_Login
        frm.Show()
    Else
      Return
    End If
  
    End Sub

    Private Sub Btn_TambahUser_Click(sender As Object, e As EventArgs) Handles Btn_TambahUser.Click
        Dim frm As New Frm_UserBaru
        frm.ShowDialog
    End Sub

    Private Sub Btn_Frm_Tim_Click(sender As Object, e As EventArgs) Handles Btn_Frm_Tim.Click
        Dim Frm As New Frm_Tim
        Frm.ShowDialog()
    End Sub

    Private Sub PictureBox_Dashboard_Click(sender As Object, e As EventArgs) Handles PictureBox_Dashboard.Click
        Panel_Daftar_Surat_Keluar.Visible = True
        PictureBox_Dashboard.Visible = false
        TampilkanData()
    End Sub

    Private Sub Btn_Hide_Panel_Click(sender As Object, e As EventArgs) Handles Btn_Hide_Panel.Click
        Panel_Daftar_Surat_Keluar.Visible = False
        PictureBox_Dashboard.Visible = True
    End Sub

    Private Sub Btn_Unggah_Surat_Masuk_Click(sender As Object, e As EventArgs) Handles Btn_Unggah_Surat_Masuk.Click
        Dim frm As New Frm_SuratMasuk
        frm.ShowDialog()
    End Sub

    Private Sub Btn_Buat_Nomor_Surat_Keluar_Click(sender As Object, e As EventArgs) Handles Btn_Buat_Nomor_Surat_Keluar.Click
        Dim frm As New Frm_SuratKeluar
        frm.ShowDialog()
    End Sub

    Private Sub Btn_Daftar_Surat_Masuk_Click(sender As Object, e As EventArgs) Handles Btn_Daftar_Surat_Masuk.Click
        Dim frm As New Frm_ViewSuratMasuk
        frm.ShowDialog()
    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        Dim frm As New Frm_Pengaturan
        frm.ShowDialog()
    End Sub

    Private Sub Btn_Daftar_Surat_Keluar_Click(sender As Object, e As EventArgs) Handles Btn_Daftar_Surat_Keluar.Click
        Dim frm As New Frm_ViewSuratKeluar
        frm.ShowDialog()
    End Sub


    'view data surat keluar
      Sub View_Datagrid()
           Try
            With DgvData
                .ColumnCount = 7
                .Columns(0).Name = "No"              
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).Name = "Nomor Surat"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells        
                .Columns(2).Name = "Tanggal"               
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"
                .Columns(3).Name = "Tujuan"               
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).Name = "Perihal"               
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).Name = "Nama File"             
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).Name = "Status Upload"              
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ReadOnly = True
                .MultiSelect = False
                .RowHeadersVisible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill             
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToDeleteRows = False
            End With

        Catch ex As Exception
           MessageBox.Show("Tampilkan Data database error: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

     Sub TampilkanData()
        Try
            'Validasi User
            Dim userRole As String = CheckUserRole(IDlogin)

            If userRole="Umum" Then
                  Cmd = New SqlCommand("Select A.ID, A.Nomor, A.Tanggal, B.Nama_Tim as Tujuan, A.Perihal, A.Nama_File,     " &
                                 "Case " &
                                 "WHEN A.isupload = 1 THEN 'Uploaded' " &
                                 "WHEN A.isupload = 0 THEN 'Need Upload' " &
                                 "END AS UploadStatus " &
                                 "From Tran_out A Join Master_Tim B ON A.id_tim=B.ID where A.recid=0 And A.isupload=0  " &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
                DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4), Reader(5), Reader(6))
            End While

            ElseIf userRole="Biasa" then
                 Cmd = New SqlCommand("Select A.ID, A.Nomor, A.Tanggal, B.Nama_Tim as Tujuan, A.Perihal, A.Nama_File,     " &
                                 "Case " &
                                 "WHEN A.isupload = 1 THEN 'Uploaded' " &
                                 "WHEN A.isupload = 0 THEN 'Need Upload' " &
                                 "END AS UploadStatus " &
                                 "From Tran_out A Join Master_Tim B ON A.id_tim=B.ID where A.recid=0 AND A.isupload=0 AND A.Addid =  " & IDlogin &
                                 "Order By A.ID Asc", Conn)
            Reader = Cmd.ExecuteReader
            DgvData.Rows.Clear()
            While Reader.Read
              DgvData.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3),Reader(4), Reader(5), Reader(6))
            End While

            End If

         
        Catch ex As Exception
             MessageBox.Show("View Data: " & ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Reader.Close()
    End Sub

    Private Sub Btn_Master_Klasifikasi_Click(sender As Object, e As EventArgs) Handles Btn_Master_Klasifikasi.Click
        Dim frm As New Frm_Klasifikasi
        frm.ShowDialog()
    End Sub

   
End Class