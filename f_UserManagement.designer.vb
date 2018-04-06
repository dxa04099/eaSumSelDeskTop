<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_UserManagement
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
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.L7 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.mUserID = New System.Windows.Forms.TextBox()
        Me.mNama = New System.Windows.Forms.TextBox()
        Me.mKd_Level = New System.Windows.Forms.ComboBox()
        Me.mKelamin = New System.Windows.Forms.ComboBox()
        Me.mPWD1 = New System.Windows.Forms.TextBox()
        Me.dg_User = New System.Windows.Forms.DataGridView()
        Me.cd_CaptionColor = New System.Windows.Forms.ColorDialog()
        Me.tbl_AturHakUSer = New System.Windows.Forms.Button()
        Me.mcari = New System.Windows.Forms.TextBox()
        Me.L11 = New System.Windows.Forms.Label()
        Me.tblaturaaksesSKPD = New System.Windows.Forms.Button()
        Me.tbl_AturKegiatan = New System.Windows.Forms.Button()
        Me.mKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mUserID_Induk = New System.Windows.Forms.TextBox()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dg_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(17, 14)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(43, 13)
        Me.L1.TabIndex = 6
        Me.L1.Text = "ID User"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(17, 45)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(35, 13)
        Me.L2.TabIndex = 7
        Me.L2.Text = "Nama"
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.BackColor = System.Drawing.Color.Transparent
        Me.L4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.Location = New System.Drawing.Point(17, 101)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(104, 13)
        Me.L4.TabIndex = 8
        Me.L4.Text = "Level Akses Aplikasi"
        '
        'L7
        '
        Me.L7.AutoSize = True
        Me.L7.BackColor = System.Drawing.Color.Transparent
        Me.L7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L7.Location = New System.Drawing.Point(17, 224)
        Me.L7.Name = "L7"
        Me.L7.Size = New System.Drawing.Size(53, 13)
        Me.L7.TabIndex = 12
        Me.L7.Text = "Password"
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.BackColor = System.Drawing.Color.Transparent
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.Location = New System.Drawing.Point(17, 71)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(71, 13)
        Me.L3.TabIndex = 10
        Me.L3.Text = "Jenis Kelamin"
        '
        'mUserID
        '
        Me.mUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mUserID.Location = New System.Drawing.Point(123, 12)
        Me.mUserID.MaxLength = 20
        Me.mUserID.Name = "mUserID"
        Me.mUserID.Size = New System.Drawing.Size(174, 20)
        Me.mUserID.TabIndex = 0
        '
        'mNama
        '
        Me.mNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama.Location = New System.Drawing.Point(123, 41)
        Me.mNama.MaxLength = 50
        Me.mNama.Name = "mNama"
        Me.mNama.Size = New System.Drawing.Size(446, 20)
        Me.mNama.TabIndex = 1
        '
        'mKd_Level
        '
        Me.mKd_Level.Enabled = False
        Me.mKd_Level.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Level.FormattingEnabled = True
        Me.mKd_Level.Items.AddRange(New Object() {"1. Admin", "2. Sub Admin", "3. Operator"})
        Me.mKd_Level.Location = New System.Drawing.Point(123, 97)
        Me.mKd_Level.Name = "mKd_Level"
        Me.mKd_Level.Size = New System.Drawing.Size(174, 21)
        Me.mKd_Level.TabIndex = 3
        '
        'mKelamin
        '
        Me.mKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKelamin.FormattingEnabled = True
        Me.mKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.mKelamin.Location = New System.Drawing.Point(123, 67)
        Me.mKelamin.Name = "mKelamin"
        Me.mKelamin.Size = New System.Drawing.Size(174, 21)
        Me.mKelamin.TabIndex = 2
        '
        'mPWD1
        '
        Me.mPWD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPWD1.Location = New System.Drawing.Point(123, 220)
        Me.mPWD1.MaxLength = 25
        Me.mPWD1.Name = "mPWD1"
        Me.mPWD1.Size = New System.Drawing.Size(142, 20)
        Me.mPWD1.TabIndex = 7
        '
        'dg_User
        '
        Me.dg_User.AllowUserToAddRows = False
        Me.dg_User.AllowUserToDeleteRows = False
        Me.dg_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_User.Location = New System.Drawing.Point(20, 284)
        Me.dg_User.Name = "dg_User"
        Me.dg_User.ReadOnly = True
        Me.dg_User.RowHeadersVisible = False
        Me.dg_User.Size = New System.Drawing.Size(705, 228)
        Me.dg_User.TabIndex = 15
        Me.dg_User.TabStop = False
        '
        'tbl_AturHakUSer
        '
        Me.tbl_AturHakUSer.BackColor = System.Drawing.Color.White
        Me.tbl_AturHakUSer.Enabled = False
        Me.tbl_AturHakUSer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_AturHakUSer.Location = New System.Drawing.Point(602, 128)
        Me.tbl_AturHakUSer.Name = "tbl_AturHakUSer"
        Me.tbl_AturHakUSer.Size = New System.Drawing.Size(116, 33)
        Me.tbl_AturHakUSer.TabIndex = 11
        Me.tbl_AturHakUSer.Text = "Atur Hak User"
        Me.tbl_AturHakUSer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_AturHakUSer.UseVisualStyleBackColor = False
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(48, 518)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(677, 20)
        Me.mcari.TabIndex = 16
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(18, 521)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 32
        Me.L11.Text = "cari"
        '
        'tblaturaaksesSKPD
        '
        Me.tblaturaaksesSKPD.BackColor = System.Drawing.Color.White
        Me.tblaturaaksesSKPD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblaturaaksesSKPD.Location = New System.Drawing.Point(602, 206)
        Me.tblaturaaksesSKPD.Name = "tblaturaaksesSKPD"
        Me.tblaturaaksesSKPD.Size = New System.Drawing.Size(116, 33)
        Me.tblaturaaksesSKPD.TabIndex = 13
        Me.tblaturaaksesSKPD.Text = "Atur Akses OPD"
        Me.tblaturaaksesSKPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblaturaaksesSKPD.UseVisualStyleBackColor = False
        '
        'tbl_AturKegiatan
        '
        Me.tbl_AturKegiatan.BackColor = System.Drawing.Color.White
        Me.tbl_AturKegiatan.Enabled = False
        Me.tbl_AturKegiatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_AturKegiatan.Location = New System.Drawing.Point(602, 167)
        Me.tbl_AturKegiatan.Name = "tbl_AturKegiatan"
        Me.tbl_AturKegiatan.Size = New System.Drawing.Size(116, 33)
        Me.tbl_AturKegiatan.TabIndex = 12
        Me.tbl_AturKegiatan.Text = "Atur Akses Kegiatan"
        Me.tbl_AturKegiatan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_AturKegiatan.UseVisualStyleBackColor = False
        '
        'mKeterangan
        '
        Me.mKeterangan.Location = New System.Drawing.Point(123, 166)
        Me.mKeterangan.Multiline = True
        Me.mKeterangan.Name = "mKeterangan"
        Me.mKeterangan.Size = New System.Drawing.Size(446, 46)
        Me.mKeterangan.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID User Induk"
        '
        'mUserID_Induk
        '
        Me.mUserID_Induk.Enabled = False
        Me.mUserID_Induk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mUserID_Induk.Location = New System.Drawing.Point(123, 135)
        Me.mUserID_Induk.MaxLength = 20
        Me.mUserID_Induk.Name = "mUserID_Induk"
        Me.mUserID_Induk.Size = New System.Drawing.Size(174, 20)
        Me.mUserID_Induk.TabIndex = 5
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(303, 135)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 33
        Me.tbCari01.UseVisualStyleBackColor = False
        Me.tbCari01.Visible = False
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(602, 20)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 8
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(602, 54)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 9
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(602, 90)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 10
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(602, 245)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 14
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(341, 234)
        Me.MaskedTextBox1.Mask = "###,###.00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(133, 20)
        Me.MaskedTextBox1.TabIndex = 34
        '
        'f_UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(743, 547)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.mKeterangan)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tblaturaaksesSKPD)
        Me.Controls.Add(Me.tbl_AturKegiatan)
        Me.Controls.Add(Me.tbl_AturHakUSer)
        Me.Controls.Add(Me.dg_User)
        Me.Controls.Add(Me.mPWD1)
        Me.Controls.Add(Me.mKelamin)
        Me.Controls.Add(Me.mKd_Level)
        Me.Controls.Add(Me.mNama)
        Me.Controls.Add(Me.mUserID_Induk)
        Me.Controls.Add(Me.mUserID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.L7)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_UserManagement"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        CType(Me.dg_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L4 As System.Windows.Forms.Label
    Friend WithEvents L7 As System.Windows.Forms.Label
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents mUserID As System.Windows.Forms.TextBox
    Friend WithEvents mNama As System.Windows.Forms.TextBox
    Friend WithEvents mKd_Level As System.Windows.Forms.ComboBox
    Friend WithEvents mKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents mPWD1 As System.Windows.Forms.TextBox
    Friend WithEvents dg_User As System.Windows.Forms.DataGridView
    Friend WithEvents cd_CaptionColor As System.Windows.Forms.ColorDialog
    Friend WithEvents tbl_AturHakUSer As System.Windows.Forms.Button
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tblaturaaksesSKPD As System.Windows.Forms.Button
    Friend WithEvents tbl_AturKegiatan As System.Windows.Forms.Button
    Friend WithEvents mKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mUserID_Induk As System.Windows.Forms.TextBox
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
