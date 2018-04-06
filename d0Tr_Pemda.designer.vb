<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d0Tr_Pemda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(d0Tr_Pemda))
        Me.tbl_Keluar = New System.Windows.Forms.Button
        Me.mthnAnggaran = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.mNama_Pemda = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mNama_PimpDaerah = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.mJabatan_PimpDa = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.mNama_Sekda = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.mNip_Sekda = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.mJabatan_Sekda = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.mNama_BUD = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.mNip_BUD = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.mJabatan_BUD = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.mNPWP_BUD = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.mIbukota = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.mAlamat = New System.Windows.Forms.TextBox
        Me.rd_aktif = New System.Windows.Forms.RadioButton
        Me.rd_Tidak_Aktif = New System.Windows.Forms.RadioButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.mNama_KelDesa = New System.Windows.Forms.TextBox
        Me.mNama_Kecamatan = New System.Windows.Forms.TextBox
        Me.mNama_KabKota = New System.Windows.Forms.TextBox
        Me.mNama_Provinsi = New System.Windows.Forms.TextBox
        Me.mKode_KelDesa = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Kecamatan = New System.Windows.Forms.MaskedTextBox
        Me.mKode_KabKota = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Provinsi = New System.Windows.Forms.MaskedTextBox
        Me.pb_Logo = New System.Windows.Forms.PictureBox
        Me.tbl_Browse = New System.Windows.Forms.Button
        Me.tblSimpan = New System.Windows.Forms.Button
        Me.tbCari01 = New System.Windows.Forms.Button
        Me.tbCari02 = New System.Windows.Forms.Button
        Me.tbCari03 = New System.Windows.Forms.Button
        Me.tbCari04 = New System.Windows.Forms.Button
        Me.mAlamatFile = New System.Windows.Forms.TextBox
        CType(Me.pb_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(725, 497)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 28
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'mthnAnggaran
        '
        Me.mthnAnggaran.FormattingEnabled = True
        Me.mthnAnggaran.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.mthnAnggaran.Location = New System.Drawing.Point(142, 26)
        Me.mthnAnggaran.Name = "mthnAnggaran"
        Me.mthnAnggaran.Size = New System.Drawing.Size(62, 21)
        Me.mthnAnggaran.TabIndex = 0
        Me.mthnAnggaran.Text = "2019"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 279
        Me.Label4.Text = "tahun anggaran"
        '
        'mNama_Pemda
        '
        Me.mNama_Pemda.Location = New System.Drawing.Point(142, 53)
        Me.mNama_Pemda.MaxLength = 100
        Me.mNama_Pemda.Name = "mNama_Pemda"
        Me.mNama_Pemda.Size = New System.Drawing.Size(588, 20)
        Me.mNama_Pemda.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 279
        Me.Label1.Text = "Nama Pemda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 279
        Me.Label2.Text = "Nama Pimpinan Daerah"
        '
        'mNama_PimpDaerah
        '
        Me.mNama_PimpDaerah.Location = New System.Drawing.Point(142, 79)
        Me.mNama_PimpDaerah.MaxLength = 100
        Me.mNama_PimpDaerah.Name = "mNama_PimpDaerah"
        Me.mNama_PimpDaerah.Size = New System.Drawing.Size(588, 20)
        Me.mNama_PimpDaerah.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Jabatan Pimpinan Daerah"
        '
        'mJabatan_PimpDa
        '
        Me.mJabatan_PimpDa.Location = New System.Drawing.Point(142, 105)
        Me.mJabatan_PimpDa.MaxLength = 50
        Me.mJabatan_PimpDa.Name = "mJabatan_PimpDa"
        Me.mJabatan_PimpDa.Size = New System.Drawing.Size(365, 20)
        Me.mJabatan_PimpDa.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Nama Sekretaris Daerah"
        '
        'mNama_Sekda
        '
        Me.mNama_Sekda.Location = New System.Drawing.Point(142, 131)
        Me.mNama_Sekda.MaxLength = 50
        Me.mNama_Sekda.Name = "mNama_Sekda"
        Me.mNama_Sekda.Size = New System.Drawing.Size(365, 20)
        Me.mNama_Sekda.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(27, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "NIP Sekretaris Daerah"
        '
        'mNip_Sekda
        '
        Me.mNip_Sekda.Location = New System.Drawing.Point(142, 157)
        Me.mNip_Sekda.MaxLength = 18
        Me.mNip_Sekda.Name = "mNip_Sekda"
        Me.mNip_Sekda.Size = New System.Drawing.Size(214, 20)
        Me.mNip_Sekda.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(27, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "Jabatan Sekretaris Daerah"
        '
        'mJabatan_Sekda
        '
        Me.mJabatan_Sekda.Location = New System.Drawing.Point(142, 183)
        Me.mJabatan_Sekda.MaxLength = 75
        Me.mJabatan_Sekda.Name = "mJabatan_Sekda"
        Me.mJabatan_Sekda.Size = New System.Drawing.Size(542, 20)
        Me.mJabatan_Sekda.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(27, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 279
        Me.Label8.Text = "Nama BUD"
        '
        'mNama_BUD
        '
        Me.mNama_BUD.Location = New System.Drawing.Point(142, 209)
        Me.mNama_BUD.Name = "mNama_BUD"
        Me.mNama_BUD.Size = New System.Drawing.Size(657, 20)
        Me.mNama_BUD.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(27, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 279
        Me.Label9.Text = "NIP BUD"
        '
        'mNip_BUD
        '
        Me.mNip_BUD.Location = New System.Drawing.Point(142, 235)
        Me.mNip_BUD.MaxLength = 18
        Me.mNip_BUD.Name = "mNip_BUD"
        Me.mNip_BUD.Size = New System.Drawing.Size(214, 20)
        Me.mNip_BUD.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(27, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 16)
        Me.Label10.TabIndex = 279
        Me.Label10.Text = "Jabatan BUD"
        '
        'mJabatan_BUD
        '
        Me.mJabatan_BUD.Location = New System.Drawing.Point(142, 261)
        Me.mJabatan_BUD.MaxLength = 75
        Me.mJabatan_BUD.Name = "mJabatan_BUD"
        Me.mJabatan_BUD.Size = New System.Drawing.Size(542, 20)
        Me.mJabatan_BUD.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(27, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 279
        Me.Label11.Text = "NPWP BUD"
        '
        'mNPWP_BUD
        '
        Me.mNPWP_BUD.Location = New System.Drawing.Point(142, 287)
        Me.mNPWP_BUD.MaxLength = 15
        Me.mNPWP_BUD.Name = "mNPWP_BUD"
        Me.mNPWP_BUD.Size = New System.Drawing.Size(214, 20)
        Me.mNPWP_BUD.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 279
        Me.Label12.Text = "Ibu Kota"
        '
        'mIbukota
        '
        Me.mIbukota.Location = New System.Drawing.Point(142, 313)
        Me.mIbukota.MaxLength = 50
        Me.mIbukota.Name = "mIbukota"
        Me.mIbukota.Size = New System.Drawing.Size(365, 20)
        Me.mIbukota.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(27, 340)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 279
        Me.Label13.Text = "Alamta"
        '
        'mAlamat
        '
        Me.mAlamat.Location = New System.Drawing.Point(142, 339)
        Me.mAlamat.MaxLength = 255
        Me.mAlamat.Multiline = True
        Me.mAlamat.Name = "mAlamat"
        Me.mAlamat.Size = New System.Drawing.Size(657, 38)
        Me.mAlamat.TabIndex = 14
        '
        'rd_aktif
        '
        Me.rd_aktif.AutoSize = True
        Me.rd_aktif.Location = New System.Drawing.Point(220, 28)
        Me.rd_aktif.Name = "rd_aktif"
        Me.rd_aktif.Size = New System.Drawing.Size(46, 17)
        Me.rd_aktif.TabIndex = 1
        Me.rd_aktif.Text = "Aktif"
        Me.rd_aktif.UseVisualStyleBackColor = True
        '
        'rd_Tidak_Aktif
        '
        Me.rd_Tidak_Aktif.AutoSize = True
        Me.rd_Tidak_Aktif.Checked = True
        Me.rd_Tidak_Aktif.Location = New System.Drawing.Point(283, 28)
        Me.rd_Tidak_Aktif.Name = "rd_Tidak_Aktif"
        Me.rd_Tidak_Aktif.Size = New System.Drawing.Size(46, 17)
        Me.rd_Tidak_Aktif.TabIndex = 2
        Me.rd_Tidak_Aktif.TabStop = True
        Me.rd_Tidak_Aktif.Text = "Aktif"
        Me.rd_Tidak_Aktif.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 464)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 297
        Me.Label18.Text = "Kelurahan/Desa"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(27, 438)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 300
        Me.Label19.Text = "Kecamatan"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 412)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 13)
        Me.Label20.TabIndex = 299
        Me.Label20.Text = "Kabupaten/Kota"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 386)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 298
        Me.Label21.Text = "Provinsi"
        '
        'mNama_KelDesa
        '
        Me.mNama_KelDesa.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_KelDesa.Enabled = False
        Me.mNama_KelDesa.Location = New System.Drawing.Point(171, 461)
        Me.mNama_KelDesa.MaxLength = 50
        Me.mNama_KelDesa.Name = "mNama_KelDesa"
        Me.mNama_KelDesa.Size = New System.Drawing.Size(491, 20)
        Me.mNama_KelDesa.TabIndex = 25
        '
        'mNama_Kecamatan
        '
        Me.mNama_Kecamatan.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Kecamatan.Enabled = False
        Me.mNama_Kecamatan.Location = New System.Drawing.Point(171, 432)
        Me.mNama_Kecamatan.MaxLength = 50
        Me.mNama_Kecamatan.Name = "mNama_Kecamatan"
        Me.mNama_Kecamatan.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Kecamatan.TabIndex = 22
        '
        'mNama_KabKota
        '
        Me.mNama_KabKota.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_KabKota.Enabled = False
        Me.mNama_KabKota.Location = New System.Drawing.Point(171, 409)
        Me.mNama_KabKota.MaxLength = 50
        Me.mNama_KabKota.Name = "mNama_KabKota"
        Me.mNama_KabKota.Size = New System.Drawing.Size(491, 20)
        Me.mNama_KabKota.TabIndex = 19
        '
        'mNama_Provinsi
        '
        Me.mNama_Provinsi.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Provinsi.Enabled = False
        Me.mNama_Provinsi.Location = New System.Drawing.Point(171, 383)
        Me.mNama_Provinsi.MaxLength = 50
        Me.mNama_Provinsi.Name = "mNama_Provinsi"
        Me.mNama_Provinsi.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Provinsi.TabIndex = 16
        '
        'mKode_KelDesa
        '
        Me.mKode_KelDesa.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_KelDesa.Enabled = False
        Me.mKode_KelDesa.Location = New System.Drawing.Point(142, 461)
        Me.mKode_KelDesa.Mask = "##"
        Me.mKode_KelDesa.Name = "mKode_KelDesa"
        Me.mKode_KelDesa.Size = New System.Drawing.Size(23, 20)
        Me.mKode_KelDesa.TabIndex = 24
        Me.mKode_KelDesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Kecamatan
        '
        Me.mKode_Kecamatan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Kecamatan.Enabled = False
        Me.mKode_Kecamatan.Location = New System.Drawing.Point(142, 435)
        Me.mKode_Kecamatan.Mask = "##"
        Me.mKode_Kecamatan.Name = "mKode_Kecamatan"
        Me.mKode_Kecamatan.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Kecamatan.TabIndex = 21
        Me.mKode_Kecamatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_KabKota
        '
        Me.mKode_KabKota.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_KabKota.Enabled = False
        Me.mKode_KabKota.Location = New System.Drawing.Point(142, 409)
        Me.mKode_KabKota.Mask = "##"
        Me.mKode_KabKota.Name = "mKode_KabKota"
        Me.mKode_KabKota.Size = New System.Drawing.Size(23, 20)
        Me.mKode_KabKota.TabIndex = 18
        Me.mKode_KabKota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Provinsi
        '
        Me.mKode_Provinsi.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Provinsi.Enabled = False
        Me.mKode_Provinsi.Location = New System.Drawing.Point(142, 383)
        Me.mKode_Provinsi.Mask = "##"
        Me.mKode_Provinsi.Name = "mKode_Provinsi"
        Me.mKode_Provinsi.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Provinsi.TabIndex = 15
        Me.mKode_Provinsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb_Logo
        '
        Me.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Logo.ErrorImage = CType(resources.GetObject("pb_Logo.ErrorImage"), System.Drawing.Image)
        Me.pb_Logo.Image = Global.eParameter.My.Resources.Resources.LogoSumsel
        Me.pb_Logo.Location = New System.Drawing.Point(736, 28)
        Me.pb_Logo.Name = "pb_Logo"
        Me.pb_Logo.Size = New System.Drawing.Size(106, 130)
        Me.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Logo.TabIndex = 301
        Me.pb_Logo.TabStop = False
        '
        'tbl_Browse
        '
        Me.tbl_Browse.Location = New System.Drawing.Point(736, 165)
        Me.tbl_Browse.Name = "tbl_Browse"
        Me.tbl_Browse.Size = New System.Drawing.Size(105, 27)
        Me.tbl_Browse.TabIndex = 302
        Me.tbl_Browse.Text = "Browse"
        Me.tbl_Browse.UseVisualStyleBackColor = True
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(26, 497)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 27
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(668, 383)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 17
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(668, 409)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 20
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'tbCari03
        '
        Me.tbCari03.BackColor = System.Drawing.Color.Transparent
        Me.tbCari03.FlatAppearance.BorderSize = 0
        Me.tbCari03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari03.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari03.Location = New System.Drawing.Point(668, 432)
        Me.tbCari03.Name = "tbCari03"
        Me.tbCari03.Size = New System.Drawing.Size(30, 23)
        Me.tbCari03.TabIndex = 23
        Me.tbCari03.UseVisualStyleBackColor = False
        '
        'tbCari04
        '
        Me.tbCari04.BackColor = System.Drawing.Color.Transparent
        Me.tbCari04.FlatAppearance.BorderSize = 0
        Me.tbCari04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari04.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari04.Location = New System.Drawing.Point(668, 461)
        Me.tbCari04.Name = "tbCari04"
        Me.tbCari04.Size = New System.Drawing.Size(30, 23)
        Me.tbCari04.TabIndex = 26
        Me.tbCari04.UseVisualStyleBackColor = False
        '
        'mAlamatFile
        '
        Me.mAlamatFile.Location = New System.Drawing.Point(588, 114)
        Me.mAlamatFile.Name = "mAlamatFile"
        Me.mAlamatFile.Size = New System.Drawing.Size(137, 20)
        Me.mAlamatFile.TabIndex = 303
        Me.mAlamatFile.Visible = False
        '
        'd0Tr_Pemda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 544)
        Me.Controls.Add(Me.mAlamatFile)
        Me.Controls.Add(Me.tbCari04)
        Me.Controls.Add(Me.tbCari03)
        Me.Controls.Add(Me.tbCari02)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tbl_Browse)
        Me.Controls.Add(Me.pb_Logo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.mNama_KelDesa)
        Me.Controls.Add(Me.mNama_Kecamatan)
        Me.Controls.Add(Me.mNama_KabKota)
        Me.Controls.Add(Me.mNama_Provinsi)
        Me.Controls.Add(Me.mKode_KelDesa)
        Me.Controls.Add(Me.mKode_Kecamatan)
        Me.Controls.Add(Me.mKode_KabKota)
        Me.Controls.Add(Me.mKode_Provinsi)
        Me.Controls.Add(Me.rd_Tidak_Aktif)
        Me.Controls.Add(Me.rd_aktif)
        Me.Controls.Add(Me.mAlamat)
        Me.Controls.Add(Me.mIbukota)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.mNPWP_BUD)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.mJabatan_BUD)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.mNip_BUD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.mNama_BUD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mJabatan_Sekda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mNip_Sekda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mNama_Sekda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mJabatan_PimpDa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mNama_PimpDaerah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mNama_Pemda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mthnAnggaran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d0Tr_Pemda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemerintah Daerah"
        CType(Me.pb_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents mthnAnggaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mNama_Pemda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mNama_PimpDaerah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mJabatan_PimpDa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mNama_Sekda As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mNip_Sekda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mJabatan_Sekda As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mNama_BUD As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mNip_BUD As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mJabatan_BUD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mNPWP_BUD As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mIbukota As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mAlamat As System.Windows.Forms.TextBox
    Friend WithEvents rd_aktif As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Tidak_Aktif As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents mNama_KelDesa As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Kecamatan As System.Windows.Forms.TextBox
    Friend WithEvents mNama_KabKota As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Provinsi As System.Windows.Forms.TextBox
    Friend WithEvents mKode_KelDesa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Kecamatan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_KabKota As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Provinsi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pb_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents tbl_Browse As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents tbCari03 As System.Windows.Forms.Button
    Friend WithEvents tbCari04 As System.Windows.Forms.Button
    Friend WithEvents mAlamatFile As System.Windows.Forms.TextBox
End Class
