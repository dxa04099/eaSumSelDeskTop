<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_LogON
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_LogON))
        Me.Label1 = New System.Windows.Forms.Label
        Me.mUserID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.mPWD = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.mOke = New System.Windows.Forms.Button
        Me.mBatal = New System.Windows.Forms.Button
        Me.LblVersi = New System.Windows.Forms.Label
        Me.mthnAnggaran = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pb_LogOn = New System.Windows.Forms.PictureBox
        CType(Me.pb_LogOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "e-Sumsel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mUserID
        '
        Me.mUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mUserID.Location = New System.Drawing.Point(241, 45)
        Me.mUserID.MaxLength = 20
        Me.mUserID.Name = "mUserID"
        Me.mUserID.Size = New System.Drawing.Size(180, 20)
        Me.mUserID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(156, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "user id"
        '
        'mPWD
        '
        Me.mPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPWD.Location = New System.Drawing.Point(241, 71)
        Me.mPWD.MaxLength = 25
        Me.mPWD.Name = "mPWD"
        Me.mPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.mPWD.Size = New System.Drawing.Size(180, 20)
        Me.mPWD.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(156, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "p a s s w o r d"
        '
        'mOke
        '
        Me.mOke.BackColor = System.Drawing.Color.White
        Me.mOke.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.mOke.FlatAppearance.BorderSize = 0
        Me.mOke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.mOke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.mOke.Image = Global.eParameter.My.Resources.Resources.oke
        Me.mOke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mOke.Location = New System.Drawing.Point(344, 129)
        Me.mOke.Name = "mOke"
        Me.mOke.Size = New System.Drawing.Size(77, 37)
        Me.mOke.TabIndex = 3
        Me.mOke.Text = "OKE"
        Me.mOke.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mOke.UseVisualStyleBackColor = False
        '
        'mBatal
        '
        Me.mBatal.BackColor = System.Drawing.Color.White
        Me.mBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mBatal.FlatAppearance.BorderSize = 0
        Me.mBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.mBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.mBatal.Image = Global.eParameter.My.Resources.Resources.close
        Me.mBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mBatal.Location = New System.Drawing.Point(241, 129)
        Me.mBatal.Name = "mBatal"
        Me.mBatal.Size = New System.Drawing.Size(77, 37)
        Me.mBatal.TabIndex = 3
        Me.mBatal.Text = "Batal"
        Me.mBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mBatal.UseVisualStyleBackColor = False
        '
        'LblVersi
        '
        Me.LblVersi.AutoSize = True
        Me.LblVersi.BackColor = System.Drawing.Color.Transparent
        Me.LblVersi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblVersi.Location = New System.Drawing.Point(22, 147)
        Me.LblVersi.Name = "LblVersi"
        Me.LblVersi.Size = New System.Drawing.Size(86, 13)
        Me.LblVersi.TabIndex = 6
        Me.LblVersi.Text = "Edisi : 20022018"
        '
        'mthnAnggaran
        '
        Me.mthnAnggaran.FormattingEnabled = True
        Me.mthnAnggaran.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.mthnAnggaran.Location = New System.Drawing.Point(241, 97)
        Me.mthnAnggaran.Name = "mthnAnggaran"
        Me.mthnAnggaran.Size = New System.Drawing.Size(62, 21)
        Me.mthnAnggaran.TabIndex = 8
        Me.mthnAnggaran.Text = "2019"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(150, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "tahun anggaran"
        '
        'pb_LogOn
        '
        Me.pb_LogOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_LogOn.ErrorImage = CType(resources.GetObject("pb_LogOn.ErrorImage"), System.Drawing.Image)
        Me.pb_LogOn.Image = Global.eParameter.My.Resources.Resources.LogoSumsel
        Me.pb_LogOn.Location = New System.Drawing.Point(25, 45)
        Me.pb_LogOn.Name = "pb_LogOn"
        Me.pb_LogOn.Size = New System.Drawing.Size(63, 74)
        Me.pb_LogOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_LogOn.TabIndex = 4
        Me.pb_LogOn.TabStop = False
        '
        'f_LogON
        '
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.mthnAnggaran)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblVersi)
        Me.Controls.Add(Me.pb_LogOn)
        Me.Controls.Add(Me.mBatal)
        Me.Controls.Add(Me.mOke)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mPWD)
        Me.Controls.Add(Me.mUserID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f_LogON"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Princess Studio"
        CType(Me.pb_LogOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mPWD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mOke As System.Windows.Forms.Button
    Friend WithEvents mBatal As System.Windows.Forms.Button
    Friend WithEvents pb_LogOn As System.Windows.Forms.PictureBox
    Friend WithEvents LblVersi As System.Windows.Forms.Label
    Friend WithEvents mthnAnggaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
