<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Klasifikasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Klasifikasi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Group_Input = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Keterangan = New System.Windows.Forms.TextBox()
        Me.GroupBox_Data = New System.Windows.Forms.GroupBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Group_Input.SuspendLayout
        Me.GroupBox_Data.SuspendLayout
        CType(Me.DgvData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-19, 51)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(951, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 255
        Me.PictureBox3.TabStop = false
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
        Me.Btn_keluar.Location = New System.Drawing.Point(882, 3)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 32)
        Me.Btn_keluar.TabIndex = 251
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(40, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 14)
        Me.Label11.TabIndex = 254
        Me.Label11.Text = "Manajemen Surat App."
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Label12.Location = New System.Drawing.Point(42, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 18)
        Me.Label12.TabIndex = 253
        Me.Label12.Text = "Master Klasifikasi"
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
        Me.PictureBox2.TabIndex = 252
        Me.PictureBox2.TabStop = false
        '
        'Group_Input
        '
        Me.Group_Input.BackColor = System.Drawing.Color.White
        Me.Group_Input.Controls.Add(Me.Label1)
        Me.Group_Input.Controls.Add(Me.Label3)
        Me.Group_Input.Controls.Add(Me.txt_kode)
        Me.Group_Input.Controls.Add(Me.Label6)
        Me.Group_Input.Controls.Add(Me.Label2)
        Me.Group_Input.Controls.Add(Me.Txt_Keterangan)
        Me.Group_Input.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Group_Input.Location = New System.Drawing.Point(13, 69)
        Me.Group_Input.Margin = New System.Windows.Forms.Padding(4)
        Me.Group_Input.Name = "Group_Input"
        Me.Group_Input.Padding = New System.Windows.Forms.Padding(4)
        Me.Group_Input.Size = New System.Drawing.Size(905, 135)
        Me.Group_Input.TabIndex = 256
        Me.Group_Input.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(116, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 24)
        Me.Label3.TabIndex = 237
        Me.Label3.Text = ":"
        '
        'txt_kode
        '
        Me.txt_kode.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_kode.Location = New System.Drawing.Point(131, 22)
        Me.txt_kode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(185, 23)
        Me.txt_kode.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(117, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 239
        Me.Label6.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Keterangan"
        '
        'Txt_Keterangan
        '
        Me.Txt_Keterangan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Keterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Keterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_Keterangan.Location = New System.Drawing.Point(131, 53)
        Me.Txt_Keterangan.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Keterangan.Multiline = true
        Me.Txt_Keterangan.Name = "Txt_Keterangan"
        Me.Txt_Keterangan.Size = New System.Drawing.Size(746, 58)
        Me.Txt_Keterangan.TabIndex = 1
        '
        'GroupBox_Data
        '
        Me.GroupBox_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox_Data.Controls.Add(Me.DgvData)
        Me.GroupBox_Data.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox_Data.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Data.Location = New System.Drawing.Point(13, 212)
        Me.GroupBox_Data.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Data.Name = "GroupBox_Data"
        Me.GroupBox_Data.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Data.Size = New System.Drawing.Size(905, 407)
        Me.GroupBox_Data.TabIndex = 253
        Me.GroupBox_Data.TabStop = false
        Me.GroupBox_Data.Text = "Daftar Klasifikasi"
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
        Me.DgvData.Location = New System.Drawing.Point(8, 27)
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
        Me.DgvData.Size = New System.Drawing.Size(889, 372)
        Me.DgvData.StandardTab = true
        Me.DgvData.TabIndex = 221
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"),System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.Location = New System.Drawing.Point(769, 627)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(149, 44)
        Me.BtnSimpan.TabIndex = 258
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = false
        '
        'Frm_Klasifikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(931, 684)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.GroupBox_Data)
        Me.Controls.Add(Me.Group_Input)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Btn_keluar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Frm_Klasifikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Klasifikasi"
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.Group_Input.ResumeLayout(false)
        Me.Group_Input.PerformLayout
        Me.GroupBox_Data.ResumeLayout(false)
        CType(Me.DgvData,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Group_Input As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_kode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Keterangan As TextBox
    Friend WithEvents GroupBox_Data As GroupBox
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents BtnSimpan As Button
End Class
