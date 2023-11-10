<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Upload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Upload))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_file = New System.Windows.Forms.Button()
        Me.Txt_pathfile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_Upload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1, 46)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(504, 10)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 256
        Me.PictureBox3.TabStop = false
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(43, 24)
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
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(42, 6)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "Upload File"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 253
        Me.PictureBox2.TabStop = false
        '
        'btn_file
        '
        Me.btn_file.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_file.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_file.Location = New System.Drawing.Point(391, 82)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(38, 26)
        Me.btn_file.TabIndex = 257
        Me.btn_file.Text = "..."
        Me.btn_file.UseVisualStyleBackColor = false
        '
        'Txt_pathfile
        '
        Me.Txt_pathfile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_pathfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_pathfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Txt_pathfile.Location = New System.Drawing.Point(109, 83)
        Me.Txt_pathfile.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_pathfile.Name = "Txt_pathfile"
        Me.Txt_pathfile.Size = New System.Drawing.Size(275, 23)
        Me.Txt_pathfile.TabIndex = 260
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(88, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 18)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 88)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 18)
        Me.Label10.TabIndex = 258
        Me.Label10.Text = "File"
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
        Me.Btn_keluar.Location = New System.Drawing.Point(1, -2)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 34)
        Me.Btn_keluar.TabIndex = 261
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Btn_Upload
        '
        Me.Btn_Upload.BackColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Upload.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Btn_Upload.ForeColor = System.Drawing.Color.White
        Me.Btn_Upload.Image = CType(resources.GetObject("Btn_Upload.Image"),System.Drawing.Image)
        Me.Btn_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Upload.Location = New System.Drawing.Point(165, 135)
        Me.Btn_Upload.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Upload.Name = "Btn_Upload"
        Me.Btn_Upload.Size = New System.Drawing.Size(149, 44)
        Me.Btn_Upload.TabIndex = 262
        Me.Btn_Upload.Text = "Upload"
        Me.Btn_Upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Upload.UseVisualStyleBackColor = false
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Btn_keluar)
        Me.GroupBox1.Location = New System.Drawing.Point(448, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(38, 34)
        Me.GroupBox1.TabIndex = 263
        Me.GroupBox1.TabStop = false
        '
        'Frm_Upload
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53,Byte),Integer), CType(CType(47,Byte),Integer), CType(CType(68,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(498, 202)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Upload)
        Me.Controls.Add(Me.btn_file)
        Me.Controls.Add(Me.Txt_pathfile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Frm_Upload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Upload"
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_file As Button
    Friend WithEvents Txt_pathfile As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btn_Upload As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
