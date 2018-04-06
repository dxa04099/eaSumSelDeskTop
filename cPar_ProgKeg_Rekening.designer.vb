<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_ProgKeg_Rekening
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
        Me.tbCari02 = New System.Windows.Forms.Button()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.mNama_Kegiatan = New System.Windows.Forms.TextBox()
        Me.mNama_Program = New System.Windows.Forms.TextBox()
        Me.mNama_Urusan = New System.Windows.Forms.TextBox()
        Me.mKd_Keg = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Prog = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Bidang_Program = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mKd_Urusan_Program = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mNama_Rek_Rincian_Objek = New System.Windows.Forms.TextBox()
        Me.mRek_Rincian_Objek = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Objek = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Jenis = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Kelompok = New System.Windows.Forms.MaskedTextBox()
        Me.mRek_Pos = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(47, 535)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(733, 20)
        Me.mcari.TabIndex = 22
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(17, 538)
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
        Me.tblBaru.Location = New System.Drawing.Point(24, 333)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 17
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(146, 333)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 18
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(268, 333)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 19
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(664, 333)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 20
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
        Me.dg_TampilData.Location = New System.Drawing.Point(21, 372)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(759, 157)
        Me.dg_TampilData.TabIndex = 21
        Me.dg_TampilData.TabStop = False
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(170, 78)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 5
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(170, 25)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 2
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'mNama_Kegiatan
        '
        Me.mNama_Kegiatan.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Kegiatan.Enabled = False
        Me.mNama_Kegiatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Kegiatan.Location = New System.Drawing.Point(110, 180)
        Me.mNama_Kegiatan.MaxLength = 255
        Me.mNama_Kegiatan.Multiline = True
        Me.mNama_Kegiatan.Name = "mNama_Kegiatan"
        Me.mNama_Kegiatan.Size = New System.Drawing.Size(648, 42)
        Me.mNama_Kegiatan.TabIndex = 9
        '
        'mNama_Program
        '
        Me.mNama_Program.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Program.Enabled = False
        Me.mNama_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Program.Location = New System.Drawing.Point(112, 106)
        Me.mNama_Program.MaxLength = 255
        Me.mNama_Program.Multiline = True
        Me.mNama_Program.Name = "mNama_Program"
        Me.mNama_Program.Size = New System.Drawing.Size(648, 42)
        Me.mNama_Program.TabIndex = 6
        '
        'mNama_Urusan
        '
        Me.mNama_Urusan.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Urusan.Enabled = False
        Me.mNama_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Urusan.Location = New System.Drawing.Point(112, 54)
        Me.mNama_Urusan.MaxLength = 50
        Me.mNama_Urusan.Name = "mNama_Urusan"
        Me.mNama_Urusan.Size = New System.Drawing.Size(498, 20)
        Me.mNama_Urusan.TabIndex = 3
        '
        'mKd_Keg
        '
        Me.mKd_Keg.BackColor = System.Drawing.SystemColors.Menu
        Me.mKd_Keg.Enabled = False
        Me.mKd_Keg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Keg.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Keg.Location = New System.Drawing.Point(110, 154)
        Me.mKd_Keg.Mask = "###"
        Me.mKd_Keg.Name = "mKd_Keg"
        Me.mKd_Keg.Size = New System.Drawing.Size(37, 20)
        Me.mKd_Keg.TabIndex = 7
        Me.mKd_Keg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKd_Prog
        '
        Me.mKd_Prog.BackColor = System.Drawing.SystemColors.Menu
        Me.mKd_Prog.Enabled = False
        Me.mKd_Prog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Prog.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Prog.Location = New System.Drawing.Point(112, 80)
        Me.mKd_Prog.Mask = "###"
        Me.mKd_Prog.Name = "mKd_Prog"
        Me.mKd_Prog.Size = New System.Drawing.Size(37, 20)
        Me.mKd_Prog.TabIndex = 4
        Me.mKd_Prog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKd_Bidang_Program
        '
        Me.mKd_Bidang_Program.BackColor = System.Drawing.SystemColors.Menu
        Me.mKd_Bidang_Program.Enabled = False
        Me.mKd_Bidang_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Bidang_Program.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Bidang_Program.Location = New System.Drawing.Point(134, 28)
        Me.mKd_Bidang_Program.Mask = "##"
        Me.mKd_Bidang_Program.Name = "mKd_Bidang_Program"
        Me.mKd_Bidang_Program.Size = New System.Drawing.Size(30, 20)
        Me.mKd_Bidang_Program.TabIndex = 1
        Me.mKd_Bidang_Program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 307
        Me.Label4.Text = "Kode Kegiatan"
        '
        'mKd_Urusan_Program
        '
        Me.mKd_Urusan_Program.BackColor = System.Drawing.SystemColors.Menu
        Me.mKd_Urusan_Program.Enabled = False
        Me.mKd_Urusan_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Urusan_Program.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Urusan_Program.Location = New System.Drawing.Point(112, 28)
        Me.mKd_Urusan_Program.Mask = "#"
        Me.mKd_Urusan_Program.Name = "mKd_Urusan_Program"
        Me.mKd_Urusan_Program.Size = New System.Drawing.Size(20, 20)
        Me.mKd_Urusan_Program.TabIndex = 0
        Me.mKd_Urusan_Program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 304
        Me.Label3.Text = "Nama Kegiatna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Kode Program"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 305
        Me.Label1.Text = "Nama Program"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 308
        Me.Label14.Text = "Urusan"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Button1.Location = New System.Drawing.Point(170, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Button2.Location = New System.Drawing.Point(299, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(26, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 316
        Me.Label5.Text = "Rekening Rincian Objek"
        '
        'mNama_Rek_Rincian_Objek
        '
        Me.mNama_Rek_Rincian_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Rek_Rincian_Objek.Enabled = False
        Me.mNama_Rek_Rincian_Objek.Location = New System.Drawing.Point(161, 260)
        Me.mNama_Rek_Rincian_Objek.MaxLength = 100
        Me.mNama_Rek_Rincian_Objek.Name = "mNama_Rek_Rincian_Objek"
        Me.mNama_Rek_Rincian_Objek.Size = New System.Drawing.Size(597, 20)
        Me.mNama_Rek_Rincian_Objek.TabIndex = 16
        '
        'mRek_Rincian_Objek
        '
        Me.mRek_Rincian_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Rincian_Objek.Enabled = False
        Me.mRek_Rincian_Objek.Location = New System.Drawing.Point(265, 234)
        Me.mRek_Rincian_Objek.Mask = "##"
        Me.mRek_Rincian_Objek.Name = "mRek_Rincian_Objek"
        Me.mRek_Rincian_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Rincian_Objek.TabIndex = 14
        Me.mRek_Rincian_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Objek
        '
        Me.mRek_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Objek.Enabled = False
        Me.mRek_Objek.Location = New System.Drawing.Point(235, 234)
        Me.mRek_Objek.Mask = "##"
        Me.mRek_Objek.Name = "mRek_Objek"
        Me.mRek_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Objek.TabIndex = 13
        Me.mRek_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Jenis
        '
        Me.mRek_Jenis.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Jenis.Enabled = False
        Me.mRek_Jenis.Location = New System.Drawing.Point(205, 234)
        Me.mRek_Jenis.Mask = "#"
        Me.mRek_Jenis.Name = "mRek_Jenis"
        Me.mRek_Jenis.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Jenis.TabIndex = 12
        Me.mRek_Jenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Kelompok
        '
        Me.mRek_Kelompok.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Kelompok.Enabled = False
        Me.mRek_Kelompok.Location = New System.Drawing.Point(183, 234)
        Me.mRek_Kelompok.Mask = "#"
        Me.mRek_Kelompok.Name = "mRek_Kelompok"
        Me.mRek_Kelompok.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Kelompok.TabIndex = 11
        Me.mRek_Kelompok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Pos
        '
        Me.mRek_Pos.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Pos.Enabled = False
        Me.mRek_Pos.Location = New System.Drawing.Point(161, 234)
        Me.mRek_Pos.Mask = "#"
        Me.mRek_Pos.Name = "mRek_Pos"
        Me.mRek_Pos.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Pos.TabIndex = 10
        Me.mRek_Pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(161, 296)
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
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(499, 296)
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
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(478, 297)
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
        Me.Label7.Location = New System.Drawing.Point(29, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 324
        Me.Label7.Text = "Dokumen Pendukung"
        '
        'cPar_ProgKeg_Rekening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mNama_Rek_Rincian_Objek)
        Me.Controls.Add(Me.mRek_Rincian_Objek)
        Me.Controls.Add(Me.mRek_Objek)
        Me.Controls.Add(Me.mRek_Jenis)
        Me.Controls.Add(Me.mRek_Kelompok)
        Me.Controls.Add(Me.mRek_Pos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCari02)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.mNama_Kegiatan)
        Me.Controls.Add(Me.mNama_Program)
        Me.Controls.Add(Me.mNama_Urusan)
        Me.Controls.Add(Me.mKd_Keg)
        Me.Controls.Add(Me.mKd_Prog)
        Me.Controls.Add(Me.mKd_Bidang_Program)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mKd_Urusan_Program)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
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
        Me.Name = "cPar_ProgKeg_Rekening"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Komposisi Rekening Kegiatan"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents mNama_Kegiatan As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Program As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Urusan As System.Windows.Forms.TextBox
    Friend WithEvents mKd_Keg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKd_Prog As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKd_Bidang_Program As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mKd_Urusan_Program As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mNama_Rek_Rincian_Objek As System.Windows.Forms.TextBox
    Friend WithEvents mRek_Rincian_Objek As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Objek As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Jenis As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Kelompok As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Pos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label7 As Label
End Class
