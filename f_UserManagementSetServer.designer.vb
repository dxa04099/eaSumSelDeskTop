<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_UserManagementSetServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_UserManagementSetServer))
        Me.Label6 = New System.Windows.Forms.Label
        Me.tblPindah = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.mNama_Server = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tblKeluar = New System.Windows.Forms.Button
        Me.tbl_simpan = New System.Windows.Forms.Button
        Me.tblTesKoneksi = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.mNama_Data_Base = New System.Windows.Forms.TextBox
        Me.mID_ = New System.Windows.Forms.TextBox
        Me.mPasswordd_1 = New System.Windows.Forms.TextBox
        Me.mKodePanggil = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "ID Login Data Base"
        '
        'tblPindah
        '
        Me.tblPindah.Location = New System.Drawing.Point(27, 129)
        Me.tblPindah.Name = "tblPindah"
        Me.tblPindah.Size = New System.Drawing.Size(27, 33)
        Me.tblPindah.TabIndex = 5
        Me.tblPindah.TabStop = False
        Me.tblPindah.Text = "><"
        Me.tblPindah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Nama Data Base"
        '
        'mNama_Server
        '
        Me.mNama_Server.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Server.Location = New System.Drawing.Point(125, 21)
        Me.mNama_Server.MaxLength = 50
        Me.mNama_Server.Name = "mNama_Server"
        Me.mNama_Server.Size = New System.Drawing.Size(293, 20)
        Me.mNama_Server.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Nama Server"
        '
        'tblKeluar
        '
        Me.tblKeluar.BackColor = System.Drawing.Color.White
        Me.tblKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblKeluar.Location = New System.Drawing.Point(330, 129)
        Me.tblKeluar.Name = "tblKeluar"
        Me.tblKeluar.Size = New System.Drawing.Size(88, 33)
        Me.tblKeluar.TabIndex = 11
        Me.tblKeluar.Text = "Keluar"
        Me.tblKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblKeluar.UseVisualStyleBackColor = False
        '
        'tbl_simpan
        '
        Me.tbl_simpan.BackColor = System.Drawing.Color.White
        Me.tbl_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbl_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_simpan.Location = New System.Drawing.Point(195, 129)
        Me.tbl_simpan.Name = "tbl_simpan"
        Me.tbl_simpan.Size = New System.Drawing.Size(75, 33)
        Me.tbl_simpan.TabIndex = 10
        Me.tbl_simpan.Text = "Simpan"
        Me.tbl_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_simpan.UseVisualStyleBackColor = False
        '
        'tblTesKoneksi
        '
        Me.tblTesKoneksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tblTesKoneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTesKoneksi.Location = New System.Drawing.Point(55, 129)
        Me.tblTesKoneksi.Name = "tblTesKoneksi"
        Me.tblTesKoneksi.Size = New System.Drawing.Size(134, 33)
        Me.tblTesKoneksi.TabIndex = 9
        Me.tblTesKoneksi.Text = "Tes Connection"
        Me.tblTesKoneksi.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Password"
        '
        'mNama_Data_Base
        '
        Me.mNama_Data_Base.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Data_Base.Location = New System.Drawing.Point(125, 47)
        Me.mNama_Data_Base.MaxLength = 50
        Me.mNama_Data_Base.Name = "mNama_Data_Base"
        Me.mNama_Data_Base.Size = New System.Drawing.Size(293, 20)
        Me.mNama_Data_Base.TabIndex = 1
        '
        'mID_
        '
        Me.mID_.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mID_.Location = New System.Drawing.Point(125, 73)
        Me.mID_.MaxLength = 50
        Me.mID_.Name = "mID_"
        Me.mID_.Size = New System.Drawing.Size(145, 20)
        Me.mID_.TabIndex = 2
        '
        'mPasswordd_1
        '
        Me.mPasswordd_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPasswordd_1.Location = New System.Drawing.Point(125, 99)
        Me.mPasswordd_1.MaxLength = 50
        Me.mPasswordd_1.Name = "mPasswordd_1"
        Me.mPasswordd_1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(79)
        Me.mPasswordd_1.Size = New System.Drawing.Size(145, 20)
        Me.mPasswordd_1.TabIndex = 3
        '
        'mKodePanggil
        '
        Me.mKodePanggil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKodePanggil.Location = New System.Drawing.Point(276, 136)
        Me.mKodePanggil.MaxLength = 1
        Me.mKodePanggil.Name = "mKodePanggil"
        Me.mKodePanggil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(79)
        Me.mKodePanggil.Size = New System.Drawing.Size(21, 20)
        Me.mKodePanggil.TabIndex = 3
        Me.mKodePanggil.Visible = False
        '
        'f_UserManagementSetServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 168)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tblPindah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mKodePanggil)
        Me.Controls.Add(Me.mPasswordd_1)
        Me.Controls.Add(Me.mID_)
        Me.Controls.Add(Me.mNama_Data_Base)
        Me.Controls.Add(Me.mNama_Server)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblKeluar)
        Me.Controls.Add(Me.tbl_simpan)
        Me.Controls.Add(Me.tblTesKoneksi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f_UserManagementSetServer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Server dan Data Base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tblPindah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mNama_Server As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tblKeluar As System.Windows.Forms.Button
    Friend WithEvents tbl_simpan As System.Windows.Forms.Button
    Friend WithEvents tblTesKoneksi As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mNama_Data_Base As System.Windows.Forms.TextBox
    Friend WithEvents mID_ As System.Windows.Forms.TextBox
    Friend WithEvents mPasswordd_1 As System.Windows.Forms.TextBox
    Friend WithEvents mKodePanggil As System.Windows.Forms.TextBox
End Class
