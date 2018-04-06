<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_OPD_3OPD
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
        Me.mKode_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Bidang = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Urusan = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mNama_OPD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_OPD = New System.Windows.Forms.DataGridView()
        Me.mcari = New System.Windows.Forms.TextBox()
        Me.L11 = New System.Windows.Forms.Label()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mKode_Fungsi = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mNama_Fungsi = New System.Windows.Forms.TextBox()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mNama_Bidang = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dg_OPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mKode_OPD
        '
        Me.mKode_OPD.BackColor = System.Drawing.Color.White
        Me.mKode_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_OPD.Location = New System.Drawing.Point(138, 60)
        Me.mKode_OPD.Mask = "##"
        Me.mKode_OPD.Name = "mKode_OPD"
        Me.mKode_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_OPD.TabIndex = 2
        Me.mKode_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Bidang
        '
        Me.mKode_Bidang.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Bidang.Enabled = False
        Me.mKode_Bidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Bidang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Bidang.Location = New System.Drawing.Point(160, 34)
        Me.mKode_Bidang.Mask = "##"
        Me.mKode_Bidang.Name = "mKode_Bidang"
        Me.mKode_Bidang.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Bidang.TabIndex = 1
        Me.mKode_Bidang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Urusan
        '
        Me.mKode_Urusan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Urusan.Enabled = False
        Me.mKode_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Urusan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Urusan.Location = New System.Drawing.Point(138, 34)
        Me.mKode_Urusan.Mask = "#"
        Me.mKode_Urusan.Name = "mKode_Urusan"
        Me.mKode_Urusan.Size = New System.Drawing.Size(20, 20)
        Me.mKode_Urusan.TabIndex = 0
        Me.mKode_Urusan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 103
        Me.Label14.Text = "Kode OPD"
        '
        'mNama_OPD
        '
        Me.mNama_OPD.BackColor = System.Drawing.Color.White
        Me.mNama_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_OPD.Location = New System.Drawing.Point(138, 86)
        Me.mNama_OPD.MaxLength = 100
        Me.mNama_OPD.Name = "mNama_OPD"
        Me.mNama_OPD.Size = New System.Drawing.Size(689, 20)
        Me.mNama_OPD.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Nama OPD"
        '
        'dg_OPD
        '
        Me.dg_OPD.AllowUserToAddRows = False
        Me.dg_OPD.AllowUserToDeleteRows = False
        Me.dg_OPD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_OPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_OPD.Location = New System.Drawing.Point(29, 267)
        Me.dg_OPD.Name = "dg_OPD"
        Me.dg_OPD.ReadOnly = True
        Me.dg_OPD.RowHeadersVisible = False
        Me.dg_OPD.Size = New System.Drawing.Size(798, 223)
        Me.dg_OPD.TabIndex = 10
        Me.dg_OPD.TabStop = False
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(55, 499)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(772, 20)
        Me.mcari.TabIndex = 11
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(25, 502)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 107
        Me.L11.Text = "cari"
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(29, 206)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 6
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(151, 206)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 7
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(273, 206)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 8
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(708, 206)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 9
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Kode Fungsi"
        '
        'mKode_Fungsi
        '
        Me.mKode_Fungsi.BackColor = System.Drawing.Color.White
        Me.mKode_Fungsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Fungsi.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Fungsi.Location = New System.Drawing.Point(138, 113)
        Me.mKode_Fungsi.Mask = "##"
        Me.mKode_Fungsi.Name = "mKode_Fungsi"
        Me.mKode_Fungsi.ReadOnly = True
        Me.mKode_Fungsi.Size = New System.Drawing.Size(20, 20)
        Me.mKode_Fungsi.TabIndex = 4
        Me.mKode_Fungsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Nama Fungsi"
        '
        'mNama_Fungsi
        '
        Me.mNama_Fungsi.BackColor = System.Drawing.Color.White
        Me.mNama_Fungsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Fungsi.Location = New System.Drawing.Point(138, 138)
        Me.mNama_Fungsi.MaxLength = 100
        Me.mNama_Fungsi.Name = "mNama_Fungsi"
        Me.mNama_Fungsi.ReadOnly = True
        Me.mNama_Fungsi.Size = New System.Drawing.Size(689, 20)
        Me.mNama_Fungsi.TabIndex = 5
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(164, 110)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 108
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(138, 168)
        Me.mKode_Dokumen.MaxLength = 50
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(311, 20)
        Me.mKode_Dokumen.TabIndex = 323
        '
        'tblPreviewDokumen
        '
        Me.tblPreviewDokumen.BackColor = System.Drawing.Color.Transparent
        Me.tblPreviewDokumen.FlatAppearance.BorderSize = 0
        Me.tblPreviewDokumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblPreviewDokumen.Image = Global.eParameter.My.Resources.Resources.preview
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(476, 168)
        Me.tblPreviewDokumen.Name = "tblPreviewDokumen"
        Me.tblPreviewDokumen.Size = New System.Drawing.Size(20, 19)
        Me.tblPreviewDokumen.TabIndex = 321
        Me.tblPreviewDokumen.UseVisualStyleBackColor = False
        '
        'tblCariDokumen_Pendukung
        '
        Me.tblCariDokumen_Pendukung.BackColor = System.Drawing.Color.Transparent
        Me.tblCariDokumen_Pendukung.FlatAppearance.BorderSize = 0
        Me.tblCariDokumen_Pendukung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCariDokumen_Pendukung.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(455, 169)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 322
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 324
        Me.Label7.Text = "Dokumen Pendukung"
        '
        'mNama_Bidang
        '
        Me.mNama_Bidang.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Bidang.Enabled = False
        Me.mNama_Bidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Bidang.Location = New System.Drawing.Point(196, 34)
        Me.mNama_Bidang.MaxLength = 100
        Me.mNama_Bidang.Name = "mNama_Bidang"
        Me.mNama_Bidang.Size = New System.Drawing.Size(599, 20)
        Me.mNama_Bidang.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Button1.Location = New System.Drawing.Point(797, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 108
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Kode OPD"
        '
        'cPar_OPD_3OPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 524)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.dg_OPD)
        Me.Controls.Add(Me.mNama_Fungsi)
        Me.Controls.Add(Me.mNama_Bidang)
        Me.Controls.Add(Me.mNama_OPD)
        Me.Controls.Add(Me.mKode_OPD)
        Me.Controls.Add(Me.mKode_Bidang)
        Me.Controls.Add(Me.mKode_Fungsi)
        Me.Controls.Add(Me.mKode_Urusan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cPar_OPD_3OPD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organisasi Perangkat Daerah"
        CType(Me.dg_OPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mKode_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Bidang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Urusan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mNama_OPD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg_OPD As System.Windows.Forms.DataGridView
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mKode_Fungsi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mNama_Fungsi As System.Windows.Forms.TextBox
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents mNama_Bidang As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
