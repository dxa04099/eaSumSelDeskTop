<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_RekAPBD_3
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
        Me.dg_TampilData = New System.Windows.Forms.DataGridView
        Me.tblBaru = New System.Windows.Forms.Button
        Me.tblSimpan = New System.Windows.Forms.Button
        Me.tblHapus = New System.Windows.Forms.Button
        Me.tbl_Keluar = New System.Windows.Forms.Button
        Me.mRek_Pos = New System.Windows.Forms.MaskedTextBox
        Me.mNama_Rek_Kelompok = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mRek_Kelompok = New System.Windows.Forms.MaskedTextBox
        Me.mRek_Jenis = New System.Windows.Forms.MaskedTextBox
        Me.mNama_Rek_Jenis = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbCari01 = New System.Windows.Forms.Button
        Me.mcari = New System.Windows.Forms.TextBox
        Me.L11 = New System.Windows.Forms.Label
        Me.rd_Debit = New System.Windows.Forms.RadioButton
        Me.rd_Kredit = New System.Windows.Forms.RadioButton
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_TampilData
        '
        Me.dg_TampilData.AllowUserToAddRows = False
        Me.dg_TampilData.AllowUserToDeleteRows = False
        Me.dg_TampilData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_TampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_TampilData.Location = New System.Drawing.Point(26, 218)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(798, 272)
        Me.dg_TampilData.TabIndex = 10
        Me.dg_TampilData.TabStop = False
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(29, 179)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 6
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(151, 179)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 7
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(273, 179)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 8
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(708, 179)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 9
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'mRek_Pos
        '
        Me.mRek_Pos.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Pos.Enabled = False
        Me.mRek_Pos.Location = New System.Drawing.Point(207, 28)
        Me.mRek_Pos.Mask = "#"
        Me.mRek_Pos.Name = "mRek_Pos"
        Me.mRek_Pos.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Pos.TabIndex = 0
        Me.mRek_Pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNama_Rek_Kelompok
        '
        Me.mNama_Rek_Kelompok.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Rek_Kelompok.Enabled = False
        Me.mNama_Rek_Kelompok.Location = New System.Drawing.Point(207, 54)
        Me.mNama_Rek_Kelompok.MaxLength = 100
        Me.mNama_Rek_Kelompok.Name = "mNama_Rek_Kelompok"
        Me.mNama_Rek_Kelompok.Size = New System.Drawing.Size(617, 20)
        Me.mNama_Rek_Kelompok.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(46, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Kode Rekening Pos, Kelompok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(46, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Rekening Kelompok"
        '
        'mRek_Kelompok
        '
        Me.mRek_Kelompok.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Kelompok.Enabled = False
        Me.mRek_Kelompok.Location = New System.Drawing.Point(229, 28)
        Me.mRek_Kelompok.Mask = "#"
        Me.mRek_Kelompok.Name = "mRek_Kelompok"
        Me.mRek_Kelompok.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Kelompok.TabIndex = 1
        Me.mRek_Kelompok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Jenis
        '
        Me.mRek_Jenis.Location = New System.Drawing.Point(207, 80)
        Me.mRek_Jenis.Mask = "#"
        Me.mRek_Jenis.Name = "mRek_Jenis"
        Me.mRek_Jenis.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Jenis.TabIndex = 4
        Me.mRek_Jenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNama_Rek_Jenis
        '
        Me.mNama_Rek_Jenis.Location = New System.Drawing.Point(207, 106)
        Me.mNama_Rek_Jenis.MaxLength = 100
        Me.mNama_Rek_Jenis.Name = "mNama_Rek_Jenis"
        Me.mNama_Rek_Jenis.Size = New System.Drawing.Size(617, 20)
        Me.mNama_Rek_Jenis.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(46, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Kode Rekening Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(46, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Rekening Jenis"
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(255, 25)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 2
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(49, 500)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(772, 20)
        Me.mcari.TabIndex = 11
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(19, 503)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 157
        Me.L11.Text = "cari"
        '
        'rd_Debit
        '
        Me.rd_Debit.AutoSize = True
        Me.rd_Debit.BackColor = System.Drawing.Color.Transparent
        Me.rd_Debit.Location = New System.Drawing.Point(207, 132)
        Me.rd_Debit.Name = "rd_Debit"
        Me.rd_Debit.Size = New System.Drawing.Size(50, 17)
        Me.rd_Debit.TabIndex = 158
        Me.rd_Debit.TabStop = True
        Me.rd_Debit.Text = "Debit"
        Me.rd_Debit.UseVisualStyleBackColor = False
        '
        'rd_Kredit
        '
        Me.rd_Kredit.AutoSize = True
        Me.rd_Kredit.BackColor = System.Drawing.Color.Transparent
        Me.rd_Kredit.Location = New System.Drawing.Point(273, 132)
        Me.rd_Kredit.Name = "rd_Kredit"
        Me.rd_Kredit.Size = New System.Drawing.Size(52, 17)
        Me.rd_Kredit.TabIndex = 158
        Me.rd_Kredit.TabStop = True
        Me.rd_Kredit.Text = "Kredit"
        Me.rd_Kredit.UseVisualStyleBackColor = False
        '
        'cPar_RekAPBD_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 532)
        Me.Controls.Add(Me.rd_Kredit)
        Me.Controls.Add(Me.rd_Debit)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNama_Rek_Jenis)
        Me.Controls.Add(Me.mNama_Rek_Kelompok)
        Me.Controls.Add(Me.mRek_Jenis)
        Me.Controls.Add(Me.mRek_Kelompok)
        Me.Controls.Add(Me.mRek_Pos)
        Me.Controls.Add(Me.tblBaru)
        Me.Controls.Add(Me.tblSimpan)
        Me.Controls.Add(Me.tblHapus)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cPar_RekAPBD_3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APBD = Rekening Jenis"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
    Friend WithEvents mRek_Pos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNama_Rek_Kelompok As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mRek_Kelompok As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Jenis As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNama_Rek_Jenis As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents rd_Debit As System.Windows.Forms.RadioButton
    Friend WithEvents rd_Kredit As System.Windows.Forms.RadioButton
End Class
