<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_ProgKeg_Kegiatan
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
        Me.mNama_Program = New System.Windows.Forms.TextBox()
        Me.mNama_Urusan = New System.Windows.Forms.TextBox()
        Me.mKd_Prog = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Bidang_Program = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Urusan_Program = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mKd_Keg = New System.Windows.Forms.MaskedTextBox()
        Me.mNama_Kegiatan = New System.Windows.Forms.TextBox()
        Me.tbCari02 = New System.Windows.Forms.Button()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(47, 468)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(704, 20)
        Me.mcari.TabIndex = 14
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(17, 471)
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
        Me.tblBaru.Location = New System.Drawing.Point(24, 266)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 9
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(146, 266)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 10
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(268, 266)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 11
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(635, 266)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 12
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
        Me.dg_TampilData.Location = New System.Drawing.Point(21, 305)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(730, 157)
        Me.dg_TampilData.TabIndex = 13
        Me.dg_TampilData.TabStop = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(163, 23)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 2
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'mNama_Program
        '
        Me.mNama_Program.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Program.Enabled = False
        Me.mNama_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Program.Location = New System.Drawing.Point(105, 104)
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
        Me.mNama_Urusan.Location = New System.Drawing.Point(105, 52)
        Me.mNama_Urusan.MaxLength = 50
        Me.mNama_Urusan.Name = "mNama_Urusan"
        Me.mNama_Urusan.Size = New System.Drawing.Size(498, 20)
        Me.mNama_Urusan.TabIndex = 3
        '
        'mKd_Prog
        '
        Me.mKd_Prog.BackColor = System.Drawing.SystemColors.Menu
        Me.mKd_Prog.Enabled = False
        Me.mKd_Prog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Prog.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Prog.Location = New System.Drawing.Point(105, 78)
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
        Me.mKd_Bidang_Program.Location = New System.Drawing.Point(127, 26)
        Me.mKd_Bidang_Program.Mask = "##"
        Me.mKd_Bidang_Program.Name = "mKd_Bidang_Program"
        Me.mKd_Bidang_Program.Size = New System.Drawing.Size(30, 20)
        Me.mKd_Bidang_Program.TabIndex = 1
        Me.mKd_Bidang_Program.Text = "00"
        Me.mKd_Bidang_Program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKd_Urusan_Program
        '
        Me.mKd_Urusan_Program.BackColor = System.Drawing.SystemColors.Menu
        Me.mKd_Urusan_Program.Enabled = False
        Me.mKd_Urusan_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Urusan_Program.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Urusan_Program.Location = New System.Drawing.Point(105, 26)
        Me.mKd_Urusan_Program.Mask = "#"
        Me.mKd_Urusan_Program.Name = "mKd_Urusan_Program"
        Me.mKd_Urusan_Program.Size = New System.Drawing.Size(20, 20)
        Me.mKd_Urusan_Program.TabIndex = 0
        Me.mKd_Urusan_Program.Text = "0"
        Me.mKd_Urusan_Program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 293
        Me.Label2.Text = "Kode Program"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 292
        Me.Label1.Text = "Nama Program"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 294
        Me.Label14.Text = "Urusan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 292
        Me.Label3.Text = "Nama Kegiatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 293
        Me.Label4.Text = "Kode Kegiatan"
        '
        'mKd_Keg
        '
        Me.mKd_Keg.BackColor = System.Drawing.Color.White
        Me.mKd_Keg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Keg.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Keg.Location = New System.Drawing.Point(142, 152)
        Me.mKd_Keg.Mask = "###"
        Me.mKd_Keg.Name = "mKd_Keg"
        Me.mKd_Keg.Size = New System.Drawing.Size(37, 20)
        Me.mKd_Keg.TabIndex = 7
        Me.mKd_Keg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNama_Kegiatan
        '
        Me.mNama_Kegiatan.BackColor = System.Drawing.Color.White
        Me.mNama_Kegiatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Kegiatan.Location = New System.Drawing.Point(142, 178)
        Me.mNama_Kegiatan.MaxLength = 255
        Me.mNama_Kegiatan.Multiline = True
        Me.mNama_Kegiatan.Name = "mNama_Kegiatan"
        Me.mNama_Kegiatan.Size = New System.Drawing.Size(609, 42)
        Me.mNama_Kegiatan.TabIndex = 8
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(163, 76)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 5
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(142, 235)
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
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(480, 235)
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
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(459, 236)
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
        Me.Label7.Location = New System.Drawing.Point(25, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 324
        Me.Label7.Text = "Dokumen Pendukung"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(216, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton1.TabIndex = 325
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Kegiatan Rutin"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(337, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(143, 17)
        Me.RadioButton2.TabIndex = 325
        Me.RadioButton2.Text = "Kegiatan Sesuai Tupoksi"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'cPar_ProgKeg_Kegiatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 503)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "cPar_ProgKeg_Kegiatan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kegiatan"
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
    Friend WithEvents mNama_Program As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Urusan As System.Windows.Forms.TextBox
    Friend WithEvents mKd_Prog As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKd_Bidang_Program As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKd_Urusan_Program As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mKd_Keg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNama_Kegiatan As System.Windows.Forms.TextBox
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
