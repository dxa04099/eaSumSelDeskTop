﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_cPar_RekAPBD_2
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
        Me.mRek_Pos = New System.Windows.Forms.MaskedTextBox()
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
        Me.mCari.Size = New System.Drawing.Size(329, 20)
        Me.mCari.TabIndex = 63
        '
        'tbl_Keluar
        '
        Me.tbl_Keluar.BackColor = System.Drawing.Color.White
        Me.tbl_Keluar.Image = Global.eParameter.My.Resources.Resources.close
        Me.tbl_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbl_Keluar.Location = New System.Drawing.Point(478, 314)
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
        Me.dg_TampilData.Size = New System.Drawing.Size(556, 296)
        Me.dg_TampilData.TabIndex = 59
        Me.dg_TampilData.TabStop = False
        '
        'mRek_Pos
        '
        Me.mRek_Pos.BackColor = System.Drawing.SystemColors.Menu
        Me.mRek_Pos.Location = New System.Drawing.Point(152, 288)
        Me.mRek_Pos.Mask = "#"
        Me.mRek_Pos.Name = "mRek_Pos"
        Me.mRek_Pos.Size = New System.Drawing.Size(20, 20)
        Me.mRek_Pos.TabIndex = 74
        Me.mRek_Pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'view_cPar_RekAPBD_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eParameter.My.Resources.Resources.bgputih
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 359)
        Me.Controls.Add(Me.mRek_Pos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mCari)
        Me.Controls.Add(Me.tbl_Keluar)
        Me.Controls.Add(Me.mKodePanggil)
        Me.Controls.Add(Me.tblGunakan)
        Me.Controls.Add(Me.dg_TampilData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "view_cPar_RekAPBD_2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "APBD - Rekening Kelompok"
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
    Friend WithEvents mRek_Pos As MaskedTextBox
End Class
