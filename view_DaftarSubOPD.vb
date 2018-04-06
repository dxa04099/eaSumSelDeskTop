Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_DaftarSubOPD
    Private Sub zz_DaftarSKPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = MenuUtama.Width - Me.Width
        Tampil_subOPD()
        'Tampil_SKPD("SUBSKPD", 0)
    End Sub
   
    Private Sub tblGunakan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblGunakan.Click
        If dg_SKPD.RowCount = 0 Then Exit Sub
        'par_SKPD
        '0.00.00.00.000
        '12345678901234
        If mKodePanggil.Text = "f_UserManagement_AturSKPD" Then
            f_UserManagement_AturSKPD.mKode_Urusan.Text = Mid(dg_SKPD.Item(0, dg_SKPD.CurrentRow.Index).Value.ToString.Trim, 1, 1)
            f_UserManagement_AturSKPD.mKode_Bidang.Text = Mid(dg_SKPD.Item(0, dg_SKPD.CurrentRow.Index).Value.ToString.Trim, 3, 2)
            f_UserManagement_AturSKPD.mKode_OPD.Text = Mid(dg_SKPD.Item(0, dg_SKPD.CurrentRow.Index).Value.ToString.Trim, 6, 2)
            f_UserManagement_AturSKPD.mKode_Sub_OPD.Text = Mid(dg_SKPD.Item(0, dg_SKPD.CurrentRow.Index).Value.ToString.Trim, 9, 2)
            f_UserManagement_AturSKPD.mKode_Sub_Sub_OPD.Text = Mid(dg_SKPD.Item(0, dg_SKPD.CurrentRow.Index).Value.ToString.Trim, 12, 3)

            f_UserManagement_AturSKPD.mNama_Sub_Sub_OPD.Text = dg_SKPD.Item(1, dg_SKPD.CurrentRow.Index).Value.ToString.Trim

        End If

        Me.Close()
    End Sub
    Sub Tampil_subOPD()
        If Open_eSumsel() = False Then Exit Sub

        '===CaRI APAKAH USER SUDAH DIATUR HAKNYUA
        Dim cari As String = "T"
        Rs_Baca.Open("Select * From aPar_UserID_OPD where UserID = '" & MenuUtama.mUserID.Text.Trim & "'", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            cari = "Y"
        End If
        Rs_Baca.Close()
        Close_eSumsel()

        Dim mkodisi_cari As String = ""

        If mCari.Text.Trim = "" Then
        Else
            mkodisi_cari = " where Nama_Sub_Sub_OPD like '%" & mCari.Text & "%' "
        End If

        Dim sql_Perintah As String = " SELECT       " _
            & " Kode_Urusan + '.' +  " _
            & " Kode_Bidang + '.' +  " _
            & " Kode_OPD + '.' +  " _
            & " Kode_Sub_OPD + '.' + " _
            & " Kode_Sub_Sub_OPD AS [Kode sub OPD],  " _
            & " Nama_Sub_Sub_OPD AS [Nama sub OPD] " _
            & " FROM         cPar_OPD_5Sub_Sub_OPD  " & mkodisi_cari _
            & " ORDER BY  " _
            & " Kode_Urusan,  " _
            & " Kode_Bidang,  " _
            & " Kode_OPD,  " _
            & " Kode_Sub_OPD, Kode_Sub_Sub_OPD "
         

        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource
        cn_Lokal_Tmpl = New OleDbConnection
        cn_Lokal_Tmpl.ConnectionString = connString_Lokal
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter(sql_Perintah, cn_Lokal_Tmpl) 'Change items to your database name
        da.Fill(ds, "items") 'Change items to your database name
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        dg_SKPD.DataSource = view

        dg_SKPD.Columns(0).Width = (dg_SKPD.Width / 10) * 1.5
        dg_SKPD.Columns(1).Width = (dg_SKPD.Width / 10) * 8
        'mCari.Focus()
    End Sub
    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

      
    Private Sub mCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mCari.TextChanged
        Tampil_subOPD()
    End Sub

    Private Sub dg_SKPD_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_SKPD.CellContentClick

    End Sub

    Private Sub chTampilSemua_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class