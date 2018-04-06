<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class d0Tr_Peraturan
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
        Me.tbCari01 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.mNama_Peraturan = New System.Windows.Forms.TextBox
        Me.mKode_Peraturan = New System.Windows.Forms.MaskedTextBox
        Me.mNo_Urut = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.mNo_Peraturan = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.mTgl_Peraturan = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.mUraian = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mNo_Urut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcari
        '
        Me.mcari.Location = New System.Drawing.Point(42, 400)
        Me.mcari.Name = "mcari"
        Me.mcari.Size = New System.Drawing.Size(659, 20)
        Me.mcari.TabIndex = 12
        '
        'L11
        '
        Me.L11.AutoSize = True
        Me.L11.BackColor = System.Drawing.Color.Transparent
        Me.L11.Location = New System.Drawing.Point(12, 403)
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
        Me.tblBaru.Location = New System.Drawing.Point(19, 198)
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
        Me.tblSimpan.Location = New System.Drawing.Point(141, 198)
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
        Me.tblHapus.Location = New System.Drawing.Point(263, 198)
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
        Me.tbl_Keluar.Location = New System.Drawing.Point(585, 198)
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
        Me.dg_TampilData.Location = New System.Drawing.Point(16, 237)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.Size = New System.Drawing.Size(685, 157)
        Me.dg_TampilData.TabIndex = 11
        Me.dg_TampilData.TabStop = False
        '
        'tbCari01
        '
        Me.tbCari01.BackColor = System.Drawing.Color.Transparent
        Me.tbCari01.FlatAppearance.BorderSize = 0
        Me.tbCari01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbCari01.Image = Global.eParameter.My.Resources.Resources.cari
        Me.tbCari01.Location = New System.Drawing.Point(670, 23)
        Me.tbCari01.Name = "tbCari01"
        Me.tbCari01.Size = New System.Drawing.Size(30, 23)
        Me.tbCari01.TabIndex = 2
        Me.tbCari01.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 285
        Me.Label1.Text = "Nama Peraturan"
        '
        'mNama_Peraturan
        '
        Me.mNama_Peraturan.BackColor = System.Drawing.SystemColors.Menu
        Me.mNama_Peraturan.Enabled = False
        Me.mNama_Peraturan.Location = New System.Drawing.Point(175, 25)
        Me.mNama_Peraturan.MaxLength = 100
        Me.mNama_Peraturan.Name = "mNama_Peraturan"
        Me.mNama_Peraturan.Size = New System.Drawing.Size(489, 20)
        Me.mNama_Peraturan.TabIndex = 1
        '
        'mKode_Peraturan
        '
        Me.mKode_Peraturan.BackColor = System.Drawing.SystemColors.Menu
        Me.mKode_Peraturan.Enabled = False
        Me.mKode_Peraturan.Location = New System.Drawing.Point(141, 25)
        Me.mKode_Peraturan.Mask = "##"
        Me.mKode_Peraturan.Name = "mKode_Peraturan"
        Me.mKode_Peraturan.Size = New System.Drawing.Size(28, 20)
        Me.mKode_Peraturan.TabIndex = 0
        Me.mKode_Peraturan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mNo_Urut
        '
        Me.mNo_Urut.Location = New System.Drawing.Point(141, 51)
        Me.mNo_Urut.Maximum = New Decimal(New Integer() {34, 0, 0, 0})
        Me.mNo_Urut.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.mNo_Urut.Name = "mNo_Urut"
        Me.mNo_Urut.Size = New System.Drawing.Size(39, 20)
        Me.mNo_Urut.TabIndex = 3
        Me.mNo_Urut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mNo_Urut.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 322
        Me.Label6.Text = "Nomor Urut"
        '
        'mNo_Peraturan
        '
        Me.mNo_Peraturan.Location = New System.Drawing.Point(141, 77)
        Me.mNo_Peraturan.Name = "mNo_Peraturan"
        Me.mNo_Peraturan.Size = New System.Drawing.Size(560, 20)
        Me.mNo_Peraturan.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 322
        Me.Label2.Text = "Nomor Peraturan"
        '
        'mTgl_Peraturan
        '
        Me.mTgl_Peraturan.CustomFormat = "dd_MM-yyyy"
        Me.mTgl_Peraturan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mTgl_Peraturan.Location = New System.Drawing.Point(141, 103)
        Me.mTgl_Peraturan.Name = "mTgl_Peraturan"
        Me.mTgl_Peraturan.Size = New System.Drawing.Size(96, 20)
        Me.mTgl_Peraturan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 322
        Me.Label3.Text = "Tgl Peraturan"
        '
        'mUraian
        '
        Me.mUraian.Location = New System.Drawing.Point(141, 129)
        Me.mUraian.Multiline = True
        Me.mUraian.Name = "mUraian"
        Me.mUraian.Size = New System.Drawing.Size(560, 63)
        Me.mUraian.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 322
        Me.Label4.Text = "Uraian"
        '
        'd0Tr_Peraturan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 425)
        Me.Controls.Add(Me.mTgl_Peraturan)
        Me.Controls.Add(Me.mUraian)
        Me.Controls.Add(Me.mNo_Peraturan)
        Me.Controls.Add(Me.mNo_Urut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCari01)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mNama_Peraturan)
        Me.Controls.Add(Me.mKode_Peraturan)
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
        Me.Name = "d0Tr_Peraturan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peraturan Daerah"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mNo_Urut, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mNama_Peraturan As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Peraturan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mNo_Urut As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mNo_Peraturan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mTgl_Peraturan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mUraian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
