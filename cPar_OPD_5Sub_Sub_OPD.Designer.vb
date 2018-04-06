<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_OPD_5Sub_Sub_OPD
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
        Me.ch_BOS = New System.Windows.Forms.CheckBox()
        Me.ch_Perjadin = New System.Windows.Forms.CheckBox()
        Me.ch_Gaji_Non_PNS = New System.Windows.Forms.CheckBox()
        Me.ch_TPP = New System.Windows.Forms.CheckBox()
        Me.ch_Gaji_PNS = New System.Windows.Forms.CheckBox()
        Me.ch_Keu = New System.Windows.Forms.CheckBox()
        Me.ch_Jenis = New System.Windows.Forms.CheckBox()
        Me.ch_BLUD = New System.Windows.Forms.CheckBox()
        Me.mcari = New System.Windows.Forms.TextBox()
        Me.L11 = New System.Windows.Forms.Label()
        Me.dg_Sub_OPD = New System.Windows.Forms.DataGridView()
        Me.mNama_Fungsi = New System.Windows.Forms.TextBox()
        Me.mNama_Sub_OPD = New System.Windows.Forms.TextBox()
        Me.mNama_OPD = New System.Windows.Forms.TextBox()
        Me.mKode_Sub_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Bidang = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Fungsi = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Urusan = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mKode_Sub_Sub_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mNama_Sub_Sub_OPD = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dg_Sub_OPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ch_BOS
        '
        Me.ch_BOS.AutoSize = True
        Me.ch_BOS.BackColor = System.Drawing.Color.Transparent
        Me.ch_BOS.Location = New System.Drawing.Point(691, 162)
        Me.ch_BOS.Name = "ch_BOS"
        Me.ch_BOS.Size = New System.Drawing.Size(48, 17)
        Me.ch_BOS.TabIndex = 17
        Me.ch_BOS.Text = "BOS"
        Me.ch_BOS.UseVisualStyleBackColor = False
        '
        'ch_Perjadin
        '
        Me.ch_Perjadin.AutoSize = True
        Me.ch_Perjadin.BackColor = System.Drawing.Color.Transparent
        Me.ch_Perjadin.Location = New System.Drawing.Point(604, 162)
        Me.ch_Perjadin.Name = "ch_Perjadin"
        Me.ch_Perjadin.Size = New System.Drawing.Size(64, 17)
        Me.ch_Perjadin.TabIndex = 16
        Me.ch_Perjadin.Text = "Perjadin"
        Me.ch_Perjadin.UseVisualStyleBackColor = False
        '
        'ch_Gaji_Non_PNS
        '
        Me.ch_Gaji_Non_PNS.AutoSize = True
        Me.ch_Gaji_Non_PNS.BackColor = System.Drawing.Color.Transparent
        Me.ch_Gaji_Non_PNS.Location = New System.Drawing.Point(506, 162)
        Me.ch_Gaji_Non_PNS.Name = "ch_Gaji_Non_PNS"
        Me.ch_Gaji_Non_PNS.Size = New System.Drawing.Size(92, 17)
        Me.ch_Gaji_Non_PNS.TabIndex = 15
        Me.ch_Gaji_Non_PNS.Text = "Gaji Non PNS"
        Me.ch_Gaji_Non_PNS.UseVisualStyleBackColor = False
        '
        'ch_TPP
        '
        Me.ch_TPP.AutoSize = True
        Me.ch_TPP.BackColor = System.Drawing.Color.Transparent
        Me.ch_TPP.Location = New System.Drawing.Point(430, 162)
        Me.ch_TPP.Name = "ch_TPP"
        Me.ch_TPP.Size = New System.Drawing.Size(47, 17)
        Me.ch_TPP.TabIndex = 14
        Me.ch_TPP.Text = "TPP"
        Me.ch_TPP.UseVisualStyleBackColor = False
        '
        'ch_Gaji_PNS
        '
        Me.ch_Gaji_PNS.AutoSize = True
        Me.ch_Gaji_PNS.BackColor = System.Drawing.Color.Transparent
        Me.ch_Gaji_PNS.Location = New System.Drawing.Point(353, 162)
        Me.ch_Gaji_PNS.Name = "ch_Gaji_PNS"
        Me.ch_Gaji_PNS.Size = New System.Drawing.Size(69, 17)
        Me.ch_Gaji_PNS.TabIndex = 13
        Me.ch_Gaji_PNS.Text = "Gaji PNS"
        Me.ch_Gaji_PNS.UseVisualStyleBackColor = False
        '
        'ch_Keu
        '
        Me.ch_Keu.AutoSize = True
        Me.ch_Keu.BackColor = System.Drawing.Color.Transparent
        Me.ch_Keu.Location = New System.Drawing.Point(193, 162)
        Me.ch_Keu.Name = "ch_Keu"
        Me.ch_Keu.Size = New System.Drawing.Size(154, 17)
        Me.ch_Keu.TabIndex = 12
        Me.ch_Keu.Text = "Perencanaan sd Akuntansi"
        Me.ch_Keu.UseVisualStyleBackColor = False
        '
        'ch_Jenis
        '
        Me.ch_Jenis.AutoSize = True
        Me.ch_Jenis.BackColor = System.Drawing.Color.Transparent
        Me.ch_Jenis.Enabled = False
        Me.ch_Jenis.Location = New System.Drawing.Point(157, 115)
        Me.ch_Jenis.Name = "ch_Jenis"
        Me.ch_Jenis.Size = New System.Drawing.Size(81, 17)
        Me.ch_Jenis.TabIndex = 9
        Me.ch_Jenis.Text = "OPD BLUD"
        Me.ch_Jenis.UseVisualStyleBackColor = False
        '
        'ch_BLUD
        '
        Me.ch_BLUD.AutoSize = True
        Me.ch_BLUD.BackColor = System.Drawing.Color.Transparent
        Me.ch_BLUD.Location = New System.Drawing.Point(114, 162)
        Me.ch_BLUD.Name = "ch_BLUD"
        Me.ch_BLUD.Size = New System.Drawing.Size(55, 17)
        Me.ch_BLUD.TabIndex = 11
        Me.ch_BLUD.Text = "BLUD"
        Me.ch_BLUD.UseVisualStyleBackColor = False
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(58, 584)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(772, 20)
        Me.mcari.TabIndex = 25
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(28, 587)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 155
        Me.L11.Text = "cari"
        '
        'dg_Sub_OPD
        '
        Me.dg_Sub_OPD.AllowUserToAddRows = False
        Me.dg_Sub_OPD.AllowUserToDeleteRows = False
        Me.dg_Sub_OPD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_Sub_OPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Sub_OPD.Location = New System.Drawing.Point(32, 329)
        Me.dg_Sub_OPD.Name = "dg_Sub_OPD"
        Me.dg_Sub_OPD.ReadOnly = True
        Me.dg_Sub_OPD.RowHeadersVisible = False
        Me.dg_Sub_OPD.Size = New System.Drawing.Size(798, 246)
        Me.dg_Sub_OPD.TabIndex = 24
        Me.dg_Sub_OPD.TabStop = False
        '
        'mNama_Fungsi
        '
        Me.mNama_Fungsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mNama_Fungsi.Enabled = False
        Me.mNama_Fungsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Fungsi.Location = New System.Drawing.Point(114, 206)
        Me.mNama_Fungsi.MaxLength = 100
        Me.mNama_Fungsi.Name = "mNama_Fungsi"
        Me.mNama_Fungsi.ReadOnly = True
        Me.mNama_Fungsi.Size = New System.Drawing.Size(716, 20)
        Me.mNama_Fungsi.TabIndex = 19
        '
        'mNama_Sub_OPD
        '
        Me.mNama_Sub_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mNama_Sub_OPD.Enabled = False
        Me.mNama_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Sub_OPD.Location = New System.Drawing.Point(114, 91)
        Me.mNama_Sub_OPD.MaxLength = 100
        Me.mNama_Sub_OPD.Name = "mNama_Sub_OPD"
        Me.mNama_Sub_OPD.Size = New System.Drawing.Size(716, 20)
        Me.mNama_Sub_OPD.TabIndex = 7
        '
        'mNama_OPD
        '
        Me.mNama_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mNama_OPD.Enabled = False
        Me.mNama_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_OPD.Location = New System.Drawing.Point(114, 46)
        Me.mNama_OPD.MaxLength = 100
        Me.mNama_OPD.Name = "mNama_OPD"
        Me.mNama_OPD.Size = New System.Drawing.Size(716, 20)
        Me.mNama_OPD.TabIndex = 4
        '
        'mKode_Sub_OPD
        '
        Me.mKode_Sub_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Sub_OPD.Enabled = False
        Me.mKode_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_OPD.Location = New System.Drawing.Point(114, 68)
        Me.mKode_Sub_OPD.Mask = "##"
        Me.mKode_Sub_OPD.Name = "mKode_Sub_OPD"
        Me.mKode_Sub_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Sub_OPD.TabIndex = 5
        Me.mKode_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_OPD
        '
        Me.mKode_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_OPD.Enabled = False
        Me.mKode_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_OPD.Location = New System.Drawing.Point(168, 22)
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
        Me.mKode_Bidang.Location = New System.Drawing.Point(136, 22)
        Me.mKode_Bidang.Mask = "##"
        Me.mKode_Bidang.Name = "mKode_Bidang"
        Me.mKode_Bidang.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Bidang.TabIndex = 1
        Me.mKode_Bidang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Fungsi
        '
        Me.mKode_Fungsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Fungsi.Enabled = False
        Me.mKode_Fungsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Fungsi.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Fungsi.Location = New System.Drawing.Point(114, 182)
        Me.mKode_Fungsi.Mask = "##"
        Me.mKode_Fungsi.Name = "mKode_Fungsi"
        Me.mKode_Fungsi.ReadOnly = True
        Me.mKode_Fungsi.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Fungsi.TabIndex = 18
        Me.mKode_Fungsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Urusan
        '
        Me.mKode_Urusan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Urusan.Enabled = False
        Me.mKode_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Urusan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Urusan.Location = New System.Drawing.Point(114, 22)
        Me.mKode_Urusan.Mask = "#"
        Me.mKode_Urusan.Name = "mKode_Urusan"
        Me.mKode_Urusan.Size = New System.Drawing.Size(20, 20)
        Me.mKode_Urusan.TabIndex = 0
        Me.mKode_Urusan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Nama Fungsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Kode Sub OPD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Nama Sub OPD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Kode Fungsi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Nama OPD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "Kode OPD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 150
        Me.Label6.Text = "Nama Sub OPD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Kode Sub OPD"
        '
        'mKode_Sub_Sub_OPD
        '
        Me.mKode_Sub_Sub_OPD.BackColor = System.Drawing.Color.White
        Me.mKode_Sub_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_Sub_OPD.Location = New System.Drawing.Point(114, 113)
        Me.mKode_Sub_Sub_OPD.Mask = "##"
        Me.mKode_Sub_Sub_OPD.Name = "mKode_Sub_Sub_OPD"
        Me.mKode_Sub_Sub_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Sub_Sub_OPD.TabIndex = 8
        Me.mKode_Sub_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNama_Sub_Sub_OPD
        '
        Me.mNama_Sub_Sub_OPD.BackColor = System.Drawing.Color.White
        Me.mNama_Sub_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Sub_Sub_OPD.Location = New System.Drawing.Point(114, 136)
        Me.mNama_Sub_Sub_OPD.MaxLength = 100
        Me.mNama_Sub_Sub_OPD.Name = "mNama_Sub_Sub_OPD"
        Me.mNama_Sub_Sub_OPD.Size = New System.Drawing.Size(716, 20)
        Me.mNama_Sub_Sub_OPD.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Button1.Location = New System.Drawing.Point(148, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(204, 19)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 3
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(32, 281)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 21
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(154, 281)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 21
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(276, 281)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 22
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(711, 281)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 23
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(114, 232)
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
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(452, 232)
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
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(431, 233)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 322
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 30)
        Me.Label8.TabIndex = 324
        Me.Label8.Text = "Dokumen Pendukung"
        '
        'cPar_OPD_5Sub_Sub_OPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(853, 622)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ch_BOS)
        Me.Controls.Add(Me.ch_Perjadin)
        Me.Controls.Add(Me.ch_Gaji_Non_PNS)
        Me.Controls.Add(Me.ch_TPP)
        Me.Controls.Add(Me.ch_Gaji_PNS)
        Me.Controls.Add(Me.ch_Keu)
        Me.Controls.Add(Me.ch_Jenis)
        Me.Controls.Add(Me.ch_BLUD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.dg_Sub_OPD)
        Me.Controls.Add(Me.mNama_Fungsi)
        Me.Controls.Add(Me.mNama_Sub_Sub_OPD)
        Me.Controls.Add(Me.mNama_Sub_OPD)
        Me.Controls.Add(Me.mNama_OPD)
        Me.Controls.Add(Me.mKode_Sub_Sub_OPD)
        Me.Controls.Add(Me.mKode_Sub_OPD)
        Me.Controls.Add(Me.mKode_OPD)
        Me.Controls.Add(Me.mKode_Bidang)
        Me.Controls.Add(Me.mKode_Fungsi)
        Me.Controls.Add(Me.mKode_Urusan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cPar_OPD_5Sub_Sub_OPD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub-Sub OPD"
        CType(Me.dg_Sub_OPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ch_BOS As System.Windows.Forms.CheckBox
    Friend WithEvents ch_Perjadin As System.Windows.Forms.CheckBox
    Friend WithEvents ch_Gaji_Non_PNS As System.Windows.Forms.CheckBox
    Friend WithEvents ch_TPP As System.Windows.Forms.CheckBox
    Friend WithEvents ch_Gaji_PNS As System.Windows.Forms.CheckBox
    Friend WithEvents ch_Keu As System.Windows.Forms.CheckBox
    Friend WithEvents ch_Jenis As System.Windows.Forms.CheckBox
    Friend WithEvents ch_BLUD As System.Windows.Forms.CheckBox
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents dg_Sub_OPD As System.Windows.Forms.DataGridView
    Friend WithEvents mNama_Fungsi As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Sub_OPD As System.Windows.Forms.TextBox
    Friend WithEvents mNama_OPD As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Sub_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Bidang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Fungsi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Urusan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mKode_Sub_Sub_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNama_Sub_Sub_OPD As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label8 As Label
End Class
