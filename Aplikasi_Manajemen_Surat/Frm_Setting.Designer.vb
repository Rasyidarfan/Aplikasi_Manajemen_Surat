<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Setting))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.Btn_TestConnect = New System.Windows.Forms.Button()
        Me.Btn_Apply = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_server = New System.Windows.Forms.TextBox()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(39, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 14)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "Manajemen Surat App."
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(98,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Setting"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 220
        Me.PictureBox1.TabStop = false
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
        Me.Btn_keluar.Location = New System.Drawing.Point(456, 12)
        Me.Btn_keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(36, 27)
        Me.Btn_keluar.TabIndex = 223
        Me.Btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_keluar.UseVisualStyleBackColor = false
        '
        'Btn_TestConnect
        '
        Me.Btn_TestConnect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_TestConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Btn_TestConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TestConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_TestConnect.Location = New System.Drawing.Point(21, 209)
        Me.Btn_TestConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_TestConnect.Name = "Btn_TestConnect"
        Me.Btn_TestConnect.Size = New System.Drawing.Size(133, 39)
        Me.Btn_TestConnect.TabIndex = 229
        Me.Btn_TestConnect.Text = "&Test Connection"
        Me.Btn_TestConnect.UseVisualStyleBackColor = true
        '
        'Btn_Apply
        '
        Me.Btn_Apply.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.Btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Apply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Apply.Location = New System.Drawing.Point(385, 209)
        Me.Btn_Apply.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Apply.Name = "Btn_Apply"
        Me.Btn_Apply.Size = New System.Drawing.Size(88, 39)
        Me.Btn_Apply.TabIndex = 228
        Me.Btn_Apply.Text = "&Apply"
        Me.Btn_Apply.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_User)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_server)
        Me.GroupBox1.Controls.Add(Me.Txt_Password)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(460, 149)
        Me.GroupBox1.TabIndex = 227
        Me.GroupBox1.TabStop = false
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(162, 61)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(50, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "User"
        '
        'Txt_User
        '
        Me.Txt_User.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_User.Location = New System.Drawing.Point(184, 61)
        Me.Txt_User.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(135, 26)
        Me.Txt_User.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(50, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Server "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(50, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(162, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(162, 104)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = ":"
        '
        'Txt_server
        '
        Me.Txt_server.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_server.Location = New System.Drawing.Point(184, 27)
        Me.Txt_server.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_server.Name = "Txt_server"
        Me.Txt_server.Size = New System.Drawing.Size(258, 26)
        Me.Txt_server.TabIndex = 1
        '
        'Txt_Password
        '
        Me.Txt_Password.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Password.Location = New System.Drawing.Point(184, 96)
        Me.Txt_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(177, 26)
        Me.Txt_Password.TabIndex = 2
        '
        'Frm_Setting
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 263)
        Me.Controls.Add(Me.Btn_TestConnect)
        Me.Controls.Add(Me.Btn_Apply)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_keluar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Frm_Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Setting"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_keluar As Button
    Friend WithEvents Btn_TestConnect As Button
    Friend WithEvents Btn_Apply As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_server As TextBox
    Friend WithEvents Txt_Password As TextBox
End Class
