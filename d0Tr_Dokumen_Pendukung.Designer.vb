<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d0Tr_Dokumen_Pendukung
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mNama_Dokumen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mTgl_Dokumen = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mAsal_Penerbit_Dokumen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mKeterangan = New System.Windows.Forms.TextBox()
        Me.ofd_CariFileDokumen = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mNamaFile_Asal = New System.Windows.Forms.TextBox()
        Me.tblBrowse = New System.Windows.Forms.Button()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.mcari = New System.Windows.Forms.TextBox()
        Me.L11 = New System.Windows.Forms.Label()
        Me.Tbl_CariSKPD = New System.Windows.Forms.Button()
        Me.mNama_Sub_Sub_OPD = New System.Windows.Forms.TextBox()
        Me.mKode_Sub_Sub_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Sub_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_OPD = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Bidang = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Urusan = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 323
        Me.Label6.Text = "Kode Dokumen"
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.Location = New System.Drawing.Point(111, 89)
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(316, 20)
        Me.mKode_Dokumen.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 323
        Me.Label1.Text = "Nama Dokumen"
        '
        'mNama_Dokumen
        '
        Me.mNama_Dokumen.Location = New System.Drawing.Point(111, 125)
        Me.mNama_Dokumen.Name = "mNama_Dokumen"
        Me.mNama_Dokumen.Size = New System.Drawing.Size(513, 20)
        Me.mNama_Dokumen.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 323
        Me.Label2.Text = "Nama Dokumen"
        '
        'mTgl_Dokumen
        '
        Me.mTgl_Dokumen.CustomFormat = "dd-MM-yyyy"
        Me.mTgl_Dokumen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mTgl_Dokumen.Location = New System.Drawing.Point(114, 151)
        Me.mTgl_Dokumen.Name = "mTgl_Dokumen"
        Me.mTgl_Dokumen.Size = New System.Drawing.Size(90, 20)
        Me.mTgl_Dokumen.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 323
        Me.Label3.Text = "Asal Dokumen"
        '
        'mAsal_Penerbit_Dokumen
        '
        Me.mAsal_Penerbit_Dokumen.Location = New System.Drawing.Point(111, 177)
        Me.mAsal_Penerbit_Dokumen.Name = "mAsal_Penerbit_Dokumen"
        Me.mAsal_Penerbit_Dokumen.Size = New System.Drawing.Size(513, 20)
        Me.mAsal_Penerbit_Dokumen.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 323
        Me.Label4.Text = "Keterangan"
        '
        'mKeterangan
        '
        Me.mKeterangan.Location = New System.Drawing.Point(111, 203)
        Me.mKeterangan.Multiline = True
        Me.mKeterangan.Name = "mKeterangan"
        Me.mKeterangan.Size = New System.Drawing.Size(513, 69)
        Me.mKeterangan.TabIndex = 11
        '
        'ofd_CariFileDokumen
        '
        Me.ofd_CariFileDokumen.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 323
        Me.Label5.Text = "File Asal"
        '
        'mNamaFile_Asal
        '
        Me.mNamaFile_Asal.Enabled = False
        Me.mNamaFile_Asal.Location = New System.Drawing.Point(111, 287)
        Me.mNamaFile_Asal.Name = "mNamaFile_Asal"
        Me.mNamaFile_Asal.Size = New System.Drawing.Size(513, 20)
        Me.mNamaFile_Asal.TabIndex = 12
        '
        'tblBrowse
        '
        Me.tblBrowse.Location = New System.Drawing.Point(114, 313)
        Me.tblBrowse.Name = "tblBrowse"
        Me.tblBrowse.Size = New System.Drawing.Size(90, 27)
        Me.tblBrowse.TabIndex = 13
        Me.tblBrowse.Text = "browse"
        Me.tblBrowse.UseVisualStyleBackColor = True
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(30, 351)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 14
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(152, 351)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 15
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(274, 351)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 16
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(508, 351)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 17
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
        Me.dg_TampilData.Location = New System.Drawing.Point(27, 390)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(597, 157)
        Me.dg_TampilData.TabIndex = 18
        Me.dg_TampilData.TabStop = False
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(60, 553)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(564, 20)
        Me.mcari.TabIndex = 19
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(30, 556)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 333
        Me.L11.Text = "cari"
        '
        'Tbl_CariSKPD
        '
        Me.Tbl_CariSKPD.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Tbl_CariSKPD.Location = New System.Drawing.Point(274, 27)
        Me.Tbl_CariSKPD.Name = "Tbl_CariSKPD"
        Me.Tbl_CariSKPD.Size = New System.Drawing.Size(29, 24)
        Me.Tbl_CariSKPD.TabIndex = 341
        Me.Tbl_CariSKPD.Text = "5"
        Me.Tbl_CariSKPD.UseVisualStyleBackColor = True
        '
        'mNama_Sub_Sub_OPD
        '
        Me.mNama_Sub_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Sub_Sub_OPD.Location = New System.Drawing.Point(111, 53)
        Me.mNama_Sub_Sub_OPD.MaxLength = 100
        Me.mNama_Sub_Sub_OPD.Name = "mNama_Sub_Sub_OPD"
        Me.mNama_Sub_Sub_OPD.ReadOnly = True
        Me.mNama_Sub_Sub_OPD.Size = New System.Drawing.Size(533, 20)
        Me.mNama_Sub_Sub_OPD.TabIndex = 6
        '
        'mKode_Sub_Sub_OPD
        '
        Me.mKode_Sub_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_Sub_OPD.Location = New System.Drawing.Point(229, 28)
        Me.mKode_Sub_Sub_OPD.Mask = "####"
        Me.mKode_Sub_Sub_OPD.Name = "mKode_Sub_Sub_OPD"
        Me.mKode_Sub_Sub_OPD.ReadOnly = True
        Me.mKode_Sub_Sub_OPD.Size = New System.Drawing.Size(40, 20)
        Me.mKode_Sub_Sub_OPD.TabIndex = 4
        Me.mKode_Sub_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Sub_OPD
        '
        Me.mKode_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_OPD.Location = New System.Drawing.Point(197, 28)
        Me.mKode_Sub_OPD.Mask = "####"
        Me.mKode_Sub_OPD.Name = "mKode_Sub_OPD"
        Me.mKode_Sub_OPD.ReadOnly = True
        Me.mKode_Sub_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Sub_OPD.TabIndex = 3
        Me.mKode_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_OPD
        '
        Me.mKode_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_OPD.Location = New System.Drawing.Point(165, 28)
        Me.mKode_OPD.Mask = "##"
        Me.mKode_OPD.Name = "mKode_OPD"
        Me.mKode_OPD.ReadOnly = True
        Me.mKode_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_OPD.TabIndex = 2
        Me.mKode_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Bidang
        '
        Me.mKode_Bidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Bidang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Bidang.Location = New System.Drawing.Point(133, 28)
        Me.mKode_Bidang.Mask = "##"
        Me.mKode_Bidang.Name = "mKode_Bidang"
        Me.mKode_Bidang.ReadOnly = True
        Me.mKode_Bidang.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Bidang.TabIndex = 1
        Me.mKode_Bidang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Urusan
        '
        Me.mKode_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Urusan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Urusan.Location = New System.Drawing.Point(111, 28)
        Me.mKode_Urusan.Mask = "#"
        Me.mKode_Urusan.Name = "mKode_Urusan"
        Me.mKode_Urusan.ReadOnly = True
        Me.mKode_Urusan.Size = New System.Drawing.Size(20, 20)
        Me.mKode_Urusan.TabIndex = 0
        Me.mKode_Urusan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 340
        Me.Label14.Text = "Kode OPD"
        '
        'd0Tr_Dokumen_Pendukung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(648, 590)
        Me.Controls.Add(Me.Tbl_CariSKPD)
        Me.Controls.Add(Me.mNama_Sub_Sub_OPD)
        Me.Controls.Add(Me.mKode_Sub_Sub_OPD)
        Me.Controls.Add(Me.mKode_Sub_OPD)
        Me.Controls.Add(Me.mKode_OPD)
        Me.Controls.Add(Me.mKode_Bidang)
        Me.Controls.Add(Me.mKode_Urusan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_TampilData)
        Me.Controls.Add(Me.tblBrowse)
        Me.Controls.Add(Me.mTgl_Dokumen)
        Me.Controls.Add(Me.mKeterangan)
        Me.Controls.Add(Me.mNamaFile_Asal)
        Me.Controls.Add(Me.mAsal_Penerbit_Dokumen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mNama_Dokumen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "d0Tr_Dokumen_Pendukung"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dokumen Pendukung"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mNama_Dokumen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mTgl_Dokumen As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents mAsal_Penerbit_Dokumen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mKeterangan As TextBox
    Friend WithEvents ofd_CariFileDokumen As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents mNamaFile_Asal As TextBox
    Friend WithEvents tblBrowse As Button
    Friend WithEvents tblBaru As Button
    Friend WithEvents tblSimpan As Button
    Friend WithEvents tblHapus As Button
    Friend WithEvents tbl_Keluar As Button
    Friend WithEvents dg_TampilData As DataGridView
    Friend WithEvents mcari As TextBox
    Friend WithEvents L11 As Label
    Friend WithEvents Tbl_CariSKPD As Button
    Friend WithEvents mNama_Sub_Sub_OPD As TextBox
    Friend WithEvents mKode_Sub_Sub_OPD As MaskedTextBox
    Friend WithEvents mKode_Sub_OPD As MaskedTextBox
    Friend WithEvents mKode_OPD As MaskedTextBox
    Friend WithEvents mKode_Bidang As MaskedTextBox
    Friend WithEvents mKode_Urusan As MaskedTextBox
    Friend WithEvents Label14 As Label
End Class
