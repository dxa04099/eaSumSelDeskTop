<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_Bank
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ko = New System.Windows.Forms.Label()
        Me.mNm_Bank = New System.Windows.Forms.TextBox()
        Me.mKd_Bank = New System.Windows.Forms.MaskedTextBox()
        Me.mNo_Rekening = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.mcari.Location = New System.Drawing.Point(42, 395)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(569, 20)
        Me.mcari.TabIndex = 15
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(12, 398)
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
        Me.tblBaru.Location = New System.Drawing.Point(19, 193)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 10
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(141, 193)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 11
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(263, 193)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 12
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(495, 193)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 13
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
        Me.dg_TampilData.Location = New System.Drawing.Point(16, 232)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(595, 157)
        Me.dg_TampilData.TabIndex = 14
        Me.dg_TampilData.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "Nama Kreditur"
        '
        'Ko
        '
        Me.Ko.AutoSize = True
        Me.Ko.Location = New System.Drawing.Point(16, 22)
        Me.Ko.Name = "Ko"
        Me.Ko.Size = New System.Drawing.Size(71, 13)
        Me.Ko.TabIndex = 353
        Me.Ko.Text = "Kode Kreditur"
        '
        'mNm_Bank
        '
        Me.mNm_Bank.Location = New System.Drawing.Point(120, 45)
        Me.mNm_Bank.MaxLength = 50
        Me.mNm_Bank.Name = "mNm_Bank"
        Me.mNm_Bank.Size = New System.Drawing.Size(491, 20)
        Me.mNm_Bank.TabIndex = 1
        '
        'mKd_Bank
        '
        Me.mKd_Bank.Location = New System.Drawing.Point(120, 22)
        Me.mKd_Bank.Mask = "##"
        Me.mKd_Bank.Name = "mKd_Bank"
        Me.mKd_Bank.Size = New System.Drawing.Size(23, 20)
        Me.mKd_Bank.TabIndex = 0
        Me.mKd_Bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNo_Rekening
        '
        Me.mNo_Rekening.Location = New System.Drawing.Point(120, 71)
        Me.mNo_Rekening.MaxLength = 50
        Me.mNo_Rekening.Name = "mNo_Rekening"
        Me.mNo_Rekening.Size = New System.Drawing.Size(491, 20)
        Me.mNo_Rekening.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 352
        Me.Label3.Text = "Nomor Rekening"
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(258, 95)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 8
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(19, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 361
        Me.Label1.Text = "Kode Rekening"
        '
        'mNama_Rek_Rincian_Objek
        '
        Me.mNama_Rek_Rincian_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Rek_Rincian_Objek.Enabled = False
        Me.mNama_Rek_Rincian_Objek.Location = New System.Drawing.Point(120, 123)
        Me.mNama_Rek_Rincian_Objek.MaxLength = 100
        Me.mNama_Rek_Rincian_Objek.Name = "mNama_Rek_Rincian_Objek"
        Me.mNama_Rek_Rincian_Objek.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Rek_Rincian_Objek.TabIndex = 9
        '
        'mRek_Rincian_Objek
        '
        Me.mRek_Rincian_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Rincian_Objek.Enabled = False
        Me.mRek_Rincian_Objek.Location = New System.Drawing.Point(224, 97)
        Me.mRek_Rincian_Objek.Mask = "##"
        Me.mRek_Rincian_Objek.Name = "mRek_Rincian_Objek"
        Me.mRek_Rincian_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Rincian_Objek.TabIndex = 7
        Me.mRek_Rincian_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Objek
        '
        Me.mRek_Objek.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Objek.Enabled = False
        Me.mRek_Objek.Location = New System.Drawing.Point(194, 97)
        Me.mRek_Objek.Mask = "##"
        Me.mRek_Objek.Name = "mRek_Objek"
        Me.mRek_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Objek.TabIndex = 6
        Me.mRek_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Jenis
        '
        Me.mRek_Jenis.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Jenis.Enabled = False
        Me.mRek_Jenis.Location = New System.Drawing.Point(164, 97)
        Me.mRek_Jenis.Mask = "#"
        Me.mRek_Jenis.Name = "mRek_Jenis"
        Me.mRek_Jenis.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Jenis.TabIndex = 5
        Me.mRek_Jenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Kelompok
        '
        Me.mRek_Kelompok.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Kelompok.Enabled = False
        Me.mRek_Kelompok.Location = New System.Drawing.Point(142, 97)
        Me.mRek_Kelompok.Mask = "#"
        Me.mRek_Kelompok.Name = "mRek_Kelompok"
        Me.mRek_Kelompok.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Kelompok.TabIndex = 4
        Me.mRek_Kelompok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Pos
        '
        Me.mRek_Pos.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Pos.Enabled = False
        Me.mRek_Pos.Location = New System.Drawing.Point(120, 97)
        Me.mRek_Pos.Mask = "#"
        Me.mRek_Pos.Name = "mRek_Pos"
        Me.mRek_Pos.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Pos.TabIndex = 3
        Me.mRek_Pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(120, 149)
        Me.mKode_Dokumen.MaxLength = 50
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(311, 20)
        Me.mKode_Dokumen.TabIndex = 364
        '
        'tblPreviewDokumen
        '
        Me.tblPreviewDokumen.BackColor = System.Drawing.Color.Transparent
        Me.tblPreviewDokumen.FlatAppearance.BorderSize = 0
        Me.tblPreviewDokumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblPreviewDokumen.Image = Global.eParameter.My.Resources.Resources.preview
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(458, 149)
        Me.tblPreviewDokumen.Name = "tblPreviewDokumen"
        Me.tblPreviewDokumen.Size = New System.Drawing.Size(20, 19)
        Me.tblPreviewDokumen.TabIndex = 362
        Me.tblPreviewDokumen.UseVisualStyleBackColor = False
        '
        'tblCariDokumen_Pendukung
        '
        Me.tblCariDokumen_Pendukung.BackColor = System.Drawing.Color.Transparent
        Me.tblCariDokumen_Pendukung.FlatAppearance.BorderSize = 0
        Me.tblCariDokumen_Pendukung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCariDokumen_Pendukung.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(437, 150)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 363
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 41)
        Me.Label7.TabIndex = 365
        Me.Label7.Text = "Dokumen Pendukung"
        '
        'cPar_Bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 426)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNama_Rek_Rincian_Objek)
        Me.Controls.Add(Me.mRek_Rincian_Objek)
        Me.Controls.Add(Me.mRek_Objek)
        Me.Controls.Add(Me.mRek_Jenis)
        Me.Controls.Add(Me.mRek_Kelompok)
        Me.Controls.Add(Me.mRek_Pos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ko)
        Me.Controls.Add(Me.mNo_Rekening)
        Me.Controls.Add(Me.mNm_Bank)
        Me.Controls.Add(Me.mKd_Bank)
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
        Me.Name = "cPar_Bank"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ko As System.Windows.Forms.Label
    Friend WithEvents mNm_Bank As System.Windows.Forms.TextBox
    Friend WithEvents mKd_Bank As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNo_Rekening As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
