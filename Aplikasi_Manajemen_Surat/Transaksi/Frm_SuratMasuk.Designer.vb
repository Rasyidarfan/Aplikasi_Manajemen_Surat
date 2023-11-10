<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SuratMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SuratMasuk))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Group_Input = New System.Windows.Forms.GroupBox()
        Me.btn_file = New System.Windows.Forms.Button()
        Me.Txt_pathfile = New System.Windows.Forms.TextBox()
        Me.DTP_Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Perihal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cmbtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Nomor_surat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Pengirim = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnUserBaru = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel_pdf = New System.Windows.Forms.Panel()
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.Group_Input.SuspendLayout
        Me.SuspendLayout
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-7, 43)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(913, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 256
        Me.PictureBox3.TabStop = false
        '
        'Btn_keluar
        '
        Me.Btn_keluar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_keluar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_keluar.FlatAppearance.BorderSize = 0
        Me.Btn_keluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.Btn_keluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Btn_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_keluar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_keluar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Btn_keluar.Image = CType(resources.GetObject("Btn_keluar.Image"),System.Drawing.Image)
        Me.Btn_keluar.Location = New System.Drawing.Point(847, 9)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 27)
        Me.Btn_keluar.TabIndex = 252
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(33, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 14)
        Me.Label11.TabIndex = 255
        Me.Label11.Text = "Manajemen Surat App."
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Label12.Location = New System.Drawing.Point(32, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 18)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "Form Surat Masuk"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 253
        Me.PictureBox2.TabStop = false
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.Panel_pdf)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 226)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(872, 425)
        Me.GroupBox2.TabIndex = 258
        Me.GroupBox2.TabStop = false
        '
        'Group_Input
        '
        Me.Group_Input.BackColor = System.Drawing.Color.White
        Me.Group_Input.Controls.Add(Me.btn_file)
        Me.Group_Input.Controls.Add(Me.Txt_pathfile)
        Me.Group_Input.Controls.Add(Me.DTP_Tanggal)
        Me.Group_Input.Controls.Add(Me.Txt_Perihal)
        Me.Group_Input.Controls.Add(Me.Label13)
        Me.Group_Input.Controls.Add(Me.Label14)
        Me.Group_Input.Controls.Add(Me.Cmbtype)
        Me.Group_Input.Controls.Add(Me.Label9)
        Me.Group_Input.Controls.Add(Me.Label10)
        Me.Group_Input.Controls.Add(Me.Label8)
        Me.Group_Input.Controls.Add(Me.Label1)
        Me.Group_Input.Controls.Add(Me.Label3)
        Me.Group_Input.Controls.Add(Me.Txt_Nomor_surat)
        Me.Group_Input.Controls.Add(Me.Label7)
        Me.Group_Input.Controls.Add(Me.Label4)
        Me.Group_Input.Controls.Add(Me.Label6)
        Me.Group_Input.Controls.Add(Me.Label2)
        Me.Group_Input.Controls.Add(Me.Txt_Pengirim)
        Me.Group_Input.Controls.Add(Me.Label5)
        Me.Group_Input.Location = New System.Drawing.Point(8, 55)
        Me.Group_Input.Margin = New System.Windows.Forms.Padding(4)
        Me.Group_Input.Name = "Group_Input"
        Me.Group_Input.Padding = New System.Windows.Forms.Padding(4)
        Me.Group_Input.Size = New System.Drawing.Size(870, 166)
        Me.Group_Input.TabIndex = 257
        Me.Group_Input.TabStop = false
        '
        'btn_file
        '
        Me.btn_file.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_file.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_file.Location = New System.Drawing.Point(806, 116)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(38, 26)
        Me.btn_file.TabIndex = 5
        Me.btn_file.Text = "..."
        Me.btn_file.UseVisualStyleBackColor = false
        '
        'Txt_pathfile
        '
        Me.Txt_pathfile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_pathfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_pathfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_pathfile.Location = New System.Drawing.Point(524, 117)
        Me.Txt_pathfile.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_pathfile.Name = "Txt_pathfile"
        Me.Txt_pathfile.Size = New System.Drawing.Size(275, 23)
        Me.Txt_pathfile.TabIndex = 248
        '
        'DTP_Tanggal
        '
        Me.DTP_Tanggal.Location = New System.Drawing.Point(131, 52)
        Me.DTP_Tanggal.Name = "DTP_Tanggal"
        Me.DTP_Tanggal.Size = New System.Drawing.Size(239, 26)
        Me.DTP_Tanggal.TabIndex = 1
        '
        'Txt_Perihal
        '
        Me.Txt_Perihal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Perihal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Perihal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_Perihal.Location = New System.Drawing.Point(524, 22)
        Me.Txt_Perihal.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Perihal.Multiline = true
        Me.Txt_Perihal.Name = "Txt_Perihal"
        Me.Txt_Perihal.Size = New System.Drawing.Size(320, 67)
        Me.Txt_Perihal.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(503, 27)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 18)
        Me.Label13.TabIndex = 245
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(404, 26)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 18)
        Me.Label14.TabIndex = 244
        Me.Label14.Text = "Perihal"
        '
        'Cmbtype
        '
        Me.Cmbtype.FormattingEnabled = true
        Me.Cmbtype.Location = New System.Drawing.Point(131, 116)
        Me.Cmbtype.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmbtype.Name = "Cmbtype"
        Me.Cmbtype.Size = New System.Drawing.Size(185, 26)
        Me.Cmbtype.TabIndex = 3
        Me.Cmbtype.Text = "PILIH TYPE"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(503, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 18)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(404, 122)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 18)
        Me.Label10.TabIndex = 241
        Me.Label10.Text = "File"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(113, 116)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 18)
        Me.Label8.TabIndex = 236
        Me.Label8.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "Nomor Surat"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(116, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 18)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = ":"
        '
        'Txt_Nomor_surat
        '
        Me.Txt_Nomor_surat.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Nomor_surat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Nomor_surat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_Nomor_surat.Location = New System.Drawing.Point(131, 22)
        Me.Txt_Nomor_surat.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Nomor_surat.Name = "Txt_Nomor_surat"
        Me.Txt_Nomor_surat.Size = New System.Drawing.Size(185, 23)
        Me.Txt_Nomor_surat.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(114, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 18)
        Me.Label7.TabIndex = 238
        Me.Label7.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(11, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Pengirim"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(117, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 18)
        Me.Label6.TabIndex = 239
        Me.Label6.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Tanggal"
        '
        'Txt_Pengirim
        '
        Me.Txt_Pengirim.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Pengirim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Pengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_Pengirim.Location = New System.Drawing.Point(131, 84)
        Me.Txt_Pengirim.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Pengirim.Name = "Txt_Pengirim"
        Me.Txt_Pengirim.Size = New System.Drawing.Size(185, 23)
        Me.Txt_Pengirim.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(11, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Tujuan"
        '
        'BtnUserBaru
        '
        Me.BtnUserBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(123,Byte),Integer))
        Me.BtnUserBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserBaru.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnUserBaru.ForeColor = System.Drawing.Color.White
        Me.BtnUserBaru.Image = CType(resources.GetObject("BtnUserBaru.Image"),System.Drawing.Image)
        Me.BtnUserBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUserBaru.Location = New System.Drawing.Point(572, 661)
        Me.BtnUserBaru.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUserBaru.Name = "BtnUserBaru"
        Me.BtnUserBaru.Size = New System.Drawing.Size(149, 44)
        Me.BtnUserBaru.TabIndex = 222
        Me.BtnUserBaru.Text = "Data Baru"
        Me.BtnUserBaru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUserBaru.UseVisualStyleBackColor = false
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"),System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.Location = New System.Drawing.Point(729, 661)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(149, 44)
        Me.BtnSimpan.TabIndex = 223
        Me.BtnSimpan.Text = "Upload"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = false
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel_pdf
        '
        Me.Panel_pdf.Location = New System.Drawing.Point(11, 14)
        Me.Panel_pdf.Name = "Panel_pdf"
        Me.Panel_pdf.Size = New System.Drawing.Size(854, 395)
        Me.Panel_pdf.TabIndex = 0
        '
        'Frm_SuratMasuk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(896, 713)
        Me.Controls.Add(Me.BtnUserBaru)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Group_Input)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Btn_keluar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Frm_SuratMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_SuratMasuk"
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.Group_Input.ResumeLayout(false)
        Me.Group_Input.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Group_Input As GroupBox
    Friend WithEvents Txt_Perihal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Cmbtype As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Nomor_surat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Pengirim As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTP_Tanggal As DateTimePicker
    Friend WithEvents btn_file As Button
    Friend WithEvents Txt_pathfile As TextBox
    Friend WithEvents BtnUserBaru As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel_pdf As Panel
End Class
