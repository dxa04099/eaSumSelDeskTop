<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_Penomoran_Dokumen
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
        Me.mcari = New System.Windows.Forms.TextBox
        Me.L11 = New System.Windows.Forms.Label
        Me.tblBaru = New System.Windows.Forms.Button
        Me.tblSimpan = New System.Windows.Forms.Button
        Me.tblHapus = New System.Windows.Forms.Button
        Me.tbl_Keluar = New System.Windows.Forms.Button
        Me.dg_TampilData = New System.Windows.Forms.DataGridView
        Me.mTahun = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tbCari01 = New System.Windows.Forms.Button
        Me.mNama_Dokumen = New System.Windows.Forms.TextBox
        Me.mNama_Sub_OPD = New System.Windows.Forms.TextBox
        Me.mKode_Dokumen = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Sub_OPD = New System.Windows.Forms.MaskedTextBox
        Me.mKode_OPD = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Bidang = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Urusan = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.mKolom_1 = New System.Windows.Forms.MaskedTextBox
        Me.mKolom_2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.label51 = New System.Windows.Forms.Label
        Me.lblHasil = New System.Windows.Forms.Label
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(46, 500)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(733, 20)
        Me.mcari.TabIndex = 280
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(16, 503)
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
        Me.tblBaru.Location = New System.Drawing.Point(23, 298)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 275
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(145, 298)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 276
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(267, 298)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 277
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(663, 298)
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
        Me.dg_TampilData.Location = New System.Drawing.Point(20, 337)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(759, 157)
        Me.dg_TampilData.TabIndex = 279
        Me.dg_TampilData.TabStop = False
        '
        'mTahun
        '
        Me.mTahun.FormattingEnabled = True
        Me.mTahun.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023"})
        Me.mTahun.Location = New System.Drawing.Point(108, 24)
        Me.mTahun.Name = "mTahun"
        Me.mTahun.Size = New System.Drawing.Size(62, 21)
        Me.mTahun.TabIndex = 296
        Me.mTahun.Text = "2019"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 308
        Me.Label4.Text = "tahun anggaran"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Button1.Location = New System.Drawing.Point(140, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 304
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(225, 49)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 301
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'mNama_Dokumen
        '
        Me.mNama_Dokumen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mNama_Dokumen.Enabled = False
        Me.mNama_Dokumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Dokumen.Location = New System.Drawing.Point(108, 127)
        Me.mNama_Dokumen.MaxLength = 100
        Me.mNama_Dokumen.Name = "mNama_Dokumen"
        Me.mNama_Dokumen.Size = New System.Drawing.Size(671, 20)
        Me.mNama_Dokumen.TabIndex = 305
        '
        'mNama_Sub_OPD
        '
        Me.mNama_Sub_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mNama_Sub_OPD.Enabled = False
        Me.mNama_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Sub_OPD.Location = New System.Drawing.Point(108, 75)
        Me.mNama_Sub_OPD.MaxLength = 100
        Me.mNama_Sub_OPD.Name = "mNama_Sub_OPD"
        Me.mNama_Sub_OPD.Size = New System.Drawing.Size(671, 20)
        Me.mNama_Sub_OPD.TabIndex = 302
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Dokumen.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Dokumen.Location = New System.Drawing.Point(108, 101)
        Me.mKode_Dokumen.Mask = "##"
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Dokumen.TabIndex = 303
        Me.mKode_Dokumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Sub_OPD
        '
        Me.mKode_Sub_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Sub_OPD.Enabled = False
        Me.mKode_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_OPD.Location = New System.Drawing.Point(189, 51)
        Me.mKode_Sub_OPD.Mask = "##"
        Me.mKode_Sub_OPD.Name = "mKode_Sub_OPD"
        Me.mKode_Sub_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Sub_OPD.TabIndex = 300
        Me.mKode_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_OPD
        '
        Me.mKode_OPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_OPD.Enabled = False
        Me.mKode_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_OPD.Location = New System.Drawing.Point(158, 51)
        Me.mKode_OPD.Mask = "##"
        Me.mKode_OPD.Name = "mKode_OPD"
        Me.mKode_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_OPD.TabIndex = 299
        Me.mKode_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Bidang
        '
        Me.mKode_Bidang.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Bidang.Enabled = False
        Me.mKode_Bidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Bidang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Bidang.Location = New System.Drawing.Point(128, 51)
        Me.mKode_Bidang.Mask = "##"
        Me.mKode_Bidang.Name = "mKode_Bidang"
        Me.mKode_Bidang.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Bidang.TabIndex = 298
        Me.mKode_Bidang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Urusan
        '
        Me.mKode_Urusan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKode_Urusan.Enabled = False
        Me.mKode_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Urusan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Urusan.Location = New System.Drawing.Point(108, 51)
        Me.mKode_Urusan.Mask = "#"
        Me.mKode_Urusan.Name = "mKode_Urusan"
        Me.mKode_Urusan.Size = New System.Drawing.Size(20, 20)
        Me.mKode_Urusan.TabIndex = 297
        Me.mKode_Urusan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 306
        Me.Label1.Text = "Dokumen"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 307
        Me.Label14.Text = "OPD"
        '
        'mKolom_1
        '
        Me.mKolom_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mKolom_1.Enabled = False
        Me.mKolom_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKolom_1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKolom_1.Location = New System.Drawing.Point(109, 206)
        Me.mKolom_1.Mask = "#####"
        Me.mKolom_1.Name = "mKolom_1"
        Me.mKolom_1.Size = New System.Drawing.Size(61, 20)
        Me.mKolom_1.TabIndex = 299
        Me.mKolom_1.Text = "00000"
        Me.mKolom_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKolom_2
        '
        Me.mKolom_2.Location = New System.Drawing.Point(176, 206)
        Me.mKolom_2.Name = "mKolom_2"
        Me.mKolom_2.Size = New System.Drawing.Size(326, 20)
        Me.mKolom_2.TabIndex = 309
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 13)
        Me.Label7.TabIndex = 310
        Me.Label7.Text = "Format Penomoran Dokumen :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 310
        Me.Label2.Text = "Kolom 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 310
        Me.Label3.Text = "Kolom 2"
        '
        'label51
        '
        Me.label51.AutoSize = True
        Me.label51.BackColor = System.Drawing.Color.Transparent
        Me.label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label51.Location = New System.Drawing.Point(17, 242)
        Me.label51.Name = "label51"
        Me.label51.Size = New System.Drawing.Size(147, 13)
        Me.label51.TabIndex = 310
        Me.label51.Text = "Tanpak pada Dokumen :"
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.BackColor = System.Drawing.Color.Transparent
        Me.lblHasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasil.Location = New System.Drawing.Point(114, 265)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(152, 20)
        Me.lblHasil.TabIndex = 310
        Me.lblHasil.Text = "00000/xxxxxxxxxxx"
        '
        'cPar_Penomoran_Dokumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 532)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.label51)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mKolom_2)
        Me.Controls.Add(Me.mTahun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.mNama_Dokumen)
        Me.Controls.Add(Me.mNama_Sub_OPD)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.mKode_Sub_OPD)
        Me.Controls.Add(Me.mKolom_1)
        Me.Controls.Add(Me.mKode_OPD)
        Me.Controls.Add(Me.mKode_Bidang)
        Me.Controls.Add(Me.mKode_Urusan)
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
        Me.Name = "cPar_Penomoran_Dokumen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Format Penomoran Dokumen"
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
    Friend WithEvents mTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents mNama_Dokumen As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Sub_OPD As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Dokumen As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Sub_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Bidang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Urusan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mKolom_1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKolom_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label51 As System.Windows.Forms.Label
    Friend WithEvents lblHasil As System.Windows.Forms.Label
End Class
