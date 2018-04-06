<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_UserManagement_GntPasword
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
        Me.mPWD2 = New System.Windows.Forms.TextBox
        Me.mPWD1 = New System.Windows.Forms.TextBox
        Me.mNama = New System.Windows.Forms.TextBox
        Me.mUserID = New System.Windows.Forms.TextBox
        Me.L5 = New System.Windows.Forms.Label
        Me.L4 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.L1 = New System.Windows.Forms.Label
        Me.L3 = New System.Windows.Forms.Label
        Me.mPwd0 = New System.Windows.Forms.TextBox
        Me.tblSimpan = New System.Windows.Forms.Button
        Me.tbl_Keluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mPWD2
        '
        Me.mPWD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mPWD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPWD2.Location = New System.Drawing.Point(174, 124)
        Me.mPWD2.MaxLength = 25
        Me.mPWD2.Name = "mPWD2"
        Me.mPWD2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.mPWD2.Size = New System.Drawing.Size(234, 20)
        Me.mPWD2.TabIndex = 4
        '
        'mPWD1
        '
        Me.mPWD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mPWD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPWD1.Location = New System.Drawing.Point(174, 96)
        Me.mPWD1.MaxLength = 25
        Me.mPWD1.Name = "mPWD1"
        Me.mPWD1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.mPWD1.Size = New System.Drawing.Size(234, 20)
        Me.mPWD1.TabIndex = 3
        '
        'mNama
        '
        Me.mNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama.Location = New System.Drawing.Point(174, 39)
        Me.mNama.MaxLength = 50
        Me.mNama.Name = "mNama"
        Me.mNama.ReadOnly = True
        Me.mNama.Size = New System.Drawing.Size(367, 20)
        Me.mNama.TabIndex = 1
        Me.mNama.TabStop = False
        '
        'mUserID
        '
        Me.mUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mUserID.Location = New System.Drawing.Point(174, 16)
        Me.mUserID.MaxLength = 20
        Me.mUserID.Name = "mUserID"
        Me.mUserID.ReadOnly = True
        Me.mUserID.Size = New System.Drawing.Size(174, 20)
        Me.mUserID.TabIndex = 0
        Me.mUserID.TabStop = False
        '
        'L5
        '
        Me.L5.AutoSize = True
        Me.L5.BackColor = System.Drawing.Color.Transparent
        Me.L5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L5.Location = New System.Drawing.Point(12, 124)
        Me.L5.Name = "L5"
        Me.L5.Size = New System.Drawing.Size(133, 13)
        Me.L5.TabIndex = 48
        Me.L5.Text = "Ulangi Masukan Password"
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.BackColor = System.Drawing.Color.Transparent
        Me.L4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.Location = New System.Drawing.Point(12, 100)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(125, 13)
        Me.L4.TabIndex = 47
        Me.L4.Text = "Masukan Password Baru"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(12, 43)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(35, 13)
        Me.L2.TabIndex = 46
        Me.L2.Text = "Nama"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(12, 18)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(43, 13)
        Me.L1.TabIndex = 45
        Me.L1.Text = "ID User"
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.BackColor = System.Drawing.Color.Transparent
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.Location = New System.Drawing.Point(12, 69)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(129, 13)
        Me.L3.TabIndex = 47
        Me.L3.Text = "Masukan Password Lama"
        '
        'mPwd0
        '
        Me.mPwd0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mPwd0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPwd0.Location = New System.Drawing.Point(174, 65)
        Me.mPwd0.MaxLength = 25
        Me.mPwd0.Name = "mPwd0"
        Me.mPwd0.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mPwd0.Size = New System.Drawing.Size(234, 20)
        Me.mPwd0.TabIndex = 2
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(12, 150)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(90, 33)
        Me.tblSimpan.TabIndex = 5
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(451, 150)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(90, 33)
        Me.tbl_Keluar.TabIndex = 6
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'f_UserManagement_GntPasword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(557, 194)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.mPWD2)
        Me.Controls.Add(Me.mPwd0)
        Me.Controls.Add(Me.mPWD1)
        Me.Controls.Add(Me.mNama)
        Me.Controls.Add(Me.mUserID)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L5)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_UserManagement_GntPasword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ganti Password User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mPWD2 As System.Windows.Forms.TextBox
    Friend WithEvents mPWD1 As System.Windows.Forms.TextBox
    Friend WithEvents mNama As System.Windows.Forms.TextBox
    Friend WithEvents mUserID As System.Windows.Forms.TextBox
    Friend WithEvents L5 As System.Windows.Forms.Label
    Friend WithEvents L4 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents mPwd0 As System.Windows.Forms.TextBox
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
End Class
