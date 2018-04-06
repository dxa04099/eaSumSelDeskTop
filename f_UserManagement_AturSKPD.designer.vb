<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_UserManagement_AturSKPD
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
        Me.dg_User = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn
        Me.mNama = New System.Windows.Forms.TextBox
        Me.mUserID = New System.Windows.Forms.TextBox
        Me.L2 = New System.Windows.Forms.Label
        Me.L1 = New System.Windows.Forms.Label
        Me.mNama_Sub_Sub_OPD = New System.Windows.Forms.TextBox
        Me.mKode_Sub_OPD = New System.Windows.Forms.MaskedTextBox
        Me.mKode_OPD = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Bidang = New System.Windows.Forms.MaskedTextBox
        Me.mKode_Urusan = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.tblKeluar = New System.Windows.Forms.Button
        Me.Tbl_CariSKPD = New System.Windows.Forms.Button
        Me.tbl_Gunakan = New System.Windows.Forms.Button
        Me.mKode_Sub_Sub_OPD = New System.Windows.Forms.MaskedTextBox
        CType(Me.dg_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_User
        '
        Me.dg_User.AllowUserToAddRows = False
        Me.dg_User.AllowUserToDeleteRows = False
        Me.dg_User.AllowUserToResizeColumns = False
        Me.dg_User.AllowUserToResizeRows = False
        Me.dg_User.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_User.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dg_User.Location = New System.Drawing.Point(30, 129)
        Me.dg_User.Name = "dg_User"
        Me.dg_User.ReadOnly = True
        Me.dg_User.RowHeadersVisible = False
        Me.dg_User.Size = New System.Drawing.Size(615, 268)
        Me.dg_User.TabIndex = 26
        Me.dg_User.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "hapus"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Text = "hapus"
        Me.Column1.Width = 35
        '
        'mNama
        '
        Me.mNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mNama.Enabled = False
        Me.mNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama.Location = New System.Drawing.Point(112, 48)
        Me.mNama.MaxLength = 50
        Me.mNama.Name = "mNama"
        Me.mNama.ReadOnly = True
        Me.mNama.Size = New System.Drawing.Size(419, 20)
        Me.mNama.TabIndex = 48
        Me.mNama.TabStop = False
        '
        'mUserID
        '
        Me.mUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mUserID.Enabled = False
        Me.mUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mUserID.Location = New System.Drawing.Point(112, 25)
        Me.mUserID.MaxLength = 20
        Me.mUserID.Name = "mUserID"
        Me.mUserID.ReadOnly = True
        Me.mUserID.Size = New System.Drawing.Size(174, 20)
        Me.mUserID.TabIndex = 47
        Me.mUserID.TabStop = False
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(42, 50)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(35, 13)
        Me.L2.TabIndex = 50
        Me.L2.Text = "Nama"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(42, 25)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(43, 13)
        Me.L1.TabIndex = 49
        Me.L1.Text = "ID User"
        '
        'mNama_Sub_Sub_OPD
        '
        Me.mNama_Sub_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mNama_Sub_Sub_OPD.Location = New System.Drawing.Point(112, 103)
        Me.mNama_Sub_Sub_OPD.MaxLength = 100
        Me.mNama_Sub_Sub_OPD.Name = "mNama_Sub_Sub_OPD"
        Me.mNama_Sub_Sub_OPD.ReadOnly = True
        Me.mNama_Sub_Sub_OPD.Size = New System.Drawing.Size(533, 20)
        Me.mNama_Sub_Sub_OPD.TabIndex = 98
        '
        'mKode_Sub_OPD
        '
        Me.mKode_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_OPD.Location = New System.Drawing.Point(198, 78)
        Me.mKode_Sub_OPD.Mask = "####"
        Me.mKode_Sub_OPD.Name = "mKode_Sub_OPD"
        Me.mKode_Sub_OPD.ReadOnly = True
        Me.mKode_Sub_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Sub_OPD.TabIndex = 96
        Me.mKode_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_OPD
        '
        Me.mKode_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_OPD.Location = New System.Drawing.Point(166, 78)
        Me.mKode_OPD.Mask = "##"
        Me.mKode_OPD.Name = "mKode_OPD"
        Me.mKode_OPD.ReadOnly = True
        Me.mKode_OPD.Size = New System.Drawing.Size(30, 20)
        Me.mKode_OPD.TabIndex = 95
        Me.mKode_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Bidang
        '
        Me.mKode_Bidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Bidang.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Bidang.Location = New System.Drawing.Point(134, 78)
        Me.mKode_Bidang.Mask = "##"
        Me.mKode_Bidang.Name = "mKode_Bidang"
        Me.mKode_Bidang.ReadOnly = True
        Me.mKode_Bidang.Size = New System.Drawing.Size(30, 20)
        Me.mKode_Bidang.TabIndex = 94
        Me.mKode_Bidang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKode_Urusan
        '
        Me.mKode_Urusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Urusan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Urusan.Location = New System.Drawing.Point(112, 78)
        Me.mKode_Urusan.Mask = "#"
        Me.mKode_Urusan.Name = "mKode_Urusan"
        Me.mKode_Urusan.ReadOnly = True
        Me.mKode_Urusan.Size = New System.Drawing.Size(20, 20)
        Me.mKode_Urusan.TabIndex = 93
        Me.mKode_Urusan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(42, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Kode OPD"
        '
        'tblKeluar
        '
        Me.tblKeluar.BackColor = System.Drawing.Color.White
        Me.tblKeluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tblKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tblKeluar.Location = New System.Drawing.Point(555, 411)
        Me.tblKeluar.Name = "tblKeluar"
        Me.tblKeluar.Size = New System.Drawing.Size(90, 41)
        Me.tblKeluar.TabIndex = 101
        Me.tblKeluar.Text = "Keluar"
        Me.tblKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tblKeluar.UseVisualStyleBackColor = False
        '
        'Tbl_CariSKPD
        '
        Me.Tbl_CariSKPD.Image = Global.eParameter.My.Resources.Resources.cari
        Me.Tbl_CariSKPD.Location = New System.Drawing.Point(275, 77)
        Me.Tbl_CariSKPD.Name = "Tbl_CariSKPD"
        Me.Tbl_CariSKPD.Size = New System.Drawing.Size(29, 24)
        Me.Tbl_CariSKPD.TabIndex = 102
        Me.Tbl_CariSKPD.UseVisualStyleBackColor = True
        '
        'tbl_Gunakan
        '
        Me.tbl_Gunakan.BackColor = System.Drawing.Color.Transparent
        Me.tbl_Gunakan.FlatAppearance.BorderSize = 0
        Me.tbl_Gunakan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbl_Gunakan.Image = Global.eParameter.My.Resources.Resources.oke
        Me.tbl_Gunakan.Location = New System.Drawing.Point(306, 74)
        Me.tbl_Gunakan.Name = "tbl_Gunakan"
        Me.tbl_Gunakan.Size = New System.Drawing.Size(29, 26)
        Me.tbl_Gunakan.TabIndex = 103
        Me.tbl_Gunakan.UseVisualStyleBackColor = False
        '
        'mKode_Sub_Sub_OPD
        '
        Me.mKode_Sub_Sub_OPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKode_Sub_Sub_OPD.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKode_Sub_Sub_OPD.Location = New System.Drawing.Point(230, 78)
        Me.mKode_Sub_Sub_OPD.Mask = "####"
        Me.mKode_Sub_Sub_OPD.Name = "mKode_Sub_Sub_OPD"
        Me.mKode_Sub_Sub_OPD.ReadOnly = True
        Me.mKode_Sub_Sub_OPD.Size = New System.Drawing.Size(40, 20)
        Me.mKode_Sub_Sub_OPD.TabIndex = 96
        Me.mKode_Sub_Sub_OPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'f_UserManagement_AturSKPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 460)
        Me.Controls.Add(Me.tbl_Gunakan)
        Me.Controls.Add(Me.Tbl_CariSKPD)
        Me.Controls.Add(Me.tblKeluar)
        Me.Controls.Add(Me.mNama_Sub_Sub_OPD)
        Me.Controls.Add(Me.mKode_Sub_Sub_OPD)
        Me.Controls.Add(Me.mKode_Sub_OPD)
        Me.Controls.Add(Me.mKode_OPD)
        Me.Controls.Add(Me.mKode_Bidang)
        Me.Controls.Add(Me.mKode_Urusan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.mNama)
        Me.Controls.Add(Me.mUserID)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.dg_User)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_UserManagement_AturSKPD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "entri data pengaturan akses SKPD"
        CType(Me.dg_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg_User As System.Windows.Forms.DataGridView
    Friend WithEvents mNama As System.Windows.Forms.TextBox
    Friend WithEvents mUserID As System.Windows.Forms.TextBox
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents mNama_Sub_Sub_OPD As System.Windows.Forms.TextBox
    Friend WithEvents mKode_Sub_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Bidang As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mKode_Urusan As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tblKeluar As System.Windows.Forms.Button
    Friend WithEvents Tbl_CariSKPD As System.Windows.Forms.Button
    Friend WithEvents tbl_Gunakan As System.Windows.Forms.Button
    Friend WithEvents mKode_Sub_Sub_OPD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
