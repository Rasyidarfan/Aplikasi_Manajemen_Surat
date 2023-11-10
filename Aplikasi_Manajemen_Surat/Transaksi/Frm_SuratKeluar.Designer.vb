<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SuratKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SuratKeluar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel_pilihklasifikasi = New System.Windows.Forms.Panel()
        Me.dgv_pilihklasifikasi = New System.Windows.Forms.DataGridView()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_search = New System.Windows.Forms.TextBox()
        Me.btnbatalpilihheader = New System.Windows.Forms.Button()
        Me.lblpilihanheader = New System.Windows.Forms.Label()
        Me.btnpilih2header = New System.Windows.Forms.Button()
        Me.lbl_kode = New System.Windows.Forms.Label()
        Me.lbl_keterangan = New System.Windows.Forms.Label()
        Me.Btnpilih_klasifikasi = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Batal = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Btn_Generate = New System.Windows.Forms.Button()
        Me.rch1 = New System.Windows.Forms.RichTextBox()
        Me.DTP_Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cmb_Tim = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Nup_Jumlah = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Perihal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_tujuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.Panel_pilihklasifikasi.SuspendLayout
        CType(Me.dgv_pilihklasifikasi,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Nup_Jumlah,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(40, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 14)
        Me.Label11.TabIndex = 247
        Me.Label11.Text = "Manajemen Surat App."
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Label12.Location = New System.Drawing.Point(38, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 18)
        Me.Label12.TabIndex = 246
        Me.Label12.Text = "Buat Surat Keluar"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 245
        Me.PictureBox2.TabStop = false
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
        Me.Btn_keluar.Location = New System.Drawing.Point(1162, 8)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 27)
        Me.Btn_keluar.TabIndex = 8
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-6, 52)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1256, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 252
        Me.PictureBox3.TabStop = false
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.Panel_pilihklasifikasi)
        Me.GroupBox2.Controls.Add(Me.lbl_kode)
        Me.GroupBox2.Controls.Add(Me.lbl_keterangan)
        Me.GroupBox2.Controls.Add(Me.Btnpilih_klasifikasi)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Btn_Batal)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Btn_Generate)
        Me.GroupBox2.Controls.Add(Me.rch1)
        Me.GroupBox2.Controls.Add(Me.DTP_Tanggal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Cmb_Tim)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Nup_Jumlah)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Txt_Perihal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_tujuan)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(29, 86)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1148, 455)
        Me.GroupBox2.TabIndex = 253
        Me.GroupBox2.TabStop = false
        '
        'Panel_pilihklasifikasi
        '
        Me.Panel_pilihklasifikasi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel_pilihklasifikasi.Controls.Add(Me.dgv_pilihklasifikasi)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.btn_filter)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.Label16)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.Label17)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.Txt_search)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.btnbatalpilihheader)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.lblpilihanheader)
        Me.Panel_pilihklasifikasi.Controls.Add(Me.btnpilih2header)
        Me.Panel_pilihklasifikasi.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Panel_pilihklasifikasi.Location = New System.Drawing.Point(56, 27)
        Me.Panel_pilihklasifikasi.Name = "Panel_pilihklasifikasi"
        Me.Panel_pilihklasifikasi.Size = New System.Drawing.Size(983, 412)
        Me.Panel_pilihklasifikasi.TabIndex = 264
        '
        'dgv_pilihklasifikasi
        '
        Me.dgv_pilihklasifikasi.AllowUserToAddRows = false
        Me.dgv_pilihklasifikasi.AllowUserToDeleteRows = false
        Me.dgv_pilihklasifikasi.AllowUserToResizeColumns = false
        Me.dgv_pilihklasifikasi.AllowUserToResizeRows = false
        Me.dgv_pilihklasifikasi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_pilihklasifikasi.BackgroundColor = System.Drawing.Color.White
        Me.dgv_pilihklasifikasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_pilihklasifikasi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_pilihklasifikasi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgv_pilihklasifikasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pilihklasifikasi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_pilihklasifikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_pilihklasifikasi.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_pilihklasifikasi.EnableHeadersVisualStyles = false
        Me.dgv_pilihklasifikasi.GridColor = System.Drawing.Color.Silver
        Me.dgv_pilihklasifikasi.Location = New System.Drawing.Point(4, 71)
        Me.dgv_pilihklasifikasi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_pilihklasifikasi.Name = "dgv_pilihklasifikasi"
        Me.dgv_pilihklasifikasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27,Byte),Integer), CType(CType(28,Byte),Integer), CType(CType(37,Byte),Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_pilihklasifikasi.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_pilihklasifikasi.RowHeadersVisible = false
        Me.dgv_pilihklasifikasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dgv_pilihklasifikasi.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_pilihklasifikasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pilihklasifikasi.ShowEditingIcon = false
        Me.dgv_pilihklasifikasi.Size = New System.Drawing.Size(975, 272)
        Me.dgv_pilihklasifikasi.StandardTab = true
        Me.dgv_pilihklasifikasi.TabIndex = 270
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.Color.FromArgb(CType(CType(249,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(23,Byte),Integer))
        Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filter.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_filter.ForeColor = System.Drawing.Color.White
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"),System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filter.Location = New System.Drawing.Point(615, 19)
        Me.btn_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(36, 35)
        Me.btn_filter.TabIndex = 267
        Me.btn_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_filter.UseVisualStyleBackColor = false
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(347, 23)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 24)
        Me.Label16.TabIndex = 269
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(274, 23)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 24)
        Me.Label17.TabIndex = 268
        Me.Label17.Text = "Search"
        '
        'Txt_search
        '
        Me.Txt_search.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_search.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_search.Location = New System.Drawing.Point(377, 19)
        Me.Txt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_search.Name = "Txt_search"
        Me.Txt_search.Size = New System.Drawing.Size(221, 32)
        Me.Txt_search.TabIndex = 266
        '
        'btnbatalpilihheader
        '
        Me.btnbatalpilihheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(231,Byte),Integer), CType(CType(70,Byte),Integer), CType(CType(70,Byte),Integer))
        Me.btnbatalpilihheader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbatalpilihheader.FlatAppearance.BorderSize = 0
        Me.btnbatalpilihheader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatalpilihheader.ForeColor = System.Drawing.Color.White
        Me.btnbatalpilihheader.Location = New System.Drawing.Point(503, 359)
        Me.btnbatalpilihheader.Name = "btnbatalpilihheader"
        Me.btnbatalpilihheader.Size = New System.Drawing.Size(70, 41)
        Me.btnbatalpilihheader.TabIndex = 52
        Me.btnbatalpilihheader.Text = "&Batal"
        Me.btnbatalpilihheader.UseVisualStyleBackColor = false
        '
        'lblpilihanheader
        '
        Me.lblpilihanheader.AutoSize = true
        Me.lblpilihanheader.Location = New System.Drawing.Point(14, 216)
        Me.lblpilihanheader.Name = "lblpilihanheader"
        Me.lblpilihanheader.Size = New System.Drawing.Size(0, 24)
        Me.lblpilihanheader.TabIndex = 50
        '
        'btnpilih2header
        '
        Me.btnpilih2header.BackColor = System.Drawing.Color.FromArgb(CType(CType(23,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.btnpilih2header.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpilih2header.FlatAppearance.BorderSize = 0
        Me.btnpilih2header.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpilih2header.ForeColor = System.Drawing.Color.White
        Me.btnpilih2header.Location = New System.Drawing.Point(416, 359)
        Me.btnpilih2header.Name = "btnpilih2header"
        Me.btnpilih2header.Size = New System.Drawing.Size(70, 41)
        Me.btnpilih2header.TabIndex = 49
        Me.btnpilih2header.Text = "&Pilih"
        Me.btnpilih2header.UseVisualStyleBackColor = false
        '
        'lbl_kode
        '
        Me.lbl_kode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_kode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_kode.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_kode.Location = New System.Drawing.Point(143, 26)
        Me.lbl_kode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_kode.Name = "lbl_kode"
        Me.lbl_kode.Size = New System.Drawing.Size(84, 43)
        Me.lbl_kode.TabIndex = 266
        '
        'lbl_keterangan
        '
        Me.lbl_keterangan.AutoEllipsis = true
        Me.lbl_keterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_keterangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_keterangan.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_keterangan.Location = New System.Drawing.Point(235, 27)
        Me.lbl_keterangan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_keterangan.Name = "lbl_keterangan"
        Me.lbl_keterangan.Size = New System.Drawing.Size(359, 60)
        Me.lbl_keterangan.TabIndex = 267
        '
        'Btnpilih_klasifikasi
        '
        Me.Btnpilih_klasifikasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(23,Byte),Integer), CType(CType(89,Byte),Integer), CType(CType(74,Byte),Integer))
        Me.Btnpilih_klasifikasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnpilih_klasifikasi.FlatAppearance.BorderSize = 0
        Me.Btnpilih_klasifikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnpilih_klasifikasi.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btnpilih_klasifikasi.ForeColor = System.Drawing.Color.White
        Me.Btnpilih_klasifikasi.Location = New System.Drawing.Point(601, 27)
        Me.Btnpilih_klasifikasi.Name = "Btnpilih_klasifikasi"
        Me.Btnpilih_klasifikasi.Size = New System.Drawing.Size(66, 32)
        Me.Btnpilih_klasifikasi.TabIndex = 265
        Me.Btnpilih_klasifikasi.Text = "&Pilih"
        Me.Btnpilih_klasifikasi.UseVisualStyleBackColor = false
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(695, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 385)
        Me.Panel1.TabIndex = 263
        '
        'Btn_Batal
        '
        Me.Btn_Batal.BackColor = System.Drawing.Color.Crimson
        Me.Btn_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Batal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_Batal.ForeColor = System.Drawing.Color.White
        Me.Btn_Batal.Image = CType(resources.GetObject("Btn_Batal.Image"),System.Drawing.Image)
        Me.Btn_Batal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Batal.Location = New System.Drawing.Point(300, 395)
        Me.Btn_Batal.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Batal.Name = "Btn_Batal"
        Me.Btn_Batal.Size = New System.Drawing.Size(149, 44)
        Me.Btn_Batal.TabIndex = 7
        Me.Btn_Batal.Text = "Batal"
        Me.Btn_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Batal.UseVisualStyleBackColor = false
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label15.Location = New System.Drawing.Point(723, 23)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 24)
        Me.Label15.TabIndex = 262
        Me.Label15.Text = "Generate Number"
        '
        'Btn_Generate
        '
        Me.Btn_Generate.BackColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(143,Byte),Integer), CType(CType(123,Byte),Integer))
        Me.Btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Generate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_Generate.ForeColor = System.Drawing.Color.White
        Me.Btn_Generate.Image = CType(resources.GetObject("Btn_Generate.Image"),System.Drawing.Image)
        Me.Btn_Generate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Generate.Location = New System.Drawing.Point(143, 395)
        Me.Btn_Generate.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Generate.Name = "Btn_Generate"
        Me.Btn_Generate.Size = New System.Drawing.Size(149, 44)
        Me.Btn_Generate.TabIndex = 6
        Me.Btn_Generate.Text = "Generate"
        Me.Btn_Generate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Generate.UseVisualStyleBackColor = false
        '
        'rch1
        '
        Me.rch1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rch1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rch1.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.rch1.Location = New System.Drawing.Point(727, 57)
        Me.rch1.Name = "rch1"
        Me.rch1.Size = New System.Drawing.Size(395, 351)
        Me.rch1.TabIndex = 261
        Me.rch1.Text = ""
        '
        'DTP_Tanggal
        '
        Me.DTP_Tanggal.CustomFormat = "dd - MMMM - yyyy"
        Me.DTP_Tanggal.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DTP_Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Tanggal.Location = New System.Drawing.Point(143, 347)
        Me.DTP_Tanggal.Name = "DTP_Tanggal"
        Me.DTP_Tanggal.Size = New System.Drawing.Size(306, 32)
        Me.DTP_Tanggal.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(123, 351)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 24)
        Me.Label13.TabIndex = 255
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 351)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 254
        Me.Label14.Text = "Tanggal"
        '
        'Cmb_Tim
        '
        Me.Cmb_Tim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Tim.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Cmb_Tim.FormattingEnabled = true
        Me.Cmb_Tim.Location = New System.Drawing.Point(143, 302)
        Me.Cmb_Tim.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmb_Tim.Name = "Cmb_Tim"
        Me.Cmb_Tim.Size = New System.Drawing.Size(306, 32)
        Me.Cmb_Tim.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(123, 305)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 24)
        Me.Label9.TabIndex = 252
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 305)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 24)
        Me.Label10.TabIndex = 251
        Me.Label10.Text = "Tim"
        '
        'Nup_Jumlah
        '
        Me.Nup_Jumlah.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Nup_Jumlah.Location = New System.Drawing.Point(143, 259)
        Me.Nup_Jumlah.Name = "Nup_Jumlah"
        Me.Nup_Jumlah.Size = New System.Drawing.Size(84, 32)
        Me.Nup_Jumlah.TabIndex = 3
        Me.Nup_Jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nup_Jumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 24)
        Me.Label3.TabIndex = 248
        Me.Label3.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 24)
        Me.Label6.TabIndex = 247
        Me.Label6.Text = "Jumlah"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 181)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 24)
        Me.Label1.TabIndex = 245
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 244
        Me.Label2.Text = "Perihal"
        '
        'Txt_Perihal
        '
        Me.Txt_Perihal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Perihal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Perihal.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_Perihal.Location = New System.Drawing.Point(143, 181)
        Me.Txt_Perihal.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Perihal.Multiline = true
        Me.Txt_Perihal.Name = "Txt_Perihal"
        Me.Txt_Perihal.Size = New System.Drawing.Size(486, 67)
        Me.Txt_Perihal.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(122, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 24)
        Me.Label7.TabIndex = 242
        Me.Label7.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 24)
        Me.Label4.TabIndex = 241
        Me.Label4.Text = "Tujuan"
        '
        'Txt_tujuan
        '
        Me.Txt_tujuan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_tujuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_tujuan.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_tujuan.Location = New System.Drawing.Point(143, 103)
        Me.Txt_tujuan.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_tujuan.Multiline = true
        Me.Txt_tujuan.Name = "Txt_tujuan"
        Me.Txt_tujuan.Size = New System.Drawing.Size(486, 67)
        Me.Txt_tujuan.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(123, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 24)
        Me.Label8.TabIndex = 239
        Me.Label8.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 24)
        Me.Label5.TabIndex = 238
        Me.Label5.Text = "Klasifikasi"
        '
        'Frm_SuratKeluar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1207, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Btn_keluar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Frm_SuratKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_SuratKeluar"
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.Panel_pilihklasifikasi.ResumeLayout(false)
        Me.Panel_pilihklasifikasi.PerformLayout
        CType(Me.dgv_pilihklasifikasi,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Nup_Jumlah,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Generate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cmb_Tim As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Nup_Jumlah As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Perihal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_tujuan As TextBox
    Friend WithEvents DTP_Tanggal As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Btn_Batal As Button
    Friend WithEvents rch1 As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_pilihklasifikasi As Panel
    Friend WithEvents btnbatalpilihheader As Button
    Friend WithEvents lblpilihanheader As Label
    Friend WithEvents btnpilih2header As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Txt_search As TextBox
    Friend WithEvents Btnpilih_klasifikasi As Button
    Friend WithEvents lbl_keterangan As Label
    Friend WithEvents lbl_kode As Label
    Friend WithEvents dgv_pilihklasifikasi As DataGridView
End Class
