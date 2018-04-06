<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_RekAPBD_6
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
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mNama_Rek_Rincian_Objek_Kd_1 = New System.Windows.Forms.TextBox()
        Me.mNama_Rek_Rincian_Objek = New System.Windows.Forms.TextBox()
        Me.mRek_Rincian_Objek = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Objek = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Jenis = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Kelompok = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Pos = New System.Windows.Forms.MaskedTextBox()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mKode_Provinsi = New System.Windows.Forms.MaskedTextBox()
        Me.mNama_Provinsi = New System.Windows.Forms.TextBox()
        Me.mKode_KabKota = New System.Windows.Forms.MaskedTextBox()
        Me.mNama_KabKota = New System.Windows.Forms.TextBox()
        Me.tbCari02 = New System.Windows.Forms.Button()
        Me.tbCari03 = New System.Windows.Forms.Button()
        Me.mRek_Rincian_Objek_kd_1 = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(47, 571)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(733, 20)
        Me.mcari.TabIndex = 20
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(17, 574)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 214
        Me.L11.Text = "cari"
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(340, 22)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 5
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(41, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "Rekening Rincian Objek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(41, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "Nama Uraian Rincian Objek"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(41, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "Kode Uraian Rincian Objek"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(41, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Kode Rekening Rincian Objek"
        '
        'mNama_Rek_Rincian_Objek_Kd_1
        '
        Me.mNama_Rek_Rincian_Objek_Kd_1.BackColor = System.Drawing.Color.White
        Me.mNama_Rek_Rincian_Objek_Kd_1.Location = New System.Drawing.Point(202, 168)
        Me.mNama_Rek_Rincian_Objek_Kd_1.MaxLength = 50
        Me.mNama_Rek_Rincian_Objek_Kd_1.Name = "mNama_Rek_Rincian_Objek_Kd_1"
        Me.mNama_Rek_Rincian_Objek_Kd_1.Size = New System.Drawing.Size(578, 20)
        Me.mNama_Rek_Rincian_Objek_Kd_1.TabIndex = 14
        '
        'mNama_Rek_Rincian_Objek
        '
        Me.mNama_Rek_Rincian_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Rek_Rincian_Objek.Enabled = False
        Me.mNama_Rek_Rincian_Objek.Location = New System.Drawing.Point(202, 50)
        Me.mNama_Rek_Rincian_Objek.MaxLength = 100
        Me.mNama_Rek_Rincian_Objek.Name = "mNama_Rek_Rincian_Objek"
        Me.mNama_Rek_Rincian_Objek.Size = New System.Drawing.Size(578, 20)
        Me.mNama_Rek_Rincian_Objek.TabIndex = 6
        '
        'mRek_Rincian_Objek
        '
        Me.mRek_Rincian_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Rincian_Objek.Enabled = False
        Me.mRek_Rincian_Objek.Location = New System.Drawing.Point(306, 24)
        Me.mRek_Rincian_Objek.Mask = "##"
        Me.mRek_Rincian_Objek.Name = "mRek_Rincian_Objek"
        Me.mRek_Rincian_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Rincian_Objek.TabIndex = 4
        Me.mRek_Rincian_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Objek
        '
        Me.mRek_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Objek.Enabled = False
        Me.mRek_Objek.Location = New System.Drawing.Point(276, 24)
        Me.mRek_Objek.Mask = "##"
        Me.mRek_Objek.Name = "mRek_Objek"
        Me.mRek_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Objek.TabIndex = 3
        Me.mRek_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Jenis
        '
        Me.mRek_Jenis.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Jenis.Enabled = False
        Me.mRek_Jenis.Location = New System.Drawing.Point(246, 24)
        Me.mRek_Jenis.Mask = "#"
        Me.mRek_Jenis.Name = "mRek_Jenis"
        Me.mRek_Jenis.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Jenis.TabIndex = 2
        Me.mRek_Jenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Kelompok
        '
        Me.mRek_Kelompok.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Kelompok.Enabled = False
        Me.mRek_Kelompok.Location = New System.Drawing.Point(224, 24)
        Me.mRek_Kelompok.Mask = "#"
        Me.mRek_Kelompok.Name = "mRek_Kelompok"
        Me.mRek_Kelompok.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Kelompok.TabIndex = 1
        Me.mRek_Kelompok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Pos
        '
        Me.mRek_Pos.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Pos.Enabled = False
        Me.mRek_Pos.Location = New System.Drawing.Point(202, 24)
        Me.mRek_Pos.Mask = "#"
        Me.mRek_Pos.Name = "mRek_Pos"
        Me.mRek_Pos.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Pos.TabIndex = 0
        Me.mRek_Pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(21, 238)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 15
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(143, 238)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 16
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(265, 238)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 17
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(661, 238)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 18
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
        Me.dg_TampilData.Location = New System.Drawing.Point(21, 277)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(759, 286)
        Me.dg_TampilData.TabIndex = 19
        Me.dg_TampilData.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(44, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "Provinsi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(44, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "Kabupaten/Kota"
        '
        'mKode_Provinsi
        '
        Me.mKode_Provinsi.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Provinsi.Enabled = False
        Me.mKode_Provinsi.Location = New System.Drawing.Point(202, 79)
        Me.mKode_Provinsi.Mask = "##"
        Me.mKode_Provinsi.Name = "mKode_Provinsi"
        Me.mKode_Provinsi.Size = New System.Drawing.Size(28, 20)
        Me.mKode_Provinsi.TabIndex = 7
        Me.mKode_Provinsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNama_Provinsi
        '
        Me.mNama_Provinsi.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Provinsi.Enabled = False
        Me.mNama_Provinsi.Location = New System.Drawing.Point(233, 79)
        Me.mNama_Provinsi.MaxLength = 50
        Me.mNama_Provinsi.Name = "mNama_Provinsi"
        Me.mNama_Provinsi.Size = New System.Drawing.Size(511, 20)
        Me.mNama_Provinsi.TabIndex = 8
        '
        'mKode_KabKota
        '
        Me.mKode_KabKota.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_KabKota.Enabled = False
        Me.mKode_KabKota.Location = New System.Drawing.Point(202, 103)
        Me.mKode_KabKota.Mask = "##"
        Me.mKode_KabKota.Name = "mKode_KabKota"
        Me.mKode_KabKota.Size = New System.Drawing.Size(28, 20)
        Me.mKode_KabKota.TabIndex = 10
        Me.mKode_KabKota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNama_KabKota
        '
        Me.mNama_KabKota.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_KabKota.Enabled = False
        Me.mNama_KabKota.Location = New System.Drawing.Point(233, 103)
        Me.mNama_KabKota.MaxLength = 50
        Me.mNama_KabKota.Name = "mNama_KabKota"
        Me.mNama_KabKota.Size = New System.Drawing.Size(511, 20)
        Me.mNama_KabKota.TabIndex = 11
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(750, 77)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 9
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'tbCari03
        '
        Me.tbCari03.BackColor = System.Drawing.Color.Transparent
        Me.tbCari03.FlatAppearance.BorderSize = 0
        Me.tbCari03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari03.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari03.Location = New System.Drawing.Point(750, 102)
        Me.tbCari03.Name = "tbCari03"
        Me.tbCari03.Size = New System.Drawing.Size(30, 23)
        Me.tbCari03.TabIndex = 12
        Me.tbCari03.UseVisualStyleBackColor = False
        '
        'mRek_Rincian_Objek_kd_1
        '
        Me.mRek_Rincian_Objek_kd_1.BackColor = System.Drawing.Color.White
        Me.mRek_Rincian_Objek_kd_1.Location = New System.Drawing.Point(202, 144)
        Me.mRek_Rincian_Objek_kd_1.Mask = "##"
        Me.mRek_Rincian_Objek_kd_1.Name = "mRek_Rincian_Objek_kd_1"
        Me.mRek_Rincian_Objek_kd_1.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Rincian_Objek_kd_1.TabIndex = 13
        Me.mRek_Rincian_Objek_kd_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(202, 194)
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
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(540, 194)
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
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(519, 195)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 322
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 324
        Me.Label5.Text = "Dokumen Pendukung"
        '
        'cPar_RekAPBD_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(796, 603)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tbCari03)
        Me.Controls.Add(Me.tbCari02)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNama_Rek_Rincian_Objek_Kd_1)
        Me.Controls.Add(Me.mNama_KabKota)
        Me.Controls.Add(Me.mNama_Provinsi)
        Me.Controls.Add(Me.mNama_Rek_Rincian_Objek)
        Me.Controls.Add(Me.mRek_Rincian_Objek_kd_1)
        Me.Controls.Add(Me.mKode_KabKota)
        Me.Controls.Add(Me.mKode_Provinsi)
        Me.Controls.Add(Me.mRek_Rincian_Objek)
        Me.Controls.Add(Me.mRek_Objek)
        Me.Controls.Add(Me.mRek_Jenis)
        Me.Controls.Add(Me.mRek_Kelompok)
        Me.Controls.Add(Me.mRek_Pos)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cPar_RekAPBD_6"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APBD-Uraian Rincian Objek"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mNama_Rek_Rincian_Objek_Kd_1 As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Rek_Rincian_Objek As System.Windows.Forms.TextBox
    Friend WithEvents mRek_Rincian_Objek As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Objek As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Jenis As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Kelompok As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Pos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mKode_Provinsi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNama_Provinsi As System.Windows.Forms.TextBox
    Friend WithEvents mKode_KabKota As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNama_KabKota As System.Windows.Forms.TextBox
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents tbCari03 As System.Windows.Forms.Button
    Friend WithEvents mRek_Rincian_Objek_kd_1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label5 As Label
End Class
