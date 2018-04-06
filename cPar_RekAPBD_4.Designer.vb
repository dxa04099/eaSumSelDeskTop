<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPar_RekAPBD_4
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
        Me.tbCari01 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.mNama_Rek_Jenis = New System.Windows.Forms.TextBox
        Me.mNama_Rek_Objek = New System.Windows.Forms.TextBox
        Me.mRek_Jenis = New System.Windows.Forms.MaskedTextBox
        Me.mRek_Kelompok = New System.Windows.Forms.MaskedTextBox
        Me.mRek_Pos = New System.Windows.Forms.MaskedTextBox
        Me.tblBaru = New System.Windows.Forms.Button
        Me.tblSimpan = New System.Windows.Forms.Button
        Me.tblHapus = New System.Windows.Forms.Button
        Me.tbl_Keluar = New System.Windows.Forms.Button
        Me.dg_TampilData = New System.Windows.Forms.DataGridView
        Me.mRek_Objek = New System.Windows.Forms.MaskedTextBox
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(41, 499)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(772, 20)
        Me.mcari.TabIndex = 12
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(11, 502)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(24, 13)
        Me.L11.TabIndex = 175
        Me.L11.Text = "cari"
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(279, 24)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 3
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(38, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Rekening Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(38, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Rekening Kelompok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(38, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Kode Rekening Kelompok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Kode Rekening Jenis"
        '
        'mNama_Rek_Jenis
        '
        Me.mNama_Rek_Jenis.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Rek_Jenis.Enabled = False
        Me.mNama_Rek_Jenis.Location = New System.Drawing.Point(199, 48)
        Me.mNama_Rek_Jenis.MaxLength = 100
        Me.mNama_Rek_Jenis.Name = "mNama_Rek_Jenis"
        Me.mNama_Rek_Jenis.Size = New System.Drawing.Size(617, 20)
        Me.mNama_Rek_Jenis.TabIndex = 4
        '
        'mNama_Rek_Objek
        '
        Me.mNama_Rek_Objek.BackColor = System.Drawing.Color.White
        Me.mNama_Rek_Objek.Location = New System.Drawing.Point(199, 101)
        Me.mNama_Rek_Objek.MaxLength = 100
        Me.mNama_Rek_Objek.Name = "mNama_Rek_Objek"
        Me.mNama_Rek_Objek.Size = New System.Drawing.Size(617, 20)
        Me.mNama_Rek_Objek.TabIndex = 6
        '
        'mRek_Jenis
        '
        Me.mRek_Jenis.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Jenis.Enabled = False
        Me.mRek_Jenis.Location = New System.Drawing.Point(245, 27)
        Me.mRek_Jenis.Mask = "#"
        Me.mRek_Jenis.Name = "mRek_Jenis"
        Me.mRek_Jenis.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Jenis.TabIndex = 2
        Me.mRek_Jenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Kelompok
        '
        Me.mRek_Kelompok.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Kelompok.Enabled = False
        Me.mRek_Kelompok.Location = New System.Drawing.Point(221, 27)
        Me.mRek_Kelompok.Mask = "#"
        Me.mRek_Kelompok.Name = "mRek_Kelompok"
        Me.mRek_Kelompok.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Kelompok.TabIndex = 1
        Me.mRek_Kelompok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mRek_Pos
        '
        Me.mRek_Pos.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Pos.Enabled = False
        Me.mRek_Pos.Location = New System.Drawing.Point(199, 27)
        Me.mRek_Pos.Mask = "#"
        Me.mRek_Pos.Name = "mRek_Pos"
        Me.mRek_Pos.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Pos.TabIndex = 0
        Me.mRek_Pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tblBaru
        '
        Me.tblBaru.BackColor = System.Drawing.Color.White
        Me.tblBaru.Image = Global.eParameter.My.Resources.Resources.neww
        Me.tblBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblBaru.Location = New System.Drawing.Point(21, 136)
        Me.tblBaru.Name = "tblBaru"
        Me.tblBaru.Size = New System.Drawing.Size(116, 33)
        Me.tblBaru.TabIndex = 7
        Me.tblBaru.Text = "Data Baru"
        Me.tblBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblBaru.UseVisualStyleBackColor = False
        '
        'tblSimpan
        '
        Me.tblSimpan.BackColor = System.Drawing.Color.White
        Me.tblSimpan.Image = Global.eParameter.My.Resources.Resources.simpan
        Me.tblSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblSimpan.Location = New System.Drawing.Point(143, 136)
        Me.tblSimpan.Name = "tblSimpan"
        Me.tblSimpan.Size = New System.Drawing.Size(116, 33)
        Me.tblSimpan.TabIndex = 8
        Me.tblSimpan.Text = "Simpan"
        Me.tblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblSimpan.UseVisualStyleBackColor = False
        '
        'tblHapus
        '
        Me.tblHapus.BackColor = System.Drawing.Color.White
        Me.tblHapus.Image = Global.eParameter.My.Resources.Resources.delete
        Me.tblHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblHapus.Location = New System.Drawing.Point(265, 136)
        Me.tblHapus.Name = "tblHapus"
        Me.tblHapus.Size = New System.Drawing.Size(116, 33)
        Me.tblHapus.TabIndex = 9
        Me.tblHapus.Text = "Hapus"
        Me.tblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblHapus.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(700, 136)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(116, 33)
        Me.tbl_Keluar.TabIndex = 10
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
        Me.dg_TampilData.Location = New System.Drawing.Point(18, 175)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(798, 314)
        Me.dg_TampilData.TabIndex = 11
        Me.dg_TampilData.TabStop = False
        '
        'mRek_Objek
        '
        Me.mRek_Objek.Location = New System.Drawing.Point(199, 74)
        Me.mRek_Objek.Mask = "##"
        Me.mRek_Objek.Name = "mRek_Objek"
        Me.mRek_Objek.Size = New System.Drawing.Size(28, 20)
        Me.mRek_Objek.TabIndex = 5
        Me.mRek_Objek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cPar_RekAPBD_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 530)
        Me.Controls.Add(Me.mcari)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNama_Rek_Jenis)
        Me.Controls.Add(Me.mNama_Rek_Objek)
        Me.Controls.Add(Me.mRek_Objek)
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
        Me.Name = "cPar_RekAPBD_4"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APBD - Rekening Objek"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcari As System.Windows.Forms.TextBox
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents tbCari01 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mNama_Rek_Jenis As System.Windows.Forms.TextBox
    Friend WithEvents mNama_Rek_Objek As System.Windows.Forms.TextBox
    Friend WithEvents mRek_Jenis As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Kelompok As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mRek_Pos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tblBaru As System.Windows.Forms.Button
    Friend WithEvents tblSimpan As System.Windows.Forms.Button
    Friend WithEvents tblHapus As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_TampilData As System.Windows.Forms.DataGridView
    Friend WithEvents mRek_Objek As System.Windows.Forms.MaskedTextBox
End Class
