<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_UserBaru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_UserBaru))
        Me.Group_Input = New System.Windows.Forms.GroupBox()
        Me.Cmbtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNamaDapan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNamaBelakang = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUserBaru = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Btn_ubah = New System.Windows.Forms.Button()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Group_Input.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.DgvData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Group_Input
        '
        Me.Group_Input.BackColor = System.Drawing.Color.White
        Me.Group_Input.Controls.Add(Me.Cmbtype)
        Me.Group_Input.Controls.Add(Me.Label9)
        Me.Group_Input.Controls.Add(Me.Label10)
        Me.Group_Input.Controls.Add(Me.Label8)
        Me.Group_Input.Controls.Add(Me.Label1)
        Me.Group_Input.Controls.Add(Me.Label3)
        Me.Group_Input.Controls.Add(Me.TxtNamaDapan)
        Me.Group_Input.Controls.Add(Me.Label7)
        Me.Group_Input.Controls.Add(Me.Label4)
        Me.Group_Input.Controls.Add(Me.Label6)
        Me.Group_Input.Controls.Add(Me.Label2)
        Me.Group_Input.Controls.Add(Me.TxtPassword)
        Me.Group_Input.Controls.Add(Me.TxtUsername)
        Me.Group_Input.Controls.Add(Me.Label5)
        Me.Group_Input.Controls.Add(Me.TxtNamaBelakang)
        Me.Group_Input.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Group_Input.Location = New System.Drawing.Point(7, 48)
        Me.Group_Input.Margin = New System.Windows.Forms.Padding(4)
        Me.Group_Input.Name = "Group_Input"
        Me.Group_Input.Padding = New System.Windows.Forms.Padding(4)
        Me.Group_Input.Size = New System.Drawing.Size(787, 187)
        Me.Group_Input.TabIndex = 227
        Me.Group_Input.TabStop = false
        '
        'Cmbtype
        '
        Me.Cmbtype.FormattingEnabled = true
        Me.Cmbtype.Location = New System.Drawing.Point(176, 153)
        Me.Cmbtype.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmbtype.Name = "Cmbtype"
        Me.Cmbtype.Size = New System.Drawing.Size(185, 32)
        Me.Cmbtype.TabIndex = 4
        Me.Cmbtype.Text = "PILIH TYPE"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(159, 155)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 24)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(11, 155)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 24)
        Me.Label10.TabIndex = 241
        Me.Label10.Text = "Tim"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(159, 116)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 24)
        Me.Label8.TabIndex = 236
        Me.Label8.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "Nama Depan"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(159, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 24)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = ":"
        '
        'TxtNamaDapan
        '
        Me.TxtNamaDapan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtNamaDapan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNamaDapan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtNamaDapan.Location = New System.Drawing.Point(176, 22)
        Me.TxtNamaDapan.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNamaDapan.Name = "TxtNamaDapan"
        Me.TxtNamaDapan.Size = New System.Drawing.Size(110, 23)
        Me.TxtNamaDapan.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(159, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 24)
        Me.Label7.TabIndex = 238
        Me.Label7.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(159, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 239
        Me.Label6.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 24)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Nama Belakang"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(176, 119)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(185, 23)
        Me.TxtPassword.TabIndex = 3
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(176, 89)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(185, 23)
        Me.TxtUsername.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Password"
        '
        'TxtNamaBelakang
        '
        Me.TxtNamaBelakang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtNamaBelakang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNamaBelakang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtNamaBelakang.Location = New System.Drawing.Point(176, 53)
        Me.TxtNamaBelakang.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNamaBelakang.Name = "TxtNamaBelakang"
        Me.TxtNamaBelakang.Size = New System.Drawing.Size(153, 23)
        Me.TxtNamaBelakang.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.DgvData)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(5, 249)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(789, 398)
        Me.GroupBox2.TabIndex = 241
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Daftar User"
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = false
        Me.DgvData.AllowUserToDeleteRows = false
        Me.DgvData.AllowUserToResizeColumns = false
        Me.DgvData.AllowUserToResizeRows = false
        Me.DgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DgvData.BackgroundColor = System.Drawing.Color.White
        Me.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvData.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvData.EnableHeadersVisualStyles = false
        Me.DgvData.GridColor = System.Drawing.Color.Silver
        Me.DgvData.Location = New System.Drawing.Point(8, 26)
        Me.DgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvData.Name = "DgvData"
        Me.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(37,Byte),Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvData.RowHeadersVisible = false
        Me.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DgvData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvData.ShowEditingIcon = false
        Me.DgvData.Size = New System.Drawing.Size(772, 363)
        Me.DgvData.StandardTab = true
        Me.DgvData.TabIndex = 221
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(34, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 14)
        Me.Label11.TabIndex = 244
        Me.Label11.Text = "Manajemen Surat App."
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Label12.Location = New System.Drawing.Point(32, 6)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 243
        Me.Label12.Text = "Master_User"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 242
        Me.PictureBox2.TabStop = false
        '
        'Btn_keluar
        '
        Me.Btn_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Btn_keluar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_keluar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_keluar.FlatAppearance.BorderSize = 0
        Me.Btn_keluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.Btn_keluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Btn_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_keluar.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_keluar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Btn_keluar.Image = CType(resources.GetObject("Btn_keluar.Image"),System.Drawing.Image)
        Me.Btn_keluar.Location = New System.Drawing.Point(764, 7)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 27)
        Me.Btn_keluar.TabIndex = 8
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"),System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.Location = New System.Drawing.Point(499, 664)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(149, 44)
        Me.BtnSimpan.TabIndex = 6
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = false
        '
        'BtnUserBaru
        '
        Me.BtnUserBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(123,Byte),Integer))
        Me.BtnUserBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUserBaru.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnUserBaru.ForeColor = System.Drawing.Color.White
        Me.BtnUserBaru.Image = CType(resources.GetObject("BtnUserBaru.Image"),System.Drawing.Image)
        Me.BtnUserBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUserBaru.Location = New System.Drawing.Point(183, 664)
        Me.BtnUserBaru.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUserBaru.Name = "BtnUserBaru"
        Me.BtnUserBaru.Size = New System.Drawing.Size(149, 44)
        Me.BtnUserBaru.TabIndex = 5
        Me.BtnUserBaru.Text = "Data Baru"
        Me.BtnUserBaru.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUserBaru.UseVisualStyleBackColor = false
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Red
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.Image = CType(resources.GetObject("Btn_Delete.Image"),System.Drawing.Image)
        Me.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delete.Location = New System.Drawing.Point(661, 664)
        Me.Btn_Delete.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(129, 44)
        Me.Btn_Delete.TabIndex = 7
        Me.Btn_Delete.Text = "NonAktif"
        Me.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Delete.UseVisualStyleBackColor = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-7, 36)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(827, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 251
        Me.PictureBox3.TabStop = false
        '
        'Btn_ubah
        '
        Me.Btn_ubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(229,Byte),Integer), CType(CType(86,Byte),Integer), CType(CType(4,Byte),Integer))
        Me.Btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ubah.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_ubah.ForeColor = System.Drawing.Color.White
        Me.Btn_ubah.Image = CType(resources.GetObject("Btn_ubah.Image"),System.Drawing.Image)
        Me.Btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ubah.Location = New System.Drawing.Point(342, 664)
        Me.Btn_ubah.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_ubah.Name = "Btn_ubah"
        Me.Btn_ubah.Size = New System.Drawing.Size(149, 44)
        Me.Btn_ubah.TabIndex = 252
        Me.Btn_ubah.Text = "Ubah"
        Me.Btn_ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_ubah.UseVisualStyleBackColor = false
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = true
        Me.cmb_status.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmb_status.Location = New System.Drawing.Point(7, 673)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(123, 26)
        Me.cmb_status.TabIndex = 244
        '
        'Frm_UserBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 18!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(813, 721)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.Btn_ubah)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.BtnUserBaru)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Btn_keluar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Group_Input)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_UserBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Manajemen Surat"
        Me.Group_Input.ResumeLayout(false)
        Me.Group_Input.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        CType(Me.DgvData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Group_Input As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNamaDapan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNamaBelakang As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cmbtype As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUserBaru As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Btn_ubah As Button
    Friend WithEvents cmb_status As ComboBox
End Class
