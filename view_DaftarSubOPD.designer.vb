<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_DaftarSubOPD
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
        Me.mKodeKelompokPilih = New System.Windows.Forms.TextBox
        Me.tblGunakan = New System.Windows.Forms.Button
        Me.tbl_Keluar = New System.Windows.Forms.Button
        Me.dg_SKPD = New System.Windows.Forms.DataGridView
        Me.mCari = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mKodePanggil = New System.Windows.Forms.TextBox
        Me.mUserID = New System.Windows.Forms.TextBox
        CType(Me.dg_SKPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mKodeKelompokPilih
        '
        Me.mKodeKelompokPilih.Enabled = False
        Me.mKodeKelompokPilih.Location = New System.Drawing.Point(122, 502)
        Me.mKodeKelompokPilih.Name = "mKodeKelompokPilih"
        Me.mKodeKelompokPilih.Size = New System.Drawing.Size(38, 20)
        Me.mKodeKelompokPilih.TabIndex = 42
        Me.mKodeKelompokPilih.Visible = False
        '
        'tblGunakan
        '
        Me.tblGunakan.BackColor = System.Drawing.Color.White
        Me.tblGunakan.Image = Global.eParameter.My.Resources.Resources.oke
        Me.tblGunakan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblGunakan.Location = New System.Drawing.Point(12, 559)
        Me.tblGunakan.Name = "tblGunakan"
        Me.tblGunakan.Size = New System.Drawing.Size(90, 39)
        Me.tblGunakan.TabIndex = 2
        Me.tblGunakan.Text = "Gunakan"
        Me.tblGunakan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblGunakan.UseVisualStyleBackColor = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(468, 555)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(90, 39)
        Me.tbl_Keluar.TabIndex = 3
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
        '
        'dg_SKPD
        '
        Me.dg_SKPD.AllowUserToAddRows = False
        Me.dg_SKPD.AllowUserToDeleteRows = False
        Me.dg_SKPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_SKPD.Location = New System.Drawing.Point(12, 12)
        Me.dg_SKPD.Name = "dg_SKPD"
        Me.dg_SKPD.ReadOnly = True
        Me.dg_SKPD.RowHeadersVisible = False
        Me.dg_SKPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_SKPD.Size = New System.Drawing.Size(546, 536)
        Me.dg_SKPD.TabIndex = 1
        Me.dg_SKPD.TabStop = False
        '
        'mCari
        '
        Me.mCari.Location = New System.Drawing.Point(166, 565)
        Me.mCari.Name = "mCari"
        Me.mCari.Size = New System.Drawing.Size(282, 20)
        Me.mCari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 572)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Cari"
        '
        'mKodePanggil
        '
        Me.mKodePanggil.Enabled = False
        Me.mKodePanggil.Location = New System.Drawing.Point(122, 528)
        Me.mKodePanggil.Name = "mKodePanggil"
        Me.mKodePanggil.Size = New System.Drawing.Size(326, 20)
        Me.mKodePanggil.TabIndex = 42
        Me.mKodePanggil.Visible = False
        '
        'mUserID
        '
        Me.mUserID.Enabled = False
        Me.mUserID.Location = New System.Drawing.Point(166, 502)
        Me.mUserID.Name = "mUserID"
        Me.mUserID.Size = New System.Drawing.Size(104, 20)
        Me.mUserID.TabIndex = 42
        Me.mUserID.Visible = False
        '
        'view_DaftarSubOPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 615)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mCari)
        Me.Controls.Add(Me.mKodePanggil)
        Me.Controls.Add(Me.mUserID)
        Me.Controls.Add(Me.mKodeKelompokPilih)
        Me.Controls.Add(Me.tblGunakan)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.dg_SKPD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_DaftarSubOPD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Daftar SKPD"
        CType(Me.dg_SKPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mKodeKelompokPilih As System.Windows.Forms.TextBox
    Friend WithEvents tblGunakan As System.Windows.Forms.Button
    Friend WithEvents tbl_Keluar As System.Windows.Forms.Button
    Friend WithEvents dg_SKPD As System.Windows.Forms.DataGridView
    Friend WithEvents mCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mKodePanggil As System.Windows.Forms.TextBox
    Friend WithEvents mUserID As System.Windows.Forms.TextBox
End Class
