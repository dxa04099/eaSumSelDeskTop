﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cgaji_Par_Gaji_Pokok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.mTahun = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mPangkat = New System.Windows.Forms.TextBox()
        Me.mGol = New System.Windows.Forms.TextBox()
        Me.tblCari01 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mMasa_Kerja = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mKode_Dokumen = New System.Windows.Forms.TextBox()
        Me.tblCariDokumen_Pendukung = New System.Windows.Forms.Button()
        Me.tblPreviewDokumen = New System.Windows.Forms.Button()
        Me.mGaji_Pokok = New System.Windows.Forms.TextBox()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mMasa_Kerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(17, 187)
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
        Me.tblSimpan.Location = New System.Drawing.Point(139, 187)
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
        Me.tblHapus.Location = New System.Drawing.Point(261, 187)
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
        Me.tbl_Keluar.Location = New System.Drawing.Point(411, 187)
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
        Me.dg_TampilData.Location = New System.Drawing.Point(17, 226)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_TampilData.Size = New System.Drawing.Size(513, 377)
        Me.dg_TampilData.TabIndex = 279
        Me.dg_TampilData.TabStop = False
        '
        'mTahun
        '
        Me.mTahun.FormattingEnabled = True
        Me.mTahun.Items.AddRange(New Object() {"2015", "2019", "2020", "2021", "2022", "2023"})
        Me.mTahun.Location = New System.Drawing.Point(128, 23)
        Me.mTahun.Name = "mTahun"
        Me.mTahun.Size = New System.Drawing.Size(62, 21)
        Me.mTahun.TabIndex = 0
        Me.mTahun.Text = "2019"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(37, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 282
        Me.Label4.Text = "tahun anggaran"
        '
        'mPangkat
        '
        Me.mPangkat.BackColor = System.Drawing.SystemColors.Menu
        Me.mPangkat.Enabled = False
        Me.mPangkat.Location = New System.Drawing.Point(186, 50)
        Me.mPangkat.MaxLength = 25
        Me.mPangkat.Name = "mPangkat"
        Me.mPangkat.Size = New System.Drawing.Size(130, 20)
        Me.mPangkat.TabIndex = 2
        '
        'mGol
        '
        Me.mGol.BackColor = System.Drawing.SystemColors.Menu
        Me.mGol.Enabled = False
        Me.mGol.Location = New System.Drawing.Point(128, 50)
        Me.mGol.MaxLength = 5
        Me.mGol.Name = "mGol"
        Me.mGol.Size = New System.Drawing.Size(44, 20)
        Me.mGol.TabIndex = 1
        '
        'tblCari01
        '
        Me.tblCari01.BackColor = System.Drawing.Color.Transparent
        Me.tblCari01.FlatAppearance.BorderSize = 0
        Me.tblCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tblCari01.Location = New System.Drawing.Point(323, 53)
        Me.tblCari01.Name = "tblCari01"
        Me.tblCari01.Size = New System.Drawing.Size(16, 17)
        Me.tblCari01.TabIndex = 3
        Me.tblCari01.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 319
        Me.Label8.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 320
        Me.Label3.Text = "Gol/Pangkat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 320
        Me.Label1.Text = "Masa Kerja"
        '
        'mMasa_Kerja
        '
        Me.mMasa_Kerja.Location = New System.Drawing.Point(128, 79)
        Me.mMasa_Kerja.Maximum = New Decimal(New Integer() {34, 0, 0, 0})
        Me.mMasa_Kerja.Name = "mMasa_Kerja"
        Me.mMasa_Kerja.Size = New System.Drawing.Size(39, 20)
        Me.mMasa_Kerja.TabIndex = 4
        Me.mMasa_Kerja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 320
        Me.Label2.Text = "Gaji Pokok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 320
        Me.Label5.Text = "Rp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 320
        Me.Label7.Text = "Dokumen Pendukung"
        '
        'mKode_Dokumen
        '
        Me.mKode_Dokumen.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Dokumen.Enabled = False
        Me.mKode_Dokumen.Location = New System.Drawing.Point(152, 149)
        Me.mKode_Dokumen.MaxLength = 50
        Me.mKode_Dokumen.Name = "mKode_Dokumen"
        Me.mKode_Dokumen.Size = New System.Drawing.Size(311, 20)
        Me.mKode_Dokumen.TabIndex = 5
        '
        'tblCariDokumen_Pendukung
        '
        Me.tblCariDokumen_Pendukung.BackColor = System.Drawing.Color.Transparent
        Me.tblCariDokumen_Pendukung.FlatAppearance.BorderSize = 0
        Me.tblCariDokumen_Pendukung.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblCariDokumen_Pendukung.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tblCariDokumen_Pendukung.Location = New System.Drawing.Point(469, 150)
        Me.tblCariDokumen_Pendukung.Name = "tblCariDokumen_Pendukung"
        Me.tblCariDokumen_Pendukung.Size = New System.Drawing.Size(16, 17)
        Me.tblCariDokumen_Pendukung.TabIndex = 3
        Me.tblCariDokumen_Pendukung.UseVisualStyleBackColor = False
        '
        'tblPreviewDokumen
        '
        Me.tblPreviewDokumen.BackColor = System.Drawing.Color.Transparent
        Me.tblPreviewDokumen.FlatAppearance.BorderSize = 0
        Me.tblPreviewDokumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tblPreviewDokumen.Image = Global.eParameter.My.Resources.Resources.preview
        Me.tblPreviewDokumen.Location = New System.Drawing.Point(490, 149)
        Me.tblPreviewDokumen.Name = "tblPreviewDokumen"
        Me.tblPreviewDokumen.Size = New System.Drawing.Size(20, 19)
        Me.tblPreviewDokumen.TabIndex = 3
        Me.tblPreviewDokumen.UseVisualStyleBackColor = False
        '
        'mGaji_Pokok
        '
        Me.mGaji_Pokok.Location = New System.Drawing.Point(152, 113)
        Me.mGaji_Pokok.Name = "mGaji_Pokok"
        Me.mGaji_Pokok.Size = New System.Drawing.Size(123, 20)
        Me.mGaji_Pokok.TabIndex = 321
        Me.mGaji_Pokok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cgaji_Par_Gaji_Pokok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(546, 615)
        Me.Controls.Add(Me.mGaji_Pokok)
        Me.Controls.Add(Me.mMasa_Kerja)
        Me.Controls.Add(Me.mKode_Dokumen)
        Me.Controls.Add(Me.mPangkat)
        Me.Controls.Add(Me.mGol)
        Me.Controls.Add(Me.tblPreviewDokumen)
        Me.Controls.Add(Me.tblCariDokumen_Pendukung)
        Me.Controls.Add(Me.tblCari01)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mTahun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cgaji_Par_Gaji_Pokok"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gaji Pokok"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mMasa_Kerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
    Friend WithEvents mTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mPangkat As System.Windows.Forms.TextBox
    Friend WithEvents mGol As System.Windows.Forms.TextBox
    Friend WithEvents tblCari01 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mMasa_Kerja As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mKode_Dokumen As TextBox
    Friend WithEvents tblCariDokumen_Pendukung As Button
    Friend WithEvents tblPreviewDokumen As Button
    Friend WithEvents mGaji_Pokok As TextBox
End Class
