<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPerjadin_Par_Tarif_Dalam_Daerah_Copy
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
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.ch_seluruh = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mNama_KabKota_Tujuan = New System.Windows.Forms.TextBox()
        Me.mNama_Provinsi_Tujuan = New System.Windows.Forms.TextBox()
        Me.mKode_KabKota_Tujuan = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Provinsi_Tujuan = New System.Windows.Forms.MaskedTextBox()
        Me.tbCari06 = New System.Windows.Forms.Button()
        Me.tbCari05 = New System.Windows.Forms.Button()
        Me.tbCari04 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mKelompok_Tujuan = New System.Windows.Forms.TextBox()
        Me.mKode_Kelompok_Tujuan = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mNama_KabKota_Asal = New System.Windows.Forms.TextBox()
        Me.mNama_Provinsi_Asal = New System.Windows.Forms.TextBox()
        Me.mKode_KabKota_Asal = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Provinsi_Asal = New System.Windows.Forms.MaskedTextBox()
        Me.tbCari03 = New System.Windows.Forms.Button()
        Me.tbCari02 = New System.Windows.Forms.Button()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mKelompok_Asal = New System.Windows.Forms.TextBox()
        Me.mKode_Kelompok_Asal = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tblProses = New System.Windows.Forms.Button()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(38, 519)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(648, 20)
        Me.mcari.TabIndex = 280
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(12, 522)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 281
        Me.L11.Text = "cari"
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(570, 317)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 278
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
        Me.dg_TampilData.Location = New System.Drawing.Point(12, 356)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(674, 157)
        Me.dg_TampilData.TabIndex = 279
        Me.dg_TampilData.TabStop = False
        '
        'ch_seluruh
        '
        Me.ch_seluruh.AutoSize = True
        Me.ch_seluruh.Location = New System.Drawing.Point(172, 303)
        Me.ch_seluruh.Name = "ch_seluruh"
        Me.ch_seluruh.Size = New System.Drawing.Size(211, 17)
        Me.ch_seluruh.TabIndex = 397
        Me.ch_seluruh.Text = "copy ke seluruh kab/kota di provinsi ini"
        Me.ch_seluruh.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 395
        Me.Label6.Text = "Nama Kab/Kota"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 396
        Me.Label7.Text = "Nama Provinsi"
        '
        'mNama_KabKota_Tujuan
        '
        Me.mNama_KabKota_Tujuan.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_KabKota_Tujuan.Enabled = False
        Me.mNama_KabKota_Tujuan.Location = New System.Drawing.Point(172, 277)
        Me.mNama_KabKota_Tujuan.MaxLength = 50
        Me.mNama_KabKota_Tujuan.Name = "mNama_KabKota_Tujuan"
        Me.mNama_KabKota_Tujuan.Size = New System.Drawing.Size(491, 20)
        Me.mNama_KabKota_Tujuan.TabIndex = 384
        '
        'mNama_Provinsi_Tujuan
        '
        Me.mNama_Provinsi_Tujuan.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Provinsi_Tujuan.Enabled = False
        Me.mNama_Provinsi_Tujuan.Location = New System.Drawing.Point(172, 254)
        Me.mNama_Provinsi_Tujuan.MaxLength = 50
        Me.mNama_Provinsi_Tujuan.Name = "mNama_Provinsi_Tujuan"
        Me.mNama_Provinsi_Tujuan.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Provinsi_Tujuan.TabIndex = 381
        '
        'mKode_KabKota_Tujuan
        '
        Me.mKode_KabKota_Tujuan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_KabKota_Tujuan.Enabled = False
        Me.mKode_KabKota_Tujuan.Location = New System.Drawing.Point(146, 277)
        Me.mKode_KabKota_Tujuan.Mask = "##"
        Me.mKode_KabKota_Tujuan.Name = "mKode_KabKota_Tujuan"
        Me.mKode_KabKota_Tujuan.Size = New System.Drawing.Size(23, 20)
        Me.mKode_KabKota_Tujuan.TabIndex = 383
        Me.mKode_KabKota_Tujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Provinsi_Tujuan
        '
        Me.mKode_Provinsi_Tujuan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Provinsi_Tujuan.Enabled = False
        Me.mKode_Provinsi_Tujuan.Location = New System.Drawing.Point(146, 254)
        Me.mKode_Provinsi_Tujuan.Mask = "##"
        Me.mKode_Provinsi_Tujuan.Name = "mKode_Provinsi_Tujuan"
        Me.mKode_Provinsi_Tujuan.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Provinsi_Tujuan.TabIndex = 380
        Me.mKode_Provinsi_Tujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCari06
        '
        Me.tbCari06.BackColor = System.Drawing.Color.Transparent
        Me.tbCari06.FlatAppearance.BorderSize = 0
        Me.tbCari06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari06.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari06.Location = New System.Drawing.Point(669, 277)
        Me.tbCari06.Name = "tbCari06"
        Me.tbCari06.Size = New System.Drawing.Size(30, 23)
        Me.tbCari06.TabIndex = 385
        Me.tbCari06.UseVisualStyleBackColor = False
        '
        'tbCari05
        '
        Me.tbCari05.BackColor = System.Drawing.Color.Transparent
        Me.tbCari05.FlatAppearance.BorderSize = 0
        Me.tbCari05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari05.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari05.Location = New System.Drawing.Point(669, 252)
        Me.tbCari05.Name = "tbCari05"
        Me.tbCari05.Size = New System.Drawing.Size(30, 23)
        Me.tbCari05.TabIndex = 382
        Me.tbCari05.UseVisualStyleBackColor = False
        '
        'tbCari04
        '
        Me.tbCari04.BackColor = System.Drawing.Color.Transparent
        Me.tbCari04.FlatAppearance.BorderSize = 0
        Me.tbCari04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari04.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari04.Location = New System.Drawing.Point(670, 196)
        Me.tbCari04.Name = "tbCari04"
        Me.tbCari04.Size = New System.Drawing.Size(30, 23)
        Me.tbCari04.TabIndex = 379
        Me.tbCari04.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 13)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "Tujuan Perjalanan Dinas :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 394
        Me.Label9.Text = "Kelompok Perjadin"
        '
        'mKelompok_Tujuan
        '
        Me.mKelompok_Tujuan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKelompok_Tujuan.Enabled = False
        Me.mKelompok_Tujuan.Location = New System.Drawing.Point(173, 196)
        Me.mKelompok_Tujuan.MaxLength = 50
        Me.mKelompok_Tujuan.Name = "mKelompok_Tujuan"
        Me.mKelompok_Tujuan.Size = New System.Drawing.Size(491, 20)
        Me.mKelompok_Tujuan.TabIndex = 378
        '
        'mKode_Kelompok_Tujuan
        '
        Me.mKode_Kelompok_Tujuan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Kelompok_Tujuan.Enabled = False
        Me.mKode_Kelompok_Tujuan.Location = New System.Drawing.Point(146, 196)
        Me.mKode_Kelompok_Tujuan.Mask = "##"
        Me.mKode_Kelompok_Tujuan.Name = "mKode_Kelompok_Tujuan"
        Me.mKode_Kelompok_Tujuan.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Kelompok_Tujuan.TabIndex = 377
        Me.mKode_Kelompok_Tujuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 391
        Me.Label4.Text = "Nama Kab/Kota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 392
        Me.Label5.Text = "Nama Provinsi"
        '
        'mNama_KabKota_Asal
        '
        Me.mNama_KabKota_Asal.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_KabKota_Asal.Enabled = False
        Me.mNama_KabKota_Asal.Location = New System.Drawing.Point(172, 136)
        Me.mNama_KabKota_Asal.MaxLength = 50
        Me.mNama_KabKota_Asal.Name = "mNama_KabKota_Asal"
        Me.mNama_KabKota_Asal.Size = New System.Drawing.Size(491, 20)
        Me.mNama_KabKota_Asal.TabIndex = 375
        '
        'mNama_Provinsi_Asal
        '
        Me.mNama_Provinsi_Asal.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Provinsi_Asal.Enabled = False
        Me.mNama_Provinsi_Asal.Location = New System.Drawing.Point(172, 113)
        Me.mNama_Provinsi_Asal.MaxLength = 50
        Me.mNama_Provinsi_Asal.Name = "mNama_Provinsi_Asal"
        Me.mNama_Provinsi_Asal.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Provinsi_Asal.TabIndex = 372
        '
        'mKode_KabKota_Asal
        '
        Me.mKode_KabKota_Asal.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_KabKota_Asal.Enabled = False
        Me.mKode_KabKota_Asal.Location = New System.Drawing.Point(146, 136)
        Me.mKode_KabKota_Asal.Mask = "##"
        Me.mKode_KabKota_Asal.Name = "mKode_KabKota_Asal"
        Me.mKode_KabKota_Asal.Size = New System.Drawing.Size(23, 20)
        Me.mKode_KabKota_Asal.TabIndex = 374
        Me.mKode_KabKota_Asal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Provinsi_Asal
        '
        Me.mKode_Provinsi_Asal.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Provinsi_Asal.Enabled = False
        Me.mKode_Provinsi_Asal.Location = New System.Drawing.Point(146, 113)
        Me.mKode_Provinsi_Asal.Mask = "##"
        Me.mKode_Provinsi_Asal.Name = "mKode_Provinsi_Asal"
        Me.mKode_Provinsi_Asal.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Provinsi_Asal.TabIndex = 371
        Me.mKode_Provinsi_Asal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbCari03
        '
        Me.tbCari03.BackColor = System.Drawing.Color.Transparent
        Me.tbCari03.FlatAppearance.BorderSize = 0
        Me.tbCari03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari03.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari03.Location = New System.Drawing.Point(669, 136)
        Me.tbCari03.Name = "tbCari03"
        Me.tbCari03.Size = New System.Drawing.Size(30, 23)
        Me.tbCari03.TabIndex = 376
        Me.tbCari03.UseVisualStyleBackColor = False
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(669, 111)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 373
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(670, 55)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 370
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 389
        Me.Label1.Text = "Tujuan Perjalanan Dinas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 390
        Me.Label2.Text = "Kelompok Perjadin"
        '
        'mKelompok_Asal
        '
        Me.mKelompok_Asal.BackColor = System.Drawing.SystemColors.Menu
        Me.mKelompok_Asal.Enabled = False
        Me.mKelompok_Asal.Location = New System.Drawing.Point(173, 55)
        Me.mKelompok_Asal.MaxLength = 50
        Me.mKelompok_Asal.Name = "mKelompok_Asal"
        Me.mKelompok_Asal.Size = New System.Drawing.Size(491, 20)
        Me.mKelompok_Asal.TabIndex = 369
        '
        'mKode_Kelompok_Asal
        '
        Me.mKode_Kelompok_Asal.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Kelompok_Asal.Enabled = False
        Me.mKode_Kelompok_Asal.Location = New System.Drawing.Point(146, 55)
        Me.mKode_Kelompok_Asal.Mask = "##"
        Me.mKode_Kelompok_Asal.Name = "mKode_Kelompok_Asal"
        Me.mKode_Kelompok_Asal.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Kelompok_Asal.TabIndex = 368
        Me.mKode_Kelompok_Asal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 13)
        Me.Label10.TabIndex = 387
        Me.Label10.Text = "Tujuan Tarif yg diCopy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 388
        Me.Label3.Text = "Asal Tarif yg akan diCopy"
        '
        'tblProses
        '
        Me.tblProses.BackColor = System.Drawing.Color.White
        Me.tblProses.Image = Global.eParameter.My.Resources.Resources.proses
        Me.tblProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblProses.Location = New System.Drawing.Point(14, 317)
        Me.tblProses.Name = "tblProses"
        Me.tblProses.Size = New System.Drawing.Size(116, 33)
        Me.tblProses.TabIndex = 386
        Me.tblProses.Text = "Proses Copy"
        Me.tblProses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblProses.UseVisualStyleBackColor = False
        '
        'cPerjadin_Par_Tarif_Dalam_Daerah_Copy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 547)
        Me.Controls.Add(Me.ch_seluruh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mNama_KabKota_Tujuan)
        Me.Controls.Add(Me.mNama_Provinsi_Tujuan)
        Me.Controls.Add(Me.mKode_KabKota_Tujuan)
        Me.Controls.Add(Me.mKode_Provinsi_Tujuan)
        Me.Controls.Add(Me.tbCari06)
        Me.Controls.Add(Me.tbCari05)
        Me.Controls.Add(Me.tbCari04)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mKelompok_Tujuan)
        Me.Controls.Add(Me.mKode_Kelompok_Tujuan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mNama_KabKota_Asal)
        Me.Controls.Add(Me.mNama_Provinsi_Asal)
        Me.Controls.Add(Me.mKode_KabKota_Asal)
        Me.Controls.Add(Me.mKode_Provinsi_Asal)
        Me.Controls.Add(Me.tbCari03)
        Me.Controls.Add(Me.tbCari02)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mKelompok_Asal)
        Me.Controls.Add(Me.mKode_Kelompok_Asal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tblProses)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cPerjadin_Par_Tarif_Dalam_Daerah_Copy"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fMM"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
    Friend WithEvents ch_seluruh As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mNama_KabKota_Tujuan As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Provinsi_Tujuan As System.Windows.Forms.TextBox
    Friend WithEvents mKode_KabKota_Tujuan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Provinsi_Tujuan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbCari06 As System.Windows.Forms.Button
    Friend WithEvents tbCari05 As System.Windows.Forms.Button
    Friend WithEvents tbCari04 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mKelompok_Tujuan As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Kelompok_Tujuan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mNama_KabKota_Asal As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Provinsi_Asal As System.Windows.Forms.TextBox
    Friend WithEvents mKode_KabKota_Asal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Provinsi_Asal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbCari03 As System.Windows.Forms.Button
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mKelompok_Asal As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Kelompok_Asal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tblProses As System.Windows.Forms.Button
End Class
