<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d0Tr_Tim_Anggaran
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
        Me.mcari = New System.Windows.Forms.TextBox()
        Me.L11 = New System.Windows.Forms.Label()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.mTahun = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rd_Anggaran = New System.Windows.Forms.RadioButton()
        Me.rd_Verifikasi = New System.Windows.Forms.RadioButton()
        Me.Rd_Asistensi = New System.Windows.Forms.RadioButton()
        Me.mNo_Urut = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mNama = New System.Windows.Forms.TextBox()
        Me.mPangkat = New System.Windows.Forms.TextBox()
        Me.mGol = New System.Windows.Forms.TextBox()
        Me.mNIP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mNo_Urut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(51, 436)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(733, 20)
        Me.mcari.TabIndex = 16
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(21, 439)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 281
        Me.L11.Text = "cari"
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(24, 234)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 11
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(146, 234)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 12
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(268, 234)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 13
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(664, 234)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 14
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'dg_TampilData
        '
        Me.dg_TampilData.AllowUserToAddRows = False
        Me.dg_TampilData.AllowUserToDeleteRows = False
        Me.dg_TampilData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_TampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_TampilData.Location = New System.Drawing.Point(21, 273)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(759, 157)
        Me.dg_TampilData.TabIndex = 15
        Me.dg_TampilData.TabStop = False
        '
        'mTahun
        '
        Me.mTahun.FormattingEnabled = True
        Me.mTahun.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.mTahun.Location = New System.Drawing.Point(112, 23)
        Me.mTahun.Name = "mTahun"
        Me.mTahun.Size = New System.Drawing.Size(62, 21)
        Me.mTahun.TabIndex = 0
        Me.mTahun.Text = "2019"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 314
        Me.Label9.Text = "tahun anggaran"
        '
        'rd_Anggaran
        '
        Me.rd_Anggaran.AutoSize = True
        Me.rd_Anggaran.Checked = True
        Me.rd_Anggaran.Location = New System.Drawing.Point(112, 50)
        Me.rd_Anggaran.Name = "rd_Anggaran"
        Me.rd_Anggaran.Size = New System.Drawing.Size(91, 17)
        Me.rd_Anggaran.TabIndex = 1
        Me.rd_Anggaran.TabStop = True
        Me.rd_Anggaran.Text = "Tim Anggaran"
        Me.rd_Anggaran.UseVisualStyleBackColor = True
        '
        'rd_Verifikasi
        '
        Me.rd_Verifikasi.AutoSize = True
        Me.rd_Verifikasi.Location = New System.Drawing.Point(209, 50)
        Me.rd_Verifikasi.Name = "rd_Verifikasi"
        Me.rd_Verifikasi.Size = New System.Drawing.Size(136, 17)
        Me.rd_Verifikasi.TabIndex = 2
        Me.rd_Verifikasi.Text = "Tim Verifikasi Anggaran"
        Me.rd_Verifikasi.UseVisualStyleBackColor = True
        '
        'Rd_Asistensi
        '
        Me.Rd_Asistensi.AutoSize = True
        Me.Rd_Asistensi.Location = New System.Drawing.Point(351, 50)
        Me.Rd_Asistensi.Name = "Rd_Asistensi"
        Me.Rd_Asistensi.Size = New System.Drawing.Size(86, 17)
        Me.Rd_Asistensi.TabIndex = 3
        Me.Rd_Asistensi.Text = "Tim Asistensi"
        Me.Rd_Asistensi.UseVisualStyleBackColor = True
        '
        'mNo_Urut
        '
        Me.mNo_Urut.Location = New System.Drawing.Point(112, 73)
        Me.mNo_Urut.Maximum = New Decimal(New Integer() {34, 0, 0, 0})
        Me.mNo_Urut.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.mNo_Urut.Name = "mNo_Urut"
        Me.mNo_Urut.Size = New System.Drawing.Size(39, 20)
        Me.mNo_Urut.TabIndex = 4
        Me.mNo_Urut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mNo_Urut.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 322
        Me.Label6.Text = "Nomor Urut"
        '
        'mNama
        '
        Me.mNama.Location = New System.Drawing.Point(112, 123)
        Me.mNama.MaxLength = 50
        Me.mNama.Name = "mNama"
        Me.mNama.Size = New System.Drawing.Size(377, 20)
        Me.mNama.TabIndex = 7
        '
        'mPangkat
        '
        Me.mPangkat.Location = New System.Drawing.Point(189, 146)
        Me.mPangkat.MaxLength = 25
        Me.mPangkat.Name = "mPangkat"
        Me.mPangkat.Size = New System.Drawing.Size(151, 20)
        Me.mPangkat.TabIndex = 9
        '
        'mGol
        '
        Me.mGol.Location = New System.Drawing.Point(112, 146)
        Me.mGol.MaxLength = 5
        Me.mGol.Name = "mGol"
        Me.mGol.Size = New System.Drawing.Size(65, 20)
        Me.mGol.TabIndex = 8
        '
        'mNIP
        '
        Me.mNIP.Location = New System.Drawing.Point(112, 99)
        Me.mNIP.Name = "mNIP"
        Me.mNIP.Size = New System.Drawing.Size(264, 20)
        Me.mNIP.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Button1.Location = New System.Drawing.Point(382, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(178, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 330
        Me.Label8.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 331
        Me.Label3.Text = "Gol/Pangkat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 328
        Me.Label2.Text = "Jabatan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 172)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(663, 20)
        Me.TextBox1.TabIndex = 10
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(112, 198)
        Me.mKode_Dokumen.MaxLength = 50
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(311, 20)
        Me.mKode_Dokumen.TabIndex = 354
        '
        'tblPreviewDokumen
        '
        Me.tblPreviewDokumen.BackColor = System.Drawing.Color.Transparent
        Me.tblPreviewDokumen.FlatAppearance.BorderSize = 0
        Me.tblPreviewDokumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblPreviewDokumen.Image = Global.eParameter.My.Resources.Resources.preview
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(450, 198)
        Me.tblPreviewDokumen.Name = "tblPreviewDokumen"
        Me.tblPreviewDokumen.Size = New System.Drawing.Size(20, 19)
        Me.tblPreviewDokumen.TabIndex = 352
        Me.tblPreviewDokumen.UseVisualStyleBackColor = False
        '
        'tblCariDokumen_Pendukung
        '
        Me.tblCariDokumen_Pendukung.BackColor = System.Drawing.Color.Transparent
        Me.tblCariDokumen_Pendukung.FlatAppearance.BorderSize = 0
        Me.tblCariDokumen_Pendukung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCariDokumen_Pendukung.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(429, 199)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 353
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(28, 201)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(78, 32)
        Me.Label36.TabIndex = 355
        Me.Label36.Text = "Dokumen Pendukung"
        '
        'd0Tr_Tim_Anggaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 463)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.mNama)
        Me.Controls.Add(Me.mPangkat)
        Me.Controls.Add(Me.mGol)
        Me.Controls.Add(Me.mNIP)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNo_Urut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Rd_Asistensi)
        Me.Controls.Add(Me.rd_Verifikasi)
        Me.Controls.Add(Me.rd_Anggaran)
        Me.Controls.Add(Me.mTahun)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d0Tr_Tim_Anggaran"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tim Anggaran Pemerintah Daerah (TAPD)"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mNo_Urut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
    Friend WithEvents mTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rd_Anggaran As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Verifikasi As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Asistensi As System.Windows.Forms.RadioButton
    Friend WithEvents mNo_Urut As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mNama As System.Windows.Forms.TextBox
    Friend WithEvents mPangkat As System.Windows.Forms.TextBox
    Friend WithEvents mGol As System.Windows.Forms.TextBox
    Friend WithEvents mNIP As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label36 As Label
End Class
