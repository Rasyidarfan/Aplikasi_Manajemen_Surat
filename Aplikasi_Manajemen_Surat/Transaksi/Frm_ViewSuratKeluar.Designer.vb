<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ViewSuratKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ViewSuratKeluar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Group_Filter = New System.Windows.Forms.GroupBox()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.Btn_viewpdf = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_Upload = New System.Windows.Forms.Button()
        Me.Btn_Batal = New System.Windows.Forms.Button()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.Group_Filter.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.DgvData,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(37, 23)
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
        Me.Label12.Location = New System.Drawing.Point(36, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 18)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "Daftar Surat Keluar"
        '
        'Group_Filter
        '
        Me.Group_Filter.Controls.Add(Me.btn_filter)
        Me.Group_Filter.Controls.Add(Me.Label7)
        Me.Group_Filter.Controls.Add(Me.Label4)
        Me.Group_Filter.Controls.Add(Me.Txt_search)
        Me.Group_Filter.Location = New System.Drawing.Point(12, 56)
        Me.Group_Filter.Name = "Group_Filter"
        Me.Group_Filter.Size = New System.Drawing.Size(868, 83)
        Me.Group_Filter.TabIndex = 257
        Me.Group_Filter.TabStop = false
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.Color.FromArgb(CType(CType(249,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(23,Byte),Integer))
        Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filter.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_filter.ForeColor = System.Drawing.Color.White
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"),System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filter.Location = New System.Drawing.Point(568, 25)
        Me.btn_filter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(36, 35)
        Me.btn_filter.TabIndex = 264
        Me.btn_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_filter.UseVisualStyleBackColor = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(364, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 18)
        Me.Label7.TabIndex = 265
        Me.Label7.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(304, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 264
        Me.Label4.Text = "Search"
        '
        'Txt_search
        '
        Me.Txt_search.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_search.Location = New System.Drawing.Point(385, 32)
        Me.Txt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_search.Name = "Txt_search"
        Me.Txt_search.Size = New System.Drawing.Size(175, 23)
        Me.Txt_search.TabIndex = 263
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.DgvData)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(8, 146)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(872, 429)
        Me.GroupBox2.TabIndex = 259
        Me.GroupBox2.TabStop = false
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = false
        Me.DgvData.AllowUserToDeleteRows = false
        Me.DgvData.AllowUserToResizeColumns = false
        Me.DgvData.AllowUserToResizeRows = false
        Me.DgvData.BackgroundColor = System.Drawing.Color.White
        Me.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.DgvData.Size = New System.Drawing.Size(855, 394)
        Me.DgvData.StandardTab = true
        Me.DgvData.TabIndex = 221
        '
        'Btn_viewpdf
        '
        Me.Btn_viewpdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(26,Byte),Integer), CType(CType(93,Byte),Integer), CType(CType(26,Byte),Integer))
        Me.Btn_viewpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_viewpdf.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_viewpdf.ForeColor = System.Drawing.Color.White
        Me.Btn_viewpdf.Image = Global.Aplikasi_Manajemen_Surat.My.Resources.Resources.view_24x24
        Me.Btn_viewpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_viewpdf.Location = New System.Drawing.Point(294, 583)
        Me.Btn_viewpdf.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_viewpdf.Name = "Btn_viewpdf"
        Me.Btn_viewpdf.Size = New System.Drawing.Size(149, 44)
        Me.Btn_viewpdf.TabIndex = 263
        Me.Btn_viewpdf.Text = "View"
        Me.Btn_viewpdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_viewpdf.UseVisualStyleBackColor = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1, 39)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(897, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 256
        Me.PictureBox3.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.Aplikasi_Manajemen_Surat.My.Resources.Resources.logo_bps_Yb8_icon
        Me.PictureBox2.Location = New System.Drawing.Point(4, 9)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 253
        Me.PictureBox2.TabStop = false
        '
        'Btn_Upload
        '
        Me.Btn_Upload.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Upload.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_Upload.ForeColor = System.Drawing.Color.White
        Me.Btn_Upload.Image = CType(resources.GetObject("Btn_Upload.Image"),System.Drawing.Image)
        Me.Btn_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Upload.Location = New System.Drawing.Point(451, 583)
        Me.Btn_Upload.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Upload.Name = "Btn_Upload"
        Me.Btn_Upload.Size = New System.Drawing.Size(149, 44)
        Me.Btn_Upload.TabIndex = 265
        Me.Btn_Upload.Text = "Upload"
        Me.Btn_Upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Upload.UseVisualStyleBackColor = false
        '
        'Btn_Batal
        '
        Me.Btn_Batal.BackColor = System.Drawing.Color.Crimson
        Me.Btn_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Batal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_Batal.ForeColor = System.Drawing.Color.White
        Me.Btn_Batal.Image = CType(resources.GetObject("Btn_Batal.Image"),System.Drawing.Image)
        Me.Btn_Batal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Batal.Location = New System.Drawing.Point(750, 583)
        Me.Btn_Batal.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Batal.Name = "Btn_Batal"
        Me.Btn_Batal.Size = New System.Drawing.Size(129, 44)
        Me.Btn_Batal.TabIndex = 264
        Me.Btn_Batal.Text = "Batal"
        Me.Btn_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Batal.UseVisualStyleBackColor = false
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
        Me.Btn_keluar.Location = New System.Drawing.Point(843, 5)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 27)
        Me.Btn_keluar.TabIndex = 267
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(37,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(133,Byte),Integer))
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.White
        Me.btn_export.Image = CType(resources.GetObject("btn_export.Image"),System.Drawing.Image)
        Me.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_export.Location = New System.Drawing.Point(608, 583)
        Me.btn_export.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(134, 44)
        Me.btn_export.TabIndex = 268
        Me.btn_export.Text = "Export"
        Me.btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_export.UseVisualStyleBackColor = false
        '
        'Frm_ViewSuratKeluar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(892, 640)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.Btn_keluar)
        Me.Controls.Add(Me.Btn_Upload)
        Me.Controls.Add(Me.Btn_Batal)
        Me.Controls.Add(Me.Btn_viewpdf)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Group_Filter)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ViewSuratKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ViewSuratKeluar"
        Me.Group_Filter.ResumeLayout(false)
        Me.Group_Filter.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        CType(Me.DgvData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Group_Filter As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_search As TextBox
    Friend WithEvents Btn_viewpdf As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Btn_Upload As Button
    Friend WithEvents Btn_Batal As Button
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents btn_export As Button
End Class
