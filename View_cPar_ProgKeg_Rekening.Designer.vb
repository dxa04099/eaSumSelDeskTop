<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_cPar_ProgKeg_Rekening
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
        Me.mKodePanggil = New System.Windows.Forms.TextBox()
        Me.dg_TampilData = New System.Windows.Forms.DataGridView()
        Me.tbl_Keluar = New System.Windows.Forms.Button()
        Me.tblGunakan = New System.Windows.Forms.Button()
        Me.mKd_Prog = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Bidang_Program = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Urusan_Program = New System.Windows.Forms.MaskedTextBox()
        Me.mKd_Keg = New System.Windows.Forms.MaskedTextBox()
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
        Me.mCari.Size = New System.Drawing.Size(461, 20)
        Me.mCari.TabIndex = 63
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
        Me.dg_TampilData.Size = New System.Drawing.Size(688, 296)
        Me.dg_TampilData.TabIndex = 59
        Me.dg_TampilData.TabStop = False
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(610, 314)
        Me.tbl_Keluar.Name = "tbl_Keluar"
        Me.tbl_Keluar.Size = New System.Drawing.Size(90, 39)
        Me.tbl_Keluar.TabIndex = 61
        Me.tbl_Keluar.Text = "Keluar"
        Me.tbl_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbl_Keluar.UseVisualStyleBackColor = False
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
        'mKd_Prog
        '
        Me.mKd_Prog.BackColor = System.Drawing.Color.White
        Me.mKd_Prog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Prog.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Prog.Location = New System.Drawing.Point(210, 288)
        Me.mKd_Prog.Mask = "###"
        Me.mKd_Prog.Name = "mKd_Prog"
        Me.mKd_Prog.Size = New System.Drawing.Size(37, 20)
        Me.mKd_Prog.TabIndex = 70
        Me.mKd_Prog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKd_Bidang_Program
        '
        Me.mKd_Bidang_Program.BackColor = System.Drawing.Color.White
        Me.mKd_Bidang_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Bidang_Program.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Bidang_Program.Location = New System.Drawing.Point(174, 288)
        Me.mKd_Bidang_Program.Mask = "##"
        Me.mKd_Bidang_Program.Name = "mKd_Bidang_Program"
        Me.mKd_Bidang_Program.Size = New System.Drawing.Size(30, 20)
        Me.mKd_Bidang_Program.TabIndex = 69
        Me.mKd_Bidang_Program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKd_Urusan_Program
        '
        Me.mKd_Urusan_Program.BackColor = System.Drawing.Color.White
        Me.mKd_Urusan_Program.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Urusan_Program.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Urusan_Program.Location = New System.Drawing.Point(152, 288)
        Me.mKd_Urusan_Program.Mask = "#"
        Me.mKd_Urusan_Program.Name = "mKd_Urusan_Program"
        Me.mKd_Urusan_Program.Size = New System.Drawing.Size(20, 20)
        Me.mKd_Urusan_Program.TabIndex = 68
        Me.mKd_Urusan_Program.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mKd_Keg
        '
        Me.mKd_Keg.BackColor = System.Drawing.Color.White
        Me.mKd_Keg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mKd_Keg.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mKd_Keg.Location = New System.Drawing.Point(253, 288)
        Me.mKd_Keg.Mask = "###"
        Me.mKd_Keg.Name = "mKd_Keg"
        Me.mKd_Keg.Size = New System.Drawing.Size(37, 20)
        Me.mKd_Keg.TabIndex = 71
        Me.mKd_Keg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'View_cPar_ProgKeg_Rekening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 363)
        Me.Controls.Add(Me.mKd_Keg)
        Me.Controls.Add(Me.mKd_Prog)
        Me.Controls.Add(Me.mKd_Bidang_Program)
        Me.Controls.Add(Me.mKd_Urusan_Program)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mCari)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.mKodePanggil)
        Me.Controls.Add(Me.tblGunakan)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "View_cPar_ProgKeg_Rekening"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Daftar Komposisi Rekening dalam Kegiatan"
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
    Friend WithEvents mKd_Prog As MaskedTextBox
    Friend WithEvents mKd_Bidang_Program As MaskedTextBox
    Friend WithEvents mKd_Urusan_Program As MaskedTextBox
    Friend WithEvents mKd_Keg As MaskedTextBox
End Class
