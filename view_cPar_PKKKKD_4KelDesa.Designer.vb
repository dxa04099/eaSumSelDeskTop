<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_cPar_PKKKKD_4KelDesa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mCari = New System.Windows.Forms.TextBox()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.mKodePanggil = New System.Windows.Forms.TextBox()
        Me.tblGunakan = New System.Windows.Forms.Button()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.mKode_Kecamatan = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_KabKota = New System.Windows.Forms.MaskedTextBox()
        Me.mKode_Provinsi = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cari"
        '
        'mCari
        '
        Me.mCari.Location = New System.Drawing.Point(143, 324)
        Me.mCari.Name = "mCari"
        Me.mCari.Size = New System.Drawing.Size(435, 20)
        Me.mCari.TabIndex = 63
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(584, 314)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(90, 39)
        Me.tbl_Keluar.TabIndex = 61
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'mKodePanggil
        '
        Me.mKodePanggil.Enabled = False
        Me.mKodePanggil.Location = New System.Drawing.Point(12, 288)
        Me.mKodePanggil.Name = "mKodePanggil"
        Me.mKodePanggil.Size = New System.Drawing.Size(134, 20)
        Me.mKodePanggil.TabIndex = 62
        Me.mKodePanggil.Visible = False
        '
        'tblGunakan
        '
        Me.tblGunakan.BackColor = System.Drawing.Color.White
        Me.tblGunakan.Image = Global.eParameter.My.Resources.Resources.oke
        Me.tblGunakan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblGunakan.Location = New System.Drawing.Point(12, 314)
        Me.tblGunakan.Name = "tblGunakan"
        Me.tblGunakan.Size = New System.Drawing.Size(90, 39)
        Me.tblGunakan.TabIndex = 60
        Me.tblGunakan.Text = "Gunakan"
        Me.tblGunakan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblGunakan.UseVisualStyleBackColor = False
        '
        'dg_TampilData
        '
        Me.dg_TampilData.AllowUserToAddRows = False
        Me.dg_TampilData.AllowUserToDeleteRows = False
        Me.dg_TampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_TampilData.Location = New System.Drawing.Point(12, 12)
        Me.dg_TampilData.Name = "dg_TampilData"
        Me.dg_TampilData.ReadOnly = True
        Me.dg_TampilData.RowHeadersVisible = False
        Me.dg_TampilData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_TampilData.Size = New System.Drawing.Size(662, 296)
        Me.dg_TampilData.TabIndex = 59
        Me.dg_TampilData.TabStop = False
        '
        'mKode_Kecamatan
        '
        Me.mKode_Kecamatan.BackColor = System.Drawing.Color.White
        Me.mKode_Kecamatan.Location = New System.Drawing.Point(206, 288)
        Me.mKode_Kecamatan.Mask = "##"
        Me.mKode_Kecamatan.Name = "mKode_Kecamatan"
        Me.mKode_Kecamatan.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Kecamatan.TabIndex = 67
        Me.mKode_Kecamatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_KabKota
        '
        Me.mKode_KabKota.BackColor = System.Drawing.Color.White
        Me.mKode_KabKota.Location = New System.Drawing.Point(177, 288)
        Me.mKode_KabKota.Mask = "##"
        Me.mKode_KabKota.Name = "mKode_KabKota"
        Me.mKode_KabKota.Size = New System.Drawing.Size(23, 20)
        Me.mKode_KabKota.TabIndex = 66
        Me.mKode_KabKota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Provinsi
        '
        Me.mKode_Provinsi.BackColor = System.Drawing.Color.White
        Me.mKode_Provinsi.Location = New System.Drawing.Point(148, 288)
        Me.mKode_Provinsi.Mask = "##"
        Me.mKode_Provinsi.Name = "mKode_Provinsi"
        Me.mKode_Provinsi.Size = New System.Drawing.Size(23, 20)
        Me.mKode_Provinsi.TabIndex = 65
        Me.mKode_Provinsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'view_cPar_PKKKKD_4KelDesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 365)
        Me.Controls.Add(Me.mKode_Kecamatan)
        Me.Controls.Add(Me.mKode_KabKota)
        Me.Controls.Add(Me.mKode_Provinsi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mCari)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.mKodePanggil)
        Me.Controls.Add(Me.tblGunakan)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "view_cPar_PKKKKD_4KelDesa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Desa / Kelurahan"
        CType(Me.dg_TampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mCari As TextBox
    Friend WithEvents tbl_Keluar As Button
    Friend WithEvents mKodePanggil As TextBox
    Friend WithEvents tblGunakan As Button
    Friend WithEvents dg_TampilData As DataGridView
    Friend WithEvents mKode_Kecamatan As MaskedTextBox
    Friend WithEvents mKode_KabKota As MaskedTextBox
    Friend WithEvents mKode_Provinsi As MaskedTextBox
End Class
