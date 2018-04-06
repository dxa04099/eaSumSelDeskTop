<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d0Tr_OPD_DataUmum
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
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.mNama_Sub_OPD = New System.Windows.Forms.TextBox()
        Me.mKode_Sub_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Bidang = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Urusan = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mNip_Pimpinan = New System.Windows.Forms.TextBox()
        Me.mNama_Pimpinan = New System.Windows.Forms.TextBox()
        Me.mGol = New System.Windows.Forms.TextBox()
        Me.mPangkat = New System.Windows.Forms.TextBox()
        Me.mJabatan_Pimpinan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mAlamat = New System.Windows.Forms.TextBox()
        Me.mUr_Visi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbCari02 = New System.Windows.Forms.Button()
        Me.mTahun = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(43, 591)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(733, 20)
        Me.mcari.TabIndex = 18
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(13, 594)
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
        Me.tblBaru.Location = New System.Drawing.Point(20, 389)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 13
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(142, 389)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 14
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(264, 389)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 15
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(660, 389)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 16
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
        Me.dg_TampilData.Location = New System.Drawing.Point(17, 428)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(759, 157)
        Me.dg_TampilData.TabIndex = 17
        Me.dg_TampilData.TabStop = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(236, 21)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 4
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'mNama_Sub_OPD
        '
        Me.mNama_Sub_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mNama_Sub_OPD.Enabled = False
        Me.mNama_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Sub_OPD.Location = New System.Drawing.Point(116, 48)
        Me.mNama_Sub_OPD.MaxLength = 100
        Me.mNama_Sub_OPD.Name = "mNama_Sub_OPD"
        Me.mNama_Sub_OPD.Size = New System.Drawing.Size(660, 20)
        Me.mNama_Sub_OPD.TabIndex = 5
        '
        'mKode_Sub_OPD
        '
        Me.mKode_Sub_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Sub_OPD.Enabled = False
        Me.mKode_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_OPD.Location = New System.Drawing.Point(199, 24)
        Me.mKode_Sub_OPD.Mask = "##"
        Me.mKode_Sub_OPD.Name = "mKode_Sub_OPD"
        Me.mKode_Sub_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Sub_OPD.TabIndex = 3
        Me.mKode_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_OPD
        '
        Me.mKode_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_OPD.Enabled = False
        Me.mKode_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_OPD.Location = New System.Drawing.Point(167, 24)
        Me.mKode_OPD.Mask = "##"
        Me.mKode_OPD.Name = "mKode_OPD"
        Me.mKode_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_OPD.TabIndex = 2
        Me.mKode_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Bidang
        '
        Me.mKode_Bidang.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Bidang.Enabled = False
        Me.mKode_Bidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Bidang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Bidang.Location = New System.Drawing.Point(137, 24)
        Me.mKode_Bidang.Mask = "##"
        Me.mKode_Bidang.Name = "mKode_Bidang"
        Me.mKode_Bidang.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Bidang.TabIndex = 1
        Me.mKode_Bidang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Urusan
        '
        Me.mKode_Urusan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Urusan.Enabled = False
        Me.mKode_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Urusan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Urusan.Location = New System.Drawing.Point(116, 24)
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
        Me.Label14.Location = New System.Drawing.Point(31, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 291
        Me.Label14.Text = "OPD"
        '
        'mNip_Pimpinan
        '
        Me.mNip_Pimpinan.Location = New System.Drawing.Point(116, 241)
        Me.mNip_Pimpinan.Name = "mNip_Pimpinan"
        Me.mNip_Pimpinan.Size = New System.Drawing.Size(264, 20)
        Me.mNip_Pimpinan.TabIndex = 8
        '
        'mNama_Pimpinan
        '
        Me.mNama_Pimpinan.Location = New System.Drawing.Point(116, 265)
        Me.mNama_Pimpinan.MaxLength = 50
        Me.mNama_Pimpinan.Name = "mNama_Pimpinan"
        Me.mNama_Pimpinan.Size = New System.Drawing.Size(377, 20)
        Me.mNama_Pimpinan.TabIndex = 9
        '
        'mGol
        '
        Me.mGol.Location = New System.Drawing.Point(116, 288)
        Me.mGol.MaxLength = 5
        Me.mGol.Name = "mGol"
        Me.mGol.Size = New System.Drawing.Size(65, 20)
        Me.mGol.TabIndex = 10
        '
        'mPangkat
        '
        Me.mPangkat.Location = New System.Drawing.Point(193, 288)
        Me.mPangkat.MaxLength = 25
        Me.mPangkat.Name = "mPangkat"
        Me.mPangkat.Size = New System.Drawing.Size(151, 20)
        Me.mPangkat.TabIndex = 11
        '
        'mJabatan_Pimpinan
        '
        Me.mJabatan_Pimpinan.Location = New System.Drawing.Point(116, 312)
        Me.mJabatan_Pimpinan.MaxLength = 75
        Me.mJabatan_Pimpinan.Name = "mJabatan_Pimpinan"
        Me.mJabatan_Pimpinan.Size = New System.Drawing.Size(584, 20)
        Me.mJabatan_Pimpinan.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 291
        Me.Label1.Text = "NIP"
        '
        'mAlamat
        '
        Me.mAlamat.Location = New System.Drawing.Point(116, 105)
        Me.mAlamat.Multiline = True
        Me.mAlamat.Name = "mAlamat"
        Me.mAlamat.Size = New System.Drawing.Size(660, 52)
        Me.mAlamat.TabIndex = 6
        '
        'mUr_Visi
        '
        Me.mUr_Visi.Location = New System.Drawing.Point(116, 161)
        Me.mUr_Visi.Multiline = True
        Me.mUr_Visi.Name = "mUr_Visi"
        Me.mUr_Visi.Size = New System.Drawing.Size(660, 52)
        Me.mUr_Visi.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 291
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "Gol/Pangkat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 291
        Me.Label4.Text = "Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 291
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 291
        Me.Label6.Text = "Visi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 291
        Me.Label7.Text = "Data Pimpinan :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(182, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 291
        Me.Label8.Text = "/"
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(386, 239)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 4
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'mTahun
        '
        Me.mTahun.FormattingEnabled = True
        Me.mTahun.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.mTahun.Location = New System.Drawing.Point(116, 74)
        Me.mTahun.Name = "mTahun"
        Me.mTahun.Size = New System.Drawing.Size(62, 21)
        Me.mTahun.TabIndex = 5
        Me.mTahun.Text = "2019"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 292
        Me.Label9.Text = "tahun anggaran"
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(116, 342)
        Me.mKode_Dokumen.MaxLength = 50
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(311, 20)
        Me.mKode_Dokumen.TabIndex = 350
        '
        'tblPreviewDokumen
        '
        Me.tblPreviewDokumen.BackColor = System.Drawing.Color.Transparent
        Me.tblPreviewDokumen.FlatAppearance.BorderSize = 0
        Me.tblPreviewDokumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblPreviewDokumen.Image = Global.eParameter.My.Resources.Resources.preview
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(454, 342)
        Me.tblPreviewDokumen.Name = "tblPreviewDokumen"
        Me.tblPreviewDokumen.Size = New System.Drawing.Size(20, 19)
        Me.tblPreviewDokumen.TabIndex = 348
        Me.tblPreviewDokumen.UseVisualStyleBackColor = False
        '
        'tblCariDokumen_Pendukung
        '
        Me.tblCariDokumen_Pendukung.BackColor = System.Drawing.Color.Transparent
        Me.tblCariDokumen_Pendukung.FlatAppearance.BorderSize = 0
        Me.tblCariDokumen_Pendukung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCariDokumen_Pendukung.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(433, 343)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 349
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(31, 348)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(79, 38)
        Me.Label36.TabIndex = 351
        Me.Label36.Text = "Dokumen Pendukung"
        '
        'd0Tr_OPD_DataUmum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 633)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.mTahun)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mUr_Visi)
        Me.Controls.Add(Me.mAlamat)
        Me.Controls.Add(Me.mJabatan_Pimpinan)
        Me.Controls.Add(Me.mNama_Pimpinan)
        Me.Controls.Add(Me.mPangkat)
        Me.Controls.Add(Me.mGol)
        Me.Controls.Add(Me.mNip_Pimpinan)
        Me.Controls.Add(Me.tbCari02)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.mNama_Sub_OPD)
        Me.Controls.Add(Me.mKode_Sub_OPD)
        Me.Controls.Add(Me.mKode_OPD)
        Me.Controls.Add(Me.mKode_Bidang)
        Me.Controls.Add(Me.mKode_Urusan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "d0Tr_OPD_DataUmum"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Umum OPD"
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
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents mNama_Sub_OPD As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Sub_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Bidang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Urusan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mNip_Pimpinan As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Pimpinan As System.Windows.Forms.TextBox
    Friend WithEvents mGol As System.Windows.Forms.TextBox
    Friend WithEvents mPangkat As System.Windows.Forms.TextBox
    Friend WithEvents mJabatan_Pimpinan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mAlamat As System.Windows.Forms.TextBox
    Friend WithEvents mUr_Visi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents mTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label36 As Label
End Class
