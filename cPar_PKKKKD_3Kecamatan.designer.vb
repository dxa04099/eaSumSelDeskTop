﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_PKKKKD_3Kecamatan
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
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.tbCari02 = New System.Windows.Forms.Button()
        Me.tbCari01 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mNama_Kecamatan = New System.Windows.Forms.TextBox()
        Me.mNama_KabKota = New System.Windows.Forms.TextBox()
        Me.mNama_Provinsi = New System.Windows.Forms.TextBox()
        Me.mKode_Kecamatan = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_KabKota = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Provinsi = New System.Windows.Forms.MaskedTextBox()
        Me.mcari = New System.Windows.Forms.TextBox()
        Me.L11 = New System.Windows.Forms.Label()
        Me.tblBaru = New System.Windows.Forms.Button()
        Me.tblSimpan = New System.Windows.Forms.Button()
        Me.tblHapus = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(507, 165)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 11
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'tbCari02
        '
        Me.tbCari02.BackColor = System.Drawing.Color.Transparent
        Me.tbCari02.FlatAppearance.BorderSize = 0
        Me.tbCari02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari02.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari02.Location = New System.Drawing.Point(161, 65)
        Me.tbCari02.Name = "tbCari02"
        Me.tbCari02.Size = New System.Drawing.Size(30, 23)
        Me.tbCari02.TabIndex = 4
        Me.tbCari02.UseVisualStyleBackColor = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(161, 15)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 1
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 304
        Me.Label6.Text = "Nama Kecamatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "Nama Kab/Kota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 302
        Me.Label2.Text = "Nama Provinsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 308
        Me.Label5.Text = "Kode Kecamatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "Kode Kab/Kota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 306
        Me.Label1.Text = "Kode Provinsi"
        '
        'mNama_Kecamatan
        '
        Me.mNama_Kecamatan.Location = New System.Drawing.Point(132, 139)
        Me.mNama_Kecamatan.MaxLength = 50
        Me.mNama_Kecamatan.Name = "mNama_Kecamatan"
        Me.mNama_Kecamatan.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Kecamatan.TabIndex = 7
        '
        'mNama_KabKota
        '
        Me.mNama_KabKota.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_KabKota.Enabled = False
        Me.mNama_KabKota.Location = New System.Drawing.Point(132, 90)
        Me.mNama_KabKota.MaxLength = 50
        Me.mNama_KabKota.Name = "mNama_KabKota"
        Me.mNama_KabKota.Size = New System.Drawing.Size(491, 20)
        Me.mNama_KabKota.TabIndex = 5
        '
        'mNama_Provinsi
        '
        Me.mNama_Provinsi.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Provinsi.Enabled = False
        Me.mNama_Provinsi.Location = New System.Drawing.Point(132, 41)
        Me.mNama_Provinsi.MaxLength = 50
        Me.mNama_Provinsi.Name = "mNama_Provinsi"
        Me.mNama_Provinsi.Size = New System.Drawing.Size(491, 20)
        Me.mNama_Provinsi.TabIndex = 2
        '
        'mKode_Kecamatan
        '
        Me.mKode_Kecamatan.Location = New System.Drawing.Point(132, 116)
        Me.mKode_Kecamatan.Mask = "##"
        Me.mKode_Kecamatan.Name = "mKode_Kecamatan"
        Me.mKode_Kecamatan.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Kecamatan.TabIndex = 6
        Me.mKode_Kecamatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_KabKota
        '
        Me.mKode_KabKota.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_KabKota.Enabled = False
        Me.mKode_KabKota.Location = New System.Drawing.Point(132, 67)
        Me.mKode_KabKota.Mask = "##"
        Me.mKode_KabKota.Name = "mKode_KabKota"
        Me.mKode_KabKota.Size = New System.Drawing.Size(23, 20)
        Me.mKode_KabKota.TabIndex = 3
        Me.mKode_KabKota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Provinsi
        '
        Me.mKode_Provinsi.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Provinsi.Enabled = False
        Me.mKode_Provinsi.Location = New System.Drawing.Point(132, 18)
        Me.mKode_Provinsi.Mask = "##"
        Me.mKode_Provinsi.Name = "mKode_Provinsi"
        Me.mKode_Provinsi.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Provinsi.TabIndex = 0
        Me.mKode_Provinsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(54, 367)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(569, 20)
        Me.mcari.TabIndex = 13
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(24, 370)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 292
        Me.L11.Text = "cari"
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(31, 165)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 8
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(153, 165)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 9
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(275, 165)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 10
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'dg_TampilData
        '
        Me.dg_TampilData.AllowUserToAddRows = False
        Me.dg_TampilData.AllowUserToDeleteRows = False
        Me.dg_TampilData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_TampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_TampilData.Location = New System.Drawing.Point(28, 204)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_TampilData.Size = New System.Drawing.Size(595, 157)
        Me.dg_TampilData.TabIndex = 12
        Me.dg_TampilData.TabStop = False
        '
        'cPar_PKKKKD_3Kecamatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(646, 396)
        Me.Controls.Add(Me.tbCari02)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNama_Kecamatan)
        Me.Controls.Add(Me.mNama_KabKota)
        Me.Controls.Add(Me.mNama_Provinsi)
        Me.Controls.Add(Me.mKode_Kecamatan)
        Me.Controls.Add(Me.mKode_KabKota)
        Me.Controls.Add(Me.mKode_Provinsi)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.dg_TampilData)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cPar_PKKKKD_3Kecamatan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kecamatan"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents tbCari02 As System.Windows.Forms.Button
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mNama_Kecamatan As System.Windows.Forms.TextBox
    Friend WithEvents mNama_KabKota As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Provinsi As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Kecamatan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_KabKota As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Provinsi As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
End Class
